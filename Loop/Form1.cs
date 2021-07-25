using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace Loop
{
    public partial class frmLoop : Form
    {
        public frmLoop()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            byte a = 0;
            Cursor.Current = Cursors.WaitCursor;
            for (long i = 1; i <= 10000; i++)
            {
                //txtOutput.Text = txtOutput.Text + " " + i.ToString();
                listBox1.Items.Add(i);
            }
            Cursor.Current = Cursors.Default;

            //txtOutput.Text = txtOutput.Text + DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss") + Environment.NewLine + " ";

            /*
             * Medir el tiempo de ejecución (2021-07-13)
             * 
             * */
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            Thread.Sleep(1000);
            stopwatch.Stop();

            txtOutput.Text = "Tiempo en milisecs: " + stopwatch.ElapsedMilliseconds.ToString();
            
        }
    }
}
