---
name: revisar-tarefas
description: Revisar o comportamento do console GerenciadorDeTarefas em C#, comparando o código e a execução de adicionar, listar, concluir e remover tarefas. Usar ao revisar mudanças nessas operações ou conferir a demonstração existente.
---

# Revisar tarefas
Leia o CLAUDE.md da raiz, Program.cs e o csproj antes de avaliar. A revisão não exige alterar o código.

Confira a inclusão com IDs crescentes e estado pendente, a atualização da tarefa pelo ID preservando título, ID e prioridade e os marcadores da listagem. Na remoção, confira que apenas o ID solicitado é excluído e que as tarefas restantes não são renumeradas. Considere também lista vazia, ID inexistente e conclusão repetida e remoção de ID inexistente: se apenas inspecionar esses casos, identifique a conclusão como análise estática.

Execute `dotnet build GerenciadorDeTarefas.sln` na raiz. Se compilar, execute `dotnet run --no-build --project GerenciadorDeTarefas/GerenciadorDeTarefas.csproj` e use o menu para cadastrar tarefas; envie 0 para sair.

Na demonstração atual, espere três tarefas pendentes na primeira listagem e somente a tarefa 1 concluída na segunda e as tarefas 1 e 3 na terceira, após remover a tarefa 2. Verifique a ordem alta, média e baixa, com desempate pelo ID. Cadastre uma tarefa de cada nível e teste título vazio, prioridade fora de 1 a 3 e entrada não numérica; os inválidos não devem criar tarefas. Compare a saída observada com essa expectativa. Se a demonstração mudar, derive a expectativa do pedido e do código, sem fixar a quantidade antiga.

Entregue um relatório curto em português com arquivos analisados, comandos executados, resultado observado e limitações. Separe falhas verificadas de sugestões opcionais. Não instale dependências nem mude o framework para fazer o teste passar. Se o comando falhar, registre a falha e prossiga apenas com a análise que ainda puder ser feita.
