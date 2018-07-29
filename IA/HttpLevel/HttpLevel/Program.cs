using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace HttpLevel
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Entrada
            Console.Write("Digite alguma coisa:");
            var entrada = Console.ReadLine();

            //Quebra Frase por palavras
            var delimitadores = new char[] { '-',' ' };
            var palavrasSeparadas = entrada.Split(delimitadores);

            //Bucar todos os arquivos na pasta Dicionário
            DirectoryInfo diretorio = new DirectoryInfo(@"C:\Users\Programacao\Desktop\Programação\Dicionarios");
            var arquivos = diretorio.GetFiles("*", SearchOption.AllDirectories);

            //Cria Buffer
            var buffer = new List<string>();

            var teste = new List<Tuple<int, string>>();

            foreach (FileInfo itens in arquivos)
            {
                int cont = 0;

                //Abri arquivo txt
                StreamReader arquivo =  File.OpenText(@"C:\Users\Programacao\Desktop\Programação\Dicionarios\" + itens);
                string input = arquivo.ReadToEnd();

                foreach (var palavra in palavrasSeparadas)
                {
                    if (palavra == "")
                    {
                        continue;
                    }
                    else
                    {
                        if (input.IndexOf(palavra) > -1)
                            cont++;
                        arquivo.Close();
                    }
                }
            }

            Console.WriteLine("Testsse");
            Console.ReadKey();
        }
    }
}
