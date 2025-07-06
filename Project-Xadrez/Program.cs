using tabuleiro;

namespace Project_Xadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Posicao p = new (3, 4);

            Console.WriteLine("Posicao: " + p);


            Console.WriteLine("program finished");
            Console.ReadKey();
        }
    }
}
