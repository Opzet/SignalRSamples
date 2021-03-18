using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Claucometa.TicTacToe
{
    public partial class BaseMark : UserControl
    {
        private string mark;
        private Label label1;

        public string Mark
        {
            get { return mark; }
            set { label1.Text = mark = value; }
        }

        public BaseMark()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 107);
            this.label1.TabIndex = 0;
            this.label1.Text = "*";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BaseMark
            // 
            this.Controls.Add(this.label1);
            this.Name = "BaseMark";
            this.Size = new System.Drawing.Size(125, 107);
            this.ResumeLayout(false);

        }
    }
}
