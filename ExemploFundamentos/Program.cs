using ExemplosFundamentos.Common.Models;
using System.Globalization;

string dataStr = "2009-07-13 18:31";

bool sucesso = DateTime.TryParseExact(
dataStr,
"yyyy-MM-dd HH:mm",
CultureInfo.InvariantCulture,
DateTimeStyles.None,
out DateTime data);

if(sucesso){
    Console.WriteLine($"deu certo! Data: {data}");
}else
    Console.WriteLine($"{dataStr} não é valido");
//DateTime data = DateTime.Parse(dataStr);
























// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-PT");

// decimal valorMonetario = 75382.40M;

// Console.WriteLine(valorMonetario.ToString("N12"));

// double porcentagem = .423;

// Console.WriteLine(porcentagem.ToString("P1"));

// long numero = 47988402422;

// Console.WriteLine(numero.ToString("(##) #####-####"));
























// Pessoa p1 = new Pessoa("Guilherme","Tonon");
// Pessoa p2 = new Pessoa("Marcelo", "Aipim");

// Curso cursoDeBananas = new Curso();
// cursoDeBananas.Nome = "Curso De Bananas";

// cursoDeBananas.Alunos = new List<Pessoa>();
// cursoDeBananas.AdicionarAluno(p1);
// cursoDeBananas.AdicionarAluno(p2);
// cursoDeBananas.AdicionarAluno(p2);
// cursoDeBananas.AdicionarAluno(p2);
// cursoDeBananas.AdicionarAluno(p2);
// cursoDeBananas.AdicionarAluno(p2);
// cursoDeBananas.AdicionarAluno(p2);
// cursoDeBananas.AdicionarAluno(p2);
// cursoDeBananas.AdicionarAluno(p2);
// cursoDeBananas.AdicionarAluno(p2);
// cursoDeBananas.AdicionarAluno(p2);
// cursoDeBananas.AdicionarAluno(p2);
// cursoDeBananas.AdicionarAluno(p2);
// cursoDeBananas.AdicionarAluno(p2);
// Console.WriteLine(cursoDeBananas.ObterQuantidadeDeAlunosMatriculados());

// cursoDeBananas.ListarAlunos();