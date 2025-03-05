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

brunopinheirobrazil

---

## Payment Machine Integration Project

This project demonstrates the implementation of the Factory design pattern to integrate different payment machines (OuroBank and NuBank) in a .NET Core API.

## Features

* Integration with OuroBank and NuBank payment machines.
* Use of the Factory pattern to instantiate the correct payment service based on the specified type.
* RESTful API to process payments.
* API documentation with Swagger.

## Prerequisites

* .NET Core SDK installed.
* A code editor (Visual Studio, VS Code, etc.).
* A REST client (Swagger, Postman, etc.).

## How to Run the Project (English)

1.  Clone the repository:

    ```bash
    git clone [URL inv�lido removido]
    cd [nome do seu projeto]
    ```

2.  Restore NuGet packages:

    ```bash
    dotnet restore
    ```

3.  Run the project:

    ```bash
    dotnet run
    ```

4.  The API will be available at `http://localhost:[porta]`.

## How to Test the API with Swagger (English)

1.  Open the Swagger UI in your browser: `http://localhost:[porta]/swagger`.

2.  Expand the payment endpoint (usually a GET endpoint).

3.  Click on "Try it out".

4.  In the "Parameters" section, fill in the following field:

    * `tipo`: `OuroBank` or `NuBank`

5.  Change the value of the `tipo` field to `OuroBank` or `NuBank` to test the different payment machine integrations.

6.  Click on "Execute".

7.  Check the API response to confirm payment processing.

## Project Structure (English)

* `Controllers`: Contains the `PagamentoController` that receives payment requests.
* `Interfaces`: Defines the `IMaquininhaPagamento` interface.
* `Servicos`: Contains the concrete implementations of the payment machines (OuroBank and NuBank).
* `Factories`: Contains the `MaquininhaPagamentoFactory` that instantiates the correct payment service.
* `Models`: Contains the data models (e.g., `PagamentoRequest`).

## Factory Pattern (English)

The project uses the Factory pattern to decouple the creation of payment services from the `PagamentoController`. The `MaquininhaPagamentoFactory` receives the machine type as a parameter and returns the correct instance of `IMaquininhaPagamento`.

## Contributing (English)

Contributions are welcome! Feel free to open issues and pull requests to improve the project.

## License (English)

brunopinheirobrazil