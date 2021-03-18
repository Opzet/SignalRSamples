
namespace Claucometa.TicTacToe
{
    partial class Board
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.square1 = new Claucometa.TicTacToe.Square();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.square2 = new Claucometa.TicTacToe.Square();
            this.square3 = new Claucometa.TicTacToe.Square();
            this.square4 = new Claucometa.TicTacToe.Square();
            this.square5 = new Claucometa.TicTacToe.Square();
            this.square6 = new Claucometa.TicTacToe.Square();
            this.square7 = new Claucometa.TicTacToe.Square();
            this.square8 = new Claucometa.TicTacToe.Square();
            this.square9 = new Claucometa.TicTacToe.Square();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // square1
            // 
            this.square1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.square1.Location = new System.Drawing.Point(3, 3);
            this.square1.Name = "square1";
            this.square1.Size = new System.Drawing.Size(101, 96);
            this.square1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.square1);
            this.flowLayoutPanel1.Controls.Add(this.square2);
            this.flowLayoutPanel1.Controls.Add(this.square3);
            this.flowLayoutPanel1.Controls.Add(this.square4);
            this.flowLayoutPanel1.Controls.Add(this.square5);
            this.flowLayoutPanel1.Controls.Add(this.square6);
            this.flowLayoutPanel1.Controls.Add(this.square7);
            this.flowLayoutPanel1.Controls.Add(this.square8);
            this.flowLayoutPanel1.Controls.Add(this.square9);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(321, 306);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // square2
            // 
            this.square2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.square2.Location = new System.Drawing.Point(110, 3);
            this.square2.Name = "square2";
            this.square2.Size = new System.Drawing.Size(101, 96);
            this.square2.TabIndex = 1;
            // 
            // square3
            // 
            this.square3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.square3.Location = new System.Drawing.Point(217, 3);
            this.square3.Name = "square3";
            this.square3.Size = new System.Drawing.Size(101, 96);
            this.square3.TabIndex = 2;
            // 
            // square4
            // 
            this.square4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.square4.Location = new System.Drawing.Point(3, 105);
            this.square4.Name = "square4";
            this.square4.Size = new System.Drawing.Size(101, 96);
            this.square4.TabIndex = 3;
            // 
            // square5
            // 
            this.square5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.square5.Location = new System.Drawing.Point(110, 105);
            this.square5.Name = "square5";
            this.square5.Size = new System.Drawing.Size(101, 96);
            this.square5.TabIndex = 4;
            // 
            // square6
            // 
            this.square6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.square6.Location = new System.Drawing.Point(217, 105);
            this.square6.Name = "square6";
            this.square6.Size = new System.Drawing.Size(101, 96);
            this.square6.TabIndex = 5;
            // 
            // square7
            // 
            this.square7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.square7.Location = new System.Drawing.Point(3, 207);
            this.square7.Name = "square7";
            this.square7.Size = new System.Drawing.Size(101, 96);
            this.square7.TabIndex = 6;
            // 
            // square8
            // 
            this.square8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.square8.Location = new System.Drawing.Point(110, 207);
            this.square8.Name = "square8";
            this.square8.Size = new System.Drawing.Size(101, 96);
            this.square8.TabIndex = 7;
            // 
            // square9
            // 
            this.square9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.square9.Location = new System.Drawing.Point(217, 207);
            this.square9.Name = "square9";
            this.square9.Size = new System.Drawing.Size(101, 96);
            this.square9.TabIndex = 8;
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Board";
            this.Size = new System.Drawing.Size(321, 306);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Square square1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Square square2;
        private Square square3;
        private Square square4;
        private Square square5;
        private Square square6;
        private Square square7;
        private Square square8;
        private Square square9;
    }
}
