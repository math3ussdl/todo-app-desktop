using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using MaterialSkin.Controls;
using TodoApp.Classes;

namespace TodoApp.Pages
{
    public partial class Register : MaterialForm
    {
        public Register()
        {
            InitializeComponent();
        }

        private void CadBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            string surname = surnameTxt.Text;
            string email = emailTxt.Text;
            string phone = phoneTxt.Text;
            string password = passTxt.Text;
            string passwordRepeat = rpassTxt.Text;

            if (!email.Contains("@"))
            {
                MessageBox.Show("Digite um e-mail válido", "Aviso");
                emailTxt.Focus();
            }

            else if (password.Length < 6)
            {
                MessageBox.Show("A senha deve ser maior ou igual a 6 caracteres ", "Aviso");
                passTxt.Focus();
            }

            else if (password != passwordRepeat)
            {
                MessageBox.Show("Senhas não conferem!", "Aviso");
                passTxt.Text = "";
                rpassTxt.Text = "";

                passTxt.Focus();
            }

            else
            {
                var body = new Dictionary<string, string>();
                body.Add("name", name + " " + surname);
                body.Add("phone", phone);
                body.Add("email", email);
                body.Add("password", password);

                HandleRegister(body);
            }
        }

        private async void HandleRegister(Dictionary<string, string> body)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:4000");
                var content = new FormUrlEncodedContent(body);
                HttpResponseMessage response = await client.PostAsync("/users", content);

                if (response.IsSuccessStatusCode)
                {
                    User userObj = JsonConvert.DeserializeObject<User>(await response.Content.ReadAsStringAsync());

                    Console.WriteLine(userObj.Name);

                    MessageBox.Show("Cadastro efetuado com sucesso", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new Login().Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Oops! Algo deu errado!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
