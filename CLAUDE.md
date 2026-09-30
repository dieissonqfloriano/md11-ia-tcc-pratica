# Guia do projeto GerenciadorDeTarefas

## Contexto
Console didático em C# com .NET 8. O programa demonstra inclusão, listagem, conclusão e remoção de tarefas. Os dados ficam em memória e são perdidos ao encerrar. Não há interface web, banco de dados e há um menu de cadastro de tarefas no console.

## Estrutura e comportamento
- `GerenciadorDeTarefas/Program.cs`: instruções de nível superior e funções locais Adicionar, Concluir, Remover, Listar e RegistrarTarefa.
- Cada tarefa é uma tupla `(int Id, string Titulo, bool Concluida, int Prioridade)` em uma lista.
- IDs começam em 1 e aumentam a cada inclusão. Novas tarefas ficam pendentes. Adicionar recebe título e prioridade: 1 = Alta, 2 = Média, 3 = Baixa; entradas inválidas não são cadastradas.
- Concluir marca a tarefa encontrada preservando sua prioridade; ID inexistente não altera a lista.
- Remover exclui a tarefa pelo ID sem renumerar as restantes; ID inexistente não altera a lista.
- Listar imprime `[X]` para concluídas e `[ ]` para pendentes, com a prioridade. Ordena por prioridade crescente (alta primeiro) e por ID em caso de empate.
- O exemplo cria três tarefas, lista, conclui a primeira, lista novamente, remove a segunda e exibe as restantes. Depois da demonstração, o menu permite cadastrar (1), listar (2) e sair (0). O fim da entrada também encerra o programa.

## Convenções
Mantenha o estilo simples existente: funções locais em PascalCase, variáveis em camelCase, nomes e mensagens em português e indentação de quatro espaços. Preserve as tuplas e os IDs ao atualizar uma tarefa. Explique a finalidade de mudanças e evite abstrações sem necessidade.

## Comandos na raiz
```powershell
dotnet build GerenciadorDeTarefas.sln
dotnet run --project GerenciadorDeTarefas/GerenciadorDeTarefas.csproj
```
No segundo comando, use 1 para cadastrar título e prioridade e 0 para encerrar. Informe erros e limitações reais; não declare teste aprovado sem executar.

## Limites
Não adicionar pacotes, persistência, interface gráfica ou novas funcionalidades sem pedido. Não alterar a solução ou a versão do framework para contornar falhas locais. Não apagar arquivos nem publicar commits ou PRs sem autorização. Na avaliação, editar a documentação solicitada; uma revisão pode analisar o código sem modificá-lo. Não inventar evidências nem dados pessoais.

## Rotina reutilizável
Para revisar o comportamento do console, leia `.claude/skills/revisar-tarefas/SKILL.md`. Em ferramentas que não descobrem essa pasta automaticamente, forneça o caminho explicitamente e peça a leitura do arquivo.
