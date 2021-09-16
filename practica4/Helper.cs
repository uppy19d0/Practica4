using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica4
{
    public  static  class Helper
    {
        //1- Hacer un método extendido que opere sobre el tipo List<int> llamado Pares()
        //que retorne un List<int> con los valores pares en la lista asociada dada. En la implementación del método Pares() utilice el método
        //FindAll() de las listas para pasarle una función predicado 
        //mediante la implementación de un delegado que represente métodos que retornen bool y que reciban un entero como parámetro.


        delegate bool OddValidation(int number);
        public static List<int> Pares(List<int> numbers)
        {

            OddValidation oddValidation;
            Predicate<int> predicate = new Predicate<int>(oddValidation = (numbers) => numbers % 2 != 0); ;

            numbers = numbers.FindAll(predicate);
            return numbers;

        }
    }
}
