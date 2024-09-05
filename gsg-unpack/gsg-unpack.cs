using System;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace gsg_unpack
{
    public partial class gsg_unpack : Form
    {

        string game, game_path, usrdir_path, movie_path, res_path, file_type;

        private void add_files_to_filebox()
        {
            fileListBox.Items.Clear();
            if (file_type == "MPK" && !string.IsNullOrEmpty(usrdir_path))
            {
                var files = new DirectoryInfo(usrdir_path).GetFiles().Select(o => o.Name).ToArray();
                fileListBox.Items.AddRange(files);
            }
            else if (file_type == "BK2" && !string.IsNullOrEmpty(res_path))
            {
                var files = new DirectoryInfo(res_path).GetFiles().Select(o => o.Name).ToArray();
                fileListBox.Items.AddRange(files);
            }
        }

        private string GetListBoxSelectedValues()
        {
            var selected_items = fileListBox.SelectedItems;
            for (int i=0; i<selected_items.Count; i++)
            {
                var selected_item = selected_items[i];
                string sel_item_str = fileListBox.GetItemText(selected_item);
                MessageBox.Show(sel_item_str);
            }
            
            return "";
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
            //resLabel = this.Controls.Find("resLabel", true).FirstOrDefault() as Label;
            //resChooser = this.Controls.Find("resChooser", true).FirstOrDefault() as ComboBox;
            resLabel.Hide();
            resChooser.Hide();
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
            GetListBoxSelectedValues();
            //MessageBox.Show(game_path + '\n' + usrdir_path + '\n' + movie_path + '\n' + file_type + '\n' + res_path);
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
