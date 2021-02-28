using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;


namespace SerialCommunication
{
    public partial class SerialComApp : Form
    {
        public SerialComApp()
        {
            InitializeComponent();
        }
        string recivedConfiguration = "C385IT001; 0.0; 500.0; 40; 440";
        string[] instrumentConfigs;
        List<MeasurementPoint> allMeasuredPoints = new List<MeasurementPoint>();

        double chartXValue = 0.0;
        double chartYValue = 0.0;
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            radioButtonConnect.Checked = false;
            timerSerialReceive.Enabled = false;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (comboBoxPort.SelectedIndex > -1)
            {
                serialPort1.PortName = comboBoxPort.Items[comboBoxPort.SelectedIndex].ToString();
                if (comboBoxBaud.SelectedIndex > -1)
                {
                    serialPort1.BaudRate = Convert.ToInt32(comboBoxBaud.Items[comboBoxBaud.SelectedIndex]);
                    serialPort1.Open();
                    radioButtonConnect.Checked = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            instrumentConfigs = recivedConfiguration.Split(';');
            TextBox[] textBoxes = { textBoxName, textBoxLowerRange,
            textBoxUpperRange, textBoxAlarmLow, textBoxAlarmHigh};
            textBoxName.Text = instrumentConfigs[0];
            textBoxLowerRange.Text = instrumentConfigs[1];
            textBoxUpperRange.Text = instrumentConfigs[2];
            textBoxAlarmLow.Text = instrumentConfigs[3];
            textBoxAlarmHigh.Text = instrumentConfigs[4];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string FileName = "";
            
            //instrumentConfigs = recivedConfiguration.Split(';');
            if (saveFileDialogConfiguration.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialogConfiguration.FileName, string.Join(";", instrumentConfigs));
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < instrumentConfigs.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        if (textBoxName.Text == "")
                        {
                            MessageBox.Show("Configuration Name empty");
                            textBoxName.Focus();
                        }
                        break;
                    case 1:
                        if (textBoxLowerRange.Text == "")
                        {
                            MessageBox.Show("Configuration LRange empty");
                            textBoxLowerRange.Focus();
                        }
                        break;
                    case 2:
                        if (textBoxUpperRange.Text == "")
                        {
                            MessageBox.Show("Configuration URange empty");
                            textBoxUpperRange.Focus();
                        }
                        break;
                    case 3:
                        if (textBoxAlarmLow.Text == "")
                        {
                            MessageBox.Show("Configuration Alarm Low empty");
                            textBoxAlarmLow.Focus();
                        }
                        break;
                    case 4:
                        if (textBoxAlarmHigh.Text == "")
                        {
                            MessageBox.Show("Configuration Alarm High empty");
                            textBoxAlarmHigh.Focus();
                        }
                        break;
                    default:
                        instrumentConfigs[i] = textBoxName.Text;
                        instrumentConfigs[i] = textBoxLowerRange.Text;
                        instrumentConfigs[i] = textBoxUpperRange.Text;
                        instrumentConfigs[i] = textBoxAlarmLow.Text;
                        instrumentConfigs[i] = textBoxAlarmHigh.Text;
                        break;



                }
            }
        }

        private void SerialComApp_Load(object sender, EventArgs e)
        {
            instrumentConfigs = new string[5];
        }

