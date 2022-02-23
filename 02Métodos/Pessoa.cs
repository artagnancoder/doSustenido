using System;

class Pessoa //Importante que a class sempre tenha o mesmo nome que o arquivo e que comece com a letra maiúscula
{

  //Você pode ter vários métodos com o mesmo nome desde que eles tenham parâmetros diferentes
  //Método 01
  public void apresentar()
  {
    Console.WriteLine("Olá");
  }

  //Método 02
  public void apresentar(string nome)
  {
    Console.WriteLine("Olá" + nome);
  }

  //Método 03
  public void apresentar(string nome, int idade)
  {
    Console.WriteLine("Olá " + nome + " você tem " + idade + " anos");
  }
}