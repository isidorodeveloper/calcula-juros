# calcula-juros
Implementação de API para cálculo de juros compostos

# Informações Gerais
  - Desenvolvimento de API Rest utilizando .Net Core 3.1
  - O Padrão de Projeto utilizado foi baseado em DDD (Domain-Driven Design)
  - IoC
  - AutoMapper
  - Foi utilizado a biblioteca FluentValidator para validação dos dados
  - Testes Unitários utilizando MSTest juntamente com a biblioteca Moq para simulação de objetos
  - Swagger para documentação das API's e para realizar as requisições aos Endpoints Implementados
  - Docker (Criado Dockerfile para construção da imagem da aplicação)

# Docker
Imagem disponível para download no DockerHub. Utilizar o comando abaixo para obter a imagem em seu repositório local:

  - Pull da Imagem: docker pull aisidoro/softplandevops:calcula-juros-api-1.0
  - Executar imagem no container: docker run -d -p 20001:80 --name calcula-juros-api aisidoro/softplandevops:calcula-juros-api-1.0