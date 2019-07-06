using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cokbook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void Button2_Click(object sender, EventArgs e)
        {
            if (Checkname())
                if (Checkinput())
                {
                    try
                    {
                        Register_Login_Connection registerChef = new Register_Login_Connection();
                        registerChef.InsertNewChef(regname.Text, regage.Text, reggender.Text, regemail.Text, regpassword.Text);
                        Checkemail();
                        MessageBox.Show($"Successfully register new chef -> {regname.Text}", "Successfully registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        regPanel.Visible = false;
                        panel1.Visible = true;
                        chefName.Text = null;
                        password.Text = null;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please check input", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else MessageBox.Show("Please enter valid input", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else MessageBox.Show("Please pick another chef name", "Chef name already exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Checkemail()
        {
            try
            {
                SmtpClient client = new SmtpClient
                {
                    Port = 587,
                    Host = "smtp.gmail.com",
                    EnableSsl = true,
                    Timeout = 10000,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new System.Net.NetworkCredential("hospitalm3dic@gmail.com", "08857490200")
                };
                //sending email to email
                MailMessage mm = new MailMessage("donotreply@domain.com", $"{regemail.Text}", "Successfully registered new chef", $"\nChef: {regname.Text} \nPassword: {regpassword.Text}")
                {
                    BodyEncoding = UTF8Encoding.UTF8,
                    DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
                };

                client.Send(mm);

                MessageBox.Show("Check email for registration details", "Email sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }//sending email to the correct input
            catch (Exception)
            {

            }
        }

        private bool Checkname()
        {
            Register_Login_Connection checknames = new Register_Login_Connection();
            if (checknames.CheckChefName(regname.Text)) return false;
            else return true;
        }

        private bool Checkinput()
        {
            if (regname.Text != "")
                if (regage.Text != "")
                    if (reggender.Text != "")
                        if (regemail.Text != "")
                            if (regpassword.Text != "")
                                return true;
            return false;
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            regPanel.Visible = false;
            regname.Text = null;
            regage.Text = null;
            regemail.Text = null;
            regpassword.Text = null;
            chefName.Text = null;
            password.Text = null;
            reggender.Text = null;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            regPanel.Visible = true;
            panel1.Visible = false;
            regname.Text = null;
            regage.Text = null;
            regemail.Text = null;
            regpassword.Text = null;
            chefName.Text = null;
            password.Text = null;
            reggender.Text = null;
        }

        public void Cook_Click(object sender, EventArgs e)
        {
            if (Checklogininput())//checking input
            {
                Register_Login_Connection login = new Register_Login_Connection();
                List<string> logininfo = login.CheckLoginDetails(chefName.Text, password.Text);
                if (logininfo.Count != 0)
                {
                    Cokbook child = new Cokbook(chefName.Text, password.Text, logininfo[0], logininfo[1], logininfo[2]); //create new isntance of form
                    child.FormClosed += new FormClosedEventHandler(Child_FormClosed); //add handler to catch when child form is closed
                    child.Show(); //show child
                    this.Hide(); //hide parent
                }
                else MessageBox.Show("Please enter correct information","Invalid information",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private bool Checklogininput()
        {
            if (chefName.Text.Contains('/'))
                if (chefName.Text.Contains('*'))
                    if (chefName.Text.Contains('\\'))
                        if (chefName.Text.Contains('-'))
                            return false;
            return true;
        }

        private void Child_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
