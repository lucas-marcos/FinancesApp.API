# Nome do Seu Projeto Backend

Descrição curta ou tagline do seu projeto de backend.

## Pré-requisitos

Certifique-se de ter o .NET 8 SDK instalado no seu sistema. Além disso, você deve ter um servidor SQL Server em execução e configurar a string de conexão no arquivo `appsettings.json`.

Exemplo de `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=seu-servidor;Database=sua-base-dados;User=seu-usuario;Password=sua-senha;"
  },
  // Outras configurações...
}
```

## Instalação

1) Clone o repositório do Front End(React Native) e do Back End:

```bash
git clone https://github.com/lucas-marcos/FinancesApp.API.git
```

```bash
git clone https://github.com/lucas-marcos/FinancesApp.git
```

2) Navegue até o diretório do projeto:

```bash
cd FinancesApp.API
```

3) Execute as migrações do Entity Framework para criar o banco de dados:

```bash
dotnet ef database update
```

## Executando o Projeto

```bash
dotnet run
```

## Contribuição

1) Fork o repositório
2) Crie uma branch com a sua feature: git checkout -b feature-nova
3) Faça o commit das suas mudanças: git commit -m 'Adiciona nova feature'
4) Push para a sua branch: git push origin feature-nova
5) Abra um pull request
