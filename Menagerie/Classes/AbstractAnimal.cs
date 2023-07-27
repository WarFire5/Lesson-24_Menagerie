namespace Lesson_24_Menagerie.Classes
{
    abstract class AbstractAnimal
    {
        public string Type { get; protected set; }
        public string Biome { get; protected set; }
        public int Square { get; set; }
        public string Feed { get; protected set; }
        public bool IsPredator { get; protected set; }
        public string Sound { get; protected set; }

        public string Name { get; set; }
        public double VolumeFeedPerDay { get; set; }
        public int Age { get; set; }

        public void Eating(string food)
        {
            Console.WriteLine($"{Name} покушал");
        }
        public void MakeASound()
        {
            Console.WriteLine($"{Name} издал звук {Sound}");
        }
        public void Playing()
        {
            Console.WriteLine($"{Name} поиграл");
        }
    }
}
