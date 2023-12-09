using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace Domain
{
    public partial class MainForm : Form
    {
        List<int> array = new List<int>();
        int navId = 0;

        public MainForm()
        {
            InitializeComponent();
            dataDict.Visible = false;
            bindingNavigatorCountItem.Text = "0";
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelNav.Text = comboBox1.SelectedIndex.ToString();
            dataDict.Controls.Clear();
            switch (comboBox1.SelectedIndex)
            {
                case 0: //Локализация
                    dataDict.Visible = true;
                    dataGridKt.Visible = false;
                    bindingNavigator1.BindingSource = sourseDict;
                    await changeNavAsync(1);
                    break;
                case 1: //Лучевая диагностика
                    dataDict.Visible = false;
                    dataGridKt.Visible = true;
                    bindingNavigator1.BindingSource = sourseKt;
                    await changeNavAsync(2);
                    break;
            }
        }

        private async Task changeNavAsync(int id)
        {
            this.navId = id;
            switch (navId)
            {
                case 1: //Локализация

                    await getLocalisation();

                    break;
                case 2: //Лучевая диагностика

                    await getKt();

                    break;
            }
        }

        protected class KtContent
        {
            public List<Kt> content { get; set; }
            public int totalPages { get; set; }
        }

        protected class Kt
        {
            public string id { get; set; }
            public string screen { get; set; }
            public string fio { get; set; }
        }

        protected class DictContent
        {
            public List<Dict> content { get; set; }
            public int totalPages { get; set; }
        }

        protected class Dict
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        private async Task getLocalisation()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string apiUrl = $"http://localhost:8081/localization/getAllPage?page={navPageId.Text}&size=10";
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, apiUrl);
                    request.Headers.Add("Authorization", Program.jwt);
                    HttpResponseMessage response = await client.SendAsync(request);

                    sourseDict.Clear();
                    if (response.IsSuccessStatusCode)
                    {
                        string data = await response.Content.ReadAsStringAsync();
                        DictContent result = JsonConvert.DeserializeObject<DictContent>(data);
                        navPageCount.Text = (result.totalPages - 1).ToString();

                        List<Dict> values = result.content;
                        foreach (Dict value in values)
                        {
                            sourseDict.Add(value);
                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }

        private async Task getKt()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string apiUrl = $"http://localhost:8081/kt/getAll?page={navPageId.Text}&size=10&statusId=1";
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, apiUrl);
                    request.Headers.Add("Authorization", Program.jwt);
                    HttpResponseMessage response = await client.SendAsync(request);

                    sourseKt.Clear();
                    if (response.IsSuccessStatusCode)
                    {
                        string data = await response.Content.ReadAsStringAsync();
                        KtContent result = JsonConvert.DeserializeObject<KtContent>(data);
                        navPageCount.Text = (result.totalPages - 1).ToString();

                        List<Kt> values = result.content;
                        foreach (Kt value in values)
                        {
                            sourseKt.Add(value);
                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }

        private async void toolStripButton4_ClickAsync(object sender, EventArgs e)
        {
            navPageId.Text = "0";
            await changeNavAsync(navId);
        }

        private async void toolStripButton5_Click(object sender, EventArgs e)
        {
            int page = int.Parse(navPageId.Text);
            if (page > 0)
            {
                navPageId.Text = (page - 1).ToString();
            }
            await changeNavAsync(navId);
        }

        private async void toolStripButton6_Click(object sender, EventArgs e)
        {
            int page = int.Parse(navPageId.Text);
            int max = int.Parse(navPageCount.Text);
            if (page < max)
            {
                navPageId.Text = (page + 1).ToString();
            }
            await changeNavAsync(navId);
        }

        private async void toolStripButton7_Click(object sender, EventArgs e)
        {
            navPageId.Text = navPageCount.Text;
            await changeNavAsync(navId);
        }
    }
}
