using System;
namespace EXERCISE_01___THIS_WORD{
    //-----> INICIO
    ///////////////////////////////////////////////////////////////////////////////////////////////////
    class Program {
        // -------> START / MAIN 
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args){
            Console.Write("Entre os dados do poduto: ");
            Console.Write("Nome: "); string name = Console.ReadLine();
            Console.Write("Preço: "); double price = double.Parse(Console.ReadLine());
            Console.Write("quantidade no estoque: "); int amount = int.Parse(Console.ReadLine());

            Product p = new Product(name, price, amount);
            

            Console.WriteLine();
            Console.Write("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int amnt = int.Parse(Console.ReadLine());
            p.AddProduct(amnt); //----------------------------------------------------------------> Chamada da classe 

            Console.WriteLine();
            Console.Write("Dados att: " + p);

            Console.WriteLine();
            Console.Write("Digite o número a ser removido do estoque: ");
            amount = int.Parse(Console.ReadLine());
            p.RemoveProduct(amount); //----------------------------------------------------------------> Chamada da classe 

            Console.WriteLine();
            Console.Write("Dados att: " + p);
        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        // -------> END
    }    
}
