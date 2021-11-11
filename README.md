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
	- **A assinatura de delegates:**
		- Vimos o que os delegates representam e os benef�cios de ter um m�todo fortemente tipado em nosso c�digo quando assinamos eventos!
	- **Construindo objetos de Delegates:**
		- A sintaxe de cria��o de Delegates fortemente tipados � a mesma para qualquer outro objeto, usamos o operador `new`! Mas, o argumento do construtor do delegate fortemente tipado � uma refer�ncia para um m�todo que respeita sua assinatura.
	- **O operador `+=`:**
		- Para fazer a assinatura de um evento e adicionar um comportamento quando este evento acontecer, podemos utilizar o operador `+=`!
	- **N�o podemos usar o operador `=` em eventos:**
		- Vimos que faz sentido n�o poder alterar o valor de um evento com o operador `=`, mas sim adicionar comportamentos via `+=`!

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
	- **Sintaxe de cria��o de delegates:**
		- Vimos que poder�amos melhorar nosso fluxo de criar um m�todo para cada delegate e aprendemos a sintaxe de m�todos an�nimos e express�es lambda!
	- **A classe `Delegate` e seu m�todo `Delegate::Combine`:**
		- Precisamos criar um delegate respons�vel por alterar a propriedade `DialogResult` e outro respons�vel por fechar a janela de edi��o. Para combinar estes dois delegates, usamos a fun��o `Delegate::Combine`.
	- **O operador de soma entre delegates:**
		- Aprendemos a usar a fun��o `Delegate::Combine`, mas uma forma mais f�cil de combinar � utilizando o operador de soma `+` - que, por de  baixo dos panos, � transformado na invoca��po da fun��o `Combine` pelo compilador.
	- **Todo delegate � filho do tipo Delegate!**
		- As manipula��es feitas durante o curso foram poss�veis, pois no .NET, todo delegate deriva o tipo `Delegate`.
	- **O argumento `sender`:**
		- Podemos manipular delegates facilmente, mas, se desejamos verificar o objeto emissor de um evento, podemos usar o par�metro `object sender`.

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
	- **A sintaxe de cria��o de delegate:**
		- Ap�s usarmos **delegates** j� criados no .NET, aprendemos a criar os nossos pr�prios delegates. Para isto, basta escrever a assinatura de um - m�todo como j� estamos acostumados e adicionar a palavra reservada `delegate`.
	- **A sintaxe de cria��o de eventos:**
		- Ap�s usarmos **eventos** j� criados no .NET, aprendemos a criar os nossos pr�prios eventos. Para isto, bastou definir o delegate a ser usado por  ele e ent�o adicionar o palavra reservada `event` na cria��o de nosso campo.
	- **M�todos an�nimos e express�es lambda:**
		- Aprendemos mais recursos da linguagem C# para criar facilmente delegates, como os m�todos an�nimos do C#2 e express�es Lambda introduzidas no C#3.

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