# PetShop Central

Sistema desktop em C# WinForms para clientes, pets, serviços e atendimentos, seguindo o protótipo do Figma.

## MySQL

O projeto já está configurado para o Laragon: servidor `127.0.0.1`, porta `3306`, banco `petshop_central`, usuário `root` e senha vazia. A conexão pode ser substituída pelas variáveis `PETSHOP_DB_SERVIDOR`, `PETSHOP_DB_PORTA`, `PETSHOP_DB_NOME`, `PETSHOP_DB_USUARIO` e `PETSHOP_DB_SENHA`. Como alternativa, execute `Dados/banco_petshop.sql`.

Primeiro acesso: usuário `admin`, senha `admin`. Altere a senha no banco antes de produção.

## Executar

```powershell
dotnet restore
dotnet run
```

## Guia do sistema

Consulte [Funcionamento e análise](docs/FUNCIONAMENTO.md) para navegação, eventos dos botões, relações do banco, pendências e roteiro de validação.
