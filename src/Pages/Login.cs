using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using TodoApp.Pages;
using MaterialSkin.Controls;
using System.IO;

namespace TodoApp
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string email = txtUserMail.Text;
            string password = txtPassword.Text;

            if (!email.Contains("@"))
            {
                MessageBox.Show("Digite um e-mail válido", "Aviso");
                txtUserMail.Focus();
            }

            else if (password.Length < 6)
            {
                MessageBox.Show("A senha deve ser maior ou igual a 6 caracteres ", "Aviso");
                txtPassword.Focus();
            }

            else
            {
                LoginLoad();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUserMail.Clear();
            txtPassword.Clear();
            txtUserMail.Focus();
        }

        private async void LoginLoad()
        {
            var bodyList = new Dictionary<string, string>();
            bodyList.Add("email", txtUserMail.Text);
            bodyList.Add("password", txtPassword.Text);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:4000");
                var content = new FormUrlEncodedContent(bodyList);
                HttpResponseMessage response = await client.PostAsync("/users/auth", content);

                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();

                    var json = JsonConvert.DeserializeObject(data);

                    var finalFile = JsonConvert.SerializeObject(json, Formatting.Indented);

                    string pathJSON = $"{Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))}/.data/prfl.json";

                    System.IO.File.WriteAllText(pathJSON, finalFile);

                    MessageBox.Show("Login efetuado com sucesso", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new Dashboard().Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("E-mail ou senha incorretos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void RegisterLbl_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }
    }
}
