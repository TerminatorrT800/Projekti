namespace EkspertniSistem
{
    partial class Master
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Master));
            pitanje = new Button();
            objasnjenje1 = new TextBox();
            uvodbtnforw = new Button();
            uvodbtnback = new Button();
            pitanje1 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            radioButton3 = new RadioButton();
            SuspendLayout();
            // 
            // pitanje
            // 
            pitanje.FlatStyle = FlatStyle.Popup;
            pitanje.Image = Properties.Resources.question_mark;
            pitanje.Location = new Point(1160, 38);
            pitanje.Name = "pitanje";
            pitanje.Size = new Size(75, 77);
            pitanje.TabIndex = 13;
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
            objasnjenje1.TabIndex = 12;
            objasnjenje1.Visible = false;
            // 
            // uvodbtnforw
            // 
            uvodbtnforw.FlatStyle = FlatStyle.Popup;
            uvodbtnforw.Image = Properties.Resources.arrowright;
            uvodbtnforw.Location = new Point(1134, 566);
            uvodbtnforw.Name = "uvodbtnforw";
            uvodbtnforw.Size = new Size(101, 77);
            uvodbtnforw.TabIndex = 11;
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
            uvodbtnback.TabIndex = 10;
            uvodbtnback.UseVisualStyleBackColor = false;
            uvodbtnback.Click += uvodbtnback_Click;
            // 
            // pitanje1
            // 
            pitanje1.Font = new Font("Unispace", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point);
            pitanje1.Location = new Point(190, 53);
            pitanje1.Name = "pitanje1";
            pitanje1.Size = new Size(931, 117);
            pitanje1.TabIndex = 9;
            pitanje1.Text = "Da li vam je važno da li škola pruža master studije?";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Unispace", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.Location = new Point(190, 279);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(52, 27);
            radioButton2.TabIndex = 17;
            radioButton2.TabStop = true;
            radioButton2.Text = "Ne";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Unispace", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.Location = new Point(190, 205);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(52, 27);
            radioButton1.TabIndex = 16;
            radioButton1.TabStop = true;
            radioButton1.Text = "Da";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Unispace", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton3.Location = new Point(190, 355);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(124, 27);
            radioButton3.TabIndex = 18;
            radioButton3.TabStop = true;
            radioButton3.Text = "Svejedno";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // Master
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(pitanje);
            Controls.Add(objasnjenje1);
            Controls.Add(uvodbtnforw);
            Controls.Add(uvodbtnback);
            Controls.Add(pitanje1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1280, 720);
            MinimumSize = new Size(1280, 720);
            Name = "Master";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Master";
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
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton3;
    }
}