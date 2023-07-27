using Lesson_24_Menagerie.Classes;

namespace Menagerie.Classes
{
    internal class Elephant : AbstractAnimal
    {
        public Elephant(string name, int volumeFeedPerDay, int age)
        {
            Type = "Слон";
            Biome = "Пустыня";
            Square = 10;
            Feed = "Сено";
            IsPredator = false;
            Sound = "Ауф";

            Name = name;
            VolumeFeedPerDay = volumeFeedPerDay;
            Age = age;
        }
    }
}
