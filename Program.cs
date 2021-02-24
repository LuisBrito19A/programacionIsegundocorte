using System;

namespace programa_02
{
    class Program
    {
        public static void Main(string[] args)
        {
         
            string cadena ="";
            int edad = 0;
            double altura = 0.0;
            
            
            Console.WriteLine("Hola, por favor ingresa tu edad:");
            cadena = Console.ReadLine();
            edad = Convert.ToInt32(cadena);
            
            
            if(edad >= 18)
            {
                Console.WriteLine("Disculpe ha superado el limite de edad para el parque.");
            }
            else
            {
                
                
                Console.WriteLine("Bienvenido");
                
                Console.WriteLine("¿cual es tu altura? En metros");
                cadena = Console.ReadLine();
                altura = Convert.ToDouble(cadena);
                
                if(altura < 1.6)
                {
                Console.WriteLine("Puedes ir a la casa encantada, el gusanito y el carrusel");    
                }
                else
                {
                    Console.WriteLine("Puedes ir a la casa encantada, el gusanito, el carrusel y a la montaña rusa");
                
                }
                //
            }
            
            
            
            
            Console.ReadKey();
        
        }
    }
}   
