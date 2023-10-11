
using System;

namespace Lab5
{
    /// <summary>
    /// Клас AppleTree, який є похідним від базового класу BaseInform і містить додаткову інформацію про яблуню, 
    /// таку як сорт яблук, кількість яблук та наявність фруктів, та має конструктор для ініціалізації цих властивостей та перевизначений метод ToString(), 
    /// який додає інформацію про яблуню до рядка, створеного базовим класом,так само додані перевірки на те,  
    /// що AppleCount невід'ємно, і що AppleVariety не є порожнім рядком.
    /// </summary>
    public class AppleTree : BaseInform
    {
        private string _applevariety;
        private int _applecount;
        private bool _hasfruit;

        public string AppleVariety 
        {
            get => _applevariety;
            set
            {
                if (string.IsNullOrWhiteSpace(_applevariety))
                {
                    throw new ArgumentException("Сорт яблук повинен бути заданим.");
                }
            }
        }
        public int AppleCount 
        { 
            get => _applecount; 
            set
            {
                if (_applecount < 0)
                {
                    throw new ArgumentException("Кількість яблук повинна бути не від'ємною.");
                }
            } 
        }
        public bool HasFruit { get => _hasfruit; set => _hasfruit = value; }

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

