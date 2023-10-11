using System;

namespace Lab5
{
    /// <summary>
    /// клас BaseInform, який містить властивості (назва, вік, висота, розташування та тип грунту) для зберігання загальної інформації про садові дерева,
    /// а також має конструктор для ініціалізації цих властивостей та перевизначений метод ToString(), 
    /// який повертає рядок з інформацією про об'єкт класу BaseInform,також додані перевірки на те , 
    /// що age і height позитивні і location не є порожніми рядками.
    /// </summary>
    public class BaseInform
    {
        private string _name;
        private int _age;
        private double _height;
        private string _location;
        private string _soiltype;


        public string Name { get => _name; set => _name = value; }
        public int Age 
        { 
            get => _age;
            set 
            {
                if (_age < 0)
                {
                    throw new ArgumentException("Вік повинен бути не від'ємним.");
                }
            } 
        }
        public double Height 
        { 
            get => _height;
            set 
            {
                if (_height < 0)
                {
                    throw new ArgumentException("Висота повинна бути не від'ємною.");
                }
            }
        }
        public string Location 
        { 
            get => _location; 
            set  
            {
                if (string.IsNullOrWhiteSpace(_location))
                {
                    throw new ArgumentException("Місце знаходження повинно бути заданим.");
                }
            }
        }
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


