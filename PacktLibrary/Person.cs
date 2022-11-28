namespace Packt.Shared;

public partial class Person
{
    public string Name;
    object surname;
    public DateTime  DateOfBirth;
    public WonderOfTheAncientWorld FavouriteAncientWonder;
    public WonderOfTheAncientWorld BucketList;
    public List<Person> Children = new List<Person>();
    public const string Species = "Homo Sapien";
    public readonly string HomePlanet = "Earth";
    public readonly DateTime Instantiated;
    public Person()
    {
        Name = "Unknown";
        Instantiated = DateTime.Now;
    }
    public Person(string initialName, string homePlanet)
    {
        Name=initialName;
        HomePlanet=homePlanet;
        Instantiated=DateTime.Now;
    }
   public  (string,int) GetFruit()
            {
                return ("Apples",5);
            }
            public string SayHello()
            {
                return $"{Name} says 'Hello'";
            }
            public string SayHello(string name)
            {
                return $"{Name} says 'Hello {name}!'";
            }
            public string OptionalParameters(string command="Run"!,
            double number=0.0,
            bool active=true)
            {
                return string.Format(
                    format:"command is {0}, number is {1},activ is {2}",
                    arg0: command, arg1:number,arg2:active
                );
            }

}
