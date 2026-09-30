# Avaliação Individual — Módulo 11 — Tecnologias Emergentes e IA

**Data de entrega:** DD/MM/AAAA
**Formato:** individual, de consulta aberta — use slides, anotações e a própria IA à vontade para pesquisar e testar suas respostas.

## Como participar

1. Faça um **fork** deste repositório.
2. Clone o seu fork localmente.
3. Responda as questões teóricas **direto neste README**, abaixo de cada uma.
4. Complete a parte prática (veja abaixo) editando `CLAUDE.md`, `.claude/skills/minha-skill/SKILL.md` e `EVIDENCIAS.md`.
5. Abra um **Pull Request** do seu fork de volta para este repositório.

> O PR não será mergeado — ele existe só para eu avaliar o seu diff. Pode deixar aberto depois de enviar.

O objetivo não é decorar definições, e sim demonstrar que você entende os conceitos e sabe aplicá-los para ganhar eficiência ao usar IA no seu projeto de TCC. Responda com suas próprias palavras — copiar e colar resposta pronta de IA sem entender não demonstra o aprendizado esperado.

---

## Questões dissertativas

### Questão 1 — O que é um "agent"?
O que é um "agent" (agente de IA)? Explique com suas próprias palavras e dê um exemplo de situação em que faz mais sentido usar um agente do que um chat comum.

resposta:

Um agente de IA recebe um objetivo e pode executar etapas usando ferramentas, como ler arquivos, editar código e rodar comandos. Ele acompanha os resultados para decidir o próximo passo. Um chat comum pode explicar como corrigir um erro; um agente conectado ao projeto pode localizar o erro, propor uma alteração e verificar a compilação. No TCC, isso ajuda em uma revisão que envolve vários arquivos, mas o resultado ainda precisa ser conferido.


### Questão 2 — O que são guidelines?
O que são "guidelines" (diretrizes) ao usar uma IA generativa? Qual é o papel delas na qualidade das respostas geradas pelo modelo?

resposta:

Guidelines são orientações sobre como a IA deve trabalhar: linguagem, estilo, limites e critérios de qualidade. Neste projeto, posso pedir para manter os nomes em português, preservar o estilo simples e não instalar pacotes sem necessidade. Essas instruções reduzem respostas fora do contexto e tornam o resultado mais consistente, mas não garantem que ele esteja correto.


### Questão 4 — Escolha de modelo e nível de esforço
Qual modelo de IA utilizar para cada tipo de tarefa? Dê um exemplo de tarefa simples e outra mais complexa, explicando como você escolheria o modelo em cada caso. O que é o "nível de esforço" (effort level) e quando faz sentido aumentá-lo ou diminuí-lo?

resposta:

Para uma tarefa simples, como explicar uma função curta ou ajustar uma mensagem, escolheria um modelo rápido e de menor custo. Para investigar um problema envolvendo várias partes do TCC, escolheria um modelo com maior capacidade de raciocínio. O nível de esforço indica quanto o modelo deve dedicar ao raciocínio quando a ferramenta oferece essa configuração. Aumentaria em problemas difíceis e diminuiria em tarefas diretas, considerando o tempo e o custo. Mais esforço não substitui testes e revisão.


### Questão 5 — Como estruturar um bom prompt
Descreva os elementos que tornam um prompt mais eficaz (ex.: contexto, objetivo, formato esperado, exemplos, restrições).

resposta:

Um bom prompt informa o contexto, o objetivo, os arquivos relevantes, o formato esperado e as restrições. Exemplos ajudam quando existe um padrão específico. Por exemplo: leia Program.cs e CLAUDE.md, revise a função Concluir, explique em português se ela preserva o ID e o título e não altere os arquivos. Assim a IA sabe o que analisar e como entregar o resultado.


### Questão 6 — Iteração de prompt
O que significa "iterar" um prompt? Por que a primeira resposta de uma IA geralmente não é a versão final, e como você usaria a resposta recebida para melhorar o próximo prompt?

resposta:

Iterar um prompt é melhorar o pedido a partir da resposta recebida. A primeira resposta pode depender de uma interpretação incompleta ou deixar algum requisito de fora. Eu conferiria o resultado e indicaria o ponto que precisa mudar, incluindo informações concretas. Se a IA sugerir um banco de dados para este console, explicaria que os dados devem continuar em memória e pediria uma solução dentro desse limite.


### Questão 7 — Zero-shot vs. few-shot
Qual é a diferença entre um prompt "zero-shot" e um prompt "few-shot"? Dê um exemplo de situação em que vale a pena incluir exemplos dentro do próprio prompt.

resposta:

