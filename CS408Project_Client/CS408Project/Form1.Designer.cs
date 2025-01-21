namespace CS408Project
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
            this.iptextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usernametextbox = new System.Windows.Forms.TextBox();
            this.ff = new System.Windows.Forms.Label();
            this.if100button = new System.Windows.Forms.Button();
            this.sps101button = new System.Windows.Forms.Button();
            this.if100richtextbox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sps101richtextbox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.messagerichtextbox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sendtoifbutton = new System.Windows.Forms.Button();
            this.porttextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sendtospsbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // iptextbox
            // 
            this.iptextbox.Location = new System.Drawing.Point(60, 55);
            this.iptextbox.Name = "iptextbox";
            this.iptextbox.Size = new System.Drawing.Size(168, 20);
            this.iptextbox.TabIndex = 0;
            this.iptextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // usernametextbox
            // 
            this.usernametextbox.Location = new System.Drawing.Point(60, 128);
            this.usernametextbox.Name = "usernametextbox";
            this.usernametextbox.Size = new System.Drawing.Size(168, 20);
            this.usernametextbox.TabIndex = 4;
            // 
            // ff
            // 
            this.ff.AutoSize = true;
            this.ff.Location = new System.Drawing.Point(16, 131);
            this.ff.Name = "ff";
            this.ff.Size = new System.Drawing.Size(38, 13);
            this.ff.TabIndex = 5;
            this.ff.Text = "Name:";
            // 
            // if100button
            // 
            this.if100button.Location = new System.Drawing.Point(60, 185);
            this.if100button.Name = "if100button";
            this.if100button.Size = new System.Drawing.Size(75, 23);
            this.if100button.TabIndex = 6;
            this.if100button.Text = "IF100";
            this.if100button.UseVisualStyleBackColor = true;
            this.if100button.Click += new System.EventHandler(this.if100button_Click);
            // 
            // sps101button
            // 
            this.sps101button.Location = new System.Drawing.Point(153, 185);
            this.sps101button.Name = "sps101button";
            this.sps101button.Size = new System.Drawing.Size(75, 23);
            this.sps101button.TabIndex = 7;
            this.sps101button.Text = "SPS101";
            this.sps101button.UseVisualStyleBackColor = true;
            this.sps101button.Click += new System.EventHandler(this.sps101button_Click);
            // 
            // if100richtextbox
            // 
            this.if100richtextbox.Location = new System.Drawing.Point(307, 35);
            this.if100richtextbox.Name = "if100richtextbox";
            this.if100richtextbox.Size = new System.Drawing.Size(409, 218);
            this.if100richtextbox.TabIndex = 8;
            this.if100richtextbox.Text = "";
            this.if100richtextbox.TextChanged += new System.EventHandler(this.if100richtextbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "IF100 Channel";
            // 
            // sps101richtextbox
            // 
            this.sps101richtextbox.Location = new System.Drawing.Point(307, 319);
            this.sps101richtextbox.Name = "sps101richtextbox";
            this.sps101richtextbox.Size = new System.Drawing.Size(409, 223);
            this.sps101richtextbox.TabIndex = 10;
            this.sps101richtextbox.Text = "";
            this.sps101richtextbox.TextChanged += new System.EventHandler(this.sps101richtextbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "SPS101 Channel";
            // 
            // messagerichtextbox
            // 
            this.messagerichtextbox.Location = new System.Drawing.Point(19, 362);
            this.messagerichtextbox.Name = "messagerichtextbox";
            this.messagerichtextbox.Size = new System.Drawing.Size(233, 83);
            this.messagerichtextbox.TabIndex = 12;
            this.messagerichtextbox.Text = "";
            this.messagerichtextbox.TextChanged += new System.EventHandler(this.messagerichtextbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Message:";
            // 
            // sendtoifbutton
            // 
            this.sendtoifbutton.Location = new System.Drawing.Point(19, 470);
            this.sendtoifbutton.Name = "sendtoifbutton";
            this.sendtoifbutton.Size = new System.Drawing.Size(103, 23);
            this.sendtoifbutton.TabIndex = 14;
            this.sendtoifbutton.Text = "Send to IF100";
            this.sendtoifbutton.UseVisualStyleBackColor = true;
            this.sendtoifbutton.Click += new System.EventHandler(this.sendtoifbutton_Click);
            // 
            // porttextbox
            // 
            this.porttextbox.Location = new System.Drawing.Point(60, 93);
            this.porttextbox.Name = "porttextbox";
            this.porttextbox.Size = new System.Drawing.Size(168, 20);
            this.porttextbox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Port:";
            // 
            // sendtospsbutton
            // 
            this.sendtospsbutton.Location = new System.Drawing.Point(138, 470);
            this.sendtospsbutton.Name = "sendtospsbutton";
            this.sendtospsbutton.Size = new System.Drawing.Size(114, 23);
            this.sendtospsbutton.TabIndex = 17;
            this.sendtospsbutton.Text = "Send to SPS101";
            this.sendtospsbutton.UseVisualStyleBackColor = true;
            this.sendtospsbutton.Click += new System.EventHandler(this.sendtospsbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 589);
            this.Controls.Add(this.sendtospsbutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.porttextbox);
            this.Controls.Add(this.sendtoifbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.messagerichtextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sps101richtextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.if100richtextbox);
            this.Controls.Add(this.sps101button);
            this.Controls.Add(this.if100button);
            this.Controls.Add(this.ff);
            this.Controls.Add(this.usernametextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iptextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox iptextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernametextbox;
        private System.Windows.Forms.Label ff;
        private System.Windows.Forms.Button if100button;
        private System.Windows.Forms.Button sps101button;
        private System.Windows.Forms.RichTextBox if100richtextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox sps101richtextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox messagerichtextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sendtoifbutton;
        private System.Windows.Forms.TextBox porttextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button sendtospsbutton;

    }
}

