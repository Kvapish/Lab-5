using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        /// <summary>
        /// Варіант 8
        /// Создать базовый класс (предметная область) «Садовое дерево» и производные классы «Яблоня», «Вишня», «Груша».
        /// 
        /// Створюємо список для зберігання об'єктів різних класів, додаємо об'єкти до списку. 
        /// Реалізовані функції додавання нового дерева, редагування існуючого дерева та видалення дерева із списку.
        /// </summary>
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<BaseInform> gardenTrees = new List<BaseInform>();

            gardenTrees.Add(new AppleTree("Яблуня 1", 5, 2.5, "Сад", "Грунт 1", "Сорт 1", 100, true));
            gardenTrees.Add(new CherryTree("Вишня 1", 7, 3.0, "Сад", "Грунт 2", "Сорт 2", 80, true));
            gardenTrees.Add(new PearTree("Груша 1", 6, 2.8, "Сад", "Грунт 3", "Сорт 3", 90, true));

            foreach (BaseInform tree in gardenTrees)
            {
                Console.WriteLine(tree.ToString());
            }

            gardenTrees.Add(new AppleTree("Яблуня 2", 4, 2.2, "Сад", "Грунт 1", "Сорт 4", 120, true));

            Console.WriteLine("\nПісля додавання нового дерева:");
            foreach (BaseInform tree in gardenTrees)
            {
                Console.WriteLine(tree.ToString());
            }

            gardenTrees[0].Name = "Яблуня солодка";

            Console.WriteLine("\nПісля редагування:");
            foreach (BaseInform tree in gardenTrees)
            {
                Console.WriteLine(tree.ToString());
            }

            gardenTrees.RemoveAt(1);

            Console.WriteLine("\nПісля видалення:");
            foreach (BaseInform tree in gardenTrees)
            {
                Console.WriteLine(tree.ToString());
            }

            Console.ReadLine();
        }
    }

}
