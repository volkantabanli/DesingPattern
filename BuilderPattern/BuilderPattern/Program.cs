using BuilderPattern;

public class Program
{
    static void Main(string[] args)
    {
        IHouseBuilder houseBuilder = new ConcreteHouseBuilder();
        HouseDirector director = new HouseDirector(houseBuilder);

        director.BuildHouse();
        House house = director.GetHouse();

        Console.WriteLine(house);
    }
}