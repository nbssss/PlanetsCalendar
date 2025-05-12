namespace astro_app
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnMercury = new System.Windows.Forms.Button();
            this.btnVenus = new System.Windows.Forms.Button();
            this.btnEarth = new System.Windows.Forms.Button();
            this.btnMars = new System.Windows.Forms.Button();
            this.btnJupiter = new System.Windows.Forms.Button();
            this.btnSaturn = new System.Windows.Forms.Button();
            this.btnUranus = new System.Windows.Forms.Button();
            this.btnNeptune = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.AutoSize = true;
            this.panelMain.Location = new System.Drawing.Point(92, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(490, 346);
            this.panelMain.TabIndex = 3;
            // 
            // btnMercury
            // 
            this.btnMercury.Location = new System.Drawing.Point(6, 12);
            this.btnMercury.Name = "btnMercury";
            this.btnMercury.Size = new System.Drawing.Size(80, 38);
            this.btnMercury.TabIndex = 4;
            this.btnMercury.Text = "Mercury";
            this.btnMercury.UseVisualStyleBackColor = true;
            this.btnMercury.Click += new System.EventHandler(this.planetBtn_Click);
            // 
            // btnVenus
            // 
            this.btnVenus.Location = new System.Drawing.Point(6, 56);
            this.btnVenus.Name = "btnVenus";
            this.btnVenus.Size = new System.Drawing.Size(80, 38);
            this.btnVenus.TabIndex = 5;
            this.btnVenus.Text = "Venus";
            this.btnVenus.UseVisualStyleBackColor = true;
            this.btnVenus.Click += new System.EventHandler(this.planetBtn_Click);
            // 
            // btnEarth
            // 
            this.btnEarth.Location = new System.Drawing.Point(6, 100);
            this.btnEarth.Name = "btnEarth";
            this.btnEarth.Size = new System.Drawing.Size(80, 38);
            this.btnEarth.TabIndex = 6;
            this.btnEarth.Text = "Earth";
            this.btnEarth.UseVisualStyleBackColor = true;
            this.btnEarth.Click += new System.EventHandler(this.planetBtn_Click);
            // 
            // btnMars
            // 
            this.btnMars.Location = new System.Drawing.Point(6, 144);
            this.btnMars.Name = "btnMars";
            this.btnMars.Size = new System.Drawing.Size(80, 38);
            this.btnMars.TabIndex = 7;
            this.btnMars.Text = "Mars";
            this.btnMars.UseVisualStyleBackColor = true;
            this.btnMars.Click += new System.EventHandler(this.planetBtn_Click);
            // 
            // btnJupiter
            // 
            this.btnJupiter.Location = new System.Drawing.Point(6, 188);
            this.btnJupiter.Name = "btnJupiter";
            this.btnJupiter.Size = new System.Drawing.Size(80, 38);
            this.btnJupiter.TabIndex = 8;
            this.btnJupiter.Text = "Jupiter";
            this.btnJupiter.UseVisualStyleBackColor = true;
            this.btnJupiter.Click += new System.EventHandler(this.planetBtn_Click);
            // 
            // btnSaturn
            // 
            this.btnSaturn.Location = new System.Drawing.Point(6, 232);
            this.btnSaturn.Name = "btnSaturn";
            this.btnSaturn.Size = new System.Drawing.Size(80, 38);
            this.btnSaturn.TabIndex = 9;
            this.btnSaturn.Text = "Saturn";
            this.btnSaturn.UseVisualStyleBackColor = true;
            this.btnSaturn.Click += new System.EventHandler(this.planetBtn_Click);
            // 
            // btnUranus
            // 
            this.btnUranus.Location = new System.Drawing.Point(6, 276);
            this.btnUranus.Name = "btnUranus";
            this.btnUranus.Size = new System.Drawing.Size(80, 38);
            this.btnUranus.TabIndex = 10;
            this.btnUranus.Text = "Uranus";
            this.btnUranus.UseVisualStyleBackColor = true;
            this.btnUranus.Click += new System.EventHandler(this.planetBtn_Click);
            // 
            // btnNeptune
            // 
            this.btnNeptune.Location = new System.Drawing.Point(6, 320);
            this.btnNeptune.Name = "btnNeptune";
            this.btnNeptune.Size = new System.Drawing.Size(80, 38);
            this.btnNeptune.TabIndex = 11;
            this.btnNeptune.Text = "Neptune";
            this.btnNeptune.UseVisualStyleBackColor = true;
            this.btnNeptune.Click += new System.EventHandler(this.planetBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(593, 371);
            this.Controls.Add(this.btnNeptune);
            this.Controls.Add(this.btnUranus);
            this.Controls.Add(this.btnSaturn);
            this.Controls.Add(this.btnJupiter);
            this.Controls.Add(this.btnMars);
            this.Controls.Add(this.btnEarth);
            this.Controls.Add(this.btnVenus);
            this.Controls.Add(this.btnMercury);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "Planet Calendar";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnMercury;
        private System.Windows.Forms.Button btnVenus;
        private System.Windows.Forms.Button btnEarth;
        private System.Windows.Forms.Button btnMars;
        private System.Windows.Forms.Button btnJupiter;
        private System.Windows.Forms.Button btnSaturn;
        private System.Windows.Forms.Button btnUranus;
        private System.Windows.Forms.Button btnNeptune;
    }
}

