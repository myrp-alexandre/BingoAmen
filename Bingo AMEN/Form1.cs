using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using Timer = System.Windows.Forms.Timer;

namespace Bingo_AMEN
{
    public partial class Form1 : Form
    {
        private Timer myTimer;
        private List<Label> labelNumbers;
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.showNumber.Visible = false;
            myTimer = new Timer();
            labelNumbers = new List<Label> { n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12,n13,n14,n15, n16, n17, n18, n19,
                n20, n21, n22, n23, n24, n25, n26, n27, n28, n29,
                n30, n31, n32, n33, n34, n35, n36, n37, n38, n39,
                n40, n41, n42, n43, n44, n45, n46, n47, n48, n49,
                n50, n51, n52, n53, n54, n55, n56, n57, n58, n59,
                n60, n61, n62, n63, n64, n65, n66, n67, n68, n69,
                n70, n71, n72, n73, n74, n75};
            Hide_Numbers();
        }
        private void markNumber()
        {
            String numberText = numberBox.Text;
            
            foreach (var label in labelNumbers)
            {
                if (label.Text.Equals(numberText))
                {
                    this.showNumber.Text = numberText;
                    this.showNumber.Visible = true;

                    
                    myTimer.Interval = 3000;
                    myTimer.Tick += myTick;
                    myTimer.Start();
                    
                    label.Visible = true;
                    label.Enabled = true;
                }
            }

            numberBox.Clear();
            numberBox.Focus();
        }

        private void myTick(object sender, EventArgs e)
        {
            this.showNumber.Visible = false;
            myTimer.Stop();

        }
        private void Clean_Click(object sender, EventArgs e)
        {
            Hide_Numbers();
        }
                       
        private void Add_Click(object sender, EventArgs e)
        {
            markNumber();
        }

        private void Hide_Numbers()
        {
            foreach (var label in labelNumbers)
            {
                label.Visible = false;
            }
        }
    }
}
