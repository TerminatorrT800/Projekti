namespace EkspertniSistem
{
    partial class Uvod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uvod));
            uvodlbl = new Label();
            uvodbtnback = new Button();
            richTextBox1 = new RichTextBox();
            uvodbtnforw = new Button();
            SuspendLayout();
            // 
            // uvodlbl
            // 
            uvodlbl.Font = new Font("Unispace", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point);
            uvodlbl.Location = new Point(190, 60);
            uvodlbl.Margin = new Padding(2, 0, 2, 0);
            uvodlbl.Name = "uvodlbl";
            uvodlbl.Size = new Size(926, 67);
            uvodlbl.TabIndex = 0;
            uvodlbl.Text = "Svrha i Uputstvo za korišćenje programa";
            // 
            // uvodbtnback
            // 
            uvodbtnback.BackColor = SystemColors.Control;
            uvodbtnback.BackgroundImageLayout = ImageLayout.Center;
            uvodbtnback.FlatAppearance.BorderSize = 0;
            uvodbtnback.FlatStyle = FlatStyle.Popup;
            uvodbtnback.Image = Properties.Resources.arrowleft;
            uvodbtnback.Location = new Point(22, 50);
            uvodbtnback.Margin = new Padding(2);
            uvodbtnback.Name = "uvodbtnback";
            uvodbtnback.Size = new Size(100, 77);
            uvodbtnback.TabIndex = 1;
            uvodbtnback.UseVisualStyleBackColor = false;
            uvodbtnback.Click += uvodbtnback_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Unispace", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox1.Location = new Point(190, 207);
            richTextBox1.Margin = new Padding(2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(855, 418);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // uvodbtnforw
            // 
            uvodbtnforw.FlatStyle = FlatStyle.Popup;
            uvodbtnforw.Image = Properties.Resources.arrowright;
            uvodbtnforw.Location = new Point(1126, 578);
            uvodbtnforw.Name = "uvodbtnforw";
            uvodbtnforw.Size = new Size(101, 77);
            uvodbtnforw.TabIndex = 3;
            uvodbtnforw.UseVisualStyleBackColor = true;
            uvodbtnforw.Click += uvodbtnforw_Click;
            // 
            // Uvod
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1264, 681);
            Controls.Add(uvodbtnforw);
            Controls.Add(richTextBox1);
            Controls.Add(uvodbtnback);
            Controls.Add(uvodlbl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximumSize = new Size(1280, 720);
            MinimumSize = new Size(1280, 720);
            Name = "Uvod";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Uvod";
            FormClosed += FormClosedHandler;
            ResumeLayout(false);
        }

        #endregion

        private Label uvodlbl;
        private Button uvodbtnback;
        private RichTextBox richTextBox1;
        private Button uvodbtnforw;
    }
}