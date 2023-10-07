
namespace Lab5
{
    /// <summary>
    /// Клас CherryTree, який є похідним від базового класу BaseInform і містить додаткову інформацію про вишню, 
    /// таку як сорт вишень, кількість вишень та наявність фруктів, та має конструктор для ініціалізації цих властивостей та перевизначений метод ToString(), 
    /// який додає інформацію про вишню до рядка, створеного базовим класом.
    /// </summary>
    public class CherryTree : BaseInform
    {
        private string _cherryvariety;
        private int _cherrycount;
        private bool _hasfruit;

        public string CherryVariety { get => _cherryvariety; set => _cherryvariety = value; }
        public int CherryCount { get => _cherrycount; set => _cherrycount = value; }
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
