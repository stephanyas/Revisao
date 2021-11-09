using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array com alocação de 5 espaços
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0; //indica qual posição vai iniciar

            //Chamada do metodo ObterOpçao
            string UsuarioOpcao = ObterOpcao();

            //ENQUANTO a opção dogitada for diferente de x ele vai trazer as opções 
            while (UsuarioOpcao.ToUpper() != "X")
            {
                switch (UsuarioOpcao)
                {
                    case "1":
                        //FAZ: adicionar aluno                     

                        Console.WriteLine("Informe o nome do aluno: ");
                        Aluno aluno = new Aluno(); //instanciando o objeto tipo aluno  
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno: ");

                        if (decimal.TryParse(Console.ReadLine(), out decimal nota)) //verifica se no tryparse se ele consegue fazer o parse 
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("O valor da nota deve ser decimal.");
                        }

                        alunos[indiceAluno] = aluno; //coloca o nome e a nota no array
                        indiceAluno++;

                        break;
                    case "2":
                        //FAZ: lista aluno

                        foreach (var listaAluno in alunos) //Para cada aluno e a nota vai imprimir uma linha mostrando
                        {
                            if (!string.IsNullOrEmpty(listaAluno.Nome)) //Se o nome NÂO for nulo e nem vazio ele vai listar somente os alunos inseridos 
                            {
                                Console.WriteLine($"ALUNO: {listaAluno.Nome} - NOTA: {listaAluno.Nota}"); //O $ indica uma string interpolation, assim pode adicionar as variaveis 
                            }
                        }

                        break;
                    case "3":
                        //FAZ: Calcula média geral

                        decimal notaTotal = 0;
                        var numeroAlunos = 0;


                        for (int i = 0; i < alunos.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(alunos[i].Nome)) //Verifica se a posição do array não esta vazia
                            {
                                notaTotal = notaTotal + alunos[i].Nota; //calc da nota mais a POSIÇÂO do array
                                numeroAlunos++;
                            }
                        }

                        var mediaGeral = notaTotal / numeroAlunos;
                        ConceitoEnum conceito;

                        if (mediaGeral < 2)
                        {
                            conceito = ConceitoEnum.E;
                        }
                        else if(mediaGeral < 4)
                        {
                            conceito = ConceitoEnum.D;
                        }
                        else if (mediaGeral < 6)
                        {
                            conceito = ConceitoEnum.C;
                        }
                        else if (mediaGeral < 8)
                        {
                            conceito = ConceitoEnum.B;
                        }
                        else 
                        {
                            conceito = ConceitoEnum.A;
                        }

                        Console.WriteLine($"Media Geral: {mediaGeral} - Conceito {conceito}");

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
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Insere novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            //lê NOVAMENTE a opção digitada
            UsuarioOpcao = Console.ReadLine();
            Console.WriteLine();
            return UsuarioOpcao;
        }
    }
}
