using System.Net.Http.Headers;
using AbstractFactory;
using AbstractFactory.Factories;



Console.WriteLine("What is the type of furnitures you want..?");
Console.WriteLine("1: modern\t2:victorian\t3: arcdeco");
var input1 = Console.ReadLine();

IFurnitureFactory factory;
if (input1 == "1")
{
     factory = new ModernFactory();

}
else if (input1 == "2")
{
    factory = new VictorianFactory();
}
else
{
    factory = new ArcDecoFactory();
}

Console.WriteLine("What is the kind of furnitures you want to buy..?");
Console.WriteLine("1: chairs\t2:sofas");
var input2 = Console.ReadLine();

void buyChair()
{
    IChair product = factory.CreateChair();
    Console.WriteLine($"Your peoduct has been bought successfully\n{product.Buy()}");
}
void buySofa()
{
    ISofa product = factory.CreateSofa();
    Console.WriteLine($"Your peoduct has been bought successfully\n{product.Buy()}");
}

IFurniture product;
if(input2 == "1")
{
    buyChair();
}
else
{
    buySofa();
}



