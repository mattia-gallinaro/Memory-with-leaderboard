
namespace WindowsFormsApp7
{
    partial class Form3
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
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Classifica_dgv = new System.Windows.Forms.DataGridView();
            this.bakcbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Classifica_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(316, 101);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(126, 29);
            this.label.TabIndex = 0;
            this.label.Text = "Classifica";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "è basata sulle vittorie complessive di ciascun giocatore";
            // 
            // Classifica_dgv
            // 
            this.Classifica_dgv.AllowUserToAddRows = false;
            this.Classifica_dgv.AllowUserToDeleteRows = false;
            this.Classifica_dgv.AllowUserToResizeColumns = false;
            this.Classifica_dgv.AllowUserToResizeRows = false;
            this.Classifica_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Classifica_dgv.Location = new System.Drawing.Point(217, 190);
            this.Classifica_dgv.Name = "Classifica_dgv";
            this.Classifica_dgv.Size = new System.Drawing.Size(334, 150);
            this.Classifica_dgv.TabIndex = 2;
            // 
            // bakcbtn
            // 
            this.bakcbtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bakcbtn.Location = new System.Drawing.Point(241, 355);
            this.bakcbtn.Name = "bakcbtn";
            this.bakcbtn.Size = new System.Drawing.Size(295, 35);
            this.bakcbtn.TabIndex = 3;
            this.bakcbtn.Text = "Torna al menù principale";
            this.bakcbtn.UseVisualStyleBackColor = true;
            this.bakcbtn.Click += new System.EventHandler(this.bakcbtn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bakcbtn);
            this.Controls.Add(this.Classifica_dgv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Classifica_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Classifica_dgv;
        private System.Windows.Forms.Button bakcbtn;
    }
}