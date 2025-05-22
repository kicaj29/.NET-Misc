namespace NET6nullableDeserialization
{
    public class Car
    {
        public string Name { get; set; } = string.Empty;
        public int AmountOfDoors { get; set; }

        public Owner Owner { get; set; } = new Owner();
    }
}
