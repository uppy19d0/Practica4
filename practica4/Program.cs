using System;
using System.Collections.Generic;

namespace practica4
{
    class Program
    {
       
   

        delegate int isODD(int number);
        delegate double computeITBIS(double price);
        delegate DateTime GetDate();

        static void Main(string[] args)
        {

         //1- Hacer un método extendido que opere sobre el tipo List<int> llamado Pares()
        //que retorne un List<int> con los valores pares en la lista asociada dada. En la implementación del método Pares() utilice el método
        //FindAll() de las listas para pasarle una función predicado 
        //mediante la implementación de un delegado que represente métodos que retornen bool y que reciban un entero como parámetro.

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 ,10};

            foreach(int number in Helper.Pares(numbers))
            {
                Console.WriteLine( number);

            }

        /////////////////////////////////////////////////



            //2 - Escriba los siguiente método como expresión lambda:
            bool coditiom;
            isODD del = number => number % 2;
            int result = del(7);
            coditiom = result != 0 ? true : false;
            Console.WriteLine("RESULT EXCERISE 2 :"+ coditiom);



            computeITBIS itbisdel = price => price * 0.18;
            double resultPrice = itbisdel(60000);
            Console.WriteLine("RESULT ITBIS :" + resultPrice);


            GetDate getDate = () => DateTime.Now;
            DateTime resultTime = getDate();
            Console.WriteLine("ME TIME NOW IS :" + resultTime);

        }

    }
}
