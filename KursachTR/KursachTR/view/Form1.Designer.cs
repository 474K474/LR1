namespace KursachTR
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            listBox1 = new ListBox();
            groupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            OutBtn = new Button();
            InBtn = new Button();
            richTextBox1 = new RichTextBox();
            TicketPic = new PictureBox();
            Dispatcher = new GroupBox();
            SV = new TextBox();
            Plac = new TextBox();
            Coupe = new TextBox();
            TimeBox = new TextBox();
            WayBox = new TextBox();
            NumBox = new TextBox();
            SearchBtn = new Button();
            label11 = new Label();
            label10 = new Label();
            label12 = new Label();
            label8 = new Label();
            label7 = new Label();
            ChangeBtn = new Button();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            ClearBtn = new Button();
            EntBtn = new Button();
            JustRB = new RadioButton();
            FastRB = new RadioButton();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TicketPic).BeginInit();
            Dispatcher.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1095, 78);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Sylfaen", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1095, 78);
            label1.TabIndex = 0;
            label1.Text = "Вокзал";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Location = new Point(12, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(510, 369);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Scoreboard";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(402, 26);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 4;
            label4.Text = "Номер";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 26);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 3;
            label2.Text = "Дата";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(199, 26);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 2;
            label3.Text = "Направление";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(6, 59);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(498, 304);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(OutBtn);
            groupBox2.Controls.Add(InBtn);
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Controls.Add(TicketPic);
            groupBox2.Location = new Point(640, 84);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(443, 369);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cashbox";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Купе", "Плацкарт", "СВ" });
            comboBox1.Location = new Point(153, 325);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 4;
            // 
            // OutBtn
            // 
            OutBtn.Location = new Point(25, 324);
            OutBtn.Name = "OutBtn";
            OutBtn.Size = new Size(94, 29);
            OutBtn.TabIndex = 3;
            OutBtn.Text = "Купить";
            OutBtn.UseVisualStyleBackColor = true;
            OutBtn.Click += OutBtn_Click;
            // 
            // InBtn
            // 
            InBtn.Location = new Point(331, 324);
            InBtn.Name = "InBtn";
            InBtn.Size = new Size(94, 29);
            InBtn.TabIndex = 2;
            InBtn.Text = "Выбрать";
            InBtn.UseVisualStyleBackColor = true;
            InBtn.Click += InBtn_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 26);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(431, 86);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // TicketPic
            // 
            TicketPic.Location = new Point(6, 130);
            TicketPic.Name = "TicketPic";
            TicketPic.Size = new Size(431, 178);
            TicketPic.SizeMode = PictureBoxSizeMode.Zoom;
            TicketPic.TabIndex = 0;
            TicketPic.TabStop = false;
            // 
            // Dispatcher
            // 
            Dispatcher.Controls.Add(SV);
            Dispatcher.Controls.Add(Plac);
            Dispatcher.Controls.Add(Coupe);
            Dispatcher.Controls.Add(TimeBox);
            Dispatcher.Controls.Add(WayBox);
            Dispatcher.Controls.Add(NumBox);
            Dispatcher.Controls.Add(SearchBtn);
            Dispatcher.Controls.Add(label11);
            Dispatcher.Controls.Add(label10);
            Dispatcher.Controls.Add(label12);
            Dispatcher.Controls.Add(label8);
            Dispatcher.Controls.Add(label7);
            Dispatcher.Controls.Add(ChangeBtn);
            Dispatcher.Controls.Add(dateTimePicker1);
            Dispatcher.Controls.Add(label5);
            Dispatcher.Controls.Add(label6);
            Dispatcher.Controls.Add(ClearBtn);
            Dispatcher.Controls.Add(EntBtn);
            Dispatcher.Controls.Add(JustRB);
            Dispatcher.Controls.Add(FastRB);
            Dispatcher.Location = new Point(12, 472);
            Dispatcher.Name = "Dispatcher";
            Dispatcher.Size = new Size(1071, 236);
            Dispatcher.TabIndex = 3;
            Dispatcher.TabStop = false;
            Dispatcher.Text = "Dispatcher";
            // 
            // SV
            // 
            SV.Location = new Point(716, 156);
            SV.Name = "SV";
            SV.Size = new Size(125, 27);
            SV.TabIndex = 42;
            // 
            // Plac
            // 
            Plac.Location = new Point(716, 110);
            Plac.Name = "Plac";
            Plac.Size = new Size(125, 27);
            Plac.TabIndex = 41;
            // 
            // Coupe
            // 
            Coupe.Location = new Point(716, 63);
            Coupe.Name = "Coupe";
            Coupe.Size = new Size(125, 27);
            Coupe.TabIndex = 40;
            // 
            // TimeBox
            // 
            TimeBox.Location = new Point(162, 79);
            TimeBox.Name = "TimeBox";
            TimeBox.Size = new Size(125, 27);
            TimeBox.TabIndex = 26;
            // 
            // WayBox
            // 
            WayBox.Location = new Point(162, 155);
            WayBox.Name = "WayBox";
            WayBox.Size = new Size(125, 27);
            WayBox.TabIndex = 27;
            // 
            // NumBox
            // 
            NumBox.Location = new Point(464, 157);
            NumBox.Name = "NumBox";
            NumBox.Size = new Size(125, 27);
            NumBox.TabIndex = 30;
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(951, 172);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(94, 29);
            SearchBtn.TabIndex = 33;
            SearchBtn.Text = "Поиск";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(616, 163);
            label11.Name = "label11";
            label11.Size = new Size(27, 20);
            label11.TabIndex = 39;
            label11.Text = "СВ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(616, 118);
            label10.Name = "label10";
            label10.Size = new Size(75, 20);
            label10.TabIndex = 38;
            label10.Text = "Плацкарт";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(616, 70);
            label12.Name = "label12";
            label12.Size = new Size(42, 20);
            label12.TabIndex = 37;
            label12.Text = "Купе";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(325, 161);
            label8.Name = "label8";
            label8.Size = new Size(110, 20);
            label8.TabIndex = 36;
            label8.Text = "Номер поезда";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(326, 81);
            label7.Name = "label7";
            label7.Size = new Size(88, 20);
            label7.TabIndex = 35;
            label7.Text = "Тип поезда";
            // 
            // ChangeBtn
            // 
            ChangeBtn.Location = new Point(951, 127);
            ChangeBtn.Name = "ChangeBtn";
            ChangeBtn.Size = new Size(94, 29);
            ChangeBtn.TabIndex = 34;
            ChangeBtn.Text = "Изменить";
            ChangeBtn.UseVisualStyleBackColor = true;
            ChangeBtn.Click += ChangeBtn_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(24, 26);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 79);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 24;
            label5.Text = "Время";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 158);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 25;
            label6.Text = "Направление";
            // 
            // ClearBtn
            // 
            ClearBtn.Location = new Point(951, 83);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(94, 29);
            ClearBtn.TabIndex = 32;
            ClearBtn.Text = "Отчистить";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // EntBtn
            // 
            EntBtn.Location = new Point(951, 36);
            EntBtn.Name = "EntBtn";
            EntBtn.Size = new Size(94, 29);
            EntBtn.TabIndex = 31;
            EntBtn.Text = "Ввод";
            EntBtn.UseVisualStyleBackColor = true;
            EntBtn.Click += EntBtn_Click;
            // 
            // JustRB
            // 
            JustRB.AutoSize = true;
            JustRB.Location = new Point(457, 93);
            JustRB.Name = "JustRB";
            JustRB.Size = new Size(132, 24);
            JustRB.TabIndex = 29;
            JustRB.TabStop = true;
            JustRB.Text = "Пассажирский";
            JustRB.UseVisualStyleBackColor = true;
            // 
            // FastRB
            // 
            FastRB.AutoSize = true;
            FastRB.Location = new Point(457, 63);
            FastRB.Name = "FastRB";
            FastRB.Size = new Size(84, 24);
            FastRB.TabIndex = 28;
            FastRB.TabStop = true;
            FastRB.Text = "Скорый";
            FastRB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1095, 720);
            Controls.Add(Dispatcher);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TicketPic).EndInit();
            Dispatcher.ResumeLayout(false);
            Dispatcher.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private ListBox listBox1;
        private GroupBox groupBox2;
        private PictureBox TicketPic;
        private Label label4;
        private Label label2;
        private RichTextBox richTextBox1;
        private Button OutBtn;
        private Button InBtn;
        private ComboBox comboBox1;
        private GroupBox Dispatcher;
        private TextBox SV;
        private TextBox Plac;
        private TextBox Coupe;
        private TextBox TimeBox;
        private TextBox WayBox;
        private TextBox NumBox;
        private Button SearchBtn;
        private Label label11;
        private Label label10;
        private Label label12;
        private Label label8;
        private Label label7;
        private Button ChangeBtn;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label6;
        private Button ClearBtn;
        private Button EntBtn;
        private RadioButton JustRB;
        private RadioButton FastRB;
    }
}