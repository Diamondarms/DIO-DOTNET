using ExemplosFundamentos.Common.Models;

Pessoa p1 = new Pessoa("Guilherme","Tonon");
Pessoa p2 = new Pessoa("Marcelo", "Aipim");

Curso cursoDeBananas = new Curso();
cursoDeBananas.Nome = "Curso De Bananas";

cursoDeBananas.Alunos = new List<Pessoa>();
cursoDeBananas.AdicionarAluno(p1);
cursoDeBananas.AdicionarAluno(p2);
cursoDeBananas.AdicionarAluno(p2);
cursoDeBananas.AdicionarAluno(p2);
cursoDeBananas.AdicionarAluno(p2);
cursoDeBananas.AdicionarAluno(p2);
cursoDeBananas.AdicionarAluno(p2);
cursoDeBananas.AdicionarAluno(p2);
cursoDeBananas.AdicionarAluno(p2);
cursoDeBananas.AdicionarAluno(p2);
cursoDeBananas.AdicionarAluno(p2);
cursoDeBananas.AdicionarAluno(p2);
cursoDeBananas.AdicionarAluno(p2);
cursoDeBananas.AdicionarAluno(p2);
Console.WriteLine(cursoDeBananas.ObterQuantidadeDeAlunosMatriculados());

cursoDeBananas.ListarAlunos();
