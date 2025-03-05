# Projeto de Integra��o de Maquininhas de Pagamento

Este projeto demonstra a implementa��o do padr�o de projeto Factory para integrar diferentes maquininhas de pagamento (OuroBank e NuBank) em uma API .NET Core.

## Funcionalidades

* Integra��o com maquininhas de pagamento OuroBank e NuBank.
* Utiliza��o do padr�o Factory para instanciar o servi�o de pagamento correto com base no tipo especificado.
* API RESTful para processar pagamentos.
* Documenta��o da API com Swagger.

## Pr�-requisitos

* .NET Core SDK instalado.
* Um editor de c�digo (Visual Studio, VS Code, etc.).
* Um cliente REST (Swagger, Postman, etc.).

## Como Executar o Projeto

1.  Clone o reposit�rio:

    ```bash
    git clone [URL inv�lido removido]
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

4.  A API estar� dispon�vel em `http://localhost:[porta]`.

## Como Testar a API com Swagger

1.  Abra o Swagger UI no seu navegador: `http://localhost:[porta]/swagger`.

2.  Expanda o endpoint de pagamento (geralmente um endpoint GET).

3.  Clique em "Try it out".

4.  Na se��o "Parameters", preencha o seguinte campo:

    * `tipo`: `OuroBank` ou `NuBank`

5.  Altere o valor do campo `tipo` para `OuroBank` ou `NuBank` para testar as diferentes integra��es de maquininhas de pagamento.

6.  Clique em "Execute".

7.  Verifique a resposta da API para confirmar o processamento do pagamento.

## Estrutura do Projeto

* `Controllers`: Cont�m o `PagamentoController` que recebe as requisi��es de pagamento.
* `Interfaces`: Define a interface `IMaquininhaPagamento`.
* `Servicos`: Cont�m as implementa��es concretas das maquininhas de pagamento (OuroBank e NuBank).
* `Factories`: Cont�m a `MaquininhaPagamentoFactory` que instancia o servi�o de pagamento correto.
* `Models`: Cont�m os modelos de dados (por exemplo, `PagamentoRequest`).

## Padr�o Factory

O projeto utiliza o padr�o Factory para desacoplar a cria��o dos servi�os de pagamento do `PagamentoController`. A `MaquininhaPagamentoFactory` recebe o tipo de maquininha como par�metro e retorna a inst�ncia correta de `IMaquininhaPagamento`.

## Contribui��o

Contribui��es s�o bem-vindas! Sinta-se � vontade para abrir issues e pull requests para melhorar o projeto.

## Licen�a

[Sua Licen�a]