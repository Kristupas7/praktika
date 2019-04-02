namespace uzduotis2
{
    partial class l
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
            this.IPadressLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ConnectionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OutcomingMessageTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IncomingMessageTextBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IPadressLabel
            // 
            this.IPadressLabel.AutoSize = true;
            this.IPadressLabel.Location = new System.Drawing.Point(34, 49);
            this.IPadressLabel.Name = "IPadressLabel";
            this.IPadressLabel.Size = new System.Drawing.Size(52, 13);
            this.IPadressLabel.TabIndex = 0;
            this.IPadressLabel.Text = "IP Adress";
            this.IPadressLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 20);
            this.textBox1.TabIndex = 1;
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(34, 102);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(26, 13);
            this.PortLabel.TabIndex = 2;
            this.PortLabel.Text = "Port";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(223, 20);
            this.textBox2.TabIndex = 3;
            // 
            // ConnectionButton
            // 
            this.ConnectionButton.Location = new System.Drawing.Point(416, 102);
            this.ConnectionButton.Name = "ConnectionButton";
            this.ConnectionButton.Size = new System.Drawing.Size(107, 20);
            this.ConnectionButton.TabIndex = 4;
            this.ConnectionButton.Text = "Connect";
            this.ConnectionButton.UseVisualStyleBackColor = true;
            this.ConnectionButton.Click += new System.EventHandler(this.ConnectionButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Outcoming message";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // OutcomingMessageTextBox
            // 
            this.OutcomingMessageTextBox.Location = new System.Drawing.Point(37, 166);
            this.OutcomingMessageTextBox.Multiline = true;
            this.OutcomingMessageTextBox.Name = "OutcomingMessageTextBox";
            this.OutcomingMessageTextBox.Size = new System.Drawing.Size(311, 51);
            this.OutcomingMessageTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Incoming message";
            // 
            // IncomingMessageTextBox
            // 
            this.IncomingMessageTextBox.Location = new System.Drawing.Point(37, 264);
            this.IncomingMessageTextBox.Multiline = true;
            this.IncomingMessageTextBox.Name = "IncomingMessageTextBox";
            this.IncomingMessageTextBox.Size = new System.Drawing.Size(311, 51);
            this.IncomingMessageTextBox.TabIndex = 8;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(416, 166);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(107, 20);
            this.SendButton.TabIndex = 9;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // l
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 353);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.IncomingMessageTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OutcomingMessageTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConnectionButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.IPadressLabel);
            this.Name = "l";
            this.Text = "t";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IPadressLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ConnectionButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OutcomingMessageTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IncomingMessageTextBox;
        private System.Windows.Forms.Button SendButton;
    }
}

