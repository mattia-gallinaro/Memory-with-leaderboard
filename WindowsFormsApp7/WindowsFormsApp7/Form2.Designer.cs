
namespace WindowsFormsApp7
{
    partial class Form2
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
            this.carta1 = new System.Windows.Forms.PictureBox();
            this.carta2 = new System.Windows.Forms.PictureBox();
            this.carta3 = new System.Windows.Forms.PictureBox();
            this.carta4 = new System.Windows.Forms.PictureBox();
            this.carta5 = new System.Windows.Forms.PictureBox();
            this.carta6 = new System.Windows.Forms.PictureBox();
            this.carta7 = new System.Windows.Forms.PictureBox();
            this.carta8 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta8)).BeginInit();
            this.SuspendLayout();
            // 
            // carta1
            // 
            this.carta1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.carta1.Location = new System.Drawing.Point(51, 27);
            this.carta1.Name = "carta1";
            this.carta1.Size = new System.Drawing.Size(112, 144);
            this.carta1.TabIndex = 0;
            this.carta1.TabStop = false;
            this.carta1.Click += new System.EventHandler(this.carta1_Click);
            // 
            // carta2
            // 
            this.carta2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.carta2.Location = new System.Drawing.Point(199, 27);
            this.carta2.Name = "carta2";
            this.carta2.Size = new System.Drawing.Size(112, 144);
            this.carta2.TabIndex = 1;
            this.carta2.TabStop = false;
            this.carta2.Click += new System.EventHandler(this.carta2_Click);
            // 
            // carta3
            // 
            this.carta3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.carta3.Location = new System.Drawing.Point(347, 27);
            this.carta3.Name = "carta3";
            this.carta3.Size = new System.Drawing.Size(112, 144);
            this.carta3.TabIndex = 2;
            this.carta3.TabStop = false;
            this.carta3.Click += new System.EventHandler(this.carta3_Click);
            // 
            // carta4
            // 
            this.carta4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.carta4.Location = new System.Drawing.Point(491, 27);
            this.carta4.Name = "carta4";
            this.carta4.Size = new System.Drawing.Size(112, 144);
            this.carta4.TabIndex = 3;
            this.carta4.TabStop = false;
            this.carta4.Click += new System.EventHandler(this.carta4_Click);
            // 
            // carta5
            // 
            this.carta5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.carta5.Location = new System.Drawing.Point(51, 198);
            this.carta5.Name = "carta5";
            this.carta5.Size = new System.Drawing.Size(112, 144);
            this.carta5.TabIndex = 4;
            this.carta5.TabStop = false;
            this.carta5.Click += new System.EventHandler(this.carta5_Click);
            // 
            // carta6
            // 
            this.carta6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.carta6.Location = new System.Drawing.Point(199, 198);
            this.carta6.Name = "carta6";
            this.carta6.Size = new System.Drawing.Size(112, 144);
            this.carta6.TabIndex = 5;
            this.carta6.TabStop = false;
            this.carta6.Click += new System.EventHandler(this.carta6_Click);
            // 
            // carta7
            // 
            this.carta7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.carta7.Location = new System.Drawing.Point(347, 198);
            this.carta7.Name = "carta7";
            this.carta7.Size = new System.Drawing.Size(112, 144);
            this.carta7.TabIndex = 6;
            this.carta7.TabStop = false;
            this.carta7.Click += new System.EventHandler(this.carta7_Click);
            // 
            // carta8
            // 
            this.carta8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.carta8.Location = new System.Drawing.Point(491, 198);
            this.carta8.Name = "carta8";
            this.carta8.Size = new System.Drawing.Size(112, 144);
            this.carta8.TabIndex = 10;
            this.carta8.TabStop = false;
            this.carta8.Click += new System.EventHandler(this.carta8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(652, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "E\' il turno di:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(953, 389);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carta8);
            this.Controls.Add(this.carta7);
            this.Controls.Add(this.carta6);
            this.Controls.Add(this.carta5);
            this.Controls.Add(this.carta4);
            this.Controls.Add(this.carta3);
            this.Controls.Add(this.carta2);
            this.Controls.Add(this.carta1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox carta1;
        private System.Windows.Forms.PictureBox carta2;
        private System.Windows.Forms.PictureBox carta3;
        private System.Windows.Forms.PictureBox carta4;
        private System.Windows.Forms.PictureBox carta5;
        private System.Windows.Forms.PictureBox carta6;
        private System.Windows.Forms.PictureBox carta7;
        private System.Windows.Forms.PictureBox carta8;
        private System.Windows.Forms.Label label1;
    }
}