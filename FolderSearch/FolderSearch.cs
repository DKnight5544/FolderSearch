using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FolderSearch
{
    public partial class SongScoutForm : Form
    {
        public SongScoutForm()
        {
            InitializeComponent();
        }

        private Dictionary<string, string> MusicDB = new Dictionary<string, string>();

        private void FolderSearch_Load(object sender, EventArgs e)
        {

            LoadData();
            this.SearchCriteria.Focus();

        }

        private void LoadData()
        {
            string dataPath = ConfigurationManager.AppSettings["CusDir32"];
            string indexRoot = ConfigurationManager.AppSettings["IndexRoot"];

            var cusdir32 = File.ReadAllLines(dataPath);

            foreach (string row in cusdir32)
            {
                var r = row.Split(';');
                var dirName = r[0];
                var dirPath = r[1].Replace("M:", indexRoot).Replace("m:", indexRoot) + @"\$Wavelog12.idx";

                var wavelog = File.ReadAllLines(dirPath);

                foreach (string wavelogrow in wavelog)
                {
                    MusicDB.Add(wavelogrow.ToLower(), dirName);
                }

            }
        }

        private void SearchCriteria_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                Search();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

        }

        private void SearchCriteria_Enter(object sender, EventArgs e)
        {
            this.SearchCriteria.Text = "";
            this.MatchingFoldersListbox.DataSource = null;
        }

        private void SearchCriteria_Leave(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            string criteria = this.SearchCriteria.Text.ToLower();

            var result = MusicDB.Where(m => m.Key.Contains(criteria)).Select(n => n.Value).Distinct().OrderBy(l => l).ToList();

            this.MatchingFoldersListbox.DataSource = result;

            this.MatchingFoldersListbox.Focus();

        }
    }
}
