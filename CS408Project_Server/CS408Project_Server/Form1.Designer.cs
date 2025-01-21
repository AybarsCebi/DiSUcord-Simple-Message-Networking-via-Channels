namespace CS408Project_Server
{
    partial class Form1
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
            this.allclientsrichtextbox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.if100clientsrichtextbox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sps101clientsrichtextbox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.allactionsrichtextbox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.porttextbox = new System.Windows.Forms.TextBox();
            this.connectbutton = new System.Windows.Forms.Button();
            this.disconnectbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // allclientsrichtextbox
            // 
            this.allclientsrichtextbox.Location = new System.Drawing.Point(30, 351);
            this.allclientsrichtextbox.Name = "allclientsrichtextbox";
            this.allclientsrichtextbox.Size = new System.Drawing.Size(188, 240);
            this.allclientsrichtextbox.TabIndex = 0;
            this.allclientsrichtextbox.Text = "";
            this.allclientsrichtextbox.TextChanged += new System.EventHandler(this.allclientsrichtextbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connected Clients";
            // 
            // if100clientsrichtextbox
            // 
            this.if100clientsrichtextbox.Location = new System.Drawing.Point(244, 351);
            this.if100clientsrichtextbox.Name = "if100clientsrichtextbox";
            this.if100clientsrichtextbox.Size = new System.Drawing.Size(190, 240);
            this.if100clientsrichtextbox.TabIndex = 2;
            this.if100clientsrichtextbox.Text = "";
            this.if100clientsrichtextbox.TextChanged += new System.EventHandler(this.if100clientsrichtextbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "IF 100 Clients";
            // 
            // sps101clientsrichtextbox
            // 
            this.sps101clientsrichtextbox.Location = new System.Drawing.Point(460, 351);
            this.sps101clientsrichtextbox.Name = "sps101clientsrichtextbox";
            this.sps101clientsrichtextbox.Size = new System.Drawing.Size(184, 240);
            this.sps101clientsrichtextbox.TabIndex = 4;
            this.sps101clientsrichtextbox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "SPS 101 Clients";
            // 
            // allactionsrichtextbox
            // 
            this.allactionsrichtextbox.Location = new System.Drawing.Point(30, 115);
            this.allactionsrichtextbox.Name = "allactionsrichtextbox";
            this.allactionsrichtextbox.Size = new System.Drawing.Size(614, 194);
            this.allactionsrichtextbox.TabIndex = 6;
            this.allactionsrichtextbox.Text = "";
            this.allactionsrichtextbox.TextChanged += new System.EventHandler(this.allactionsrichtextbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "All Action in the Server";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Port:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // porttextbox
            // 
            this.porttextbox.Location = new System.Drawing.Point(68, 25);
            this.porttextbox.Name = "porttextbox";
            this.porttextbox.Size = new System.Drawing.Size(122, 20);
            this.porttextbox.TabIndex = 9;
            this.porttextbox.TextChanged += new System.EventHandler(this.porttextbox_TextChanged);
            // 
            // connectbutton
            // 
            this.connectbutton.Location = new System.Drawing.Point(244, 23);
            this.connectbutton.Name = "connectbutton";
            this.connectbutton.Size = new System.Drawing.Size(75, 23);
            this.connectbutton.TabIndex = 10;
            this.connectbutton.Text = "Connect";
            this.connectbutton.UseVisualStyleBackColor = true;
            this.connectbutton.Click += new System.EventHandler(this.connectbutton_Click);
            // 
            // disconnectbutton
            // 
            this.disconnectbutton.Location = new System.Drawing.Point(336, 23);
            this.disconnectbutton.Name = "disconnectbutton";
            this.disconnectbutton.Size = new System.Drawing.Size(75, 23);
            this.disconnectbutton.TabIndex = 11;
            this.disconnectbutton.Text = "Disconnect";
            this.disconnectbutton.UseVisualStyleBackColor = true;
            this.disconnectbutton.Click += new System.EventHandler(this.disconnectbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 635);
            this.Controls.Add(this.disconnectbutton);
            this.Controls.Add(this.connectbutton);
            this.Controls.Add(this.porttextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.allactionsrichtextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sps101clientsrichtextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.if100clientsrichtextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.allclientsrichtextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox allclientsrichtextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox if100clientsrichtextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox sps101clientsrichtextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox allactionsrichtextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox porttextbox;
        private System.Windows.Forms.Button connectbutton;
        private System.Windows.Forms.Button disconnectbutton;
    }
}

