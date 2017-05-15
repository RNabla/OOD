
using Game;
using Game.CustomCollections;
using Game.Model;
using Game.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Game.CustomIterators;
namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomCollection<Hero> zone1List = generateZone1();
            ICustomCollection<Hero> zone2List = generateZone2();
            ICustomCollection<Hero> zone3List = generateZone3();

            var zone1Iterator = new SimpleIterator<Hero>(zone1List);
            var zone2Iterator = new SimpleIterator<Hero>(zone2List);
            var zone3Iterator = new SimpleIterator<Hero>(zone3List);

            //displayCollection<Hero>(zone1Iterator, 1);
            //displayCollection<Hero>(zone2Iterator, 2);
            //displayCollection<Hero>(zone3Iterator, 3);

            //displayPvPPairs<Hero>(zone1Iterator, 1);
            //displayPvPPairs<Hero>(zone2Iterator, 2);
            //displayPvPPairs<Hero>(zone3Iterator, 3);

            var filterZone1Iterator = new FilterIterator<Hero>(zone1List, 'S');

            displayCollection<Hero>(filterZone1Iterator, 1);
        }

        static void displayPvPPairs<T>(Iterator<T> it, int ID)
        {
            Console.WriteLine($"\n === ZONE #{ID} PVP PAIRS ===");
            foreach (var e1 in it)
                foreach (var e2 in it)
                    Console.WriteLine($"{e1} vs {e2}");
        }

        static void displayCollection<T>(Iterator<T> it, int ID)
        {
            Console.WriteLine($"\n=== ZONE #{ID} ===");
            foreach (var elem in it)
                Console.Write($"{elem}\n");
        }

        // DO NOT CHANGE CODE BELOW

        static ICustomCollection<Hero> generateZone1()
        {
            CustomLinkedList<Hero> result = new CustomLinkedList<Hero>();
            RandomHeroGenerator generator = new RandomHeroGenerator();

            for(int i=0; i<20; i++)
            {
                result.Add(generator.GenerateRandomHero());
            }

            return result;
        }

        static ICustomCollection<Hero> generateZone2()
        {
            CustomLinkedList<Hero> result = new CustomLinkedList<Hero>();
            RandomHeroGenerator generator = new RandomHeroGenerator();

            for (int i = 0; i < 10; i++)
            {
                result.Add(generator.GenerateRandomHero());
            }

            return result;
        }

        static ICustomCollection<Hero> generateZone3()
        {
            ReversedArrayList<Hero> result = new ReversedArrayList<Hero>();
            RandomHeroGenerator generator = new RandomHeroGenerator();

            for (int i = 0; i < 10; i++)
            {
                result.Add(generator.GenerateRandomHero());
            }

            return result;
        }
    }
}
