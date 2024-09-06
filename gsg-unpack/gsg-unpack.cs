using System.Reflection;
using System.Diagnostics;
using System.IO;

namespace gsg_unpack
{
    public partial class gsg_unpack : Form
    {

        string? game, game_path, usrdir_path, movie_path, res_path, file_type;

        private void add_files_to_filebox()
        {
            startButton.Enabled = false;
            fileListBox.Items.Clear();
            if (file_type == "MPK" && !string.IsNullOrEmpty(usrdir_path))
            {
                startButton.Enabled = true;
                var files = new DirectoryInfo(usrdir_path).GetFiles().Select(o => o.Name).ToArray();
                fileListBox.Items.AddRange(files);
            }
            else if (file_type == "BK2" && !string.IsNullOrEmpty(res_path))
            {
                startButton.Enabled = true;
                var files = new DirectoryInfo(res_path).GetFiles().Select(o => o.Name).ToArray();
                fileListBox.Items.AddRange(files);
            }
        }

        private List<string?> getSelectedItems()
        {
            List<string?> selected_items_str=new List<string?>();
            var selected_items = fileListBox.SelectedItems;
            for (int i=0; i<selected_items.Count; i++)
            {
                var selected_item = selected_items[i];
                string? sel_item_str = fileListBox.GetItemText(selected_item);
                selected_items_str.Add(sel_item_str);
            }

            return selected_items_str;
        }

        Dictionary<string, string> gamePath;
        public gsg_unpack()
        {
            InitializeComponent();
            string root_path = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\";
            gamePath = new Dictionary<string, string>();
            gamePath.Add("STEINS;GATE", root_path + "STEINS;GATE");
            gamePath.Add("STEINS;GATE 0", root_path + "STEINS;GATE 0");
            gamePath.Add("STEINS;GATE: Linear Bounded Phenogram", root_path + "SG_Phenogram");
            gamePath.Add("STEINS;GATE: My Darling's Embrace", root_path + "SG_My Darling's Embrace");
            resLabel.Hide();
            resChooser.Hide();
            startButton.Enabled = false;
        }

        private void gsg_unpack_Load(object sender, EventArgs e)
        {

        }


        private void gameChooser_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            game = cmb.SelectedItem?.ToString() ?? "No item selected";
            game_path = gamePath[game];
            usrdir_path = game_path + "\\USRDIR";
            movie_path = game_path + "\\USRDIR\\movie";
            add_files_to_filebox();
            // MessageBox.Show(game+'\n'+game_path+'\n'+usrdir_path+'\n'+movies_path);
        }

        private void fileTypeChooser_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            file_type = cmb.SelectedItem?.ToString() ?? "No item selected";
            if (file_type == "BK2")
            {
                resLabel.Show();
                resChooser.Show();
                add_files_to_filebox();
            }
            else if (file_type == "MPK")
            {
                resLabel.Hide();
                resChooser.Hide();
                add_files_to_filebox();
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            string? exe_root = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string? output_dir = exe_root + "\\output\\"+game?.Replace(":", "");
            Directory.CreateDirectory(output_dir);
            List<string?> selected_items = getSelectedItems();
            if (file_type == "MPK")
            {
                string sg_unpack = exe_root + "\\sg-unpack\\sg-unpack.exe";
                for (int i = 0; i < selected_items.Count; i++)
                {
                    string? item = selected_items[i]; 
                    string path = usrdir_path + '\\' + item;
                    Process p = new Process();
                    p.StartInfo.FileName = sg_unpack;
                    p.StartInfo.Arguments = String.Format("-i \"{0}\" -o \"{1}\"", path, output_dir);
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardOutput = true;

                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

                    p.Start();
                    string output = p.StandardOutput.ReadToEnd();
                    p.WaitForExit(); // This waits until the program called is closed

                    logTextBox.Text = output;
                }
            }
            else if (file_type == "BK2")
            {
                // https://forums.nexusmods.com/topic/11403533-rad-bink-downsizing-the-resolution-of-a-video/
                // https://www.radgametools.com/binkfaq.htm (Search for "switches" in the page)

                string radvideo = exe_root + "\\RADVideo\\radvideo64.exe";
                string bk2_output_dir = output_dir + "\\BK2";
                Directory.CreateDirectory(bk2_output_dir);
                for (int i = 0; i < selected_items.Count; i++)
                {
                    string? item = selected_items[i];
                    string path = res_path + '\\' + item;
                    string? output_filename = item?.Replace(".bk2", ".mp4");
                    Process p = new Process();
                    p.StartInfo.FileName = radvideo;
                    p.StartInfo.Arguments = String.Format("binkconv \"{0}\" \"{1}\\{2}\"", path, bk2_output_dir, output_filename);
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardOutput = true;

                    // p.StartInfo.CreateNoWindow = true;
                    // p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

                    p.Start();
                    string output = p.StandardOutput.ReadToEnd();
                    p.WaitForExit(); // This waits until the program called is closed

                    logTextBox.Text = output;
                }
            }
        }

        private void resChooser_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            string res = cmb.SelectedItem?.ToString() ?? "No item selected";
            res_path = movie_path + "\\" + res;
            add_files_to_filebox();
        }
    }
}
