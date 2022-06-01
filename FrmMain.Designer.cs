namespace WFA220601
{
    partial class FrmMain
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
            this.btnKoszonj = new System.Windows.Forms.Button();
            this.lblSzoveg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKoszonj
            // 
            this.btnKoszonj.Font = new System.Drawing.Font("Consolas", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKoszonj.ForeColor = System.Drawing.Color.Red;
            this.btnKoszonj.Location = new System.Drawing.Point(13, 111);
            this.btnKoszonj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKoszonj.Name = "btnKoszonj";
            this.btnKoszonj.Size = new System.Drawing.Size(418, 99);
            this.btnKoszonj.TabIndex = 0;
            this.btnKoszonj.Text = "Köszönj!";
            this.btnKoszonj.UseVisualStyleBackColor = true;
            this.btnKoszonj.Click += new System.EventHandler(this.BtnKoszonj_Click);
            // 
            // lblSzoveg
            // 
            this.lblSzoveg.BackColor = System.Drawing.Color.White;
            this.lblSzoveg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSzoveg.ForeColor = System.Drawing.Color.Tomato;
            this.lblSzoveg.Location = new System.Drawing.Point(13, 21);
            this.lblSzoveg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSzoveg.Name = "lblSzoveg";
            this.lblSzoveg.Size = new System.Drawing.Size(418, 67);
            this.lblSzoveg.TabIndex = 1;
            this.lblSzoveg.Text = "###";
            this.lblSzoveg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 224);
            this.Controls.Add(this.lblSzoveg);
            this.Controls.Add(this.btnKoszonj);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "Első programom! <3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKoszonj;
        private System.Windows.Forms.Label lblSzoveg;
    }
}

