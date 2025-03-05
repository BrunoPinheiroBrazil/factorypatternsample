# Projeto de Integração de Maquininhas de Pagamento

Este projeto demonstra a implementação do padrão de projeto Factory para integrar diferentes maquininhas de pagamento (OuroBank e NuBank) em uma API .NET Core.

## Funcionalidades

* Integração com maquininhas de pagamento OuroBank e NuBank.
* Utilização do padrão Factory para instanciar o serviço de pagamento correto com base no tipo especificado.
* API RESTful para processar pagamentos.
* Documentação da API com Swagger.

## Pré-requisitos

* .NET Core SDK instalado.
* Um editor de código (Visual Studio, VS Code, etc.).
* Um cliente REST (Swagger, Postman, etc.).

## Como Executar o Projeto

1.  Clone o repositório:

    ```bash
    git clone [URL inválido removido]
    cd [nome do seu projeto]
    ```

2.  Restaure os pacotes NuGet:

    ```bash
    dotnet restore
    ```

3.  Execute o projeto:

    ```bash
    dotnet run
    ```

4.  A API estará disponível em `http://localhost:[porta]`.

## Como Testar a API com Swagger

1.  Abra o Swagger UI no seu navegador: `http://localhost:[porta]/swagger`.

2.  Expanda o endpoint de pagamento (geralmente um endpoint GET).

3.  Clique em "Try it out".

4.  Na seção "Parameters", preencha o seguinte campo:

    * `tipo`: `OuroBank` ou `NuBank`

5.  Altere o valor do campo `tipo` para `OuroBank` ou `NuBank` para testar as diferentes integrações de maquininhas de pagamento.

6.  Clique em "Execute".

7.  Verifique a resposta da API para confirmar o processamento do pagamento.

## Estrutura do Projeto

* `Controllers`: Contém o `PagamentoController` que recebe as requisições de pagamento.
* `Interfaces`: Define a interface `IMaquininhaPagamento`.
* `Servicos`: Contém as implementações concretas das maquininhas de pagamento (OuroBank e NuBank).
* `Factories`: Contém a `MaquininhaPagamentoFactory` que instancia o serviço de pagamento correto.
* `Models`: Contém os modelos de dados (por exemplo, `PagamentoRequest`).

## Padrão Factory

O projeto utiliza o padrão Factory para desacoplar a criação dos serviços de pagamento do `PagamentoController`. A `MaquininhaPagamentoFactory` recebe o tipo de maquininha como parâmetro e retorna a instância correta de `IMaquininhaPagamento`.

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues e pull requests para melhorar o projeto.

## Licença

[Sua Licença]