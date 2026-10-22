. ./scripts/Testar-Preview.ps1
foreach($nome in @('PaginaClientes','PaginaPDV')) {
 $tipo=$assembly.GetTypes() | Where-Object Name -eq $nome
 $c=[Activator]::CreateInstance($tipo); $c.CreateControl(); $c.PerformLayout()
 function Exibir($n,$nivel=0){ Write-Output (((' ' * $nivel)+$n.Name)+' '+$n.Bounds+' visible='+$n.Visible);foreach($f in $n.Controls){Exibir $f ($nivel+1)}}
 Exibir $c; $c.Dispose()
}
