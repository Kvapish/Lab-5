using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    /// <summary>
    /// клас BaseInform, який містить властивості (назва, вік, висота, розташування та тип грунту) для зберігання загальної інформації про садові дерева,
    /// а також має конструктор для ініціалізації цих властивостей та перевизначений метод ToString(), 
    /// який повертає рядок з інформацією про об'єкт класу BaseInform.
    /// </summary>
    public class BaseInform
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public string Location { get; set; }
        public string SoilType { get; set; }

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
