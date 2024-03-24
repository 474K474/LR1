using System;
using System.Collections.Generic;
using System.IO;
using Railway.model;

namespace Railway.model
{
    public class TrainDataStorage
    {
        private const string FilePath = "trainData.txt";

        public List<TR> LoadDataFromFile()
        {
            List<TR> trainsList = new List<TR>();
            try
            {
                if (File.Exists(FilePath))
                {
                    using (StreamReader reader = new StreamReader(FilePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] parts = line.Split(',');
                            if (parts.Length >= 5)
                            {
                                int currentIndex = 5;
                                int[,,] wag = new int[1, 1, 3];
                                for (int i = 0; i < wag.GetLength(0); i++)
                                {
                                    for (int j = 0; j < wag.GetLength(1); j++)
                                    {
                                        for (int g = 0; g < wag.GetLength(2); g++)
                                        {
                                            if (currentIndex < parts.Length)
                                            {
                                                wag[i, j, g] = int.Parse(parts[currentIndex]);
                                                currentIndex++;
                                            }
                                        }
                                    }
                                }
                                TR train = new TR(parts[0], parts[1], parts[2], parts[3], parts[4], wag);
                                trainsList.Add(train);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Рассмотрите возможность логирования ошибок
                throw new InvalidOperationException("Ошибка при загрузке данных: " + ex.Message, ex);
            }
            return trainsList;
        }

        public void SaveDataToFile(List<TR> trainsList)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(FilePath))
                {
                    foreach (TR train in trainsList)
                    {
                        writer.Write($"{train.Date},{train._Time},{train.Way},{train.Type},{train.UNum},");

                        for (int i = 0; i < train.WagonData.GetLength(0); i++)
                        {
                            for (int j = 0; j < train.WagonData.GetLength(1); j++)
                            {
                                for (int g = 0; g < train.WagonData.GetLength(2); g++)
                                {
                                    writer.Write($"{train.WagonData[i, j, g]},");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Рассмотрите возможность логирования ошибок
                throw new InvalidOperationException("Ошибка при сохранении данных: " + ex.Message, ex);
            }
        }
    }
}
