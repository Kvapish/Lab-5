
namespace Lab5
{
    /// <summary>
    /// клас BaseInform, який містить властивості (назва, вік, висота, розташування та тип грунту) для зберігання загальної інформації про садові дерева,
    /// а також має конструктор для ініціалізації цих властивостей та перевизначений метод ToString(), 
    /// який повертає рядок з інформацією про об'єкт класу BaseInform.
    /// </summary>
    public class BaseInform
    {
        private string _name;
        private int _age;
        private double _height;
        private string _location;
        private string _soiltype;
       
        
        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public double Height { get => _height; set => _height = value; }
        public string Location { get => _location; set => _location = value; }
        public string SoilType { get => _soiltype; set => _soiltype = value; }

        public BaseInform(string name, int age, double height, string location, string soilType)
        {
            Name = name;
            Age = age;
            Height = height;
            Location = location;
            SoilType = soilType;
        }

        public override string ToString()
        {
            return $"Назва: {Name}, Вік: {Age} роки, Висота: {Height} м, Розташування: {Location}, Тип грунту: {SoilType}";
        }
    }
}
