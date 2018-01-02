using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitterScraper.Exceptions;
using TwitterScraper.Scraper;

namespace TwitterScraper
{
    public partial class Main : Form
    {
        private readonly IScraper _scraper;
        private Proxy _proxy;
        private readonly Export.Export _export;
        private readonly CancellationTokenSource cts;
        CancellationToken ct;
        private int _index = 0;

        public Main()
        {
            InitializeComponent();
            _scraper = new MyTwitterScraper();
            _proxy = new Proxy();
            _export = new Export.Export();
            cts = new CancellationTokenSource();
            ct = cts.Token;
        }

        private void btnRandomizeUserAgent_Click(object sender, EventArgs e)
        {
            txtUserAgent.Text = Helper.GetUserAgent();
        }

        private async void btnScrape_Click(object sender, EventArgs e)
        {
            if(!ValidateInput())
            {
                MessageBox.Show(@"Invalid input, check your input/settings before trying again.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(!String.IsNullOrEmpty(txtProxy.Text) && !String.IsNullOrWhiteSpace(txtProxy.Text))
            {
                _proxy = new Proxy(txtProxy.Text, ':');
            }
            
            List<string> users = new List<string>();

            if(rbFromFile.Checked)
            {
                foreach(string s in Helper.ReadAllLinesFromFile(txtInput.Text))
                {
                    users.Add(s);
                }

                List<Task> tasks = new List<Task>();

                using (SemaphoreSlim semaphore = new SemaphoreSlim(Convert.ToInt32(txtThreads.Text)))
                {
                    for(int i = 0; i < users.Count; i++)
                    {
                        string user = users[i]; // why?
                        await semaphore.WaitAsync();

                        tasks.Add(
                            Task.Run(async () =>
                            {
                                try
                                {
                                    TwitterScraperData scraperData = await _scraper.GetDetails(txtUserAgent.Text, user, Convert.ToDouble(txtRequestTimeout.Text), _proxy.WebProxy);
                                    AddItemsToDgv(scraperData);
                                }
                                catch(Exception ex)
                                {
                                    Console.WriteLine(@"Error msg: {0}, index: {1}, users.Count: {2}", ex.Message, i, users.Count);
                                }
                                finally
                                {
                                    semaphore.Release();
                                }
                            }));
                    }

                    await Task.WhenAll(tasks);
                }
                users.Clear();
            }
            else if(rbSingleUser.Checked)
            {
                try
                {
                    TwitterScraperData scraperData = await _scraper.GetDetails(txtUserAgent.Text, txtInput.Text, Convert.ToDouble(txtRequestTimeout.Text), _proxy.WebProxy);

                    AddItemsToDgv(scraperData);
                }
                catch(InvalidUsernameException ex)
                {
                    Console.WriteLine(@"Error msg: " + ex.Message);
                }
                
            }
        }

        private void AddItemsToDgv(TwitterScraperData data)
        {
            Invoke((MethodInvoker)delegate
            {
                dgvItems.Rows.Add(
                            _index++,
                            data.Username,
                            data.UserAmountOfTweets,
                            data.UserAmountOfFollowings,
                            data.UserAmountOfFollowers,
                            data.UserAmountOfLikes,
                            data.UserDescription,
                            data.UserLocation,
                            data.UserBirthDate,
                            data.UserRegistrationDate,
                            data.UserAmountOfMedias,
                            data.IsUserVerified
                );
            });
        }

        private void rbFromFile_CheckedChanged(object sender, EventArgs e)
        {
            if(rbFromFile.Checked)
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = @"Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                    ofd.RestoreDirectory = true;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        txtInput.Text = ofd.FileName;
                    }
                }
            }
        }

        private bool ValidateInput(bool export = false)
        {
            if(export)
            {
                if (String.IsNullOrEmpty(txtOutput.Text) || String.IsNullOrWhiteSpace(txtOutput.Text)) return false;
                if (String.IsNullOrEmpty(txtCsvDelimiter.Text) || String.IsNullOrWhiteSpace(txtCsvDelimiter.Text)) return false;
            }
            else
            {
                if (!rbFromFile.Checked && !rbSingleUser.Checked) return false;
                if (String.IsNullOrEmpty(txtUserAgent.Text) || String.IsNullOrWhiteSpace(txtUserAgent.Text)) return false;
                if (String.IsNullOrEmpty(txtRequestTimeout.Text) || String.IsNullOrWhiteSpace(txtRequestTimeout.Text)) return false;
                if (String.IsNullOrEmpty(txtThreads.Text) || String.IsNullOrWhiteSpace(txtThreads.Text)) return false;
                if (String.IsNullOrEmpty(txtInput.Text) || String.IsNullOrWhiteSpace(txtInput.Text)) return false;
            }
            return true;
        }

