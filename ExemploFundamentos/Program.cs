using ExemplosFundamentos.Common.Models;
using System.Globalization;
using Newtonsoft.Json;

int qt = int.Parse(Console.ReadLine());
        string[] v = new string[2];
        // TODO: Crie as outras condições necessárias para a resolução do desafio:
        for (int i = 0; i < qt; i++)
        {
            v = Console.ReadLine().Split(" ");
            string a = v[0];
            string b = v[1];
            
            if (b.Length > a.Length)
                Console.WriteLine("nao encaixa");
            else if (a.EndsWith(b))
                Console.WriteLine("encaixa");
            else
                Console.WriteLine("nao encaixa");

        }

























// MeuArray<int> array1 = new MeuArray<int>();

// array1.AdicionarElementoArray(5);

// Console.WriteLine(array1[0]);




















// dynamic variavelDinamica = 4;
// Console.WriteLine($"tipo: {variavelDinamica.GetType()} valor: {variavelDinamica}");
// variavelDinamica = false;
// Console.WriteLine($"tipo: {variavelDinamica.GetType()} valor: {variavelDinamica}");
// variavelDinamica = "oshe";
// Console.WriteLine($"tipo: {variavelDinamica.GetType()} valor: {variavelDinamica}");























// string conteudo = File.ReadAllText("../arquivos/vendas1.json");

// List<VendaImportada> listaVendas = JsonConvert.DeserializeObject<List<VendaImportada>>(conteudo);

// var listaAnonimo = listaVendas.Select(x => new{x.Produto, x.Preco});

// foreach(var v in listaAnonimo){
//     Console.WriteLine($"Produto: {v.Produto} - Preço: {v.Preco:C}");
// }

























// var tipoAnonimo = new {Nome = "Guilherme", Idade = 20};

// Console.WriteLine($"Nome: {tipoAnonimo.Nome} Idade: {tipoAnonimo.Idade}");

























// string conteudo = File.ReadAllText("../arquivos/vendas1.json");

// List<VendaImportada> listaVendas = JsonConvert.DeserializeObject<List<VendaImportada>>(conteudo);

// foreach(VendaImportada v in listaVendas){
//     Console.WriteLine($"Produto: {v.Produto} - Preço: {v.Preco:C} - Data: {v.DataVenda.ToString("dd/MM/yy HH:mm")}"+
//     $"{(v.Desconto.HasValue ? $" - Desconto: {v.Desconto}" : "")}");
// }




















// DateTime dataAtual = DateTime.Now;

// Venda v1 = new Venda(1, "Caderno", 20.0M,dataAtual);
// Venda v2 = new Venda(2, "Lápis", 4.0M,dataAtual);
// Venda v3 = new Venda(3, "Borracha", 3.0M,dataAtual);
// Venda v4 = new Venda(4, "Caneta", 5.0M,dataAtual);

// List<Venda> vendas = new List<Venda>();
// vendas.Add(v1);
// vendas.Add(v2);
// vendas.Add(v3);
// vendas.Add(v4);

// string serializado = JsonConvert.SerializeObject(vendas, Formatting.Indented);

// File.WriteAllText("../arquivos/vendas1.json",serializado);

// Console.WriteLine(serializado);



























// Pessoa pq = new Pessoa("Gui", "Tonon");


// (string nome, string sobrenom) = pq;

// Console.WriteLine(nome + " " + sobrenom);





















// LeituraArquivo arq = new LeituraArquivo();

// var (_,linhasArq,_) = arq.LerArquivo("../arquivos/arquivoleitura.txt");

// Console.WriteLine(linhasArq[0]);

























// (int id,string nome,string sobrenome) tupla = (1,"Guilherme","Tonon");
// ValueTuple<int,string,string> tupla2 = (1,"Guilherme","Tonon");
// var tupla3 = Tuple.Create(1,"Guilherme","Tonon");


// tupla.id = 2;

// Console.WriteLine(tupla.id);
























// Dictionary<string,string> estados = new Dictionary<string, string>();

// estados.Add("SC","Santa Catarina");
// estados.Add("SP","São Paulo");
// estados.Add("RJ","Rio de Janeiro");
// estados.Add("MT","Mato Grosso");
// estados.Add("BA","Bahia");

// foreach(var item in estados){
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// Console.WriteLine("-------");

// estados.Remove("SP");

// foreach(var item in estados){
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// Console.WriteLine("-------");

// estados["SC"] = "Santa";

// foreach(var item in estados){
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }




























// Stack<int> pilha = new Stack<int>();

// pilha.Push(1);
// pilha.Push(3);
// pilha.Push(5);
// pilha.Push(7);


//  foreach(int item in pilha){
//     Console.WriteLine(item);
// }

// Console.WriteLine("Removendo da pilha: " + pilha.Pop());

// pilha.Push(9);

//  foreach(int item in pilha){
//     Console.WriteLine(item);
// }




















// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(8);
// fila.Enqueue(335);
// fila.Enqueue(6);
// fila.Enqueue(5);
// fila.Enqueue(23);


// Console.WriteLine(fila.Dequeue());
// fila.Enqueue(88);
// Console.WriteLine(fila.Dequeue());
// fila.Enqueue(24);
// fila.Enqueue(64);
// Console.WriteLine(fila.Dequeue());

// foreach(int item in fila){
//     Console.WriteLine(item);
// }




















// try{

// string[] linhas = File.ReadAllLines("../arquivos/arquivoleitura.txt");

// foreach(string linha in linhas){
//     Console.WriteLine(linha);
// }

// } catch(FileNotFoundException ex){
//     Console.WriteLine($"Arquivo não encontrado: {ex.Message}");
// }
// catch(DirectoryNotFoundException ex){
//     Console.WriteLine($"Diretório não encontrado: {ex.Message}");
// }
// catch(Exception ex){
//     Console.WriteLine($"Ocorreu um erro: {ex.Message}");
// }
// finally {
//     Console.WriteLine($"cabou");
// }























// string dataStr = "2009-07-13 18:31";

// bool sucesso = DateTime.TryParseExact(
// dataStr,
// "yyyy-MM-dd HH:mm",
// CultureInfo.InvariantCulture,
// DateTimeStyles.None,
// out DateTime data);

// if(sucesso){
//     Console.WriteLine($"deu certo! Data: {data}");
// }else
//     Console.WriteLine($"{dataStr} não é valido");
// //DateTime data = DateTime.Parse(dataStr);
























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