using Lesson_24_Menagerie.Classes;

namespace Menagerie.Classes
{
    internal class Tiger : AbstractAnimal
    {
        public Tiger(string name, int volumeFeedPerDay, int age)
        {
            Type = "Тигр";
            Biome = "Тропики";
            Square = 10;
            Feed = "Мясо";
            IsPredator = true;
            Sound = "Рррр";

            Name = name;
            VolumeFeedPerDay = volumeFeedPerDay;
            Age = age;
        }
    }
}