        private async void OnAppStart()
        {
            // Deserialize object for settings
            Settings s = Serialize.LoadUserData(Application.StartupPath + "\\data\\data.bin");
            if(s != null)
            {
                txtUserAgent.Text = s.UserAgent;
                txtProxy.Text = s.Proxy;
                txtThreads.Text = s.Threads;
                txtRequestTimeout.Text = s.RequestTimeout;
                cbDumpDebugLogs.Checked = s.DumpDebugData;
                txtOutput.Text = s.OutputDirectory;
                txtCsvDelimiter.Text = s.CsvDelimiter;
            }

            // Set default user agent and request timeout, so it can finish the requests below (if none are loaded by serialization)
            if (String.IsNullOrEmpty(txtUserAgent.Text)) txtUserAgent.Text = Helper.GetUserAgent();
            if (String.IsNullOrEmpty(txtRequestTimeout.Text)) txtRequestTimeout.Text = "100";

            // Group box: Version
            lblCurrentVersion.Text += Helper.GetCurrentVersion();
            lblLatestVersion.Text += await Helper.GetLatestVersion(txtUserAgent.Text, Convert.ToDouble(txtRequestTimeout.Text), _proxy.WebProxy);

            // Group box: News
            txtNews.Text = await Helper.GetLatestNews(txtUserAgent.Text, Convert.ToDouble(txtRequestTimeout.Text), _proxy.WebProxy);

            // Group box: Changelog
            txtChangelog.Text = await Helper.GetChangelog(txtUserAgent.Text, Convert.ToDouble(txtRequestTimeout.Text), _proxy.WebProxy);
        }

        private void OnAppExit()
        {
            Settings s = new Settings
            {
                CsvDelimiter = txtCsvDelimiter.Text,
                DumpDebugData = cbDumpDebugLogs.Checked,
                OutputDirectory = txtOutput.Text,
                Proxy = txtProxy.Text,
                RequestTimeout = txtRequestTimeout.Text,
                Threads = txtThreads.Text,
                UserAgent = txtUserAgent.Text
            };

            Serialize.SaveUserData(s);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            OnAppStart();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnAppExit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btnOutputFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.ShowNewFolderButton = true;
                fbd.Description = @"Export data folder";
                if(fbd.ShowDialog() == DialogResult.OK)
                {
                    txtOutput.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            dgvItems.Rows.Clear();
            _index = 0;
        }

        private void removeFilters_Click(object sender, EventArgs e)
        {
            if (!(sender is ToolStripMenuItem t)) return;
            
            switch(t.Name)
            {
                case "removeMoreThanTweets":
                    dgvItems = Filters.FilterTweets(dgvItems, false, Convert.ToInt32(removeMoreThanTweetsTextBox.Text));
                    break;

                case "removeLessThanTweets":
                    dgvItems = Filters.FilterTweets(dgvItems, true, Convert.ToInt32(removeLessThanTweetsTextBox.Text));
                    break;

                case "removeMoreThanFollowings":
                    dgvItems = Filters.FilterFollowings(dgvItems, false, Convert.ToInt32(removeMoreThanFollowingsTextBox.Text));
                    break;

                case "removeLessThanFollowings":
                    dgvItems = Filters.FilterFollowings(dgvItems, true, Convert.ToInt32(removeLessThanFollowingsTextBox.Text));
                    break;

                case "removeMoreThanFollowers":
                    dgvItems = Filters.FilterFollowers(dgvItems, false, Convert.ToInt32(removeMoreThanFollowersTextBox.Text));
                    break;

                case "removeLessThanFollowers":
                    dgvItems = Filters.FilterFollowers(dgvItems, true, Convert.ToInt32(removeLessThanFollowersTextBox.Text));
                    break;

                case "removeMoreThanLikes":
                    dgvItems = Filters.FilterLikes(dgvItems, false, Convert.ToInt32(removeMoreThanLikesTextBox.Text));
                    break;

                case "removeLessThanLikes":
                    dgvItems = Filters.FilterLikes(dgvItems, true, Convert.ToInt32(removeLessThanLikesTextBox.Text));
                    break;
            }
        }

        private void ExportData(object sender, EventArgs e)
        {
            if(ValidateInput(true))
            {
                _export.GridIn = dgvItems;
                _export.Delimiter = txtCsvDelimiter.Text;
                _export.SavePath = txtOutput.Text;
                _export.FileName = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss", CultureInfo.InvariantCulture);

                if (!(sender is ToolStripMenuItem t)) return;

                switch (t.Name)
                {
                    case "allDataToolStripMenuItem":
                        if (dgvItems.Rows.Count > 0)
                        {
                            _export.ExportAllData();
                        }
                        break;
                    case "selectedRowsToolStripMenuItem":
                        if (dgvItems.SelectedRows.Count > 0)
                        {
                            _export.ExportSelectedRows();
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show(@"Invalid input, check your settings before trying again.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
