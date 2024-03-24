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
            string type = FastRB.Checked ? "������" : (JustRB.Checked ? "������������" : " ");
            string uNum = NumBox.Text;

            int wagKupe, wagPlatskart, wagSV;
            if (int.TryParse(Coupe.Text, out wagKupe) && int.TryParse(Plac.Text, out wagPlatskart) && int.TryParse(SV.Text, out wagSV))
            {
                int[,,] wagonData = new int[,,] { { { wagKupe, wagPlatskart, wagSV } } };
                _presenter.AddTrain(date, time, way, type, uNum, wagonData);
                UpdateListBox(); // ��������� ListBox ����� ���������� ������ ������
            }
            else
            {
                MessageBox.Show("������� ���������� ���������� �������");
            }
        }


        private void ClearBtn_Click(object sender, EventArgs e)
        {
            FastRB.Checked = false; // ��� ������� RadioButton
            JustRB.Checked = false; // ��� ������� RadioButton
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
            string searchType = FastRB.Checked ? "������" : (JustRB.Checked ? "������������" : " ");

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

                // ��������� RadioButton
                FastRB.Checked = selectedTrain.Type == "������";
                JustRB.Checked = selectedTrain.Type == "������������";

                // ��������� ComboBox
                comboBox1.Items.Clear();
                List<string> wagonTypes = _presenter.GetAvailableWagonTypes(selectedIndex);
                foreach (string type in wagonTypes)
                {
                    comboBox1.Items.Add(type);
                }
                comboBox1.SelectedIndex = comboBox1.Items.Count > 0 ? 0 : -1; // �������� ������ �������, ���� �� ����
            }
        }




        //����� ������
        private void InBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                int selectedIndex = listBox1.SelectedIndex;
                string wagonType = comboBox1.SelectedItem?.ToString() ?? "";
                if (_presenter.CheckWagonAvailability(selectedIndex, wagonType, out int availableSeats))
                {
                    MessageBox.Show($"�������� ����: {availableSeats} � ���� ������: {wagonType}");
                    // ����������� ���������� � ��������� ������ ��� ������
                }
                else
                {
                    MessageBox.Show("��� ���������� ���� ������ ���� ���.");
                }
            }
            else
            {
                MessageBox.Show("����������, �������� ����� �� ������.");
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
                    string type = FastRB.Checked ? "������" : JustRB.Checked ? "������������" : "";
                    int[,,] wagonData = new int[,,] { { { wagKupe, wagPlatskart, wagSV } } };

                    _presenter.UpdateTrain(selectedIndex, time, way, uNum, type, wagonData);
                    MessageBox.Show("���������� � ������ ������� ���������.");
                    UpdateListBox();
                    listBox1.SelectedIndex = selectedIndex; // ��������� ����� ������ � ������
                }
                else
                {
                    MessageBox.Show("������� ���������� ���������� �������.");
                }
            }
        }

        }
    }
