using MaterialSkin.Controls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using TodoApp.Classes;
using TodoApp.src.Classes;

namespace TodoApp.src.Pages
{
    public partial class ActivitiesDetails : MaterialForm
    {
        private BodyUser UserData;
        private string targetId;

        private List<Dictionary<string, string>> activities = new List<Dictionary<string, string>>();

        public ActivitiesDetails(string targetId)
        {
            InitializeComponent();
            this.targetId = targetId;
        }

        private async void ActivitiesDetails_Load(object sender, EventArgs e)
        {
            string pathJSON = $"{Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))}/.data/prfl.json";
            UserData = JObject.Parse(File.ReadAllText(pathJSON)).ToObject<BodyUser>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:4000");
                client.DefaultRequestHeaders.Add("authorization", $"Bearer {UserData.token}");

                HttpResponseMessage response = await client.GetAsync($"/lists/{this.targetId}");

                var respBody = await response.Content.ReadAsStringAsync();

                var JSONTask = JsonConvert.DeserializeObject<TaskList>(respBody);

                titleText.Text = JSONTask.Title;
                descriptionText.Text = JSONTask.Description;
                ownerText.Text = JSONTask.Users.Name;
                categoryText.Text = JSONTask.Categories.Description;

                List<Activity> activitiesList = JSONTask.Activities;

                foreach (Activity activity in activitiesList)
                {
                    DataTable ss = new DataTable();
                    ss.Columns.Add("Id");
                    ss.Columns.Add("Email do Responsável");
                    ss.Columns.Add("Descrição");
                    ss.Columns.Add("Data Prevista");
                    ss.Columns.Add("Data de Execução");
                    ss.Columns.Add("Status");

                    DataRow row = ss.NewRow();
                    row["Id"] = activity.Id;
                    row["Email do Responsável"] = activity.Users.Email;
                    row["Descrição"] = activity.Description;
                    row["Data Prevista"] = activity.PrevDate;
                    row["Data de Execução"] = activity.ExecDate;
                    row["Status"] = activity.Status.Description;

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
            }
        }

        private async void DeleteBtn_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:4000");
                client.DefaultRequestHeaders.Add("authorization", $"Bearer {UserData.token}");

                HttpResponseMessage response = await client.DeleteAsync($"/lists/{this.targetId}");

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Lista removida com sucesso", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new Dashboard().Show();
                    this.Hide();
                }
            }
        }

        private async void UpdateListBtn_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:4000");
                client.DefaultRequestHeaders.Add("authorization", $"Bearer {UserData.token}");

                var body = new Dictionary<string, object>
                {
                    { "title", titleText.Text },
                    { "description", descriptionText.Text },
                    { "activities", activities }
                };

                var bodyJSON = JsonConvert.SerializeObject(body, Formatting.Indented);

                var content = new StringContent(bodyJSON, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PutAsync($"/lists/{this.targetId}", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Lista atualizada com sucesso", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new Dashboard().Show();
                    this.Hide();
                } 
                
                else
                {
                    MessageBox.Show("Não foi possível realizar a atualização. Tente novamente.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
