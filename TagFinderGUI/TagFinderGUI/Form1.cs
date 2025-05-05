using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TagFinderGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void BtnFindTags_Click(object sender, EventArgs e)
        {
            lstResults.Items.Clear();
            lblStatus.Text = "Fetching...";

            string url = txtUrl.Text.Trim();
            string tag = txtTag.Text.Trim();

            if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(tag))
            {
                MessageBox.Show("Please enter both URL and tag.");
                lblStatus.Text = "Input required.";
                return;
            }

            try
            {
                using HttpClient client = new HttpClient();
                string html = await client.GetStringAsync(url);

                string pattern = $@"<\s*{tag}[^>]*>";
                MatchCollection matches = Regex.Matches(html, pattern, RegexOptions.IgnoreCase);

                foreach (Match match in matches)
                {
                    lstResults.Items.Add(match.Value);
                }

                lblStatus.Text = $"Found {matches.Count} <{tag}> tag(s).";

                if (matches.Count == 0)
                    lstResults.Items.Add($"No <{tag}> tags found.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                lblStatus.Text = "Error occurred.";
            }
        }
    }
}
