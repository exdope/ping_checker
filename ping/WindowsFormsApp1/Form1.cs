using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       private void button1_Click(object sender, EventArgs e)
        {
            var list = new List<string>
            { 
                "vk.com",
                "fb.com",
                "youtube.com",
                "telegram.com",
                "microsoft.com",
                "github.com",
                "market.dota2.net"
            };
            Pinger(list);

        }
        async public void Pinger(List<string> list)
        {
            await Task.Run(() =>
            {
                Ping ping = new Ping();
                foreach (var ch in list)
                {
                    label1.Text += ch + $": {ping.Send(ch).RoundtripTime} ms\n";
                }
            });
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
