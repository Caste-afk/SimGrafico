namespace SimGrafico
{
    partial class Ricarica
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
            lbl_cattuale = new Label();
            label1 = new Label();
            nud_credito = new NumericUpDown();
            btn_aggiungi = new Button();
            btn_annulla = new Button();
            ((System.ComponentModel.ISupportInitialize)nud_credito).BeginInit();
            SuspendLayout();
            // 
            // lbl_cattuale
            // 
            lbl_cattuale.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_cattuale.Location = new Point(41, 19);
            lbl_cattuale.Name = "lbl_cattuale";
            lbl_cattuale.Size = new Size(388, 40);
            lbl_cattuale.TabIndex = 0;
            lbl_cattuale.Text = "Ricarica Credito";
            lbl_cattuale.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 70);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 1;
            label1.Text = "Credito da aggiungere";
            // 
            // nud_credito
            // 
            nud_credito.DecimalPlaces = 2;
            nud_credito.Location = new Point(283, 62);
            nud_credito.Name = "nud_credito";
            nud_credito.Size = new Size(120, 23);
            nud_credito.TabIndex = 2;
            // 
            // btn_aggiungi
            // 
            btn_aggiungi.Location = new Point(72, 118);
            btn_aggiungi.Name = "btn_aggiungi";
            btn_aggiungi.Size = new Size(128, 23);
            btn_aggiungi.TabIndex = 3;
            btn_aggiungi.Text = "Aggiungi credito";
            btn_aggiungi.UseVisualStyleBackColor = true;
            btn_aggiungi.Click += btn_aggiungi_Click;
            // 
            // btn_annulla
            // 
            btn_annulla.Location = new Point(275, 118);
            btn_annulla.Name = "btn_annulla";
            btn_annulla.Size = new Size(128, 23);
            btn_annulla.TabIndex = 4;
            btn_annulla.Text = "Annulla";
            btn_annulla.UseVisualStyleBackColor = true;
            btn_annulla.Click += btn_annulla_Click;
            // 
            // Ricarica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 161);
            Controls.Add(btn_annulla);
            Controls.Add(btn_aggiungi);
            Controls.Add(nud_credito);
            Controls.Add(label1);
            Controls.Add(lbl_cattuale);
            Name = "Ricarica";
            Text = "Ricarica";
            ((System.ComponentModel.ISupportInitialize)nud_credito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_cattuale;
        private Label label1;
        private NumericUpDown nud_credito;
        private Button btn_aggiungi;
        private Button btn_annulla;
    }
}