using Railway.model;

namespace Railway.model
{
    public sealed class TR : Train
    {
        // Поле для хранения объекта Wagon
        private Wagon wagon;

        // Конструктор класса TR
        public TR(string date, string time, string way, string type, string num, int[,,] wag) : base(date, time, way, type, num)
        {
            _type = type;
            // Создаем объект Wagon с переданными данными
            wagon = new Wagon(wag);
        }

        // Свойство для доступа к данным вагона
        public int[,,] WagonData
        {
            get { return wagon.Data; }
            set { wagon.Data = value; }
        }

        // Делегат для события изменения типа поезда
        public delegate void TypeChangedDelegate(string newType);

        // Событие, срабатывающее при изменении типа поезда
        public event TypeChangedDelegate TypeChanged;

        // Определение свойства Type
        private string _type;
        public string Type
        {
            get { return _type; }
            set
            {
                if (_type != value)
                {
                    _type = value;
                    OnTypeChanged(); // Вызываем метод при изменении типа
                }
            }
        }

        // Метод для вызова делегата при изменении типа поезда
        protected void OnTypeChanged()
        {
            TypeChanged?.Invoke(Type);
        }

        public override string ToString(string position = "#")
        {
            return $"{Date} \t\t {Way} \t\t {position} {UNum} ";
        }

        public override string UNum
        {
            get { return Num; }
            set { Num = value.ToUpper(); }
        }

        public override string _Time
        {
            get { return Time; }
            set
            {
                // Проверка, что HH - целочисленное значение
                if (int.TryParse(value.Substring(0, 2), out int hours) && hours >= 0 && hours <= 23)
                {
                    // Проверка наличия MM
                    if (value.Length >= 5 && value[2] == ':' && int.TryParse(value.Substring(3, 2), out int minutes) && minutes >= 0 && minutes <= 59)
                    {
                        Time = $"{hours:D2}:{minutes:D2}";
                    }
                    else
                    {
                        Time = $"{hours:D2}:00";
                    }
                }
                else
                {
                    throw new ArgumentException("Введите время в числовом значении.");
                }
            }
        }

    }
}
