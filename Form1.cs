namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] month = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            for (int mon = 0; mon < month.Length; mon++)
            {
                comboBox7.Items.Add(month[mon]);
            }

            for (int yr = 2024; yr <= 2050; yr++)
            {
                comboBox9.Items.Add(yr);
            }

            int GetDaysInMonth(int year, int monthIndex)
            {
                if (monthIndex == 1)
                {
                    if (DateTime.IsLeapYear(year))
                    {
                        return 29;
                    }
                    else
                    {
                        return 28;
                    }
                }
                if (monthIndex == 3 || monthIndex == 5 || monthIndex == 8 || monthIndex == 10)
                {
                    return 30;
                }
                return 31;
            }
            comboBox7.SelectedIndexChanged += (sender, e) =>
            {
                if (comboBox7.SelectedIndex == -1)
                    return;

                int selectedMonth = comboBox7.SelectedIndex;
                comboBox8.Items.Clear();
                for (int day = 1; day <= GetDaysInMonth(2024, selectedMonth); day++)
                {
                    comboBox8.Items.Add(day.ToString());
                }
                if (comboBox8.Items.Count > 0)
                {
                    comboBox8.SelectedIndex = 0;
                }
                comboBox8.Enabled = true;
            };
            comboBox8.SelectedIndexChanged += (sender, e) =>
            {
                if (comboBox8.SelectedIndex == -1)
                    return;
                comboBox9.Items.Clear();
                for (int yr = 2024; yr <= 2050; yr++)
                {
                    comboBox9.Items.Add(yr);
                }
                if (comboBox9.Items.Count > 0)
                {
                    comboBox9.SelectedIndex = 0;
                }
                comboBox9.Enabled = true;
            };
            comboBox8.Enabled = false;
            comboBox9.Enabled = false;


            for (int min = 01; min <= 12; min++)
            {
                comboBox1.Items.Add(min);
            }
            for (int sec = 01; sec <= 59; sec++)
            {
                comboBox2.Items.Add(sec);
            }
            string[] time = { "AM", "PM" };
            for (int i = 0; i < time.Length; i++)
            {
                comboBox3.Items.Add(time[i]);
            }

            string[] typeOfAppointment =
            {
                "Routine or Preventive Appointment",
                "Annual Physical Exam",
                "Vaccination Appointment",
                "Specialist Appointment",
                "Follow-Up Appointment",
                "Acute Care Appointment",
                "Diagnostic Appointment",
                "Therapy Appointment",
                "Dental Appointment",
                "Pediatric Appointment",
                "Telemedicine Appointment",
                "Emergency Car",
                "Surgical Consultation",
                "Rehabilitation Appointment",
                "Fertility and Reproductive Health Appointment",
                "Vision and Eye Care Appointment"
            };
            for (int app = 0; app < typeOfAppointment.Length; app++)
            {
                comboBox10.Items.Add(typeOfAppointment[app]);
            }
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Appointment" + "\n" + "Type of Appointment:  " + comboBox10.SelectedItem + "\n" + "Date:  " + comboBox7.SelectedItem + " " + comboBox8.SelectedItem + ", " + comboBox9.SelectedItem + "\n" + "Time:  " + comboBox1.SelectedItem + ":" + comboBox2.SelectedItem + " " + comboBox3.SelectedItem);
        }
    }
}
