namespace G19_20231125
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\Gela.txt";
            Person[] array = new Person[1];
            Person person = new Person
            {
                Id = 1,
                Firstname = "Nika",
                Lastname = "Chichua",
                BirthDate = new DateTime(2004, 8, 4),
                Gender = GenderType.Male
            };

            //Person person4 = new Person(2, "NikaJr", "Chichua", new DateTime(2030, 3, 1), GenderType.Male);
            //person.Children.Add(person4);

            Person person2 = new Person(3, "Gulbaza", "Gulbazadze", new DateTime(1993, 3, 1), GenderType.Male);

            Person person3 = new Person
            {
                Id = 4,
                Firstname = "Gela",
                Lastname = "Geladze",
                BirthDate = new DateTime(2022, 1, 3),
                Gender = GenderType.Male
            };

            PersonList2 personList = new();
            personList.Add(person);
            personList.Add(person2);
            personList.Add(person3);
            //personList[1] = person;
            //personList.Clear();
            //personList.Save(filePath);
            //personList.Load(filePath);
            //personList.Remove(person);

            //Console.WriteLine($"{personList.IndexOf(person3)}");
            //Console.WriteLine($"{personList.Contains(person4)}");

            foreach (var p in personList)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();



            //personList.CopyTo(array, 0);

            //foreach (var p in personList)
            //{
            //    Console.WriteLine(p);
            //}
            //personList.Load(filePath);

            //Console.WriteLine(person);
            //Console.WriteLine(person2);
            //Console.WriteLine(person3);

        }
    }
}