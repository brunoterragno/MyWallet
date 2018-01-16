MyWallet

Usuário

* Contas

  * Nome
  * Saldo
  * Tipo
  * Gastos
    * Data, Valor, Tipo
  * Recebimentos
    * Data, Valor, Tipo
  * Transferências

Maus cheiros

1. Refused Bequest
   o nome dado para quando herdamos de uma classe, mas não queremos fazer uso de alguns dos métodos herdados. Ou seja, a classe filho só precisa usar partes da classe pai.

2. Feature envy
   é o nome que damos para quando um método está mais interessado em outro objeto do que no objeto em que ele está inserido. Às vezes, o comportamento está no lugar errado. Pergunte a você mesmo se ele não poderia estar dentro da classe que aquele método está usando. (intimidade inapropriada) Observe que o código faz perguntas para o objeto e, dada a resposta, ele decide marcá-la como importante. Essa é uma decisão que deveria estar dentro da nota fiscal

3. God class
   é aquela classe que controla muitos outros objetos do sistema. Classes assim tendem a crescer mais do que deveriam e passam a "fazer tudo"

4. Divergent changes
   é o nome do mau cheiro para quando a classe não é coesa, e sofre alterações constantes, devido às suas diversas r esponsabilidades. Mais uma vez, classes não coesas possuem baixo reúso, apresentam mais bugs e são mais complexas do que deveriam

5. Shotgun surgery
   quando seu usuário pede uma mudança no sistema e, para que isso aconteça, você precisa modificar 20 arquivos de uma só vez
   Código procedural

Métricas de código

heuristicas para achar problemas no código

* complexidade ciclomatica
  Quando um método é complexo? Geralmente quando ele tem muita linha de código ou quando ele tem muitos possíveis diferentes caminhos a serem executados (numero de Mccabe)
