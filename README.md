# checkpoint-MS-RM99430-RM551234

Este projeto demonstra como implementar cache com Redis em uma API ASP.NET Core para melhorar a performance de consultas ao banco de dados.
O banco principal utilizado é o MySQL, mas a arquitetura pode ser adaptada facilmente para MongoDB ou outros bancos.

## Funcionalidades

 - Consulta de usuários no banco de dados
 - Armazenamento em cache Redis para evitar consultas repetitivas
 - Expiração configurada no Redis (15 minutos)
 - Retorno otimizado caso os dados já estejam em cache
 - Tratamento de exceções para maior robustez

## Classe de Usuário

A classe Users representa o modelo de usuário retornado pelo banco:

```c#
public class Users
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public DateTime UltimoAcesso { get; set; }
}
```

## Conexão com Banco de Dados

MySQL: Utiliza Dapper e MySqlConnector para consultas.

## Conexão com Redis

A biblioteca utilizada é o StackExchange.Redis.
O Redis armazena o resultado da consulta em formato JSON e define um tempo de expiração de 15 minutos.

Lógica de Cache

- Verificar se a chave já existe no Redis.
- Se existir, retornar os dados diretamente do cache.
- Caso contrário, buscar os dados no banco de dados.
- Salvar o resultado no Redis com tempo de expiração.

## Como Executar

- Clonar o repositório
- Restaurar dependências com dotnet restore
- Subir instâncias do MySQL e Redis localmente
- Configurar a connection string no código
- Executar a aplicação com `dotnet run`
