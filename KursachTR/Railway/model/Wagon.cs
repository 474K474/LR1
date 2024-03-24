namespace Railway.model
{
    public class Wagon
    {
        public int[,,] Data { get; set; }

        // Конструктор класса Wagon
        public Wagon(int[,,] data)
        {
            Data = data;
        }
    }
}
