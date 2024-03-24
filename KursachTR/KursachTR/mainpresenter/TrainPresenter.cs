using KursachTR.view;
using Railway.model;


namespace KursachTR.mainpresenter
{
    internal class TrainPresenter
    {
        private TrainDataStorage _dataStorage = new TrainDataStorage();
        public List<TR> TrainsList { get; private set; } = new List<TR>();

        public TrainPresenter(IFormView view)
        {
            TrainsList = _dataStorage.LoadDataFromFile();
        }

        public TrainPresenter()
        {
            TrainsList = _dataStorage.LoadDataFromFile();
        }


        // Обновите вызовы SaveDataToFile, чтобы использовать _dataStorage
        public void AddTrain(string date, string time, string way, string type, string uNum, int[,,] wagonData)
        {
            TR newTrain = new TR(date, time, way, type, uNum, wagonData);
            TrainsList.Add(newTrain);
            _dataStorage.SaveDataToFile(TrainsList);
        }

        public List<TR> SearchTrains(string searchParam1, string searchParam2, string searchParam3, string searchType)
        {
            List<TR> searchResults = TrainsList.FindAll(train =>
                train._Time == searchParam1 ||
                train.Way == searchParam2 ||
                train.UNum == searchParam3 ||
                train.Type == searchType);
            return searchResults;
        }


        public void UpdateTrain(int selectedIndex, string time, string way, string uNum, string type, int[,,] wagonData)
        {
            // Ваши обновления
            _dataStorage.SaveDataToFile(TrainsList);
        }

        public bool CheckWagonAvailability(int selectedIndex, string wagonType, out int availableSeats)
        {
            availableSeats = 0;
            if (selectedIndex < 0 || selectedIndex >= TrainsList.Count) return false;

            var selectedTrain = TrainsList[selectedIndex];
            switch (wagonType)
            {
                case "Купе":
                    availableSeats = selectedTrain.WagonData[0, 0, 0];
                    break;
                case "Плацкарт":
                    availableSeats = selectedTrain.WagonData[0, 0, 1];
                    break;
                case "СВ":
                    availableSeats = selectedTrain.WagonData[0, 0, 2];
                    break;
            }
            return availableSeats > 0;
        }

        public string GetTrainType(int selectedIndex)
        {
            if (selectedIndex >= 0 && selectedIndex < TrainsList.Count)
            {
                return TrainsList[selectedIndex].Type;
            }
            return "";
        }
        public List<string> GetAvailableWagonTypes(int selectedIndex)
        {
            List<string> availableTypes = new List<string>();

            if (selectedIndex >= 0 && selectedIndex < TrainsList.Count)
            {
                TR selectedTrain = TrainsList[selectedIndex];
                if (selectedTrain.WagonData[0, 0, 0] > 0) availableTypes.Add("Купе");
                if (selectedTrain.WagonData[0, 0, 1] > 0) availableTypes.Add("Плацкарт");
                if (selectedTrain.WagonData[0, 0, 2] > 0) availableTypes.Add("СВ");
            }

            return availableTypes;
        }

    }
}
