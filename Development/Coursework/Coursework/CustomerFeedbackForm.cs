using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class CustomerFeedbackForm : Form
    {

        String[] criteria;
        CheckBox[] boxes;
        String fullName, feedback, email, contact; 

        public CustomerFeedbackForm()
        {
            InitializeComponent();
        }

        private void CustomerFeedbackForm_Load(object sender, EventArgs e)
        {
            makingFullTable();

        }

        public void makingFullTable()
        {
            String filePath = "criteria.csv";
            StreamReader reader = null;
            if (File.Exists(filePath))
            {
                reader = new StreamReader(File.OpenRead(filePath));
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    criteria = values;
                }
            }
            else
            {
                Console.WriteLine("File doesn't exist");
            }
            reader.Close();

            int count = criteria.Length;
            int number = count * 5;
            boxes = new CheckBox[number];
            int row = 1;

            for(int i = 0; i < count; i++)
            {
                Label label = new Label()
                {
                    AutoSize = false,
                    Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                    Font = new Font("Century Gothic", 12),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = criteria[i]
                };
                label.ForeColor = Color.White;
                feedBackTable2.Controls.Add(label, 0, row);
                row++;
            }
            for (int a = 0; a < number; a++)
            {
                CheckBox checkBox = new CheckBox();

                checkBox.Name = "checkbox" + a.ToString();
                checkBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                checkBox.CheckAlign = ContentAlignment.MiddleCenter;

                checkBox.CheckedChanged += new EventHandler(CheckedChangedEvent);

                boxes[a] = checkBox;

                feedBackTable2.Controls.Add(boxes[a]);
            }
        }

        public void CheckedChangedEvent(Object sender, EventArgs e)
        {
            int countB = boxes.Length;

            CheckBox selectedCheckBox = (CheckBox)sender;

            for (int i = 0; i < countB; i += 5)
            {
                if (selectedCheckBox.Equals(boxes[i]))
                {
                    boxes[i + 1].Checked = false;
                    boxes[i + 2].Checked = false;
                    boxes[i + 3].Checked = false;
                    boxes[i + 4].Checked = false;
                }
                else if (selectedCheckBox.Equals(boxes[i + 1]))
                {
                    boxes[i].Checked = false;
                    boxes[i + 2].Checked = false;
                    boxes[i + 3].Checked = false;
                    boxes[i + 4].Checked = false;
                }
                else if (selectedCheckBox.Equals(boxes[i + 2]))
                {
                    boxes[i].Checked = false;
                    boxes[i + 1].Checked = false;
                    boxes[i + 3].Checked = false;
                    boxes[i + 4].Checked = false;
                }
                else if (selectedCheckBox.Equals(boxes[i + 3]))
                {
                    boxes[i].Checked = false;
                    boxes[i + 1].Checked = false;
                    boxes[i + 2].Checked = false;
                    boxes[i + 4].Checked = false;
                }
                else if (selectedCheckBox.Equals(boxes[i + 4]))
                {
                    boxes[i].Checked = false;
                    boxes[i + 1].Checked = false;
                    boxes[i + 2].Checked = false;
                    boxes[i + 3].Checked = false;
                }
            }
        }


        private void submitBtn_Click(object sender, EventArgs e)
        {

            List<string> rate = new List<string>();
            int fullSize = boxes.Length;
            for (int i = 0; i < fullSize; i += 5)
            {
                if (boxes[i].Checked == true)
                {
                    rate.Add("1");
                }
                else if (boxes[i + 1].Checked == true)
                {
                    rate.Add("2");
                }
                else if (boxes[i + 2].Checked == true)
                {
                    rate.Add("3");
                }
                else if (boxes[i + 3].Checked == true)
                {
                    rate.Add("4");
                }
                else if (boxes[i + 4].Checked == true)
                {
                    rate.Add("5");
                }
            }
            int totalLength = rate.Count;

            String[] finalRate = new String[totalLength];

            for (int i = 0; i < totalLength; i++)
            {
                finalRate[i] = rate[i];
            }
            
            string result = string.Join(",", finalRate);

            String path = "rating.csv";
            if (fullNameTb.TextLength != 0)
            {
                fullName = fullNameTb.Text;
            }
            if (contactTb.TextLength != 0)
            {
                contact = contactTb.Text;
            }
            if (emailTb.TextLength != 0)
            {
                email = emailTb.Text;
            }
            if (overallFeedbackTb.TextLength != 0)
            {
                feedback = overallFeedbackTb.Text;
            }
            using (StreamWriter streamWriter =File.AppendText(path))
            {
                streamWriter.WriteLine(fullName + "," + email + "," + contact + "," + feedback + "," + DateTime.UtcNow.ToString("MM-dd-yyyy") + "," + DateTime.Now.ToString("HH:mm") + "," + result);
                fullNameTb.Text = "";
                contactTb.Text = "";
                emailTb.Text = "";
                overallFeedbackTb.Text = "";            
            }
            foreach (Control ctrl in feedBackTable2.Controls)
            {
                CheckBox chk = ctrl as CheckBox;

                if (chk != null)
                {
                    chk.Checked = false;
                }
            }

            serialize();
            showMessage();

        }

        private void serialize()
        {
            try
            {

                CustomerSerialize obj = new CustomerSerialize();

                obj.fullName = fullName;
                obj.email = email;
                obj.contact = contact;
                obj.feedback = feedback;

                IFormatter formatter = new BinaryFormatter();

                Stream stream = new FileStream("customerDataSerialize.csv", FileMode.Create, FileAccess.Write);
                formatter.Serialize(stream, obj);
                stream.Close();

            }
            catch
            {
            }
        }

        private void showMessage()
        {
            try
            {

                IFormatter formatter = new BinaryFormatter();

                using (var stream = File.Open("customerDataSerialize.csv", FileMode.Open, FileAccess.Read))
                {
                    CustomerSerialize obj = (CustomerSerialize)formatter.Deserialize(stream);

                    MessageBox.Show("Full Name: "+obj.fullName+"\n"+ 
                        "Email: " + obj.email + "\n" +
                        "Contact: " + obj.contact + "\n" +
                        "Overall Feedback: " + obj.feedback+ "\n" ,"Customer Details");
                }
            }
            catch
            {
                MessageBox.Show("Data was not saved", "Invalid");
            }
        }


        private void clearBtn_Click(object sender, EventArgs e)
        {
            fullNameTb.Text = "";
            contactTb.Text = "";
            emailTb.Text = "";
            overallFeedbackTb.Text = "";
            foreach (Control ctrl in feedBackTable2.Controls)
            {
                CheckBox chk = ctrl as CheckBox;

                if (chk != null)
                {
                    chk.Checked = false;
                }
            }
        }
    }
}
