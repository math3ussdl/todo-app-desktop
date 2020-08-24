using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TodoApp.src.Classes;

namespace TodoApp.Pages
{
    public partial class AddTask : MaterialForm
    {
        private BodyUser UserData;
        private int _idCount = 0;

        private List<Dictionary<string, string>> activities = new List<Dictionary<string, string>>();

        public AddTask()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void AddTask_Load(object sender, EventArgs e)
        {
            string pathJSON = $"{Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))}/.data/prfl.json";
            UserData = JObject.Parse(File.ReadAllText(pathJSON)).ToObject<BodyUser>();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            DataTable ss = new DataTable();
            ss.Columns.Add("Id");
            ss.Columns.Add("Email do Responsável");
            ss.Columns.Add("Descrição");
            ss.Columns.Add("Data Prevista");
            ss.Columns.Add("Data de Execução");
            ss.Columns.Add("Status");

            DataRow row = ss.NewRow();
            row["Id"] = _idCount;
            row["Email do Responsável"] = emailTxt.Text;
            row["Descrição"] = descTblTxt.Text;
            row["Data Prevista"] = dtPrevTxt.Text;
            row["Data de Execução"] = dtExecTxt.Text;
            row["Status"] = statusTxt.Text;

            ss.Rows.Add(row);

            var act = new Dictionary<string, string>
            {
                { "responsibleEmail", row["Email do Responsável"].ToString() },
                { "description", row["Descrição"].ToString() },
                { "prevDate", row["Data Prevista"].ToString() },
                { "execDate", row["Data de Execução"].ToString() },
                { "status", row["Status"].ToString() }
            };

            activities.Add(act);

            _idCount++;

            foreach (DataRow Drow in ss.Rows)
            {
                int num = activityGridView.Rows.Add();

                activityGridView.Rows[num].Cells[0].Value = Drow["Id"].ToString();
                activityGridView.Rows[num].Cells[1].Value = Drow["Email do Responsável"].ToString();
                activityGridView.Rows[num].Cells[2].Value = Drow["Descrição"].ToString();
                activityGridView.Rows[num].Cells[3].Value = Drow["Data Prevista"].ToString();
                activityGridView.Rows[num].Cells[4].Value = Drow["Data de Execução"].ToString();
                activityGridView.Rows[num].Cells[5].Value = Drow["Status"].ToString();
            }
        }

        private void CreateListBtn_Click(object sender, EventArgs e)
        {
            string title = titleTxt.Text;
            string description = descriptionTxt.Text;
            string category = categoryTxt.Text;
            

            if (title == null && description == null && category == null)
            {
                MessageBox.Show("Oops! Preencha os campos corretamente!");
            }

            else
            {
                var body = new Dictionary<string, object>
                {
                    { "title", title },
                    { "description", description },
                    { "category", category },
                    { "activities", activities }
                };

                var bodyJSON = JsonConvert.SerializeObject(body, Formatting.Indented);

                HandleCreate(bodyJSON);
            }
        }

        private async void HandleCreate(string body)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:4000");
                client.DefaultRequestHeaders.Add("authorization", $"Bearer {UserData.token}");
                var content = new StringContent(body, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync("/lists", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Lista cadastrada com sucesso", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new Dashboard().Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Oops! Algo deu errado!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void activityGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (activityGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                MessageBox.Show(activityGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            }
        }
    }
}
