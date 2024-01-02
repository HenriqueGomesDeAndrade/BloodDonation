# BloodDonation

Esse repositório se trata de uma api para o gerenciamento de doações de sangue.
Com essa api é possível cadastrar doadores e doações de sangue, que são armazenadas em estoques.

A API foi feita em .NET 8

## Tecnologias e Padrões utilizados:
- Arquitetura Limpa
- CQRS
- Unit Of Work
- Padrão Repository
- Fluent Validation
- SQL Server
- Domain Event
- SeedData
- ExceptionHandler
- Result Pattern

## Algumas regras de negócio:
- Menor de idade não pode doar, mas pode ter cadastro.
- O doador deve pesar no mínimo 50KG.
- Mulheres só podem doar de 90 em 90 dias.
- Homens só podem doar de 60 em 60 dias.
- Quantidade de mililitros de sangue doados deve ser entre 420ml e 470ml.

## Ações disponibilizadas:
- Cadastrar doadores
- Buscar todos os doadores
- Cadastrar doações
- Consultar doações a partir de um número X de dias
- Consultar estoque de sangue
- Consultar estoque de sangue por tipo

## Execução
Para executar o projeto, basta clonar o repositório e executar o projeto *BloodDonation.API*
* Lembre de adicionar um arquivo de configuração *appsettings.json* com a connectionString do banco de dados.
