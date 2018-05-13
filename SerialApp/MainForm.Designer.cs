namespace SerialApp
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.ComPortTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DataBitsTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.OutputTb = new System.Windows.Forms.TextBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SendBtn = new System.Windows.Forms.Button();
            this.CommandTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ParityCmb = new System.Windows.Forms.ComboBox();
            this.StopBitsCmb = new System.Windows.Forms.ComboBox();
            this.BaudRateCmb = new System.Windows.Forms.ComboBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.AppendCrCb = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ComPortTb, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.DataBitsTb, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.OutputTb, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.CommandTb, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.SendBtn, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.OpenBtn, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.CloseBtn, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ParityCmb, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.StopBitsCmb, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.BaudRateCmb, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ClearBtn, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.AppendCrCb, 2, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 562);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM port name";
            // 
            // ComPortTb
            // 
            this.ComPortTb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ComPortTb.Location = new System.Drawing.Point(135, 3);
            this.ComPortTb.Name = "ComPortTb";
            this.ComPortTb.Size = new System.Drawing.Size(100, 27);
            this.ComPortTb.TabIndex = 2;
            this.ComPortTb.Text = "COM10";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data bits";
            // 
            // DataBitsTb
            // 
            this.DataBitsTb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DataBitsTb.Location = new System.Drawing.Point(135, 67);
            this.DataBitsTb.Name = "DataBitsTb";
            this.DataBitsTb.Size = new System.Drawing.Size(100, 27);
            this.DataBitsTb.TabIndex = 2;
            this.DataBitsTb.Text = "8";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Stop bits";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Parity";
            // 
            // OpenBtn
            // 
            this.OpenBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OpenBtn.AutoSize = true;
            this.OpenBtn.Location = new System.Drawing.Point(54, 162);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(75, 30);
            this.OpenBtn.TabIndex = 3;
            this.OpenBtn.Text = "Open";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // OutputTb
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.OutputTb, 2);
            this.OutputTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputTb.Location = new System.Drawing.Point(135, 234);
            this.OutputTb.Multiline = true;
            this.OutputTb.Name = "OutputTb";
            this.OutputTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutputTb.Size = new System.Drawing.Size(762, 325);
            this.OutputTb.TabIndex = 4;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CloseBtn.AutoSize = true;
            this.CloseBtn.Enabled = false;
            this.CloseBtn.Location = new System.Drawing.Point(135, 162);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(64, 30);
            this.CloseBtn.TabIndex = 3;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // SendBtn
            // 
            this.SendBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SendBtn.AutoSize = true;
            this.SendBtn.Enabled = false;
            this.SendBtn.Location = new System.Drawing.Point(54, 198);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(75, 30);
            this.SendBtn.TabIndex = 3;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // CommandTb
            // 
            this.CommandTb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CommandTb.Location = new System.Drawing.Point(135, 199);
            this.CommandTb.Name = "CommandTb";
            this.CommandTb.Size = new System.Drawing.Size(543, 27);
            this.CommandTb.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Baud rate";
            // 
            // ParityCmb
            // 
            this.ParityCmb.FormattingEnabled = true;
            this.ParityCmb.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.ParityCmb.Location = new System.Drawing.Point(135, 131);
            this.ParityCmb.Name = "ParityCmb";
            this.ParityCmb.Size = new System.Drawing.Size(121, 28);
            this.ParityCmb.TabIndex = 5;
            // 
            // StopBitsCmb
            // 
            this.StopBitsCmb.FormattingEnabled = true;
            this.StopBitsCmb.Items.AddRange(new object[] {
            "None",
            "1",
            "2",
            "1.5"});
            this.StopBitsCmb.Location = new System.Drawing.Point(135, 100);
            this.StopBitsCmb.Name = "StopBitsCmb";
            this.StopBitsCmb.Size = new System.Drawing.Size(121, 28);
            this.StopBitsCmb.TabIndex = 6;
            // 
            // BaudRateCmb
            // 
            this.BaudRateCmb.FormattingEnabled = true;
            this.BaudRateCmb.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.BaudRateCmb.Location = new System.Drawing.Point(135, 36);
            this.BaudRateCmb.Name = "BaudRateCmb";
            this.BaudRateCmb.Size = new System.Drawing.Size(121, 28);
            this.BaudRateCmb.TabIndex = 7;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ClearBtn.AutoSize = true;
            this.ClearBtn.Location = new System.Drawing.Point(54, 381);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 30);
            this.ClearBtn.TabIndex = 3;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // AppendCrCb
            // 
            this.AppendCrCb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AppendCrCb.AutoSize = true;
            this.AppendCrCb.Checked = true;
            this.AppendCrCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AppendCrCb.Location = new System.Drawing.Point(684, 201);
            this.AppendCrCb.Name = "AppendCrCb";
            this.AppendCrCb.Size = new System.Drawing.Size(202, 24);
            this.AppendCrCb.TabIndex = 8;
            this.AppendCrCb.Text = "Append CR character";
            this.AppendCrCb.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Serial Monitor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ComPortTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DataBitsTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.TextBox OutputTb;
        private System.Windows.Forms.TextBox CommandTb;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ParityCmb;
        private System.Windows.Forms.ComboBox StopBitsCmb;
        private System.Windows.Forms.ComboBox BaudRateCmb;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.CheckBox AppendCrCb;
    }
}

