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


            // Parte 2 (calculadora)

            Console.WriteLine(  );
            int numero1, numero2;
            int soma, sub, div, mult;

            Console.WriteLine("digite dois números a:");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite dois números b:");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine(  );
            soma = numero1 + numero2;
            sub = numero1 - numero2;
            div = numero1 / numero2;
            mult = numero1 * numero2;

            Console.WriteLine(  );
            Console.WriteLine("soma: {0} \nsub: {1} \ndiv: {2} \nmult: {3}", soma, sub, div, mult);







        }
    }
}