        private void buttonReadFile_Click(object sender, EventArgs e)
        {
            textBoxRegister.Clear();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string line in File.ReadLines(openFileDialog.FileName))
                {
                    textBoxRegister.AppendText(line);
                }
            }
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            string fileName = "";
            string[] textFileContent = textBoxRegister.Text.Split(',');
            if (saveFileDialogRegister.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialogRegister.FileName;
                File.AppendAllLines(fileName, textFileContent);
                MessageBox.Show(fileName);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            textBoxLowerRange.Text = "";
            textBoxUpperRange.Text = "";
            textBoxAlarmLow.Text = "";
            textBoxAlarmHigh.Text = "";
            textBoxRegister.Text = "";
            textBoxResult.Text = "";
            textBoxInput1.Text = "";
            textBoxInput2.Text = "";
        }

        private void buttonReseive_Click(object sender, EventArgs e)
        {
            if (radioButtonConnect.Checked)
            {
                if (serialPort1.BytesToRead > 0)
                {
                    // MeasurementPoint measuredPoint;
                    string availableData = "";
                    availableData += serialPort1.ReadExisting().ToString();
                    string[] analogReadings = availableData.Split(';');
                    textBoxReseive.Text = serialPort1.DataBits.ToString();
                }
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

        }

        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            if (this.chart1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textBoxReseive.AppendText(text);
            }
        }

        private void listBoxVb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.AddXY(Convert.ToDouble(textBoxX.Text), Convert.ToDouble(textBoxY.Text));
            textBoxX.Text = textBoxY.Text = "";
        }

        private void timerChartAdd_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("readraw");
                timerSerialReceive.Enabled = true;
                timerChartAdd.Enabled = false;
            }
            chart1.Series[0].Points.AddXY(chartXValue, chartYValue);
            chartXValue += 1.0;
            chartYValue += 1.0;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonRead1_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
                openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            textBoxRead1.Clear();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;

                
                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                //foreach (string text in File.ReadLines(openFileDialog.FileName))
                {
                    fileContent = reader.ReadToEnd();
                    textBoxRead1.AppendText(fileContent);
                }
                MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timerChartAdd.Enabled = true;
        }

        private void timerSerialReceive_Tick(object sender, EventArgs e)
        {
            if (serialPort1.BytesToRead > 0)
            {
                MeasurementPoint measuredPoint;
                string availableData = "";
                availableData += serialPort1.ReadExisting().ToString();
                string[] analogReadings = availableData.Split(';');
                textBoxRead1.AppendText(availableData);
                if (analogReadings.Length == 1)
                {
                    measuredPoint = new MeasurementPoint(DateTime.Now.ToLongTimeString(), Convert.ToInt32(analogReadings[0]),
                        Convert.ToInt32(analogReadings[0]), Convert.ToInt32(analogReadings[0]));
                   chart1.Series[0].Points.AddXY(measuredPoint.time, measuredPoint.va);
                   //chart1.Series[1].Points.AddXY(measuredPoint.time, measuredPoint.vb);
                  // chart1.Series[2].Points.AddXY(measuredPoint.time, measuredPoint.vab);
                    allMeasuredPoints.Add(measuredPoint);

                    /*listBoxVa.Items.Add(analogReadings[0]);
                    chart1.Series[0].Points.AddXY(Convert.ToDouble(listBoxVa.Items.Count - 1),
                        Convert.ToDouble(listBoxVa.Items[listBoxVa.Items.Count - 1]));
                    listBoxVb.Items.Add(analogReadings[1]);
                    chart1.Series[1].Points.AddXY(Convert.ToDouble(listBoxVb.Items.Count - 1),
                        Convert.ToDouble(listBoxVb.Items[listBoxVb.Items.Count - 1]));
                    listBoxVab.Items.Add(analogReadings[2]);
                    chart1.Series[2].Points.AddXY(Convert.ToDouble(listBoxVab.Items.Count - 1),
                        Convert.ToDouble(listBoxVab.Items[listBoxVab.Items.Count - 1]));
                    */

                }
                timerChartAdd.Enabled = true;
                timerSerialReceive.Enabled = false;
            }
        }
            
        
        public class MeasurementPoint
        {
            public String time { get; set; }
            public int va { get; set; }
            public int vb { get; set; }
            public int vab { get; set; }
            public MeasurementPoint(String time, int va, int vb, int vab)
            {
                this.time = time;
                this.va = va;
                this.vb = vb;
                this.vab = vab;
            }
            public override string ToString()
            {
                return time + ";" + va + ";" + vb + ";" + vab;
            }
        }
        public class Instrument
        {
            private int measurement;
            public Instrument(int measurement)
            {
                this.measurement = measurement;
            }
            public Instrument(string tagname, string unit, double lrv, double urv)
            {
                this.tagname = tagname;
                this.unit = unit;
                this.lrv = lrv;
                this.urv = urv;
            }
            public string tagname
            {
                get { return tagname; }
                set { tagname = value; }
            }
            public string unit { get; set; }
            public double lrv { get; set; }
            public double urv { get; set; }

            public double Scaled()
            {
                return measurement / 10.0;
            }       
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            try
            {
                int tmpInteger = int.Parse(textBoxInput1.Text);
                textBoxInput2.Text = tmpInteger.ToString();

            }
            catch (FormatException)
            {
                MessageBox.Show("It is not an integer");

               // throw;
            }
            if (checkBoxCase.Checked)
            {
                textBoxResult.AppendText("" + textBoxInput1.Text.IndexOf(textBoxInput2.Text) + "\r\n");
            }
            else
            {
                textBoxResult.AppendText("" + textBoxInput1.Text.ToLower().IndexOf(textBoxInput2.Text.ToLower()) + "\r\n");

            }
            string[] splitInput = textBoxInput1.Text.Split(';');
            for (int i = 0; i < splitInput.Length; i++)
            {
                textBoxResult.AppendText(string.Format("string no {0} is: {1} \r\n", i, splitInput[i]));
            }
        }

        private void buttonSendSerial_Click(object sender, EventArgs e)
        {
            string writeString;
            string passwordString = "Tønsberg123";
            writeString = "writeconf>" + passwordString + ">" + string.Join(";", instrumentConfigs);
            textBoxResult.Clear();
            textBoxResult.Text = writeString;


        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            textBoxRegister.AppendText("Port: " + comboBoxPort.Text + "\r\n");
            textBoxRegister.AppendText("Baud: " + comboBoxBaud.Text + "\r\n");
            textBoxRegister.AppendText("TagName: " + textBoxName.Text + "\r\n");
            textBoxRegister.AppendText("Lrv: " + textBoxLowerRange.Text + "\r\n");
            textBoxRegister.AppendText("Upr: " + textBoxUpperRange.Text + "\r\n");
            textBoxRegister.AppendText("A_L: " + textBoxAlarmLow.Text + "\r\n");
            textBoxRegister.AppendText("A_H: " + textBoxAlarmHigh.Text + "\r\n");
            textBoxRegister.AppendText("Input1: " + textBoxInput1.Text + "\r\n");
            textBoxRegister.AppendText("Input2: " + textBoxInput2.Text + "\r\n");
            textBoxRegister.AppendText("X_value: " + textBoxX.Text + "\r\n");
            textBoxRegister.AppendText("Y_value: " + textBoxY.Text + "\r\n");
        }

        private void buttonSaveFile_Click_1(object sender, EventArgs e)
        {
            //Stream myStream;
           // SaveFileDialog saveFileDialogNotes = new SaveFileDialog();
            saveFileDialogNotes.Filter = "txt files (*.txt) |*.txt|All files (*.*)|*.*";
            //saveFileDialogRegister.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialogNotes.Title = "save project";
            saveFileDialogNotes.ShowDialog();
            //if (saveFileDialogRegister.ShowDialog() == DialogResult.OK)
            if (saveFileDialogNotes.FileName != "")
            {
                //if ((myStream = saveFileDialogRegister.OpenFile()) != null)
                {
                    System.IO.FileStream fs =
               (System.IO.FileStream)saveFileDialogNotes.OpenFile();
                    //myStream.Close();
                }
            }
        }

        private void buttonReadFile_Click_1(object sender, EventArgs e)
        {
            string message = "are you sure you want to log out ?";
            string caption = "Continue with operation?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons, icon);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void buttonAboutForm_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutWindow = new AboutBox1();
            aboutWindow.ShowDialog(this);
            this.Visible = false;
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK) ;
        }
    }
}
