from pathlib import Path
root=Path('.')
# Explicit grid columns: Name preserves Cells["Id"] lookups; DataPropertyName preserves bindings.
maps={
'Clientes/PaginaClientes':{'gradeClientes':['Id','Nome','Cpf','Telefone','Email']},
'Pets/PaginaPets':{'gradePets':['Id','Nome','Tutor','Especie','Raca','Porte','Peso']},
'Servicos/PaginaServicos':{'gradeServicos':['Id','Nome','Descricao','Valor','Duração','Status']},
'Agendamentos/PaginaAtendimentos':{'gradeAtendimentos':['Id','Data','Pet','Tutor','Servico','Valor','Status']},
'Principal/PainelDiario':{'gradeAgenda':['Horário','Pet','Tutor','Serviço','Valor','Status']},
'Vendas/PaginaEstoque':{'gradeEstoque':['Id','Codigo','Nome','Categoria','Preço','Estoque','Mínimo','Situação']},
'Vendas/PaginaPedidos':{'gradePedidos':['Numero','Cliente','Data','Total','Status','Pagamento']},
'Vendas/PaginaPDV':{'gradeProdutos':['Codigo','Nome','Preço','Estoque'],'gradeCarrinho':['Codigo','Nome','Quantidade','Unitário','Subtotal']}}
import re,unicodedata
for page,grids in maps.items():
 p=root/'Telas'/f'{page}.Designer.cs'; s=p.read_text(encoding='utf-8-sig')
 declarations=[]
 for grid,cols in grids.items():
  setup=[]; fields=[]
  for col in cols:
   field=grid+'Col'+unicodedata.normalize('NFKD',col).encode('ascii','ignore').decode()
   fields.append(field); declarations.append(f'private DataGridViewTextBoxColumn {field};')
   setup += [f'{field} = new DataGridViewTextBoxColumn();',f'{field}.Name = "{col}";',f'{field}.DataPropertyName = "{col}";',f'{field}.HeaderText = "{col}";']
   if col=='Id': setup.append(f'{field}.Visible = false;')
  setup += [f'{grid}.AutoGenerateColumns = false;',f'{grid}.Columns.AddRange(new DataGridViewColumn[] {{ '+', '.join(fields)+' });']
  anchor=f'{grid} = new DataGridView();'
  assert anchor in s,(p,grid)
  s=s.replace(anchor,anchor+'\n'+'\n'.join(setup),1)
 s=s.replace('private void InitializeComponent()', '\n'.join(declarations)+'\nprivate void InitializeComponent()',1)
 # Name each control for selection and consistent serialization.
 for m in list(re.finditer(r'\b(\w+) = new (?:Label|Panel|Button|TextBox|ComboBox|DataGridView|NumericUpDown|SplitContainer|FlowLayoutPanel)\(\);',s)):
  name=m[1]
  if not re.search(r'\b'+name+r'\.Name\s*=',s):s=s.replace(m[0],m[0]+f'\n{name}.Name = "{name}";',1)
 # Explicit initialization and lifetime for component tray in every page.
 if 'IContainer components' not in s:
  s=s.replace('private void InitializeComponent()', '''private System.ComponentModel.IContainer components;
protected override void Dispose(bool disposing)
{
    if (disposing && components != null) components.Dispose();
    base.Dispose(disposing);
}
private void InitializeComponent()''',1)
 if 'components = new System.ComponentModel.Container();' not in s:
  s=re.sub(r'(private void InitializeComponent\(\)\s*\{)',r'\1\ncomponents = new System.ComponentModel.Container();',s, count=1)
 # Separate statements without altering semicolons inside text.
 s=re.sub(r'("(?:\\.|[^"\\])*"|;)',lambda m:m[0]+'\n' if m[0]==';' else m[0],s)
 p.write_text(s,encoding='utf-8')
# Standard design-time detection, including nested controls whose Site is inherited from parents.
for p in (root/'Telas').rglob('*.cs'):
 if p.name.endswith('.Designer.cs'):continue
 s=p.read_text(encoding='utf-8-sig')
 s=s.replace('DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime','PetShop_App.Componentes.AmbienteDesign.EstaAtivo(this)')
 s=s.replace('System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime','PetShop_App.Componentes.AmbienteDesign.EstaAtivo(this)')
 # Block-style namespaces improve compatibility with older VS designer parsers.
 if re.search(r'namespace [\w.]+;',s):s=re.sub(r'namespace ([\w.]+);',r'namespace \1\n{',s,count=1)+'\n}\n'
 p.write_text(s,encoding='utf-8')
