using AYZ8R9_SOF_202231.Model;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AYZ8R9_SOF_202231_ProjectStatsWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public ObservableCollection<Project> Projects{ get; set; }

        HttpClient client;
        HubConnection conn;

        public MainWindow()
        {
            InitializeComponent();

            Thread.Sleep(5000);

            client = new HttpClient();
            client.BaseAddress = new Uri("https://scrummer.azurewebsites.net");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
            new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            Task.Run(async () => 
            {
                Projects = new ObservableCollection<Project>(await GetProjects());
            }).Wait();

            conn = new HubConnectionBuilder().WithUrl("https://scrummer.azurewebsites.net/events").Build();
            conn.Closed += async (error) =>
            {
                await Task.Delay(new Random().Next(0, 5) * 1000);
                await conn.StartAsync();
            };

            conn.On<Project>("projectCreated", async t => await Refresh());
            conn.On<Project>("projectModified", async t => await Refresh());
            conn.On<string>("projectDeleted",async t => await Refresh());

            Task.Run(async () =>
            {
                await conn.StartAsync();
            }).Wait();

            this.DataContext = this;
        }

        async Task Refresh()
        {
            Projects = new ObservableCollection<Project>(await GetProjects());
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Projects"));
        }

        async Task<IEnumerable<Project>> GetProjects()
        {
            var response = await client.GetAsync("/apiproject");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<IEnumerable<Project>>();
            }
            throw new Exception("something wrong...");
        }


    }
}
