# CSharp: Eventos, Delegates e Lambda

## Objetivos ao completar os estudos

- Expresse e manipule m�todos como objetos
- Fa�a uso de eventos, simplifique e desacople seu c�digo
- Escreva um c�digo mais leg�vel com express�es Lambda
- Adote as pr�ticas e conven��es usadas pela Microsoft e o mercado de trabalho
- Entenda como eventos, delegates e lambda s�o tratados pelo compilador

## Ementas:

### Comportamentos e Eventos
- Nosso projeto inicial
- Comportamento em nossos elementos
- Comportamento de controles
- Classes especializadas
- Usando Eventos do dotNET
- Consolidando seu conhecimento
- O que aprendi?
	- **M�todo virtual `OnSelectionChanged`:**
		- Precis�vamos alterar o comportamento da ListBox, para isto, criamos um controle especializado chamado `AgenciasListBox` e nele sobreescrevemos o m�todo `OnSelectionChanged` para mudar seu comportamento.
	- **O custo de criar controles customizados:**
		- Criamos novos controles e criar controles especializados � uma rela��o de perda-e-ganho: alteramos seu comportamento, mas perdemos recursos do Visual Studio como o arrastar-e-soltar.
	- **Eventos:**
		- Criar classe especializada para cada comportamento pareceu trabalhoso e desorganizado demais! Se o objetivo � adicionar comportamento, uma melhor alternativa � utilizar Eventos!
	- **Conhecemos eventos de alguns controles do .NET:**
		- A `ListBox` possui um evento chamado `SelectionChanged`, emitido na mudan�a de sele��o de item;
		- O `Button` possui um evento chamado `Click`, emitido no clique do usu�rio.

### Delegates
- Usando delegates
- Respeitando assinaturas de delegate
- Entre eventos e delegates
- Criando a janela de edi��o
- Assinando eventos mais de uma vez
- Mais manipula��es de m�todos
- Combinando delegates
- Consolidando seu conhecimento
- O que aprendi?

### Manipulando Delegates
- Usando delegates
- Respeitando assinaturas de delegate
- Entre eventos e delegates
- Criando a janela de edi��o
- Assinando eventos mais de uma vez
- Mais manipula��es de m�todos
- Combinando delegates
- Consolidando seu conhecimento
- O que aprendi?

### Fun��es e nosso pr�prio evento
- Usando fun��es
- Criando fun��es
- Simplificando a sintaxe de fun��es
- Criando um campo de valida��o customizado
- O Delegate e Evento de valida��o
- Criando Delegates
- Executando nossos eventos
- Consolidando seu conhecimento
- O que aprendi?

### Avan�ando em Eventos
- Usando os metodos Add e Remove
- Usando o GetExecutionList
- Lista de delegates
- Usando boas praticas no OnValidacao
- Criando nossos argumentos de evento
- Conven��es
- Consolidando seu conhecimento
- Projeto final do curso
- Conclus�o
- O que aprendi?