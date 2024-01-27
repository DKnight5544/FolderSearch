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
            string indexRoot = ConfigurationManager.AppSettings["IndexRoot"];
            List<string> files = new List<string>();
            DirectoryInfo directory = new DirectoryInfo(indexRoot);
            var dirs = directory.GetDirectories();

            var filteredDirectories = dirs.Where(
                f => !f.Name.StartsWith("$") 
                && !f.Name.StartsWith("_")
                && !(f.Extension == ".000")
                && !(f.Extension == ".001")
                && ! (f.Name == "System Volume Information")
                );

            foreach (var dir in filteredDirectories)
            {
                var idxFiles = dir.GetFiles("$Wavelog12.idx", SearchOption.AllDirectories);
                foreach (var f in idxFiles)
                {
                    files.Add(f.FullName);
                }

            }

            foreach (string file in files)
            {

                var folder = file.Replace(indexRoot + @"\", "").Replace(@"\$Wavelog12.idx", "");

                var wavelog = File.ReadAllLines(file);

                foreach (string wavelogrow in wavelog)
                {
                    string guid = Guid.NewGuid().ToString();
                    MusicDB.Add(guid + wavelogrow.ToLower(), folder.Replace(@"\", @" \ "));
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
