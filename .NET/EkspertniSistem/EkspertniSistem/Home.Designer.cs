namespace EkspertniSistem
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            fontDialog1 = new FontDialog();
            logo = new PictureBox();
            pocetakBtn = new Button();
            naslov = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // logo
            // 
            logo.ImageLocation = "img/logo.png";
            logo.Location = new Point(499, 194);
            logo.Name = "logo";
            logo.Size = new Size(300, 300);
            logo.SizeMode = PictureBoxSizeMode.CenterImage;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // pocetakBtn
            // 
            pocetakBtn.Font = new Font("Unispace", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            pocetakBtn.Location = new Point(544, 517);
            pocetakBtn.Margin = new Padding(2);
            pocetakBtn.Name = "pocetakBtn";
            pocetakBtn.Size = new Size(213, 57);
            pocetakBtn.TabIndex = 1;
            pocetakBtn.Text = "Započni";
            pocetakBtn.UseVisualStyleBackColor = true;
            pocetakBtn.Click += pocetakBtn_Click;
            // 
            // naslov
            // 
            naslov.Font = new Font("Unispace", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            naslov.Location = new Point(188, 46);
            naslov.Margin = new Padding(2, 0, 2, 0);
            naslov.Name = "naslov";
            naslov.Size = new Size(841, 145);
            naslov.TabIndex = 2;
            naslov.Text = "Tragač Škola";
            naslov.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "img/book.png";
            pictureBox1.Location = new Point(306, 194);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.ImageLocation = "img/kapacrna.png";
            pictureBox2.Location = new Point(285, 371);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.ImageLocation = "img/kapa.png";
            pictureBox3.Location = new Point(929, 168);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 100);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.ImageLocation = "img/openbook.png";
            pictureBox4.Location = new Point(909, 394);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 100);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // Home
            // 
            AccessibleDescription = "";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(naslov);
            Controls.Add(pocetakBtn);
            Controls.Add(logo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1280, 720);
            MinimumSize = new Size(1280, 720);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tragac skola";
            FormClosed += FormClosedHandler;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FontDialog fontDialog1;
        private PictureBox logo;
        private Button pocetakBtn;
        private Label naslov;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}