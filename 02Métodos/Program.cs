using System;

namespace _02Métodos
{
  class Program
  {
    static void Main(string[] args)
    {
      Pessoa nomeInstancia = new Pessoa();
      nomeInstancia.apresentar("Igor", 25);
    }
  }
}

//Overload acontece quando se tem métodos que tem ações diferentes, onde eles podem ser sobescritos, ou seja, como na classe Pessoa existem métodos diferentes porém com nomes iguais, você pode chamar um método passando ou não um parâmetro, diferenciando assim o método que será chamado.

//A sobrecarga (Overload)  é a habilidade de poder definir diversas propriedades, métodos ou procedimentos em uma classe com o mesmo nome, mas parâmetros diferentes.