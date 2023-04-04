# WebAPI-dotNet-EFCore-Docker
Project EOT


add global.json
dotnet new globaljson --sdk

create WebAPI
dotnet new webapi -n EOT.WebAPI


Criação das Models:
Aluno
AlunoDisciplina
Disciplina
Professor

Onde Aluno e Disciplina - muitos para muitos, pois um aluno pode cursas diversas disciplinas e uma disciplina pode ter diversos alunos cursando.

E Professor e disciplina - um para muitos, pois um professor pode dar aula para diversas disciplinas e uma disciplina pode ter somente um professor.

Add Migrations:
dotnet ef migrations add Init

Add SqLite Database:
dotnet ef database update