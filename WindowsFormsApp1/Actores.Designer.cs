namespace WindowsFormsApp1
{
    partial class Actores
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
            this.volver = new System.Windows.Forms.Button();
            this.actoresLB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(195, 44);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(75, 23);
            this.volver.TabIndex = 0;
            this.volver.Text = "volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // actoresLB
            // 
            this.actoresLB.FormattingEnabled = true;
            this.actoresLB.ItemHeight = 16;
            this.actoresLB.Location = new System.Drawing.Point(23, 44);
            this.actoresLB.Name = "actoresLB";
            this.actoresLB.Size = new System.Drawing.Size(120, 84);
            this.actoresLB.TabIndex = 1;
            // 
            // Actores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.actoresLB);
            this.Controls.Add(this.volver);
            this.Name = "Actores";
            this.Text = "Actores";
            this.Load += new System.EventHandler(this.Actores_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button volver;
        private System.Windows.Forms.ListBox actoresLB;
    }
}