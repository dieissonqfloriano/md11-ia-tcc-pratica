# Evidência de uso real da IA — Questão 11

## Ferramenta e tarefa
Em 30/09/2026, usei o agente Codex desktop conectado ao clone local em `source/repos/md11-ia-tcc-pratica`. A tarefa prática foi adicionar uma função de remoção por ID em Program.cs, mantendo o estilo do console e validando o resultado.

## Prompts exatos desta conversa
Pedido inicial:
> era so isso kkkk, agora deixe isso nao contexto e resolva o problema. e uma avaliacao que tenho que entregar hoje

Após o assistente inicialmente realizar somente uma revisão, pedi a alteração real:
> mas pede pra usar um agente pra completar o program, voce nao leu?

O agente propôs implementar Remover(int id) e realizou essa alteração. Não foi usado um prompt fictício mais detalhado do que os pedidos realmente enviados.

## Instruções aplicadas
O agente leu CLAUDE.md, Program.cs e o csproj. Também leu explicitamente a Skill em `.claude/skills/revisar-tarefas/SKILL.md` para revisar o comportamento e executar a validação. Essa leitura ocorreu no Codex; não houve invocação automática pelo Claude Code. O guia e a Skill foram atualizados para refletir a remoção adicionada.

## Alteração real
- Foi criada a função local Remover(int id), com nomes em português e indentação de quatro espaços.
- A função percorre a lista, remove a tarefa encontrada com RemoveAt e retorna imediatamente.
- As tarefas restantes preservam seus IDs, títulos e estados. O contador proximoId não é reiniciado.
- A demonstração chama Remover(2) depois da conclusão da tarefa 1 e lista o resultado.
- O projeto manteve C#, .NET 8, tuplas e armazenamento em memória, sem novos pacotes.

## Compilação e execução
Inicialmente, dotnet build falhou por acesso ao NuGet.Config do perfil do usuário. Uma autorização de leitura não resolveu o bloqueio. O agente então usou uma configuração temporária fora do repositório, sem fontes de pacotes, e definiu APPDATA somente no processo do comando para uma pasta temporária. Os componentes de .NET 8 já estavam instalados; não houve mudança de framework nem instalação de dependências.

Comandos usados na validação final, com esses caminhos temporários:
```powershell
$env:APPDATA = 'C:\Users\Acer Nitro V15 4050\Documents\Codex\2026-09-30\https-github-com-dieissonqfloriano-md11-ia\work\dotnet-appdata'
dotnet restore GerenciadorDeTarefas.sln --configfile 'C:\Users\Acer Nitro V15 4050\Documents\Codex\2026-09-30\https-github-com-dieissonqfloriano-md11-ia\work\NuGet.Config'
dotnet build GerenciadorDeTarefas.sln --no-restore
'' | dotnet run --no-build --no-restore --project GerenciadorDeTarefas/GerenciadorDeTarefas.csproj
```
O restore passou e a compilação terminou com zero avisos e zero erros. A linha vazia enviada ao programa encerrou Console.ReadLine.

Trecho real da saída final:
```text
=== Depois de remover a tarefa #2 ===
[X] #1 — Estudar para a avaliação do Módulo 11
[ ] #3 — Criar uma Skill reutilizável
```
As listagens anteriores também mostraram as três tarefas inicialmente pendentes e, depois, somente a tarefa 1 concluída. Isso confirma a remoção da tarefa 2 e a preservação das demais na demonstração executada.

## Revisão e limitações
Por análise estática, remover um ID inexistente não altera a lista e a remoção em uma lista vazia também não altera nada. Esses dois casos não foram executados como testes separados. A execução comprovou o fluxo da demonstração.

O agente seguiu o estilo definido no guia, fez uma alteração pequena e verificou o resultado usando a rotina da Skill. Precisei corrigir o escopo porque a primeira interpretação foi apenas revisar, enquanto eu queria completar o código. A evidência foi atualizada após a implementação real. Não houve publicação no GitHub nesta etapa.

## Continuação: cadastro com prioridade
Prompt exato do usuário:
> adicione uma fucao de adicionar tarefas e comolar uma prioridade quando registrar uma nova tarefa e organise em ordem de prioridade

O agente adaptou Adicionar para receber título e prioridade, acrescentou RegistrarTarefa e um menu de console. Os níveis são 1 = Alta, 2 = Média e 3 = Baixa. Listar ordena por prioridade e depois por ID. Concluir preserva a prioridade. A entrada e a saída usam UTF-8 para manter os acentos.

A compilação foi repetida com `dotnet build GerenciadorDeTarefas.sln --no-restore`, usando o mesmo APPDATA temporário documentado acima, e terminou sem avisos nem erros. A execução final recebeu pelo terminal a sequência abaixo, uma entrada por linha, com codificação UTF-8:
```text
1
Nova baixa
3
1
Nova alta
1
1
Nova média
2
1
Outra alta
1
1

1
Inválida
9
1
Inválida texto
abc
2
0
```
A linha vazia após uma opção 1 testou título vazio. O teste confirmou cadastro nos três níveis, desempate por ordem de cadastro, rejeição de título vazio e rejeição das prioridades 9 e abc. A listagem final apresentou os IDs 1, 5 e 7 como alta, 3 e 6 como média e 4 como baixa; entradas inválidas não geraram tarefas. O menu saiu com a opção 0. A demonstração anterior continuou concluindo a tarefa 1 e removendo a tarefa 2 corretamente.

O guia e a Skill foram atualizados para o cadastro interativo e a ordenação. Não foram adicionadas dependências nem persistência: os registros continuam em memória.
