# Teste do programa de estágio TI-Industrial Aperam

## Parte 1 - Criação de um Controlador com Base em Arquitetura MVC

### 1.1 
asdasdas

### 1.2
asdasd

### 1.3
asdasd

## Parte 2 – Manipulação de Listas com Objetos Personalizados

### 2.1 
asasdds

### 2.2
asdasdasd

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
