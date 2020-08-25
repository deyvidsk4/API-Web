
# Web API
> A API foi desenvolvia em C#/.Net utilizando o padrão de repositório para utilização de uma enquete.


## Começando

Para executar o projeto, será necessário instalar os seguintes programas:

- Visual Studio Code: Necessário para executar o projeto.
- Sql Server: Necessário para criar o banco e sua respectiva tabela.
- Postman: Necessário para fazer os envios de requisições.

## Exemplo de uso

Após o download dos programas necessários, atente para os seguintes passos para executar o projeto.
 
- Criação do Banco de dados no SQl Server.
- Alterar no arquivo appsetinggs.json a propriedade “DefaultConnection” informando assim a sua String de conexão.
- Abra o terminei (tecla de atalho Ctrl+ “ ).
- Para verificação de erros use o comando ”donet build”. 
- Digite o comando “dotnet run” para levantar a aplicação.
- Abra o Postman para então fazer suas requisições.
- URL padrão https://localhost:5001/api/polls/.

## Feedback do desafio:

A entrega da solução contém algumas pendencias nas necessidades da função da API.

- O metodo para incrementar na tabela "visualizacao" após uma requisição a Polls/id não conseguir implementar.

- O atributo "option" deveria ser um atributo multivalorado para assim guardar um array contento três opções para votação.

- Ao analiza a proposta do desafio a solução que estou entregando, percebo que minha solução não cumpre com alguns requisitos do mesmo...  

