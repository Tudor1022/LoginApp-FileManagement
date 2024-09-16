using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.VisualBasic;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace lloginApp
{
    public partial class Form1 : Form
    {
        OleDbConnection conexiune;
        OleDbCommand comanda;
        OleDbDataReader cititor;
        DataSet dsDate;
        DataTable tblLogin;
        bool emailExistent;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                conexiune = new OleDbConnection();
                conexiune.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= DATABASE PATH ;Persist Security Info=False;";
                conexiune.Open();
                comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT username, password FROM loginData WHERE username=? AND password=?;";
                comanda.Parameters.Clear();
                comanda.Parameters.AddWithValue("username", txtUsername.Text);
                comanda.Parameters.AddWithValue("password", txtParola.Text);
                cititor = comanda.ExecuteReader();
                tblLogin = new DataTable("loginData");
                tblLogin.Load(cititor);
                dsDate = new DataSet();
                dsDate.Tables.Add(tblLogin);

                bool exista = true;

                for (int i = 0; i < dsDate.Tables["loginData"].Rows.Count; i++)
                {
                    if (txtUsername.Text.ToString().ToLower() != dsDate.Tables["loginData"].Rows[i].ItemArray[0].ToString().ToLower() || txtParola.Text.ToString().ToLower() != dsDate.Tables["loginData"].Rows[i].ItemArray[1].ToString().ToLower())
                    {
                        exista = false;
                    }
                }


                if (dsDate.Tables["loginData"].Rows.Count > 0)
                {
                    MessageBox.Show("Logged in");
                    menuStrip1.Visible = true;
                }
                else
                {
                    MessageBox.Show("Non-existent user or wrong username or password");
                }
                conexiune.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                conexiune = new OleDbConnection();
                conexiune.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= DATABASE PATH ;Persist Security Info=False;";
                conexiune.Open();
                comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "INSERT INTO loginData([Username], [Password], [Email]) VALUES(?, ?, ?)";
                comanda.Parameters.Clear();
                comanda.Parameters.AddWithValue("username", txtNewUser.Text);
                comanda.Parameters.AddWithValue("password", txtNewPass.Text);
                comanda.Parameters.AddWithValue("email", txtEmail.Text);
                comanda.ExecuteNonQuery();
                MessageBox.Show("Cont creat");
                conexiune.Close();
                email.Visible = false;
                txtEmail.Visible = false;
                username.Visible = false;
                password.Visible = false;
                email.Visible = false;
                btnCreate.Visible = false;
                txtEmail.Visible = false;
                txtNewPass.Visible = false;
                txtNewUser.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void app1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aplicatie app = new Aplicatie();    
            app.Visible = true;
            this.Hide();

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            username.Visible = true;
            password.Visible = true;
            email.Visible = true;
            btnCreate.Visible = true;
            txtEmail.Visible = true;
            txtNewPass.Visible = true;
            txtNewUser.Visible = true;
        }

        public string GeneraParola(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string email = Interaction.InputBox("Email of the account");
                conexiune = new OleDbConnection();
                conexiune.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= DATABASE PATH ;Persist Security Info=False;";
                conexiune.Open();
                comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT email FROM loginData WHERE email=?";
                comanda.Parameters.Clear();
                comanda.Parameters.AddWithValue("emailVerificare", email);
                cititor = comanda.ExecuteReader();
                tblLogin = new DataTable("loginData");
                tblLogin.Load(cititor);
                dsDate = new DataSet();
                dsDate.Tables.Add(tblLogin);
                conexiune.Close();

                emailExistent = true;

                if (dsDate.Tables["loginData"].Rows.Count == 0)
                {
                    MessageBox.Show("This email doesn't exist");
                    emailExistent = false;
                }
                if (emailExistent)
                {
                    string parolaNoua = GeneraParola(5);

                    string mesaj = "Your new password is " + GeneraParola(5);

                    var fromAddress = new MailAddress("add sender emaul", "App developer");
                    var toAddress = new MailAddress(email, "Utlizator");
                    const string fromPassword = "add password to the email";
                    const string subject = "Forgotten password";
                    string body = mesaj;

                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                    };
                    using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = subject,
                        Body = body
                    })
                    {
                        smtp.Send(message);
                    }
                    MessageBox.Show("Check your email for new password");

                    conexiune.Open();
                    comanda.Connection=conexiune;
                    comanda.CommandText = "UPDATE loginData SET [password]=? WHERE [email]=?";
                    comanda.Parameters.Clear();
                    comanda.Parameters.AddWithValue("password", parolaNoua);
                    comanda.Parameters.AddWithValue("email", email);
                    comanda.ExecuteNonQuery();
                    MessageBox.Show("Password changed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }




        }

        public void verificareEmail(string emailVerificare)
        {
            conexiune = new OleDbConnection();
            conexiune.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= DATABASE PATH ;Persist Security Info=False;";
            conexiune.Open();
            comanda = new OleDbCommand();
            comanda.Connection = conexiune;
            comanda.CommandText = "SELECT email FROM loginData WHERE email=?";
            comanda.Parameters.Clear();
            comanda.Parameters.AddWithValue("emailVerificare", emailVerificare);
            cititor=comanda.ExecuteReader();
            tblLogin = new DataTable("loginData");
            tblLogin.Load(cititor);
            dsDate=new DataSet();
            dsDate.Tables.Add(tblLogin);
            conexiune.Close();
            
            if (dsDate.Tables["loginData"].Rows.Count == 0)
            {
                MessageBox.Show("Email doesn't exist");
                emailExistent=false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtParola.Text = "";
            menuStrip1.Visible= false;
        }

        private void aplicatieToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
