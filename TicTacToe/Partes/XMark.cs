using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claucometa.TicTacToe
{
    public class XMark : BaseMark
    {
        public XMark()
        {
            this.Mark = "X";
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // XMark
            // 
            this.Mark = "X";
            this.Name = "XMark";
            this.Size = new System.Drawing.Size(1201, 645);
            this.ResumeLayout(false);

        }
    }
}
