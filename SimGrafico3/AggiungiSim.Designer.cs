namespace SimGrafico
{
    partial class AggiungiSim
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
            tbx_numero = new TextBox();
            tbx_credito = new TextBox();
            lbl_numero = new Label();
            lbl_credito = new Label();
            btn_aggiungi = new Button();
            btn_annulla = new Button();
            SuspendLayout();
            // 
            // tbx_numero
            // 
            tbx_numero.Location = new Point(130, 45);
            tbx_numero.Name = "tbx_numero";
            tbx_numero.Size = new Size(159, 23);
            tbx_numero.TabIndex = 0;
            tbx_numero.KeyPress += tbx_numero_KeyPressed;
            // 
            // tbx_credito
            // 
            tbx_credito.Location = new Point(130, 113);
            tbx_credito.Name = "tbx_credito";
            tbx_credito.Size = new Size(159, 23);
            tbx_credito.TabIndex = 1;
            tbx_credito.KeyPress += tbx_credito_KeyPressed;
            // 
            // lbl_numero
            // 
            lbl_numero.Location = new Point(12, 48);
            lbl_numero.Name = "lbl_numero";
            lbl_numero.Size = new Size(100, 23);
            lbl_numero.TabIndex = 2;
            lbl_numero.Text = "numero della sim";
            // 
            // lbl_credito
            // 
            lbl_credito.Location = new Point(12, 116);
            lbl_credito.Name = "lbl_credito";
            lbl_credito.Size = new Size(100, 23);
            lbl_credito.TabIndex = 3;
            lbl_credito.Text = "credito";
            // 
            // btn_aggiungi
            // 
            btn_aggiungi.Location = new Point(29, 161);
            btn_aggiungi.Name = "btn_aggiungi";
            btn_aggiungi.Size = new Size(118, 23);
            btn_aggiungi.TabIndex = 4;
            btn_aggiungi.Text = "Aggiungi";
            btn_aggiungi.UseVisualStyleBackColor = true;
            btn_aggiungi.Click += btn_aggiungi_Click;
            // 
            // btn_annulla
            // 
            btn_annulla.Location = new Point(153, 161);
            btn_annulla.Name = "btn_annulla";
            btn_annulla.Size = new Size(118, 23);
            btn_annulla.TabIndex = 5;
            btn_annulla.Text = "Annulla";
            btn_annulla.UseVisualStyleBackColor = true;
            btn_annulla.Click += btn_annulla_Click;
            // 
            // AggiungiSim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 196);
            Controls.Add(btn_annulla);
            Controls.Add(btn_aggiungi);
            Controls.Add(lbl_credito);
            Controls.Add(lbl_numero);
            Controls.Add(tbx_credito);
            Controls.Add(tbx_numero);
            Name = "AggiungiSim";
            Text = "AggiungiSim";
            Load += AggiungiSim_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbx_numero;
        private TextBox tbx_credito;
        private Label lbl_numero;
        private Label lbl_credito;
        private Button btn_aggiungi;
        private Button btn_annulla;
    }
}