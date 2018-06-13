namespace WindowsFormsApp1
{
    partial class Directores
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
            this.salir = new System.Windows.Forms.Button();
            this.directoresLB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(195, 26);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 0;
            this.salir.Text = "salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // directoresLB
            // 
            this.directoresLB.FormattingEnabled = true;
            this.directoresLB.ItemHeight = 16;
            this.directoresLB.Location = new System.Drawing.Point(27, 26);
            this.directoresLB.Name = "directoresLB";
            this.directoresLB.Size = new System.Drawing.Size(120, 84);
            this.directoresLB.TabIndex = 1;
            // 
            // Directores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.directoresLB);
            this.Controls.Add(this.salir);
            this.Name = "Directores";
            this.Text = "Directores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.ListBox directoresLB;
    }
}