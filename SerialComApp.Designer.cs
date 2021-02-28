
namespace SerialCommunication
{
    partial class SerialComApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 100D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 400D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 1000D);
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 200D);
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint15 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint16 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 300D);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonReseive = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxReseive = new System.Windows.Forms.TextBox();
            this.radioButtonConnect = new System.Windows.Forms.RadioButton();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonSendSerial = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxCase = new System.Windows.Forms.CheckBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxInput2 = new System.Windows.Forms.TextBox();
            this.textBoxInput1 = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxAlarmHigh = new System.Windows.Forms.TextBox();
            this.textBoxAlarmLow = new System.Windows.Forms.TextBox();
            this.textBoxUpperRange = new System.Windows.Forms.TextBox();
            this.textBoxLowerRange = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelAlarmHigh = new System.Windows.Forms.Label();
            this.labelAlarmLow = new System.Windows.Forms.Label();
            this.labelUpper = new System.Windows.Forms.Label();
            this.labelLower = new System.Windows.Forms.Label();
            this.labelTagName = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonRead1 = new System.Windows.Forms.Button();
            this.textBoxRead1 = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxVab = new System.Windows.Forms.ListBox();
            this.listBoxVb = new System.Windows.Forms.ListBox();
            this.listBoxVa = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonAboutForm = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxRegister = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timerSerialReceive = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialogConfiguration = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialogRegister = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.timerChartAdd = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialogNotes = new System.Windows.Forms.SaveFileDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1101, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonReseive);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxReseive);
            this.tabPage1.Controls.Add(this.radioButtonConnect);
            this.tabPage1.Controls.Add(this.buttonDisconnect);
            this.tabPage1.Controls.Add(this.buttonConnect);
            this.tabPage1.Controls.Add(this.comboBoxBaud);
            this.tabPage1.Controls.Add(this.comboBoxPort);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1093, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Serial";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // buttonReseive
            // 
            this.buttonReseive.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonReseive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReseive.Location = new System.Drawing.Point(371, 187);
            this.buttonReseive.Name = "buttonReseive";
            this.buttonReseive.Size = new System.Drawing.Size(318, 45);
            this.buttonReseive.TabIndex = 5;
            this.buttonReseive.Text = "Reseive";
            this.buttonReseive.UseVisualStyleBackColor = false;
            this.buttonReseive.Click += new System.EventHandler(this.buttonReseive_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Baud";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // textBoxReseive
            // 
            this.textBoxReseive.Location = new System.Drawing.Point(371, 40);
            this.textBoxReseive.Multiline = true;
            this.textBoxReseive.Name = "textBoxReseive";
            this.textBoxReseive.Size = new System.Drawing.Size(318, 110);
            this.textBoxReseive.TabIndex = 4;
            this.textBoxReseive.TabStop = false;
            // 
            // radioButtonConnect
            // 
            this.radioButtonConnect.AutoSize = true;
            this.radioButtonConnect.BackColor = System.Drawing.Color.Black;
            this.radioButtonConnect.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.radioButtonConnect.ImageKey = "(none)";
            this.radioButtonConnect.Location = new System.Drawing.Point(320, 212);
            this.radioButtonConnect.Name = "radioButtonConnect";
            this.radioButtonConnect.Size = new System.Drawing.Size(21, 20);
            this.radioButtonConnect.TabIndex = 0;
            this.radioButtonConnect.TabStop = true;
            this.radioButtonConnect.UseVisualStyleBackColor = false;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.BackColor = System.Drawing.Color.Red;
            this.buttonDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisconnect.Location = new System.Drawing.Point(106, 291);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(195, 67);
            this.buttonDisconnect.TabIndex = 3;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = false;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.Location = new System.Drawing.Point(108, 187);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(195, 67);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.BackColor = System.Drawing.Color.LightGray;
            this.comboBoxBaud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.comboBoxBaud.Location = new System.Drawing.Point(108, 117);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(193, 33);
            this.comboBoxBaud.TabIndex = 1;
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.BackColor = System.Drawing.Color.LightGray;
            this.comboBoxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Items.AddRange(new object[] {
            "COM3",
            "COM4",
            "COM7"});
            this.comboBoxPort.Location = new System.Drawing.Point(108, 36);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(193, 33);
            this.comboBoxPort.Sorted = true;
            this.comboBoxPort.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.buttonSendSerial);
            this.tabPage2.Controls.Add(this.buttonResult);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.checkBoxCase);
            this.tabPage2.Controls.Add(this.textBoxResult);
            this.tabPage2.Controls.Add(this.textBoxInput2);
            this.tabPage2.Controls.Add(this.textBoxInput1);
            this.tabPage2.Controls.Add(this.buttonClear);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1093, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "String";
            // 
            // buttonSendSerial
            // 
            this.buttonSendSerial.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonSendSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendSerial.Location = new System.Drawing.Point(637, 323);
            this.buttonSendSerial.Name = "buttonSendSerial";
            this.buttonSendSerial.Size = new System.Drawing.Size(198, 58);
            this.buttonSendSerial.TabIndex = 16;
            this.buttonSendSerial.Text = "Send Serial";
            this.buttonSendSerial.UseVisualStyleBackColor = false;
            this.buttonSendSerial.Click += new System.EventHandler(this.buttonSendSerial_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResult.Location = new System.Drawing.Point(648, 182);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(166, 32);
            this.buttonResult.TabIndex = 15;
            this.buttonResult.Text = "Result";
            this.buttonResult.UseVisualStyleBackColor = false;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(532, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Case Sensitive";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(532, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Input.2 =>";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(532, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Input.1 =>";
            // 
            // checkBoxCase
            // 
            this.checkBoxCase.AutoSize = true;
            this.checkBoxCase.Location = new System.Drawing.Point(648, 118);
            this.checkBoxCase.Name = "checkBoxCase";
            this.checkBoxCase.Size = new System.Drawing.Size(22, 21);
            this.checkBoxCase.TabIndex = 11;
            this.checkBoxCase.UseVisualStyleBackColor = true;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(841, 6);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(198, 205);
            this.textBoxResult.TabIndex = 10;
            // 
            // textBoxInput2
            // 
            this.textBoxInput2.Location = new System.Drawing.Point(648, 79);
            this.textBoxInput2.Name = "textBoxInput2";
            this.textBoxInput2.Size = new System.Drawing.Size(166, 26);
            this.textBoxInput2.TabIndex = 9;
            // 
            // textBoxInput1
            // 
            this.textBoxInput1.Location = new System.Drawing.Point(648, 32);
            this.textBoxInput1.Name = "textBoxInput1";
            this.textBoxInput1.Size = new System.Drawing.Size(166, 26);
            this.textBoxInput1.TabIndex = 8;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(841, 322);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(198, 58);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SkyBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(367, 343);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(188, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(8, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Read";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.textBoxAlarmHigh);
            this.groupBox1.Controls.Add(this.textBoxAlarmLow);
            this.groupBox1.Controls.Add(this.textBoxUpperRange);
            this.groupBox1.Controls.Add(this.textBoxLowerRange);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.labelAlarmHigh);
            this.groupBox1.Controls.Add(this.labelAlarmLow);
            this.groupBox1.Controls.Add(this.labelUpper);
            this.groupBox1.Controls.Add(this.labelLower);
            this.groupBox1.Controls.Add(this.labelTagName);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 306);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // textBoxAlarmHigh
            // 
            this.textBoxAlarmHigh.BackColor = System.Drawing.Color.LemonChiffon;
            this.textBoxAlarmHigh.Location = new System.Drawing.Point(180, 229);
            this.textBoxAlarmHigh.Name = "textBoxAlarmHigh";
            this.textBoxAlarmHigh.Size = new System.Drawing.Size(262, 26);
            this.textBoxAlarmHigh.TabIndex = 4;
            // 
            // textBoxAlarmLow
            // 
            this.textBoxAlarmLow.BackColor = System.Drawing.Color.LemonChiffon;
            this.textBoxAlarmLow.Location = new System.Drawing.Point(180, 179);
            this.textBoxAlarmLow.Name = "textBoxAlarmLow";
            this.textBoxAlarmLow.Size = new System.Drawing.Size(262, 26);
            this.textBoxAlarmLow.TabIndex = 3;
            // 
            // textBoxUpperRange
            // 
            this.textBoxUpperRange.BackColor = System.Drawing.Color.LemonChiffon;
            this.textBoxUpperRange.Location = new System.Drawing.Point(180, 129);
            this.textBoxUpperRange.Name = "textBoxUpperRange";
            this.textBoxUpperRange.Size = new System.Drawing.Size(262, 26);
            this.textBoxUpperRange.TabIndex = 2;
            // 
            // textBoxLowerRange
            // 
            this.textBoxLowerRange.BackColor = System.Drawing.Color.LemonChiffon;
            this.textBoxLowerRange.Location = new System.Drawing.Point(180, 79);
            this.textBoxLowerRange.Name = "textBoxLowerRange";
            this.textBoxLowerRange.Size = new System.Drawing.Size(262, 26);
            this.textBoxLowerRange.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.LemonChiffon;
            this.textBoxName.Location = new System.Drawing.Point(180, 29);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(262, 26);
            this.textBoxName.TabIndex = 0;
            // 
            // labelAlarmHigh
            // 
            this.labelAlarmHigh.AutoSize = true;
            this.labelAlarmHigh.ForeColor = System.Drawing.Color.MediumBlue;
            this.labelAlarmHigh.Location = new System.Drawing.Point(18, 231);
            this.labelAlarmHigh.Name = "labelAlarmHigh";
            this.labelAlarmHigh.Size = new System.Drawing.Size(96, 20);
            this.labelAlarmHigh.TabIndex = 0;
            this.labelAlarmHigh.Text = "Alaram High";
            // 
            // labelAlarmLow
            // 
            this.labelAlarmLow.AutoSize = true;
            this.labelAlarmLow.ForeColor = System.Drawing.Color.MediumBlue;
            this.labelAlarmLow.Location = new System.Drawing.Point(18, 182);
            this.labelAlarmLow.Name = "labelAlarmLow";
            this.labelAlarmLow.Size = new System.Drawing.Size(83, 20);
            this.labelAlarmLow.TabIndex = 0;
            this.labelAlarmLow.Text = "Alarm Low";
            // 
            // labelUpper
            // 
            this.labelUpper.AutoSize = true;
            this.labelUpper.ForeColor = System.Drawing.Color.MediumBlue;
            this.labelUpper.Location = new System.Drawing.Point(18, 133);
            this.labelUpper.Name = "labelUpper";
            this.labelUpper.Size = new System.Drawing.Size(150, 20);
            this.labelUpper.TabIndex = 0;
            this.labelUpper.Text = "Upper Range Value";
            // 
            // labelLower
            // 
            this.labelLower.AutoSize = true;
            this.labelLower.ForeColor = System.Drawing.Color.MediumBlue;
            this.labelLower.Location = new System.Drawing.Point(18, 84);
            this.labelLower.Name = "labelLower";
            this.labelLower.Size = new System.Drawing.Size(149, 20);
            this.labelLower.TabIndex = 0;
            this.labelLower.Text = "Lower Range Value";
            // 
            // labelTagName
            // 
            this.labelTagName.AutoSize = true;
            this.labelTagName.ForeColor = System.Drawing.Color.MediumBlue;
            this.labelTagName.Location = new System.Drawing.Point(18, 35);
            this.labelTagName.Name = "labelTagName";
            this.labelTagName.Size = new System.Drawing.Size(78, 20);
            this.labelTagName.TabIndex = 0;
            this.labelTagName.Text = "TagName";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonStart);
            this.tabPage3.Controls.Add(this.buttonRead1);
            this.tabPage3.Controls.Add(this.textBoxRead1);
            this.tabPage3.Controls.Add(this.buttonAdd);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.textBoxY);
            this.tabPage3.Controls.Add(this.textBoxX);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.listBoxVab);
            this.tabPage3.Controls.Add(this.listBoxVb);
            this.tabPage3.Controls.Add(this.listBoxVa);
            this.tabPage3.Controls.Add(this.chart1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1093, 417);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Chart";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(268, 146);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(237, 43);
            this.buttonStart.TabIndex = 14;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonRead1
            // 
            this.buttonRead1.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonRead1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRead1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRead1.Location = new System.Drawing.Point(268, 84);
            this.buttonRead1.Name = "buttonRead1";
            this.buttonRead1.Size = new System.Drawing.Size(237, 43);
            this.buttonRead1.TabIndex = 13;
            this.buttonRead1.Text = "Read File";
            this.buttonRead1.UseVisualStyleBackColor = false;
            this.buttonRead1.Click += new System.EventHandler(this.buttonRead1_Click);
            // 
            // textBoxRead1
            // 
            this.textBoxRead1.Location = new System.Drawing.Point(268, 241);
            this.textBoxRead1.Multiline = true;
            this.textBoxRead1.Name = "textBoxRead1";
            this.textBoxRead1.Size = new System.Drawing.Size(237, 144);
            this.textBoxRead1.TabIndex = 12;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(43, 146);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(170, 43);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add Point";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "X";
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(43, 81);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(170, 26);
            this.textBoxY.TabIndex = 8;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(43, 26);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(170, 26);
            this.textBoxX.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Vab";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vb";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Va";
            // 
            // listBoxVab
            // 
            this.listBoxVab.FormattingEnabled = true;
            this.listBoxVab.ItemHeight = 20;
            this.listBoxVab.Location = new System.Drawing.Point(160, 241);
            this.listBoxVab.Name = "listBoxVab";
            this.listBoxVab.ScrollAlwaysVisible = true;
            this.listBoxVab.Size = new System.Drawing.Size(53, 144);
            this.listBoxVab.TabIndex = 3;
            // 
            // listBoxVb
            // 
            this.listBoxVb.FormattingEnabled = true;
            this.listBoxVb.ItemHeight = 20;
            this.listBoxVb.Location = new System.Drawing.Point(86, 241);
            this.listBoxVb.Name = "listBoxVb";
            this.listBoxVb.ScrollAlwaysVisible = true;
            this.listBoxVb.Size = new System.Drawing.Size(53, 144);
            this.listBoxVb.TabIndex = 2;
            this.listBoxVb.SelectedIndexChanged += new System.EventHandler(this.listBoxVb_SelectedIndexChanged);
            // 
            // listBoxVa
            // 
            this.listBoxVa.FormattingEnabled = true;
            this.listBoxVa.ItemHeight = 20;
            this.listBoxVa.Location = new System.Drawing.Point(12, 241);
            this.listBoxVa.Name = "listBoxVa";
            this.listBoxVa.ScrollAlwaysVisible = true;
            this.listBoxVa.Size = new System.Drawing.Size(53, 144);
            this.listBoxVa.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Right;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(514, 0);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "SeriesVa";
            series4.Points.Add(dataPoint9);
            series4.Points.Add(dataPoint10);
            series4.Points.Add(dataPoint11);
            series4.Points.Add(dataPoint12);
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "SeriesVb";
            series5.Points.Add(dataPoint13);
            series5.Points.Add(dataPoint14);
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "SeriesVab";
            series6.Points.Add(dataPoint15);
            series6.Points.Add(dataPoint16);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(579, 417);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Transparent;
            this.tabPage4.Controls.Add(this.buttonPrint);
            this.tabPage4.Controls.Add(this.buttonAboutForm);
            this.tabPage4.Controls.Add(this.buttonRegister);
            this.tabPage4.Controls.Add(this.buttonSaveFile);
            this.tabPage4.Controls.Add(this.buttonExit);
            this.tabPage4.Controls.Add(this.textBoxRegister);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1093, 417);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Notes";
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.Location = new System.Drawing.Point(861, 261);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(182, 48);
            this.buttonPrint.TabIndex = 11;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonAboutForm
            // 
            this.buttonAboutForm.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonAboutForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAboutForm.Location = new System.Drawing.Point(861, 39);
            this.buttonAboutForm.Name = "buttonAboutForm";
            this.buttonAboutForm.Size = new System.Drawing.Size(182, 48);
            this.buttonAboutForm.TabIndex = 10;
            this.buttonAboutForm.Text = "About";
            this.buttonAboutForm.UseVisualStyleBackColor = false;
            this.buttonAboutForm.Click += new System.EventHandler(this.buttonAboutForm_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.Location = new System.Drawing.Point(861, 113);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(182, 48);
            this.buttonRegister.TabIndex = 9;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonSaveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveFile.Location = new System.Drawing.Point(861, 187);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(182, 48);
            this.buttonSaveFile.TabIndex = 8;
            this.buttonSaveFile.Text = "Save File";
            this.buttonSaveFile.UseVisualStyleBackColor = false;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click_1);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(861, 335);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(182, 48);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonReadFile_Click_1);
            // 
            // textBoxRegister
            // 
            this.textBoxRegister.BackColor = System.Drawing.Color.White;
            this.textBoxRegister.Location = new System.Drawing.Point(337, 39);
            this.textBoxRegister.Multiline = true;
            this.textBoxRegister.Name = "textBoxRegister";
            this.textBoxRegister.Size = new System.Drawing.Size(416, 344);
            this.textBoxRegister.TabIndex = 5;
            this.textBoxRegister.TabStop = false;
            // 
            // timerSerialReceive
            // 
            this.timerSerialReceive.Tick += new System.EventHandler(this.timerSerialReceive_Tick);
            // 
            // saveFileDialogConfiguration
            // 
            this.saveFileDialogConfiguration.DefaultExt = "ssc";
            this.saveFileDialogConfiguration.FileName = "instrumentConfigs";
            // 
            // saveFileDialogRegister
            // 
            this.saveFileDialogRegister.DefaultExt = "ssc";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // timerChartAdd
            // 
            this.timerChartAdd.Interval = 1000;
            this.timerChartAdd.Tick += new System.EventHandler(this.timerChartAdd_Tick);
            // 
            // saveFileDialogNotes
            // 
            this.saveFileDialogNotes.DefaultExt = "txt";
            this.saveFileDialogNotes.FileName = "Notes";
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // SerialComApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "SerialComApp";
            this.Text = "Serial Communication App";
            this.Load += new System.EventHandler(this.SerialComApp_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton radioButtonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timerSerialReceive;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxAlarmHigh;
        private System.Windows.Forms.TextBox textBoxAlarmLow;
        private System.Windows.Forms.TextBox textBoxUpperRange;
        private System.Windows.Forms.TextBox textBoxLowerRange;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelAlarmHigh;
        private System.Windows.Forms.Label labelAlarmLow;
        private System.Windows.Forms.Label labelUpper;
        private System.Windows.Forms.Label labelLower;
        private System.Windows.Forms.Label labelTagName;
        private System.Windows.Forms.SaveFileDialog saveFileDialogConfiguration;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.SaveFileDialog saveFileDialogRegister;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonReseive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxReseive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxVab;
        private System.Windows.Forms.ListBox listBoxVb;
        private System.Windows.Forms.ListBox listBoxVa;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonRead1;
        private System.Windows.Forms.TextBox textBoxRead1;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxCase;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxInput2;
        private System.Windows.Forms.TextBox textBoxInput1;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxRegister;
        private System.Windows.Forms.Button buttonSendSerial;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Timer timerChartAdd;
        private System.Windows.Forms.SaveFileDialog saveFileDialogNotes;
        private System.Windows.Forms.Button buttonAboutForm;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.PrintDialog printDialog;
    }
}

