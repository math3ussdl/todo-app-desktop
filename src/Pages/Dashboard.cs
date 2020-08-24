using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TodoApp.Classes;
using TodoApp.Pages;
using TodoApp.src.Classes;
using TodoApp.src.Pages;

namespace TodoApp
{
    public partial class Dashboard : MaterialForm
    {
        private BodyUser UserData;

        // Constructor
        public Dashboard()
        {
            InitializeComponent();
        }

        private void AddListBtn_Click(object sender, EventArgs e)
        {
            new AddTask().Show();
            this.Hide();
        }

        private async void Dashboard_Load(object sender, EventArgs e)
        {
            string pathJSON = $"{Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))}/.data/prfl.json";
            UserData = JObject.Parse(File.ReadAllText(pathJSON)).ToObject<BodyUser>();

            nameLbl.Text = UserData.user.Name;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:4000");
                client.DefaultRequestHeaders.Add("authorization", $"Bearer {UserData.token}");

                HttpResponseMessage response = await client.GetAsync("/lists/all");

                var respBody = await response.Content.ReadAsStringAsync();

                var json = JsonConvert.DeserializeObject<List<TaskList>>(respBody);

                foreach (TaskList item in json)
                {
                    DataTable ss = new DataTable();
                    ss.Columns.Add("Id");
                    ss.Columns.Add("Título");
                    ss.Columns.Add("Descrição");
                    ss.Columns.Add("Responsável");
                    ss.Columns.Add("Categoria");
                    ss.Columns.Add("Atividades");

                    DataRow row = ss.NewRow();
                    row["Id"] = item.Id;
                    row["Título"] = item.Title;
                    row["Descrição"] = item.Description;
                    row["Responsável"] = "Hugo Matheus";
                    row["Categoria"] = item.Categories.Description;
                    row["Atividades"] = new Button().Text = "...";

                    ss.Rows.Add(row);

                    foreach (DataRow Drow in ss.Rows)
                    {
                        int num = tasksGridView.Rows.Add();

                        tasksGridView.Rows[num].Cells[0].Value = Drow["Id"].ToString();
                        tasksGridView.Rows[num].Cells[1].Value = Drow["Título"].ToString();
                        tasksGridView.Rows[num].Cells[2].Value = Drow["Descrição"].ToString();
                        tasksGridView.Rows[num].Cells[3].Value = Drow["Responsável"].ToString();
                        tasksGridView.Rows[num].Cells[4].Value = Drow["Categoria"].ToString();
                        tasksGridView.Rows[num].Cells[5].Value = Drow["Atividades"].ToString();
                    }
                }
            }

        }

        private void logoutLbl_Click(object sender, EventArgs e)
        {
            string pathJSON = $"{Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))}/.data/prfl.json";
            File.Delete(pathJSON);

            new Login().Show();
            this.Hide();
        }

        private void tasksGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tasksGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && tasksGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "...")
            {
                var targetId = tasksGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

                new ActivitiesDetails(targetId).Show();
            }
        }
    }
}
