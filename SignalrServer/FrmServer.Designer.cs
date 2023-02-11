using Wisej.Web;

namespace SignalrServer
{
    partial class FrmServer
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

        #region Wisej Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStartServer = new Wisej.Web.Button();
            this.label1 = new Wisej.Web.Label();
            this.txtUrl = new Wisej.Web.TextBox();
            this.btnStop = new Wisej.Web.Button();
            this.txtLog = new Wisej.Web.TextBox();
            this.groupBox1 = new Wisej.Web.GroupBox();
            this.groupBox2 = new Wisej.Web.GroupBox();
            this.grpBroadcast = new Wisej.Web.GroupBox();
            this.btnSend = new Wisej.Web.Button();
            this.label2 = new Wisej.Web.Label();
            this.txtMessage = new Wisej.Web.TextBox();
            this.cmbClients = new Wisej.Web.ComboBox();
            this.cmbGroups = new Wisej.Web.ComboBox();
            this.rdToClient = new Wisej.Web.RadioButton();
            this.rdToGroup = new Wisej.Web.RadioButton();
            this.rdToAll = new Wisej.Web.RadioButton();
            this.tableLayoutPanel1 = new Wisej.Web.TableLayoutPanel();
            this.panel1 = new Wisej.Web.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpBroadcast.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(44, 45);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(108, 23);
            this.btnStartServer.TabIndex = 0;
            this.btnStartServer.Text = "Start";
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Url";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(44, 19);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(242, 22);
            this.txtUrl.TabIndex = 2;
            this.txtUrl.Text = "http://localhost:8080";
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(178, 45);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(108, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(8, 29);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(418, 205);
            this.txtLog.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLog);
            this.groupBox1.Location = new System.Drawing.Point(3, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 257);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.Text = "Log";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUrl);
            this.groupBox2.Controls.Add(this.btnStartServer);
            this.groupBox2.Controls.Add(this.btnStop);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 82);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.Text = "Server";
            // 
            // grpBroadcast
            // 
            this.grpBroadcast.Controls.Add(this.btnSend);
            this.grpBroadcast.Controls.Add(this.label2);
            this.grpBroadcast.Controls.Add(this.txtMessage);
            this.grpBroadcast.Controls.Add(this.cmbClients);
            this.grpBroadcast.Controls.Add(this.cmbGroups);
            this.grpBroadcast.Controls.Add(this.rdToClient);
            this.grpBroadcast.Controls.Add(this.rdToGroup);
            this.grpBroadcast.Controls.Add(this.rdToAll);
            this.grpBroadcast.Enabled = false;
            this.grpBroadcast.Location = new System.Drawing.Point(3, 92);
            this.grpBroadcast.Name = "grpBroadcast";
            this.grpBroadcast.Size = new System.Drawing.Size(444, 130);
            this.grpBroadcast.TabIndex = 7;
            this.grpBroadcast.Text = "Broadcast Message";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(301, 42);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(131, 76);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "Send";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Message";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(98, 98);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(188, 22);
            this.txtMessage.TabIndex = 7;
            // 
            // cmbClients
            // 
            this.cmbClients.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cmbClients.FormattingEnabled = true;
            this.cmbClients.Location = new System.Drawing.Point(98, 71);
            this.cmbClients.Name = "cmbClients";
            this.cmbClients.Size = new System.Drawing.Size(188, 22);
            this.cmbClients.TabIndex = 4;
            // 
            // cmbGroups
            // 
            this.cmbGroups.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cmbGroups.FormattingEnabled = true;
            this.cmbGroups.Location = new System.Drawing.Point(98, 44);
            this.cmbGroups.Name = "cmbGroups";
            this.cmbGroups.Size = new System.Drawing.Size(188, 22);
            this.cmbGroups.TabIndex = 3;
            // 
            // rdToClient
            // 
            this.rdToClient.Location = new System.Drawing.Point(12, 76);
            this.rdToClient.Name = "rdToClient";
            this.rdToClient.Size = new System.Drawing.Size(85, 22);
            this.rdToClient.TabIndex = 2;
            this.rdToClient.Text = "To Client";
            // 
            // rdToGroup
            // 
            this.rdToGroup.Location = new System.Drawing.Point(12, 50);
            this.rdToGroup.Name = "rdToGroup";
            this.rdToGroup.Size = new System.Drawing.Size(87, 22);
            this.rdToGroup.TabIndex = 1;
            this.rdToGroup.Text = "To Group";
            // 
            // rdToAll
            // 
            this.rdToAll.Checked = true;
            this.rdToAll.Location = new System.Drawing.Point(12, 22);
            this.rdToAll.Name = "rdToAll";
            this.rdToAll.Size = new System.Drawing.Size(66, 22);
            this.rdToAll.TabIndex = 0;
            this.rdToAll.TabStop = true;
            this.rdToAll.Text = "To All";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 461F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 497F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1223, 793);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.grpBroadcast);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(384, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 491);
            this.panel1.TabIndex = 9;
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmServer";
            this.Size = new System.Drawing.Size(1223, 793);
            this.Text = "Server";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpBroadcast.ResumeLayout(false);
            this.grpBroadcast.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Button btnStartServer;
        private Wisej.Web.Label label1;
        private Wisej.Web.TextBox txtUrl;
        private Wisej.Web.Button btnStop;
        private Wisej.Web.TextBox txtLog;
        private Wisej.Web.GroupBox groupBox1;
        private Wisej.Web.GroupBox groupBox2;
        private Wisej.Web.GroupBox grpBroadcast;
        private Wisej.Web.Button btnSend;
        private Wisej.Web.Label label2;
        private Wisej.Web.TextBox txtMessage;
        private Wisej.Web.ComboBox cmbClients;
        private Wisej.Web.ComboBox cmbGroups;
        private Wisej.Web.RadioButton rdToClient;
        private Wisej.Web.RadioButton rdToGroup;
        private Wisej.Web.RadioButton rdToAll;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
    }
}

