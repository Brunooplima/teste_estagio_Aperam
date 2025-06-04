# Teste do programa de estágio TI-Industrial Aperam

## Parte 1 - Criação de um Controlador com Base em Arquitetura MVC

Para executar o código é necessário um compilador compatível com o o C#, neste teste eu utilizei o Visual Studio, para executar o código foi necessário executar o software e na tela principal, terá uma aba escrito "Arquivos" (ou Files), selecione ela e logo em seguida selecione Abrir Pasta.

### 1.1 
Para executar esse problema selecione a pasta chamada Parte 1.1, e após isso clique no botão Iniciar, após isso deverá aparecer uma tela informando a impressão do resultado.

Para estruturar melhor a solução, comecei criando as classes e métodos mencionados no enunciado, garantindo que cada elemento essencial estivesse presente. Em seguida, utilizei herança para que ProdutoController herdasse de BaseController, mantendo a organização e a reutilização de código. Como o objetivo era apenas simular a ação, implementei ProdutoService e Index com mensagens simples para facilitar a instância e exibição na Main. O maior desafio foi o método Inicializar, pois, inicialmente, houve dúvidas sobre como formatar a resposta JSON corretamente. Para resolver isso, defini diretamente um modelo de visualização (ProdutoViewModel) com valores fictícios e utilizei JsonSerializer.Serialize() para retornar a resposta esperada.


### 1.2
Para manter a organização, optei por criar uma nova pasta chamada Parte 1.2, reutilizando as classes do problema anterior. Dessa forma, a estrutura fica mais clara e facilita a execução. Para rodar este problema, basta seguir os mesmos passos utilizados anteriormente.

Como o problema havia solicitado inserir uma lista de ações em uma interface, inicialmente havia uma interface para inserir o AcoesProduto, mas já que o foco era apenas sobrescrever a propriedade AcoesProduto dentro da herança, decidi remové-la, criando a propriedade AcoesProduto dentro da classe BaseController e retornando a lista de ações na classe ProdutoController.

### 1.3
Para manter a organização, optei por criar uma nova pasta chamada Parte 1.3, reutilizando as classes dos problemas anteriores. Dessa forma, a estrutura fica mais clara e facilita a execução. Para rodar este problema, basta seguir os mesmos passos utilizados anteriormente.

Nessa problema foi literalmente fazer a mesma coisa do problema anterior com a diferença que em vez de retornar os valores que estão dentro da lista, retorno as especificações de objetos informados na questão.


## Parte 2 – Manipulação de Listas com Objetos Personalizados

Para executar o código é necessário um compilador compatível com o o C#, neste teste eu utilizei o Visual Studio, para executar o código foi necessário executar o software e na tela principal, terá uma aba escrito "Arquivos" (ou Files), selecione ela e logo em seguida selecione "Abrir Pasta", selecione a pasta Parte2. 

Por ser um código menor, ambas as alternativas foram utilizadas em uma única pasta.
### 2.1 
Nessa parte não tem segredo, foi criado a classe ProdutoGrid como solicitado e as duas propriedades publicas do tipo string.  

### 2.2


## Parte 3 – Questões de Compreensão de Conceitos de Programação

### 3.1 
O valor impresso no console será 10, porque quando y recebeu o valor de x, ele copiou o valor inical de x (que era 10). Depois mesmo que x tenha sido alterado para 5, isso não afetou y, já que y guarda uma cópia independente do valor. 

### 3.2
Uma classe pública serve para permitir que uma classe possa ser acessado em qualquer lugar do código, mesmo em outras classes, projetos ou até bibliotecas, por outro lado uma classe privada só pode ser usada dentro da própria classe onde foi definida.

Você usa uma classe pública quando quer que a classe seja acessível para todo mundo, tipo quando cria um componente em uma classe pai e as classes filhas precisam usá-las. Já o private é indicado para esconder detalhes internos, quando a classe é só um apoio dentro de outra classe e não faz sentido expor para o resto do código, por exemplo um sistema de cadastro, garantindo que essas informações fiquem protegidas dentro da própria classe.

### 3.3
O bloco try/catch em C# serve para tentar executar um código que pode gerar erros (chamado de exceções) e caso isso aconteça, o bloco catch filtra esses erros, evitando que o programa quebre de forma inesperada.

As boas práticas ao lidar com exceções no código incluem: filtrar/capturar só as exceções que você sabe tratar, evitar usar exceções para controlar o fluxo do programa, sempre escrever mensagens claras e específicas para ajudar na identificação dos problemas.

### 3.4
Significa que o modificador override em C# é usado para estender ou modificar a implementação de um método, propriedade, indexador ou até um evento herdado que foi declarado como virtual, abstrata ou já tenha sobrescrito na classe base, permitindo que a classe derivada forneça uma nova versão desse membro mantendo a mesma assinatura.

A diferença entre os usos de virtual, override e new em herança de classes é que o virtual serve para permitir que um método na classe base seja sobrescrito, o override serve para modificar a implementação desse método na classe derivada, garantindo polimorfismo e o new oculta o método da classe base sem polimorfismo.
