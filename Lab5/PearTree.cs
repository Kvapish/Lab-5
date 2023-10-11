
using System;

namespace Lab5
{
    /// <summary>
    /// Клас PearTree, який є похідним від базового класу BaseInform і містить додаткову інформацію про грушу, таку як сорт груш, 
    /// кількість груш та наявність фруктів, та має конструктор для ініціалізації цих властивостей та перевизначений метод ToString(),
    /// який додає інформацію про грушу до рядка, створеного базовим класом,так само додані перевірки на те, 
    /// що PearCount невід'ємно, і що PearVariety не є порожнім рядком.
    /// </summary>
    public class PearTree : BaseInform
    {
        private string _pearvariety;
        private int _pearcount;
        private bool _hasfruit;

        public string PearVariety 
        { 
            get => _pearvariety;
            set 
            {
                if (string.IsNullOrWhiteSpace(_pearvariety))
                {
                    throw new ArgumentException("Сорт груш повинен бути заданим.");
                }
            }
        }
        public int PearCount 
        { 
            get => _pearcount;
            set 
            {
                if (_pearcount < 0)
                {
                    throw new ArgumentException("Кількість груш повинна бути не від'ємною.");
                }
            }
        }
        public bool HasFruit { get => _hasfruit; set => _hasfruit = value; }

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
