using CSharp2.Models;

Pessoa p1 = new Pessoa(nome: "gui",sobrenome: "tonon");
Pessoa p2 = new Pessoa(nome: "Robson",sobrenome: "Cardoso");


Curso cursoDeBananas = new Curso();
cursoDeBananas.Nome = "Curso De Bananas";

cursoDeBananas.Alunos = new List<Pessoa>();
cursoDeBananas.AdicionarAluno(p1);
cursoDeBananas.AdicionarAluno(p2);
Console.WriteLine(cursoDeBananas.ObterQuantidadeDeAlunosMatriculados());

cursoDeBananas.ListarAlunos();

