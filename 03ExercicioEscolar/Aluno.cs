using System;

namespace _03ExercicioEscolar
{
    public class Aluno
    {
        //Atributos

        public string? nome;
        public double nota1, nota2;

        //Métodos - ações

        //Média //double é o tipo de retorno do método
        public double media()
        {
            var result = nota1 + nota2 / 2;

            return result;
        }
        //Situação             //parâmetro 
        public string situacao(double media)
        {
            return media >= 7 ? "aprovado" : "reprovado"; //ternário
        }

        //Mensagem
        public void mensagem()
        {
            //Obter a média
            double obterMedia = media();

            //Obter a situação
            string obterSituacao = situacao(obterMedia);

            //Mensagem
            Console.WriteLine(nome+" está "+obterSituacao+" com média "+obterMedia);
        }

    }
}