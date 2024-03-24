namespace Railway.model
{
    public abstract class Train
    {
        public string Date;
        public string Time;
        public string Way;
        public string Type;
        public string Num;

        public Train(string date, string time, string way, string type, string num)
        {
            Date = date;
            _Time = time;
            Way = way;
            Type = type;
            UNum = num;

        }
        public abstract string ToString(string position = "#");

        public abstract string UNum { get; set; }

        public abstract string _Time { get; set; }

    }
}