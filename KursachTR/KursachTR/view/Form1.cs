using KursachTR.mainpresenter;
using KursachTR.view;


namespace KursachTR
{

    public partial class Form1 : Form, IFormView
    {
        private TrainPresenter _presenter;

        public Form1()
        {
            InitializeComponent();
            _presenter = new TrainPresenter(); 
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            listBox1.Items.Clear();
            foreach (var train in _presenter.TrainsList)
            {
                listBox1.Items.Add(train.ToString());
            }
        }


        private void EntBtn_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Text;
            string time = TimeBox.Text;
            string way = WayBox.Text;
            string type = FastRB.Checked ? "Скорый" : (JustRB.Checked ? "Пассажирский" : " ");
            string uNum = NumBox.Text;

            int wagKupe, wagPlatskart, wagSV;
            if (int.TryParse(Coupe.Text, out wagKupe) && int.TryParse(Plac.Text, out wagPlatskart) && int.TryParse(SV.Text, out wagSV))
            {
                int[,,] wagonData = new int[,,] { { { wagKupe, wagPlatskart, wagSV } } };
                _presenter.AddTrain(date, time, way, type, uNum, wagonData);
                UpdateListBox(); // Обновляем ListBox после добавления нового поезда
            }
            else
            {
                MessageBox.Show("Введите корректное количество вагонов");
            }
        }


        private void ClearBtn_Click(object sender, EventArgs e)
        {
            FastRB.Checked = false; // Для первого RadioButton
            JustRB.Checked = false; // Для второго RadioButton
            TimeBox.Text = "";
            WayBox.Text = "";
            NumBox.Text = "";
            listBox1.SelectedItem = null;
            richTextBox1.Text = "";
            Coupe.Text = "";
            Plac.Text = "";
            SV.Text = "";
            comboBox1.Text = "";
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string searchParam1 = TimeBox.Text;
            string searchParam2 = WayBox.Text;
            string searchParam3 = NumBox.Text;
            string searchType = FastRB.Checked ? "Скорый" : (JustRB.Checked ? "Пассажирский" : " ");

            var searchResults = _presenter.SearchTrains(searchParam1, searchParam2, searchParam3, searchType);
            richTextBox1.Clear();
            foreach (var result in searchResults)
            {
                richTextBox1.AppendText(result.ToString() + Environment.NewLine);
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                int selectedIndex = listBox1.SelectedIndex;
                var selectedTrain = _presenter.TrainsList[selectedIndex];

                TimeBox.Text = selectedTrain._Time;
                WayBox.Text = selectedTrain.Way;
                NumBox.Text = selectedTrain.UNum;

                Coupe.Text = selectedTrain.WagonData[0, 0, 0].ToString();
                Plac.Text = selectedTrain.WagonData[0, 0, 1].ToString();
                SV.Text = selectedTrain.WagonData[0, 0, 2].ToString();

                // Установка RadioButton
                FastRB.Checked = selectedTrain.Type == "Скорый";
                JustRB.Checked = selectedTrain.Type == "Пассажирский";

                // Установка ComboBox
                comboBox1.Items.Clear();
                List<string> wagonTypes = _presenter.GetAvailableWagonTypes(selectedIndex);
                foreach (string type in wagonTypes)
                {
                    comboBox1.Items.Add(type);
                }
                comboBox1.SelectedIndex = comboBox1.Items.Count > 0 ? 0 : -1; // Выбираем первый элемент, если он есть
            }
        }




        //выбор билета
        private void InBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                int selectedIndex = listBox1.SelectedIndex;
                string wagonType = comboBox1.SelectedItem?.ToString() ?? "";
                if (_presenter.CheckWagonAvailability(selectedIndex, wagonType, out int availableSeats))
                {
                    MessageBox.Show($"Доступно мест: {availableSeats} в типе вагона: {wagonType}");
                    // Отображение информации о выбранном билете или вагоне
                }
                else
                {
                    MessageBox.Show("Для выбранного типа вагона мест нет.");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите поезд из списка.");
            }
        }


        private void OutBtn_Click(object sender, EventArgs e)
        {
            TicketPic.Image = null;
        }


        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                int selectedIndex = listBox1.SelectedIndex;

                if (int.TryParse(Coupe.Text, out int wagKupe) && int.TryParse(Plac.Text, out int wagPlatskart) && int.TryParse(SV.Text, out int wagSV))
                {
                    string time = TimeBox.Text;
                    string way = WayBox.Text;
                    string uNum = NumBox.Text;
                    string type = FastRB.Checked ? "Скорый" : JustRB.Checked ? "Пассажирский" : "";
                    int[,,] wagonData = new int[,,] { { { wagKupe, wagPlatskart, wagSV } } };

                    _presenter.UpdateTrain(selectedIndex, time, way, uNum, type, wagonData);
                    MessageBox.Show("Информация о поезде успешно обновлена.");
                    UpdateListBox();
                    listBox1.SelectedIndex = selectedIndex; // Повторный выбор поезда в списке
                }
                else
                {
                    MessageBox.Show("Введите корректное количество вагонов.");
                }
            }
        }

        }
    }
