namespace ConsoleApp1
{
    public static class Mappers
    {
        public static Beer MapToBeer(this RegisterBeer Cerveza) => new Beer
        {
            Brand = Cerveza.Brand,
            Name = Cerveza.Name
        };
    }
}
