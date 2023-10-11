
using System;

namespace Lab5
{
    /// <summary>
    /// Клас CherryTree, який є похідним від базового класу BaseInform і містить додаткову інформацію про вишню, 
    /// таку як сорт вишень, кількість вишень та наявність фруктів, та має конструктор для ініціалізації цих властивостей та перевизначений метод ToString(), 
    /// який додає інформацію про вишню до рядка, створеного базовим класом,так само додані перевірки на те, 
    /// що CherryCount невід'ємно, і що  CherryVariety не є порожнім рядком.
    /// </summary>
    public class CherryTree : BaseInform
    {
        private string _cherryvariety;
        private int _cherrycount;
        private bool _hasfruit;

        public string CherryVariety 
        {
            get => _cherryvariety; 
            set
            {
                if (string.IsNullOrWhiteSpace(_cherryvariety))
                {
                    throw new ArgumentException("Сорт вишень повинен бути заданим.");
                }
            }
        }
        public int CherryCount 
        {
            get => _cherrycount; 
            set
            {
                if (_cherrycount < 0)
                {
                    throw new ArgumentException("Кількість вишень повинна бути не від'ємною.");
                }
            } 
        }
        public bool HasFruit { get => _hasfruit; set => _hasfruit = value; }

        public CherryTree(string name, int age, double height, string location, string soilType, string cherryVariety, int cherryCount, bool hasFruit)
            : base(name, age, height, location, soilType)
        {
            CherryVariety = cherryVariety;
            CherryCount = cherryCount;
            HasFruit = hasFruit;
        }

        public override string ToString()
        {
            string hasFruitStr = HasFruit ? "так" : "ні";
            return base.ToString() + $", Сорт вишень: {CherryVariety}, Кількість вишень: {CherryCount}, Наявність фруктів: {hasFruitStr}";
        }
    }
}
