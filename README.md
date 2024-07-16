# Projeto CdbCalculator

Este projeto inclui uma API em .NET Framework para cálculo de investimentos (CDB) e um projeto de testes unitários para validar sua funcionalidade.

## Pré-requisitos

- Visual Studio 2019 ou superior
- .NET Framework 4.7.2 ou superior
- Node.js (para o projeto Angular)

## Configuração do Ambiente

### API (.NET Framework)

1. Abra a solução `CdbCalculator.sln` no Visual Studio.

2. Verifique se todos os pacotes NuGet foram restaurados corretamente:
   - Clique com o botão direito no projeto da API (`CdbCalculatorAPI`) -> "Restore NuGet Packages".

### Frontend (Angular)

1. Abra um terminal e navegue até a pasta do projeto Angular: cd CdbCalculatorFrontend
2. Instale as dependências do projeto: npm install


## Execução da API

1. Defina o projeto da API (`CdbCalculatorAPI`) como projeto de inicialização:
- Clique com o botão direito no projeto da API -> "Set as StartUp Project".

2. Execute a API:
- Pressione `F5` ou clique em "Start" no Visual Studio para iniciar a API.

3. Verifique se a API está sendo executada corretamente:
- Abra o navegador e acesse `http://localhost:<porta>/api/investment/calculate` para verificar se a API está respondendo.

## Execução dos Testes Unitários

1. No Visual Studio, abra o `Test Explorer` (Ctrl + E, T).

2. Clique em `Run All` para executar todos os testes unitários ou selecione testes específicos para executar individualmente.

3. Verifique os resultados dos testes no `Test Explorer`. Certifique-se de que todos os testes passaram com êxito.

## Estrutura do Projeto

- `CdbCalculatorAPI/`: Projeto da API em .NET Framework para cálculo de investimentos.
- `CdbCalculatorFrontend/`: Projeto frontend em Angular para interação com a API.

## Observações

- Certifique-se de configurar corretamente o ambiente antes de executar a API e os testes.
- Os testes devem cobrir a lógica principal da aplicação, garantindo a integridade e a qualidade do código.


