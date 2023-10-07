using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    /// <summary>
    /// Клас AppleTree, який є похідним від базового класу BaseInform і містить додаткову інформацію про яблуню, 
    /// таку як сорт яблук, кількість яблук та наявність фруктів, та має конструктор для ініціалізації цих властивостей та перевизначений метод ToString(), 
    /// який додає інформацію про яблуню до рядка, створеного базовим класом.
    /// </summary>
    public class AppleTree : BaseInform
    {
        public string AppleVariety { get; set; }
        public int AppleCount { get; set; }
        public bool HasFruit { get; set; }

        public AppleTree(string name, int age, double height, string location, string soilType, string appleVariety, int appleCount, bool hasFruit)
            : base(name, age, height, location, soilType)
        {
            AppleVariety = appleVariety;
            AppleCount = appleCount;
            HasFruit = hasFruit;
        }

        public override string ToString()
        {
            string hasFruitStr = HasFruit ? "Так" : "Ні";
            return base.ToString() + $", Сорт яблук: {AppleVariety}, Кількість яблук: {AppleCount}, Наявність фруктів: {hasFruitStr}";
        }
    }
}
