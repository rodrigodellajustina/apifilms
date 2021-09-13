# Projeto APIFilms


[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://travis-ci.org/joemccann/dillinger)
[![netFoundation](https://camo.githubusercontent.com/fd3d4792df527a2eac5fde2400e8f423ce1cb28a6ee2ffb355e8f2b4facd2394/68747470733a2f2f696d672e736869656c64732e696f2f62616467652f2e4e4554253230466f756e646174696f6e2d626c756576696f6c65742e737667)

## Instalação

Requer [ASP.NET Core 5.0]

Caso queira executar o projeto de maneira local, basta executar os comandos abaixo:

```
> dotnet add package Microsoft.EntityFrameworkCore
> dotnet add package Microsoft.EntityFrameworkCore.Design
> dotnet add package Microsoft.EntityFrameworkCore.Sqlite
> dotnet add package Microsoft.EntityFrameworkCore.Sqlite.Design
> dotnet add package Microsoft.EntityFrameworkCore.Tools

## Migration (Caso necessitar)

> dotnet restore
> dotnet ef migrations add InitialCreate
> dotnet ef database update
```

## Execução

Executando pelo Visual Studio 2019, automaticamente irá alimentar uma tabela no SQLite chamada Films, basta executar pelo IIS Express, ou executar a release ou debug irá criar e manter um arquivo Films.db


## Carregando novos Dados

Caso queira substituir os valores da entidade Films, basta substituir o arquivo movielist.csv que se encontra no diretório csv na raiz do projeto

[![Arquivo](http://databaseit.com.br/git/moviecsv.png)
