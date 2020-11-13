using System;

namespace semafaro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a cor do semaforo (vermelho, amarelo, verde):");
            string cordosem = (Console.ReadLine());

            if(cordosem == "vermelho") {
                Console.Write("Pare!");
                    }
            else if(cordosem == "amarelo") {
                Console.Write("Reduzir a velocidade e Para");
                    }
            else {
                Console.Write("continuar acelerando");
                    }   
            
        }
    }
}
