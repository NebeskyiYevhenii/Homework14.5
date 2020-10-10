using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14._5
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> linkedList1 = new LinkedList<string>();
            LinkedList<string> linkedList2 = new LinkedList<string>();
            linkedList1.DeleteNode += linkedList2.AddToStart;
            // добавление элементов
            linkedList1.AddToEnd("Саша");
            linkedList1.AddToEnd("Маша");
            linkedList1.AddToEnd("Даша");
            linkedList1.AddToEnd("Даша");
            linkedList1.AddToEnd("Глаша");

            //var i = linkedList1.Where(x => x == "Даша");

            // выводим элементы
            foreach (var item in linkedList1)
            {
                Console.WriteLine(item);
            }

            // удаляем элемент
            linkedList1.Delete("Маша");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Delete \"Маша\"");
            foreach (var item in linkedList1)
            {
                Console.WriteLine(item);
            }

            // проверяем наличие элемента
            bool isPresent = linkedList1.Contains("Дима");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("проверяем наличие элемента \"Дима\"");
            Console.WriteLine(isPresent == true ? "Дима присутствует" : "Sam отсутствует");

            // проверяем наличие элемента
            isPresent = linkedList1.Contains("Глаша");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("проверяем наличие элемента \"Глаша\"");
            Console.WriteLine(isPresent == true ? "Глаша присутствует" : "Sam отсутствует");

            // добавляем элемент в начало            
            linkedList1.AddToStart("Сергей");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("добавляем элемент в начало  \"Сергей\"");
            foreach (var item in linkedList1)
            {
                Console.WriteLine(item);
            }

            // добавляем элемент в конец            
            linkedList1.AddToEnd("Яна");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("добавляем элемент в конец  \"Яна\"");
            foreach (var item in linkedList1)
            {
                Console.WriteLine(item);
            }

            // добавляем элемент в индекс 3            
            linkedList1.AddByIndex("Миша", 3);
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("добавляем элемент в индекс 3  \"Миша\"");
            foreach (var item in linkedList1)
            {
                Console.WriteLine(item);
            }

            // получаем 3 элемент
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("получаем 3 элемент");
            Console.WriteLine(linkedList1[3].Name);



            Console.ReadKey();
        }
    }
}
