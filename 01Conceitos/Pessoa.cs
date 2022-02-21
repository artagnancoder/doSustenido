using System;

class Pessoa //Uma classe pode ser definida como um "molde"
{
  //Atributos: características que uma classe pode ter
  public string nome;     //Um atributo public pode ser acessado dentro de qualquer arquivo .cs
  public int idade;

  //Métodos: funções.
  public void mensagem()  //void define o tipo de função que não tem retorno
  {    //ação 
    Console.WriteLine("Olá" + nome + "você tem" + idade + "anos");
  }
}