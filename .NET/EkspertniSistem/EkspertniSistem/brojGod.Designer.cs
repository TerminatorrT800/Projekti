namespace EkspertniSistem
{
    partial class brojGod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(brojGod));
            pitanje = new Button();
            objasnjenje1 = new TextBox();
            uvodbtnforw = new Button();
            uvodbtnback = new Button();
            pitanje1 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // pitanje
            // 
            pitanje.FlatStyle = FlatStyle.Popup;
            pitanje.Image = Properties.Resources.question_mark;
            pitanje.Location = new Point(1160, 38);
            pitanje.Name = "pitanje";
            pitanje.Size = new Size(75, 77);
            pitanje.TabIndex = 21;
            pitanje.UseVisualStyleBackColor = true;
            pitanje.Click += pitanje_Click;
            // 
            // objasnjenje1
            // 
            objasnjenje1.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            objasnjenje1.Location = new Point(30, 471);
            objasnjenje1.Multiline = true;
            objasnjenje1.Name = "objasnjenje1";
            objasnjenje1.ReadOnly = true;
            objasnjenje1.Size = new Size(1014, 172);
            objasnjenje1.TabIndex = 20;
            objasnjenje1.Visible = false;
            // 
            // uvodbtnforw
            // 
            uvodbtnforw.FlatStyle = FlatStyle.Popup;
            uvodbtnforw.Image = Properties.Resources.arrowright;
            uvodbtnforw.Location = new Point(1134, 566);
            uvodbtnforw.Name = "uvodbtnforw";
            uvodbtnforw.Size = new Size(101, 77);
            uvodbtnforw.TabIndex = 19;
            uvodbtnforw.UseVisualStyleBackColor = true;
            uvodbtnforw.Click += uvodbtnforw_Click;
            // 
            // uvodbtnback
            // 
            uvodbtnback.BackColor = SystemColors.Control;
            uvodbtnback.BackgroundImageLayout = ImageLayout.Center;
            uvodbtnback.FlatAppearance.BorderSize = 0;
            uvodbtnback.FlatStyle = FlatStyle.Popup;
            uvodbtnback.Image = Properties.Resources.arrowleft;
            uvodbtnback.Location = new Point(30, 38);
            uvodbtnback.Margin = new Padding(2);
            uvodbtnback.Name = "uvodbtnback";
            uvodbtnback.Size = new Size(100, 77);
            uvodbtnback.TabIndex = 18;
            uvodbtnback.UseVisualStyleBackColor = false;
            uvodbtnback.Click += uvodbtnback_Click;
            // 
            // pitanje1
            // 
            pitanje1.Font = new Font("Unispace", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point);
            pitanje1.Location = new Point(190, 53);
            pitanje1.Name = "pitanje1";
            pitanje1.Size = new Size(919, 99);
            pitanje1.TabIndex = 17;
            pitanje1.Text = "Odaberite broj godina studiranja.";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(209, 183);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(248, 27);
            comboBox1.TabIndex = 22;
            // 
            // brojGod
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(comboBox1);
            Controls.Add(pitanje);
            Controls.Add(objasnjenje1);
            Controls.Add(uvodbtnforw);
            Controls.Add(uvodbtnback);
            Controls.Add(pitanje1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1280, 720);
            MinimumSize = new Size(1280, 720);
            Name = "brojGod";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Godine studiranja";
            FormClosed += FormClosedHandler;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button pitanje;
        private TextBox objasnjenje1;
        private Button uvodbtnforw;
        private Button uvodbtnback;
        private Label pitanje1;
        private ComboBox comboBox1;
    }
}