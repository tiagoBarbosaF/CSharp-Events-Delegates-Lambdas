# CSharp: Eventos, Delegates e Lambda

## Objetivos ao completar os estudos

- Expresse e manipule métodos como objetos
- Faça uso de eventos, simplifique e desacople seu código
- Escreva um código mais legível com expressões Lambda
- Adote as práticas e convenções usadas pela Microsoft e o mercado de trabalho
- Entenda como eventos, delegates e lambda são tratados pelo compilador

## Ementas:

### Comportamentos e Eventos
- Nosso projeto inicial
- Comportamento em nossos elementos
- Comportamento de controles
- Classes especializadas
- Usando Eventos do dotNET
- Consolidando seu conhecimento
- O que aprendi?
	- **Método virtual `OnSelectionChanged`:**
		- Precisávamos alterar o comportamento da ListBox, para isto, criamos um controle especializado chamado `AgenciasListBox` e nele sobreescrevemos o método `OnSelectionChanged` para mudar seu comportamento.
	- **O custo de criar controles customizados:**
		- Criamos novos controles e criar controles especializados é uma relação de perda-e-ganho: alteramos seu comportamento, mas perdemos recursos do Visual Studio como o arrastar-e-soltar.
	- **Eventos:**
		- Criar classe especializada para cada comportamento pareceu trabalhoso e desorganizado demais! Se o objetivo é adicionar comportamento, uma melhor alternativa é utilizar Eventos!
	- **Conhecemos eventos de alguns controles do .NET:**
		- A `ListBox` possui um evento chamado `SelectionChanged`, emitido na mudança de seleção de item;
		- O `Button` possui um evento chamado `Click`, emitido no clique do usuário.

### Delegates
- Usando delegates
- Respeitando assinaturas de delegate
- Entre eventos e delegates
- Criando a janela de edição
- Assinando eventos mais de uma vez
- Mais manipulações de métodos
- Combinando delegates
- Consolidando seu conhecimento
- O que aprendi?

### Manipulando Delegates
- Usando delegates
- Respeitando assinaturas de delegate
- Entre eventos e delegates
- Criando a janela de edição
- Assinando eventos mais de uma vez
- Mais manipulações de métodos
- Combinando delegates
- Consolidando seu conhecimento
- O que aprendi?

### Funções e nosso próprio evento
- Usando funções
- Criando funções
- Simplificando a sintaxe de funções
- Criando um campo de validação customizado
- O Delegate e Evento de validação
- Criando Delegates
- Executando nossos eventos
- Consolidando seu conhecimento
- O que aprendi?

### Avançando em Eventos
- Usando os metodos Add e Remove
- Usando o GetExecutionList
- Lista de delegates
- Usando boas praticas no OnValidacao
- Criando nossos argumentos de evento
- Convenções
- Consolidando seu conhecimento
- Projeto final do curso
- Conclusão
- O que aprendi?