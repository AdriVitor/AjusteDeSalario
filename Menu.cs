using System;

namespace AjusteDeSalario
{
    class Menu
    {
        public static void Show()
        {
            Console.WriteLine("Olá, Seja Bem-vindo(a), Nós vamos calcular o ajuste de salário de 5 Funcionários");
            Console.WriteLine("");

            for(var i = 0; i < 5; i++){
                Console.WriteLine("Digite o seu nome: "); 
                var name = Console.ReadLine();

                Console.WriteLine("Digite o seu salario: ");
                var salario = float.Parse(Console.ReadLine());

                if(salario <= 300){
                    double resultado = salario + (salario * 0.5);
                    
                    Console.WriteLine($"{name}, o seu novo salário é: {resultado.ToString("C")}");
                }
                
                else if(salario > 300){
                    double resultado = salario + (salario * 0.3);
                    
                    Console.WriteLine($"{name}, o seu novo salário é: {resultado.ToString("C")}");
                }
                
                Console.WriteLine("");
            }

            
            }
        }
    }
