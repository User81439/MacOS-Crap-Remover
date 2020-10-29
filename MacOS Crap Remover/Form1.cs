using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacOS_Crap_Remover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * 
         * cd /location/location/etc
            f:

            del /s /q /f /a .DS_STORE
            del /s /q /f /a .Trashes
            del /s /q /f /a ._.*
            del /s /q /f /a ._*

        string del_cmd1 = "";
        string del_cmd2 = "";
        string del_cmd3 = "";
        string del_cmd4 = "";
         */



        FolderBrowserDialog outputBrowser = new FolderBrowserDialog();
        private string del_cmd1 = "del /s /q /f /a .DS_STORE";
        private string del_cmd2 = "del /s /q /f /a .Trashes";
        private string del_cmd3 = "del /s /q /f /a ._.*";
        private string del_cmd4 = "del /s /q /f /a ._*";

        private string selected_location = "D:\\User\\Documents\\Tools etc\\Autoruns";

        private void main() {

        }

        private void set_cmd()
        {

        }

        private void run_cmds()
        {
            Process StartCMD = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Normal/*Normal or Hidden*/;
            startInfo.FileName = "cmd.exe";

            //startInfo.WorkingDirectory = @"C:\"; //how to

            StartCMD.StartInfo = startInfo;

            startInfo.Arguments = selected_location;

            //startInfo.Arguments = del_cmd1;
            //startInfo.Arguments = del_cmd2;
            //startInfo.Arguments = del_cmd3;
            //startInfo.Arguments = del_cmd4;


            StartCMD.Start();
            StartCMD.WaitForExit();
        }


        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }


        private void select_directory_Click(object sender, EventArgs e)
        {
            outputBrowser.SelectedPath = selected_location;
            outputBrowser.Description = "Select Output Folder";

            //if (outputBrowser.ShowDialog() == CommonFileDialogResult.Ok)
            //{
            //    location_display.Text = outputBrowser.;
            //}
        }

        private void run_button_Click(object sender, EventArgs e)
        {
            run_cmds();
        }
    }
}
