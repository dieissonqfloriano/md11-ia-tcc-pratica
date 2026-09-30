Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

var tarefas = new List<(int Id, string Titulo, bool Concluida, int Prioridade)>();
var proximoId = 1;

void Adicionar(string titulo, int prioridade)
{
    if (string.IsNullOrWhiteSpace(titulo) || prioridade < 1 || prioridade > 3)
    {
        Console.WriteLine("Informe um título e uma prioridade válida (1 a 3).");
        return;
    }

    tarefas.Add((proximoId++, titulo.Trim(), false, prioridade));
}

void Concluir(int id)
{
    for (var i = 0; i < tarefas.Count; i++)
    {
        if (tarefas[i].Id == id)
        {
            tarefas[i] = (tarefas[i].Id, tarefas[i].Titulo, true, tarefas[i].Prioridade);
        }
    }
}

void Remover(int id)
{
    for (var i = 0; i < tarefas.Count; i++)
    {
        if (tarefas[i].Id == id)
        {
            tarefas.RemoveAt(i);
            return;
        }
    }
}

void Listar()
{
    foreach (var t in tarefas.OrderBy(t => t.Prioridade).ThenBy(t => t.Id))
    {
        var status = t.Concluida ? "[X]" : "[ ]";
        var prioridade = t.Prioridade == 1 ? "Alta" : t.Prioridade == 2 ? "Média" : "Baixa";
        Console.WriteLine($"{status} #{t.Id} — {t.Titulo} — Prioridade: {prioridade}");
    }
}

void RegistrarTarefa()
{
    Console.Write("Título da tarefa: ");
    var titulo = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(titulo))
    {
        Console.WriteLine("O título não pode ficar vazio.");
        return;
    }

    Console.Write("Prioridade (1 = Alta, 2 = Média, 3 = Baixa): ");
    if (!int.TryParse(Console.ReadLine(), out var prioridade) || prioridade < 1 || prioridade > 3)
    {
        Console.WriteLine("Prioridade inválida. Use 1, 2 ou 3.");
        return;
    }

    Adicionar(titulo, prioridade);
    Console.WriteLine("Tarefa cadastrada. Lista por prioridade:");
    Listar();
}

Adicionar("Estudar para a avaliação do Módulo 11", 1);
Adicionar("Configurar o CLAUDE.md do projeto", 3);
Adicionar("Criar uma Skill reutilizável", 2);

Console.WriteLine("=== Gerenciador de Tarefas — ordem de prioridade ===");
Listar();

Concluir(1);

Console.WriteLine();
Console.WriteLine("=== Depois de concluir a tarefa #1 ===");
Listar();

Remover(2);

Console.WriteLine();
Console.WriteLine("=== Depois de remover a tarefa #2 ===");
Listar();

while (true)
{
    Console.WriteLine();
    Console.WriteLine("1 - Adicionar tarefa | 2 - Listar por prioridade | 0 - Sair");
    var opcao = Console.ReadLine();

    if (opcao == "0" || opcao is null)
    {
        break;
    }

    switch (opcao)
    {
        case "1":
            RegistrarTarefa();
            break;
        case "2":
            Listar();
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}
