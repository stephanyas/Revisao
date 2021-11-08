using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {

            //le a informação digitada
            string UsuarioOpcao = ObterOpcao();

            //ENQUANTO a opção dogitada for diferente de x ele vai trazer as opções 
            while (UsuarioOpcao.ToUpper() != "X")
            {
                switch (UsuarioOpcao)
                {
                    case "1":
                        //FAZ: adicionar aluno
                        break;
                    case "2":
                        //FAZ: lista aluno
                        break;
                    case "3":
                        //FAZ: Calcula média geral
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                UsuarioOpcao = ObterOpcao();
            }

        }

        //metodos sempre ficam fora do static void main**
        private static string ObterOpcao()
        {
            string UsuarioOpcao;
            //Pega as informações que o usuario digitar
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Insere novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            //lê NOVAMENTE a opção digitada
            UsuarioOpcao = Console.ReadLine();
            return UsuarioOpcao;
        }
    }
}
