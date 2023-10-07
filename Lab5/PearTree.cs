
namespace Lab5
{
    /// <summary>
    /// Клас PearTree, який є похідним від базового класу BaseInform і містить додаткову інформацію про грушу, таку як сорт груш, 
    /// кількість груш та наявність фруктів, та має конструктор для ініціалізації цих властивостей та перевизначений метод ToString(),
    /// який додає інформацію про грушу до рядка, створеного базовим класом.
    /// </summary>
    public class PearTree : BaseInform
    {
        private string pearvariety;
        private int pearcount;
        private bool hasfruit;

        public string PearVariety { get => pearvariety; set => pearvariety = value; }
        public int PearCount { get => pearcount; set => pearcount = value; }
        public bool HasFruit { get => hasfruit; set => hasfruit = value; }

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
