using System; //o using é usado quando você quer importar alguma funcionalidade/biblioteca. A system é uma biblioteca padrão onde se pode exibir ou armazenar dados através do console.

namespace _01Conceitos //Namespace é o local/diretório onde você tem o projeto. Usado para identificar e utilizar os dados desse arquivo em outros lugares da aplicação.
{
  class Program
  {
    static void Main(string[] args)
    {
      //Instanciando / criando um objeto
      Pessoa obj = new Pessoa();
      obj.nome = "Igor";
      obj.idade= 25;

      //executando uma ação dentro de um objeto
      obj.mensagem();
    }
  }
}

//Todo projeto em C# precisa ter um arquivo com o static void Main().
//Program.cs é a nossa classe principal, onde vamso executar todos os nossos projetos.