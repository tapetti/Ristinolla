namespace ristinolla
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
            this.Aloita5x5 = new System.Windows.Forms.Button();
            this.Lopeta = new System.Windows.Forms.Button();
            this.Ohje = new System.Windows.Forms.Button();
            this.Aloita3x3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Aloita5x5
            // 
            this.Aloita5x5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Aloita5x5.AutoSize = true;
            this.Aloita5x5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Aloita5x5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aloita5x5.Location = new System.Drawing.Point(36, 130);
            this.Aloita5x5.Name = "Aloita5x5";
            this.Aloita5x5.Size = new System.Drawing.Size(300, 100);
            this.Aloita5x5.TabIndex = 0;
            this.Aloita5x5.Text = "Aloita peli 5x5";
            this.Aloita5x5.UseVisualStyleBackColor = false;
            this.Aloita5x5.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lopeta
            // 
            this.Lopeta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lopeta.AutoSize = true;
            this.Lopeta.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Lopeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lopeta.Location = new System.Drawing.Point(35, 342);
            this.Lopeta.Name = "Lopeta";
            this.Lopeta.Size = new System.Drawing.Size(300, 100);
            this.Lopeta.TabIndex = 1;
            this.Lopeta.Text = "Lopeta";
            this.Lopeta.UseVisualStyleBackColor = false;
            this.Lopeta.Click += new System.EventHandler(this.button2_Click);
            // 
            // Ohje
            // 
            this.Ohje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ohje.AutoSize = true;
            this.Ohje.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Ohje.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ohje.Location = new System.Drawing.Point(36, 236);
            this.Ohje.Name = "Ohje";
            this.Ohje.Size = new System.Drawing.Size(300, 100);
            this.Ohje.TabIndex = 2;
            this.Ohje.Text = "Ohje";
            this.Ohje.UseVisualStyleBackColor = false;
            this.Ohje.Click += new System.EventHandler(this.Ohje_Click);
            // 
            // Aloita3x3
            // 
            this.Aloita3x3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Aloita3x3.AutoSize = true;
            this.Aloita3x3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Aloita3x3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aloita3x3.Location = new System.Drawing.Point(35, 24);
            this.Aloita3x3.Name = "Aloita3x3";
            this.Aloita3x3.Size = new System.Drawing.Size(300, 100);
            this.Aloita3x3.TabIndex = 3;
            this.Aloita3x3.Text = "Aloita peli 3x3";
            this.Aloita3x3.UseVisualStyleBackColor = false;
            this.Aloita3x3.Click += new System.EventHandler(this.Aloita3x3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImage = global::ristinolla.Properties.Resources.blue_background_rectangles_best_1024x576;
            this.ClientSize = new System.Drawing.Size(372, 473);
            this.Controls.Add(this.Aloita3x3);
            this.Controls.Add(this.Ohje);
            this.Controls.Add(this.Lopeta);
            this.Controls.Add(this.Aloita5x5);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.Text = "Ristinolla";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Aloita5x5;
        private System.Windows.Forms.Button Lopeta;
        private System.Windows.Forms.Button Ohje;
        private System.Windows.Forms.Button Aloita3x3;
    }
}

