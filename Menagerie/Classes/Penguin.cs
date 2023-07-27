using Lesson_24_Menagerie.Classes;

namespace Menagerie.Classes
{
    internal class Penguin : AbstractAnimal
    {
        public Penguin(string name, double volumeFeedPerDay, int age)
        {
            Type = "Пингвин";
            Biome = "Тундра";
            Square = 10;
            Feed = "Рыба";
            IsPredator = true;
            Sound = "Хрю";

            Name = name;
            VolumeFeedPerDay = volumeFeedPerDay;
            Age = age;
        }
    }
}
