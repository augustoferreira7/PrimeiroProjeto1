namespace PrimeiroProjeto2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string nome;
            int idade;
            string cidade ;
            Console.WriteLine("Qual seu nome?");
            nome =  Console.ReadLine();
            Console.WriteLine("Você tem quantos anos ?");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Onde você mora?");
            cidade = Console.ReadLine();
            
            Console.WriteLine(  );
            Console.WriteLine("suas informações:");
            Console.WriteLine("nome: {0}  \nAnos: {1} anos \ncidade: {2} ", nome, idade, cidade); 

          

        }
    }
}
