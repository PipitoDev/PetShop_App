param([string]$Saida = (Join-Path $env:TEMP 'petshop-preview'))
$ErrorActionPreference = 'Stop'
Add-Type -AssemblyName System.Windows.Forms
Add-Type -AssemblyName System.Drawing
$raiz = Split-Path $PSScriptRoot -Parent
$bin = Join-Path $raiz 'bin/Debug/net8.0-windows'
[System.Reflection.Assembly]::LoadFrom((Join-Path $bin 'FontAwesome.Sharp.dll')) | Out-Null
[System.Reflection.Assembly]::LoadFrom((Join-Path $bin 'MySqlConnector.dll')) | Out-Null
$assembly = [System.Reflection.Assembly]::LoadFrom((Join-Path $bin 'PetShop_App.dll'))
[System.ComponentModel.LicenseManager]::CurrentContext = [System.ComponentModel.Design.DesigntimeLicenseContext]::new()
New-Item -ItemType Directory -Force $Saida | Out-Null
function VerificarControles([System.Windows.Forms.Control]$controle) {
    if ($controle -is [System.Windows.Forms.DataGridView]) {
        if ($controle.Columns.Count -eq 0) { throw "Grade sem colunas: $($controle.Name)" }
        if ($controle.AutoGenerateColumns) { throw "Grade ainda depende de colunas automáticas: $($controle.Name)" }
        $nomes = @($controle.Columns | ForEach-Object Name)
        if (@($nomes | Select-Object -Unique).Count -ne $nomes.Count) { throw 'Colunas duplicadas' }
        # Verifica o contrato com a fonte de dados sem depender de MySQL.
        $tabela = [System.Data.DataTable]::new()
        foreach ($coluna in $controle.Columns) {
            $tabela.Columns.Add($coluna.DataPropertyName, [string]) | Out-Null
        }
        $linha = $tabela.NewRow()
        foreach ($coluna in $controle.Columns) { $linha[$coluna.DataPropertyName] = 'teste' }
        $tabela.Rows.Add($linha)
        $controle.BindingContext = [System.Windows.Forms.BindingContext]::new()
        $controle.DataSource = $tabela
        if ($controle.Columns.Count -ne $nomes.Count) { throw 'Colunas perdidas ao vincular dados' }
        foreach ($coluna in $controle.Columns) {
            if ($controle.Rows[0].Cells[$coluna.Name].Value -ne 'teste') { throw "Vínculo inválido: $($coluna.Name)" }
        }
        $controle.DataSource = $null
    }
    if ($controle -is [System.Windows.Forms.Button] -and $controle.Parent.Name -eq 'pnlCabecalho') {
        if ($controle.Left -lt 0 -or $controle.Right -gt $controle.Parent.ClientSize.Width) {
            throw "Botão fora do cabeçalho: $($controle.Name)"
        }
    }
    foreach ($filho in $controle.Controls) { VerificarControles $filho }
}
$tipos = $assembly.GetTypes() | Where-Object { $_.IsPublic -and -not $_.IsAbstract -and ([System.Windows.Forms.Form].IsAssignableFrom($_) -or [System.Windows.Forms.UserControl].IsAssignableFrom($_)) }
foreach ($tipo in $tipos) {
    if (!$tipo.GetConstructor([Type[]]@())) { throw "Sem construtor vazio: $($tipo.Name)" }
    $controle = [Activator]::CreateInstance($tipo)
    $hostVisual = [System.Windows.Forms.Panel]::new()
    try {
        if ($controle -is [System.Windows.Forms.Form]) {
            # Hospedagem fora da tela, sem abrir janela na área de trabalho.
            $controle.TopLevel = $false
            $hostVisual.Size = $controle.Size
            $hostVisual.Controls.Add($controle)
            $controle.Visible = $true
        }
        $controle.CreateControl()
        # Dispara Load no contexto de design: não deve consultar MySQL ou abrir avisos.
        $onLoad = $tipo.GetMethod('OnLoad', [System.Reflection.BindingFlags]'Instance,NonPublic')
        $onLoad.Invoke($controle, @([EventArgs]::Empty)) | Out-Null
        $controle.PerformLayout()
        VerificarControles $controle
        $imagem = [System.Drawing.Bitmap]::new($controle.Width, $controle.Height)
        try { $controle.DrawToBitmap($imagem, [System.Drawing.Rectangle]::new(0, 0, $controle.Width, $controle.Height)); $imagem.Save((Join-Path $Saida ($tipo.Name + '.png'))) }
        finally { $imagem.Dispose() }
        Write-Output "OK: $($tipo.Name) — construção, Load, colunas e renderização"
    } finally { $controle.Dispose(); $hostVisual.Dispose() }
}
Write-Output "Imagens: $Saida"
