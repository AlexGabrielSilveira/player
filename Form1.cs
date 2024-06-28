using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        WMPLib.IWMPPlaylist playlist;

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Open";
            openFileDialog.Filter = "Arquivo mp3|*.mp3|arquivo wav| *.wav|arquivo m4a| *.m4a|arquivo aac| *.aac"; 

            if (openFileDialog.ShowDialog() == DialogResult.OK) 
            {
                playlist = Player.playlistCollection.newPlaylist("List");

                foreach (var file in openFileDialog.FileNames)
                {
                    playlist.appendItem(Player.newMedia(file));
                    UPlayList.Items.Add(file);

                    Player.currentPlaylist = playlist;
                    Player.Ctlcontrols.play();
                }
            }
        }   
    }
}
