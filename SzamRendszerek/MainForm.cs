using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SzamRendszerek
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            NumberSystem.Init();
            Convert();
        }

        private void Convert()
        {
            source.BackColor = Color.White;
            result.Text = "";

            CustomNumber? num = CustomNumber.CreateNumber(source.Text, (int)sourceSystem.Value);

            if (num.HasValue)
            {
                CustomNumber? conv = num.Value.ConvertTo((int)targetSystem.Value);

                if (conv.HasValue)
                {
                    result.Text = conv.Value.Value;
                }
                else
                { 
                    //LOL
                }
            }
            else
            {
                source.BackColor = Color.Red;
            }
        }

        private void source_TextChanged(object sender, EventArgs e)
        {
            Convert();
        }

        private void targetSystem_ValueChanged(object sender, EventArgs e)
        {
            Convert();
        }
    }
}
