using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Security.Principal;
using System.Runtime.InteropServices;
using OpenHardwareMonitor.Hardware;


namespace Hardware_Monitor_Display_PC
{
    public partial class Form1 : Form
    {
        private readonly Computer _computer = new Computer();
        private int _cpuCores = 0;
        private bool isAdministrator;
        private readonly Dictionary<string, float> _sensorData = new Dictionary<string, float>();
        private readonly Dictionary<string, string> _hardwareData = new Dictionary<string, string>();
        private readonly UpdaterVisitor _updater = new UpdaterVisitor();
        private readonly SensorVisitor _sensorVisitor;
        int port;
        string message;
        string cpu_name;
        string cpu_load = "0";
        string cpu_temperature = "0";
        string gpu_load = "0";
        string gpu_temperature = "0";
        string RAM_load = "0";
        string front_fan = "0";
        string cpu_fan = "0";
        string rear_fan = "0";

        int byteCount;

        NetworkStream stream;
        byte[] sendData;
        TcpClient client;
        public Form1()
        {
            _sensorVisitor = new SensorVisitor(ProcessSensor);  //, ProcessHardware);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Stop();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private string GetSensorData(string key)
        {
            return _sensorData.ContainsKey(key) ? _sensorData[key].ToString("###") : "NA";
        }

        private string GetHardwareData(string key)
        {
            return _hardwareData.ContainsKey(key) ? _hardwareData[key] : "cannot find";
        }



        private void ProcessHardware(IHardware hardware)
        {
            if (hardware.HardwareType.ToString() == "CPU Package")
            {

                _hardwareData["cpuName"] = hardware.Name;

            }


        }


        private void ProcessSensor(ISensor sensor)
        {
            if (!sensor.Value.HasValue)
            {
                return;
            }   /*
            if (sensor.SensorType != SensorType.Temperature)
            {
                if (sensor.SensorType != SensorType.Load)
                {
                    if (sensor.SensorType != SensorType.Voltage)
                    {
                        if (sensor.SensorType != SensorType.Fan)
                        {
                            if (sensor.SensorType != SensorType.Control)
                            {
                                return;
                            }
                        }
                    }
                }
            }
            */

            var value = sensor.Value.Value;



            if (sensor.Name.StartsWith("CPU Core #"))
            {
                if (Int32.TryParse(sensor.Name.Substring(10), out var id))
                {
                    _sensorData["cpuTemp" + sensor.Name.Substring(10)] = value;
                    if (id > _cpuCores)
                    {
                        _cpuCores = id;
                    }
                }

                return;
            }



            if (sensor.Name == "CPU Package")
            {
                if (sensor.SensorType == SensorType.Temperature)
                {
                    _sensorData["cpuTemp"] = value;
                }
            }

            if (sensor.Name == "GPU Core")
            {
                if (sensor.SensorType == SensorType.Temperature)
                {
                    _sensorData["gpuTemp"] = value;
                }
            }

            if (sensor.Name == "GPU Core")
            {
                if (sensor.SensorType == SensorType.Load)
                {
                    _sensorData["gpuLoad"] = value;
                }
            }


            if (sensor.Name == "CPU Total")
            {
                if (sensor.SensorType == SensorType.Load)
                {
                    _sensorData["cpuUtil"] = value;
                }
            }

            if (sensor.Name == "Memory")
            {
                if (sensor.SensorType == SensorType.Load)
                {
                    _sensorData["ramUtil"] = value;
                }
            }

            if (sensor.Name == "Fan #1")
            {
                if (sensor.SensorType == SensorType.Fan)
                {
                    _sensorData["cpuFan"] = value;
                }
            }

            if (sensor.Name == "Fan #3")
            {
                if (sensor.SensorType == SensorType.Fan)
                {
                    _sensorData["FrontFan"] = value;
                }
            }

            if (sensor.Name == "Fan #2")
            {
                if (sensor.SensorType == SensorType.Fan)
                {
                    _sensorData["RearFan"] = value;
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)

          //  Icons made by<a href="https://www.flaticon.com/authors/freepik" title="Freepik"> Freepik</a> from<a href="https://www.flaticon.com/" title="Flaticon"> www.flaticon.com</a>
        {
            if (!int.TryParse(textBox1.Text, out port))
            {
                MessageBox.Show("Port number not valid");
                Log("Port number invalid");

            }
            try
            {
                client = new TcpClient(textBox3.Text, port);
                Initialize();

                Log("Connection made with " + textBox3.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed");
                Log(ex, "Connection failed");
            }
        }


        
        private void collect_data()
        {
            if (isAdministrator == true)
            {
                _sensorData.Clear();
                _computer.Traverse(_updater);
                _computer.Traverse(_sensorVisitor);

                cpu_name = GetHardwareData("cpuName");


                cpu_load = GetSensorData("cpuUtil");
                if (cpu_load == "")
                {
                    cpu_load = "0";
                }
                cpu_temperature = GetSensorData("cpuTemp");
                if (cpu_temperature == "")
                {
                    cpu_temperature = "0";
                }

                gpu_load = GetSensorData("gpuLoad");
                if (gpu_load == "")
                {
                    gpu_load = "0";
                }
                gpu_temperature = GetSensorData("gpuTemp");
                if (gpu_temperature == "")
                {
                    gpu_temperature = "0";
                }

                RAM_load = GetSensorData("ramUtil");
                if (RAM_load == "")
                {
                    RAM_load = "0";
                }
                cpu_fan = GetSensorData("cpuFan");
                if (cpu_fan == "")
                {
                    cpu_fan = "0";
                }

                front_fan = GetSensorData("FrontFan");
                if (front_fan == "")
                {
                    front_fan = "0";
                }

                rear_fan = GetSensorData("RearFan");
                if (rear_fan == "")
                {
                    rear_fan = "0";
                }

            }
        }

        private void Log(string message)
        {

            if (logBox.Lines.Length > 15)
            {
                logBox.ReadOnly = false;
                logBox.Select(0, logBox.GetFirstCharIndexFromLine(logBox.Lines.Length - 15));
                logBox.SelectedText = "";
                logBox.ReadOnly = true;
            }

            //logbox.Lines.Count() < 15

            logBox.AppendText(Environment.NewLine);
            message = $"[{DateTime.Now:HH:mm:ss}] {message}";
            logBox.AppendText(message);
        }

        private void Log(Exception ex, string title)
        {
            Log($"Exception {title} ({ex.GetType().FullName}): {ex.Message}");
        }

    
        private void Send_to_pi()
        {



            byteCount = Encoding.ASCII.GetByteCount(message);
            sendData = new byte[byteCount];
            sendData = Encoding.ASCII.GetBytes(message);
            stream = client.GetStream();
            stream.Write(sendData, 0, sendData.Length);
            Log("Data sent " + message);
      


        }


        private string dropdown_to_variable(ComboBox propertyName) 
        {
            //switch (gauge_8_dropdown.SelectedIndex)
            switch  (propertyName.SelectedIndex)
            {
               
                case 0:
                    return cpu_load;
                case 1:
                    return cpu_temperature;
                case 2:
                    return gpu_load;
                case 3:
                    return gpu_temperature;
                case 4:
                    return RAM_load;
                case 5:
                    return front_fan;
                case 6:
                    return cpu_fan;
                case 7:
                    return rear_fan;
                default:
                    return "0";
            }


            

        }




        private void tick_object(object sender, EventArgs e)
        {
            try
            {

                collect_data();
                message = dropdown_to_variable(Gauge_1_dropdown) + "," + dropdown_to_variable(Gauge_2_dropdown) + "," + dropdown_to_variable(Gauge_3_dropdown) + "," +
                     dropdown_to_variable(Gauge_4_dropdown) + "," + dropdown_to_variable(Gauge_5_dropdown) + "," + dropdown_to_variable(Gauge_6_dropdown) + "," +
                    dropdown_to_variable(Gauge_7_dropdown) + "," + dropdown_to_variable(Gauge_8_dropdown);
                Send_to_pi();
            }

            catch

                (System.NullReferenceException)
            {
                MessageBox.Show("Connection not initialised");
                Log("failed to send data");

            }

        }

        private void manual_send()
        {
            try
            {

                collect_data();
                Send_to_pi();
            }

            catch

                (System.NullReferenceException)
            {
                MessageBox.Show("Connection not initialised");
                Log("failed to send data");

            }

        }



        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            stream.Close();
            client.Close();
            Log("Connection terminated");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private static bool checkAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private void Initialize()
        {

            {
                if (checkAdministrator() == true)
                {
                    isAdministrator = true;
                }
                else
                {
                    isAdministrator = false;
                }

                if (isAdministrator == true)  // Use Open Hardware Monitor if the process is started with administrative privileges.
                {
                    _computer.Open();
                    _computer.CPUEnabled = true;
                    _computer.GPUEnabled = true;
                    _computer.RAMEnabled = true;
                    _computer.MainboardEnabled = true;
                    Log("Running as admin: using Open Hardware Monitor");
                }
                else // Otherwise, just use the built-in Windows performance counters.
                {

                    Log("Running without admin privileges: using Windows Performance Counters");
                }


                Log("Starting up...");


            }

        }

      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }

    }
