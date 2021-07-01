using System;
namespace _06___Manual___Exercise_09___ARRAY {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite o tamanho do vetor: "); 
            int n = int.Parse(Console.ReadLine());
            string[] fruits = new string[n]; 

            for(int i =0; i < fruits.Length; i++) {
                Console.WriteLine("Digite o nome #"+i);
                fruits[i] = Console.ReadLine();
            }

            var result = Array.FindAll(fruits, fruits => fruits.Contains("A") 
            || fruits.Contains("a") 
            || fruits.Contains("B") 
            || fruits.Contains("b"));
           
            int count = 0;
            foreach (var fruit in result) {   
                count += +1; 
                Console.WriteLine(fruit);
            }
            Console.WriteLine(count);

            Console.ReadKey();
        }
    }
}
