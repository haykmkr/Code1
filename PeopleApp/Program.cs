// See https://aka.ms/new-console-template for more information
using System;
using static System.Console;
using System.Collections.Generic;
using Packt.Shared;


using System;
using static  System.Console;


namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var bob = new Person();
            WriteLine(bob.ToString());
            bob.Name = "Babken";
            bob.FavouriteAncientWonder = WonderOfTheAncientWorld.Zeus;
           // bob.FavouriteAncientWonder = Array.IndexOf(WonderOfTheAncientWorld.Zeus);
            WriteLine(format:"{0}'s favorite wonder is {1}.It's integer is {2}.",
            arg0:bob.Name,
            arg1:bob.FavouriteAncientWonder,
            arg2:(int)bob.FavouriteAncientWonder
            );
            //bob.BucketList = WonderOfTheAncientWorld.Hanging | WonderOfTheAncientWorld.Halicarnassus;
            bob.BucketList = (WonderOfTheAncientWorld)18;
            WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");
            bob.Children.Add(new Person{Name="Alfred"});
            bob.Children.Add(new Person{Name="Zoe"});
            WriteLine($"{bob.Name} has {bob.Children.Count} children");
            for (int child = 0; child < bob.Children.Count; child++)
            {
                WriteLine($"{bob.Children[child].Name}");
            }

            BankAccount.InterestRate = 0.012M;
            var jonesAccount = new BankAccount();
            jonesAccount.AccountName = "Mrs. Jones";
            jonesAccount.Balance = 2400;

            WriteLine(format: "{0} earned {1:C} interest",jonesAccount.AccountName, jonesAccount.Balance * BankAccount.InterestRate);
            var gerrierAccount = new BankAccount();
            gerrierAccount.AccountName = "Mrs. Gerrier";
            gerrierAccount.Balance = 98;
            WriteLine(format: "{0} earned {1:C} interest",gerrierAccount.AccountName, gerrierAccount.Balance * BankAccount.InterestRate);
            WriteLine($"{bob.Name} is a {Person.Species}");
            WriteLine($"{bob.Name} was born on {bob.HomePlanet}");
            var blankPerson= new Person();
            WriteLine(format:"{0}of {1} was created at{2:hh:mm:ss} on a {2:dddd}.",
            arg0:blankPerson.Name,
            arg1:blankPerson.HomePlanet,
            arg2:blankPerson.Instantiated);
            var gunny= new Person("Gunny" ,"Mars");
                WriteLine(format:"{0} of {1} was created at{2:hh:mm:ss} on a {2:dddd}.",
            arg0:gunny.Name,
            arg1:gunny.HomePlanet,
            arg2:gunny.Instantiated);
            
            (string, int) fruit= bob.GetFruit();
            WriteLine($"{fruit.Item1},{fruit.Item2} there are");
           WriteLine( bob.SayHello());
                WriteLine( bob.SayHello("Gago"));
                //WriteLine(bob.OptionalParameters("Go",3.1,false));
               //  WriteLine(bob.OptionalParameters());
                WriteLine(bob.OptionalParameters(number:52.7,command:"Hide!"));
                var sam =new Person
                {
                    Name="Sam",
                    DateOfBirth=new DateTime(1972,1,27)
                };
                WriteLine(sam.Origin);
                WriteLine(sam.Greeting);
                WriteLine(sam.Age);
                sam.FavoriteIceCream="Chocolate Fudge";
                WriteLine($"Sams favorite ice cream is {sam.FavoriteIceCream}.");
                sam.FavoritePrimaryColor="Red";
                WriteLine($"sams favorite primary color is {sam.FavoritePrimaryColor}.");
                sam.Children.Add(new Person {Name="Charli"});
                sam.Children.Add(new Person {Name="Ella"});
                WriteLine($"Sams first children is {sam.Children[0].Name}");
                WriteLine($"Sams first children is {sam.Children[1].Name}");
                WriteLine($"Sams first children is {sam[0].Name}");
                WriteLine($"Sams first children is {sam[1].Name}");
    }
 }
  
}