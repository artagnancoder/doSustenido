using System;

namespace _03ExercicioEscolar
{
  class Program
  {
      static void Main(string[] args)
      {
        //Instanciar objeto da classe Aluno
        Aluno igor = new Aluno();
        igor.nome = "Igor";
        igor.nota1 = 5;
        igor.nota2 = 3;
        igor.mensagem();
        
      }
  }
}