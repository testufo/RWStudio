﻿using IniParser.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RWS
{
    public partial class effects : Form
    {
        public effects()
        {
            InitializeComponent();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = checkBox7.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            button1.BackColor = colorDialog1.Color;
            color.Text = HexConverter(colorDialog1.Color);
        }
        private static String HexConverter(Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void effects_Load(object sender, EventArgs e)
        {
            string[] s1ss = Directory.GetFiles(New_edit.path, "*.png");
            for (int i = 0; i < s1ss.Length; i++)
            {
                icon.Items.Add(new DirectoryInfo(s1ss[i]).Name);
            }
            if (New_edit.lastact != null)
            {
                namee.Enabled = false;
                List<Control> txt = Controls.OfType<TextBox>().Cast<Control>().ToList();
                List<Control> cb = Controls.OfType<ComboBox>().Cast<Control>().ToList();
                List<CheckBox> ch = Controls.OfType<CheckBox>().Cast<CheckBox>().ToList();
                string[] sss = Directory.GetFiles(New_edit.path, "*.ini");
                var parser = new IniParser.FileIniDataParser();
                IniData data = parser.ReadFile(sss[0]);
                for (int i = 0; i < txt.Count; i++)
                {
                    if (txt[i].Tag != null && data["effect_" + New_edit.lastact][txt[i].Tag.ToString()] != null)
                        txt[i].Text = data["effect_" + New_edit.lastact][txt[i].Tag.ToString()];
                }
                for (int i = 0; i < cb.Count; i++)
                {
                    if (cb[i].Tag != null)
                        cb[i].Text = data["effect_" + New_edit.lastact][cb[i].Tag.ToString()];
                }
                for (int i = 0; i < ch.Count; i++)
                {
                    if (ch[i].Tag != null && data["effect_" + New_edit.lastact][ch[i].Tag.ToString()] != null)
                        ch[i].Checked = Convert.ToBoolean(data["effect_" + New_edit.lastact][ch[i].Tag.ToString()]);
                }
                namee.Text = New_edit.lastact;
            }
            button1.BackColor = ColorTranslator.FromHtml(color.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Control> txt = Controls.OfType<TextBox>().Cast<Control>().ToList();
            List<Control> cb = Controls.OfType<ComboBox>().Cast<Control>().ToList();
            List<CheckBox> ch = Controls.OfType<CheckBox>().Cast<CheckBox>().ToList();
            string[] sss = Directory.GetFiles(New_edit.path, "*.ini");
            var parser = new IniParser.FileIniDataParser();
            IniData data = parser.ReadFile(sss[0]);
            for (int i = 0; i < txt.Count; i++)
            {
                if (txt[i].Text != "" && txt[i].Text != " " && txt[i].Enabled)
                {
                    if (txt[i].Tag.ToString() != "")
                        data["effect_" + namee.Text][txt[i].Tag.ToString()] = txt[i].Text;
                }
                else if (data["effect_" + namee.Text][txt[i].Tag.ToString()] != null)
                {
                    data["effect_" + namee.Text].RemoveKey(txt[i].Tag.ToString());
                }
            }
            for (int i = 0; i < cb.Count; i++)
            {
                if (cb[i].Text != "" && cb[i].Text != " " && cb[i].Enabled)
                {
                    if (cb[i].Tag.ToString() != "")
                        data["effect_" + namee.Text][cb[i].Tag.ToString()] = cb[i].Text;
                }
                else if (data["effect_" + namee.Text][cb[i].Tag.ToString()] != null)
                {
                    data["effect_" + namee.Text].RemoveKey(cb[i].Tag.ToString());
                }
            }
            for (int i = 0; i < ch.Count; i++)
            {
                if (ch[i].Tag.ToString() != "")
                    data["effect_" + namee.Text][ch[i].Tag.ToString()] = ch[i].Checked.ToString();
            }
            parser.WriteFile(sss[0], data);
            Close();
        }
    }
}
