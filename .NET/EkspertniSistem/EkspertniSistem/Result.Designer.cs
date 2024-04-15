namespace EkspertniSistem
{
    partial class Result
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Result));
            naslov = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            podnaslov = new Label();
            SuspendLayout();
            // 
            // naslov
            // 
            naslov.Font = new Font("Unispace", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            naslov.Location = new Point(12, 9);
            naslov.Name = "naslov";
            naslov.Size = new Size(1220, 62);
            naslov.TabIndex = 15;
            naslov.Text = "tekst";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(32, 125);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1220, 517);
            flowLayoutPanel1.TabIndex = 16;
            // 
            // podnaslov
            // 
            podnaslov.Location = new Point(46, 69);
            podnaslov.Name = "podnaslov";
            podnaslov.Size = new Size(1186, 42);
            podnaslov.TabIndex = 17;
            // 
            // Result
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1264, 681);
            Controls.Add(podnaslov);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(naslov);
            Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximumSize = new Size(1280, 720);
            MinimumSize = new Size(1280, 720);
            Name = "Result";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rezultat";
            FormClosed += FormClosedHandler;
            Load += Result_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label naslov;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label podnaslov;
    }
}