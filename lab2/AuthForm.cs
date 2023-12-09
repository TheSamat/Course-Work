using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domain
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
            label2.Visible = false;
        }

        private async void mergeSortButton_ClickAsync(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string apiUrl = "http://localhost:8081/authenticate";
                    var requestContent = new
                    {
                        pin = inputLogin?.Text,
                        password = inputPassword?.Text,
                        ozCode = inputOzCode?.Text
                    };
                    string jsonData = JsonConvert.SerializeObject(requestContent);
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, apiUrl);
                    request.Content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.SendAsync(request);

                    if (response.IsSuccessStatusCode)
                    {
                        string data = await response.Content.ReadAsStringAsync();
                        Program.jwt = "Bearer_" + JsonConvert.DeserializeObject<AuthResponse>(data).jwtToken;
                        this.Visible = false;
                        MainForm mergeSortForm = new MainForm();
                        mergeSortForm.Show();
                    }
                    else
                    {
                        label2.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    label2.Visible = true;
                }
            }
        }
        protected class AuthResponse
        {
            public string jwtToken { get; set; }
        }
    }
}
