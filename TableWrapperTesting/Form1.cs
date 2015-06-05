using System;
using System.Windows.Forms;
using DatabaseWrapper;

namespace TableWrapperTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Console.Write(DateTime.Now.ToString()) ; 
        }

   

        private void button1_Click(object sender, EventArgs e)
        {
            string strId = textBox1.Text;
            int id = Convert.ToInt32(strId);
            DataAccessLayer switcher = new DataAccessLayer();
            HouseLight light = new HouseLight();


            if (radioButton1.Checked)
            {
                switcher.SwitchLight(id, true);
            }
            else if (radioButton2.Checked)
            {
                switcher.SwitchLight(id, false);
            }

            light.LoadByPrimaryKey(id);
            light.HouseZoneId = Convert.ToInt32(textBox2.Text);
            light.Wattage = Convert.ToDouble(textBox3.Text);
            if (light.HouseLightId == 0)
                throw new Exception("The light you are attempting to alter is invalid!");
            light.Save();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HouseEntranceLog log = new HouseEntranceLog();
            int id = Convert.ToInt32(textBox7.Text);

            log.LoadByPrimaryKey(id);
            log.TimeStamp = DateTime.Now;
            log.HouseEntranceId = Convert.ToInt32(textBox6.Text);
            log.Event = textBox4.Text;
            log.Save();


        }

        private void button3_Click(object sender, EventArgs e)
        {

            HouseEntrance entrance = new HouseEntrance();
            int id = Convert.ToInt32(textBox5.Text);

            entrance.LoadByPrimaryKey(id);
            entrance.HouseZoneId = Convert.ToInt32(textBox8.Text);
            entrance.EntranceType = textBox9.Text;
            entrance.Status = Convert.ToBoolean(textBox10.Text);
            entrance.Save();


        }

        private void button4_Click(object sender, EventArgs e)
        {

            HouseLightLog log = new HouseLightLog();
            int id = Convert.ToInt32(textBox12.Text);

            log.LoadByPrimaryKey(id);
            log.TimeStamp = DateTime.Now;
            log.HouseLightId = Convert.ToInt32(textBox13.Text);
            log.Event = textBox14.Text;
            log.Save();


        }

        private void button5_Click(object sender, EventArgs e)
        {

            TemperatureSensorLog log = new TemperatureSensorLog();
            int id = Convert.ToInt32(textBox11.Text);

            log.LoadByPrimaryKey(id);
            log.TimeStamp = DateTime.Now;
            log.TemperatureSensorId = Convert.ToInt32(textBox15.Text);
            log.Event = textBox16.Text;
            log.Save();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            TemperatureSensor sensor = new TemperatureSensor();
            int id = Convert.ToInt32(textBox17.Text);

            sensor.LoadByPrimaryKey(id);
            sensor.HouseZoneId = Convert.ToInt32(textBox18.Text);
            sensor.CurrentTemperature = Convert.ToDouble(textBox19.Text);
            sensor.Save();

        }

        private void button7_Click(object sender, EventArgs e)
        {

            MotionSensor sensor = new MotionSensor();
            int id = Convert.ToInt32(textBox20.Text);

            sensor.LoadByPrimaryKey(id);
            sensor.HouseZoneId = Convert.ToInt32(textBox21.Text);
            sensor.Status = Convert.ToBoolean(textBox22.Text);
            sensor.Save();


        }

        private void button8_Click(object sender, EventArgs e)
        {
            MotionSensorLog log = new MotionSensorLog();
            int id = Convert.ToInt32(textBox23.Text);

            log.LoadByPrimaryKey(id);
            log.TimeStamp = DateTime.Now;
            log.MotionSensorId = Convert.ToInt32(textBox24.Text);
            log.Event = textBox25.Text;
            log.Save();
        }

    }
}
