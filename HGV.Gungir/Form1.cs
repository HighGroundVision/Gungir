using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var commands = this.txtCommands.Text.Split(Environment.NewLine);

            var sim = new InputSimulator();
            sim.Keyboard.Sleep(TimeSpan.FromSeconds(10));

            foreach (var cmd in commands)
            {
                sim.Keyboard.TextEntry(cmd).Sleep(300);
                sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
            }
        }
    }
}
