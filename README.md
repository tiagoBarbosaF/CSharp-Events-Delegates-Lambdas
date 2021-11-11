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
	- **A assinatura de delegates:**
		- Vimos o que os delegates representam e os benefícios de ter um método fortemente tipado em nosso código quando assinamos eventos!
	- **Construindo objetos de Delegates:**
		- A sintaxe de criação de Delegates fortemente tipados é a mesma para qualquer outro objeto, usamos o operador `new`! Mas, o argumento do construtor do delegate fortemente tipado é uma referência para um método que respeita sua assinatura.
	- **O operador `+=`:**
		- Para fazer a assinatura de um evento e adicionar um comportamento quando este evento acontecer, podemos utilizar o operador `+=`!
	- **Não podemos usar o operador `=` em eventos:**
		- Vimos que faz sentido não poder alterar o valor de um evento com o operador `=`, mas sim adicionar comportamentos via `+=`!

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
	- **Sintaxe de criação de delegates:**
		- Vimos que poderíamos melhorar nosso fluxo de criar um método para cada delegate e aprendemos a sintaxe de métodos anônimos e expressões lambda!
	- **A classe `Delegate` e seu método `Delegate::Combine`:**
		- Precisamos criar um delegate responsável por alterar a propriedade `DialogResult` e outro responsável por fechar a janela de edição. Para combinar estes dois delegates, usamos a função `Delegate::Combine`.
	- **O operador de soma entre delegates:**
		- Aprendemos a usar a função `Delegate::Combine`, mas uma forma mais fácil de combinar é utilizando o operador de soma `+` - que, por de  baixo dos panos, é transformado na invocaçãpo da função `Combine` pelo compilador.
	- **Todo delegate é filho do tipo Delegate!**
		- As manipulações feitas durante o curso foram possíveis, pois no .NET, todo delegate deriva o tipo `Delegate`.
	- **O argumento `sender`:**
		- Podemos manipular delegates facilmente, mas, se desejamos verificar o objeto emissor de um evento, podemos usar o parâmetro `object sender`.

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
	- **A sintaxe de criação de delegate:**
		- Após usarmos **delegates** já criados no .NET, aprendemos a criar os nossos próprios delegates. Para isto, basta escrever a assinatura de um - método como já estamos acostumados e adicionar a palavra reservada `delegate`.
	- **A sintaxe de criação de eventos:**
		- Após usarmos **eventos** já criados no .NET, aprendemos a criar os nossos próprios eventos. Para isto, bastou definir o delegate a ser usado por  ele e então adicionar o palavra reservada `event` na criação de nosso campo.
	- **Métodos anônimos e expressões lambda:**
		- Aprendemos mais recursos da linguagem C# para criar facilmente delegates, como os métodos anônimos do C#2 e expressões Lambda introduzidas no C#3.

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