Zero-shot é pedir uma tarefa sem fornecer exemplos de resposta. Few-shot é incluir alguns exemplos para mostrar o padrão desejado. Para padronizar mensagens de tarefas, posso mostrar que uma tarefa pendente aparece como [ ] #1 — Estudar e uma concluída como [X] #1 — Estudar. Isso ajuda a IA a manter o formato nas próximas sugestões.


### Questão 8 — Memória e contexto entre sessões
O que significa uma IA "ter memória" entre sessões diferentes de conversa? Por que, em um projeto longo como o TCC, é importante decidir o que precisa ser "lembrado" e como fornecer esse contexto para a IA a cada nova conversa?

resposta:

Ter memória entre sessões significa que algumas informações anteriores podem ser guardadas e disponibilizadas em outra conversa, dependendo da ferramenta. Não devo presumir que a IA lembra tudo. Em um TCC longo, registraria o objetivo, a arquitetura, as decisões e os comandos em arquivos do projeto e pediria sua leitura em uma nova sessão. Neste trabalho, CLAUDE.md fornece esse contexto. É importante atualizar os registros e evitar guardar senhas ou informações desnecessárias.


### Questão 9 — Avaliar a resposta da IA
Antes de aplicar a sugestão de uma IA no seu projeto, como você verifica se ela está correta? Descreva pelo menos 2 formas práticas de checar a confiabilidade de uma resposta gerada por IA.

resposta:

Eu verificaria a sugestão lendo o código e comparando com os requisitos. Também compilaria e executaria casos com resultados esperados, incluindo situações como ID inexistente. Para afirmações sobre uma API ou biblioteca, consultaria a documentação oficial da versão usada. Se um teste não puder rodar, registraria a limitação em vez de considerar a resposta validada.


### Questão 10 — Dividir tarefas complexas em etapas
Por que, em tarefas mais complexas, pode ser melhor dividir o trabalho em um fluxo de etapas (ex.: primeiro classificar/organizar, depois processar, depois revisar) em vez de pedir tudo em um único prompt? Dê um exemplo aplicado a uma tarefa do seu TCC.

resposta:

Dividir uma tarefa complexa permite conferir cada etapa, identificar erros cedo e manter o contexto mais claro. No TCC, para revisar o gerenciamento de tarefas, começaria identificando as operações e as regras, depois analisaria cada função, executaria os casos possíveis e por fim revisaria o relatório. Isso evita misturar requisitos, implementação e validação em uma resposta difícil de conferir.


> **Questão 3** (como escrever um bom CLAUDE.md) e a **Questão 11** (prática, evidência de uso real da IA) são respondidas nos próprios arquivos `CLAUDE.md` e `EVIDENCIAS.md` — veja a parte prática abaixo.

---

## Parte prática

1. **Complete o `CLAUDE.md`** na raiz deste repositório — é onde você responde a Questão 3, documentando o projeto para orientar um assistente de IA.
2. **Complete a Skill** em `.claude/skills/minha-skill/SKILL.md`, com instruções reutilizáveis para uma tarefa recorrente do projeto. Renomeie a pasta `minha-skill/` para o nome real da sua skill.
3. **Conecte um assistente de IA ao código local** (Claude Code, GitHub Copilot, Cursor, ou outro de sua escolha) e use-o pelo menos uma vez de verdade, aplicando o `CLAUDE.md` e/ou a Skill que você criou em uma tarefa real do projeto `GerenciadorDeTarefas`.
4. **Complete o `EVIDENCIAS.md`** — é onde você responde a Questão 11, documentando essa experiência (ferramenta usada, prompt exato, o que a IA fez, se seguiu suas instruções).

### O que NÃO fazer

- ❌ Copiar as respostas, o CLAUDE.md ou a Skill de um colega
- ❌ Inventar uma evidência que não aconteceu de verdade
- ❌ Alterar arquivos fora do escopo pedido

## Sobre o projeto de exemplo

Dentro de `GerenciadorDeTarefas/` tem um console app simples em C# — um gerenciador de tarefas fictício — que serve de base para você praticar. Não é necessário adicionar funcionalidades novas ao app; o foco é a configuração e o uso da IA em cima desse código.

Abra `GerenciadorDeTarefas.sln` no Visual Studio, ou rode pelo terminal:

```bash
cd GerenciadorDeTarefas
dotnet run
```

---

## Critérios de avaliação (10 pontos)

| Critério | Pontos |
|---|---|
| Questões dissertativas (conjunto) | 4 |
| `CLAUDE.md` bem estruturado e específico ao projeto (Questão 3) | 2 |
| Skill funcional e realmente reutilizável | 2 |
| `EVIDENCIAS.md` — uso real da IA, seguindo (ou não) o CLAUDE.md/Skill (Questão 11) | 1 |
| Qualidade do Pull Request (descrição clara, organizado, dentro do escopo) | 1 |

## Entrega

Envie o **link do seu Pull Request** pelo Akademos até a data acima.
