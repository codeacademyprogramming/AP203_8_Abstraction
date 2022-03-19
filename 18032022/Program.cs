using System;

namespace _18032022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Name = "Artur";
            dog.Age = -3;
            dog.MakeSound();
            Console.WriteLine(dog.GetInfo());
            dog.ShowName();

            Cat cat = new Cat();
            cat.Age = -2;
            cat.Name = "Mestan";
            cat.MakeSound();
            Console.WriteLine(cat.GetInfo());


            PetDog petDog = new PetDog();
            petDog.MakeSound();

            Ak47 ak47 = new Ak47();
            ak47.CurrentMagazine = 30;
            ak47.Fire();
            ak47.Fire();
            Console.WriteLine(ak47.CurrentMagazine);

            Makarov makarov = new Makarov();
            makarov.CurrentMagazine = 10;
            makarov.Fire();


            Human human = new Human
            {
                Name = "Hikmet",
                Surname = "Abbasov"
            };

            Student student = new Student
            {
                Name = "Zeyneb",
                Surname = "Abdullayeva",
                GroupNo = "PB123"
            };

            human.ShowInfo();
            student.ShowInfo();

            WarrantyStudent warrantyStudent = new WarrantyStudent
            {
                GroupNo = "P123",
                PrevGroupNo = "P111"
            };

            warrantyStudent.ShowInfo();
        }
    }
}
