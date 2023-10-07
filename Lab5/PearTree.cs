using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    /// <summary>
    /// Клас PearTree, який є похідним від базового класу BaseInform і містить додаткову інформацію про грушу, таку як сорт груш, 
    /// кількість груш та наявність фруктів, та має конструктор для ініціалізації цих властивостей та перевизначений метод ToString(),
    /// який додає інформацію про грушу до рядка, створеного базовим класом.
    /// </summary>
    public class PearTree : BaseInform
    {
        public string PearVariety { get; set; }
        public int PearCount { get; set; }
        public bool HasFruit { get; set; }

        public PearTree(string name, int age, double height, string location, string soilType, string pearVariety, int pearCount, bool hasFruit)
            : base(name, age, height, location, soilType)
        {
            PearVariety = pearVariety;
            PearCount = pearCount;
            HasFruit = hasFruit;
        }

        public override string ToString()
        {
            string hasFruitStr = HasFruit ? "так" : "ні";
            return base.ToString() + $", Сорт груш: {PearVariety}, Кількість груш: {PearCount}, Наявність фруктів: {hasFruitStr}";
        }
    }
}
