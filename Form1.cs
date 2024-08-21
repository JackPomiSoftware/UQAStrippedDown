using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAC_Fast_Access
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            RegistryKey InitKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System");

            //////////
            // Check if LUA is off
            //////////


                if (InitKey.GetValue("ConsentPromptBehaviorAdmin").ToString() == "0" && InitKey.GetValue("PromptOnSecureDesktop").ToString() == "0")
                {
                    Slider.Value = 0;
                    labelL0.Visible = true;
                    labelL0T.Visible = true;
                    warn.Visible = true;
                    labelL1.Visible = false;
                    labelL1T.Visible = false;
                    labelL2.Visible = false;
                    labelL2T.Visible = false;
                    labelL3.Visible = false;
                    labelL3T.Visible = false;
                }

                if (InitKey.GetValue("ConsentPromptBehaviorAdmin").ToString() == "5" && InitKey.GetValue("PromptOnSecureDesktop").ToString() == "0")
                {
                    Slider.Value = 1;
                    labelL0.Visible = false;
                    labelL0T.Visible = false;
                    warn.Visible = false;
                    labelL1.Visible = true;
                    labelL1T.Visible = true;
                    labelL2.Visible = false;
                    labelL2T.Visible = false;
                    labelL3.Visible = false;
                    labelL3T.Visible = false;
                }

                if (InitKey.GetValue("ConsentPromptBehaviorAdmin").ToString() == "5" && InitKey.GetValue("PromptOnSecureDesktop").ToString() == "1")
                {
                    Slider.Value = 2;
                    labelL0.Visible = false;
                    labelL0T.Visible = false;
                    warn.Visible = false;
                    labelL1.Visible = false;
                    labelL1T.Visible = false;
                    labelL2.Visible = true;
                    labelL2T.Visible = true;
                    labelL3.Visible = false;
                    labelL3T.Visible = false;
                }

                if (InitKey.GetValue("ConsentPromptBehaviorAdmin").ToString() == "2" && InitKey.GetValue("PromptOnSecureDesktop").ToString() == "1")
                {
                    Slider.Value = 3;
                    labelL0.Visible = false;
                    labelL0T.Visible = false;
                    warn.Visible = false;
                    labelL1.Visible = false;
                    labelL1T.Visible = false;
                    labelL2.Visible = false;
                    labelL2T.Visible = false;
                    labelL3.Visible = true;
                    labelL3T.Visible = true;
                }
        }

        //////////
        // Cancel
        //////////

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //////////
        // What is UAC
        //////////

        private void linkHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://w.wiki/AxmC");
        }

        //////////
        // UAC Settings
        //////////

        //////////
        // Slider change
        //////////

        private void Slider_Scroll(object sender, EventArgs e)
        {
            buttonApply.Enabled = true;
            if (Slider.Value == 0)
            {
                labelL0.Visible = true;
                labelL0T.Visible = true;
                warn.Visible = true;
                labelL1.Visible = false;
                labelL1T.Visible = false;
                labelL2.Visible = false;
                labelL2T.Visible = false;
                labelL3.Visible = false;
                labelL3T.Visible = false;
            }
            if (Slider.Value == 1)
            {
                labelL0.Visible = false;
                labelL0T.Visible = false;
                warn.Visible = false;
                labelL1.Visible = true;
                labelL1T.Visible = true;
                labelL2.Visible = false;
                labelL2T.Visible = false;
                labelL3.Visible = false;
                labelL3T.Visible = false;
            }
            if (Slider.Value == 2)
            {
                labelL0.Visible = false;
                labelL0T.Visible = false;
                warn.Visible = false;
                labelL1.Visible = false;
                labelL1T.Visible = false;
                labelL2.Visible = true;
                labelL2T.Visible = true;
                labelL3.Visible = false;
                labelL3T.Visible = false;
            }
            if (Slider.Value == 3)
            {
                labelL0.Visible = false;
                labelL0T.Visible = false;
                warn.Visible = false;
                labelL1.Visible = false;
                labelL1T.Visible = false;
                labelL2.Visible = false;
                labelL2T.Visible = false;
                labelL3.Visible = true;
                labelL3T.Visible = true;
            }
        }

        //////////
        // Change UAC settings
        //////////

        private void buttonApply_Click(object sender, EventArgs e)
        {
            RegistryKey LUAKey = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System");

            if (Slider.Value == 0)
            {
                LUAKey.SetValue("ConsentPromptBehaviorAdmin", 0);
                LUAKey.SetValue("PromptOnSecureDesktop", 0);
            }
            if (Slider.Value == 1)
            {
                LUAKey.SetValue("ConsentPromptBehaviorAdmin", 5);
                LUAKey.SetValue("PromptOnSecureDesktop", 0);
            }
            if (Slider.Value == 2)
            {
                LUAKey.SetValue("ConsentPromptBehaviorAdmin", 5);
                LUAKey.SetValue("PromptOnSecureDesktop", 1);
            }
            if (Slider.Value == 3)
            {
                LUAKey.SetValue("ConsentPromptBehaviorAdmin", 2);
                LUAKey.SetValue("PromptOnSecureDesktop", 1);
            }

            buttonApply.Enabled = false;
        }
    }
}
