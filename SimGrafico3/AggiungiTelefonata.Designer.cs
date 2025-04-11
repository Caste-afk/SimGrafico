namespace SimGrafico
{
    partial class AggiungiTelefonata
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
            lbl_titolo = new Label();
            lbl_numero = new Label();
            lbl_durata = new Label();
            tbx_numero = new TextBox();
            btn_aggiungi = new Button();
            btn_annulla = new Button();
            dtp_durata = new DateTimePicker();
            SuspendLayout();
            // 
            // lbl_titolo
            // 
            lbl_titolo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_titolo.Location = new Point(-1, 0);
            lbl_titolo.Name = "lbl_titolo";
            lbl_titolo.Size = new Size(383, 36);
            lbl_titolo.TabIndex = 0;
            lbl_titolo.Text = "Aggiungi telefonata";
            lbl_titolo.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_numero
            // 
            lbl_numero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_numero.Location = new Point(12, 62);
            lbl_numero.Name = "lbl_numero";
            lbl_numero.Size = new Size(141, 36);
            lbl_numero.TabIndex = 1;
            lbl_numero.Text = "Numero chiamato";
            // 
            // lbl_durata
            // 
            lbl_durata.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_durata.Location = new Point(12, 98);
            lbl_durata.Name = "lbl_durata";
            lbl_durata.Size = new Size(169, 36);
            lbl_durata.TabIndex = 2;
            lbl_durata.Text = "Durata della chiamata";
            // 
            // tbx_numero
            // 
            tbx_numero.Location = new Point(212, 62);
            tbx_numero.Name = "tbx_numero";
            tbx_numero.Size = new Size(159, 23);
            tbx_numero.TabIndex = 3;
            tbx_numero.KeyPress += tbx_numero_KeyPressed;
            // 
            // btn_aggiungi
            // 
            btn_aggiungi.Location = new Point(45, 137);
            btn_aggiungi.Name = "btn_aggiungi";
            btn_aggiungi.Size = new Size(127, 31);
            btn_aggiungi.TabIndex = 5;
            btn_aggiungi.Text = "Aggiungi";
            btn_aggiungi.UseVisualStyleBackColor = true;
            btn_aggiungi.Click += button1_Click;
            // 
            // btn_annulla
            // 
            btn_annulla.Location = new Point(212, 137);
            btn_annulla.Name = "btn_annulla";
            btn_annulla.Size = new Size(127, 31);
            btn_annulla.TabIndex = 7;
            btn_annulla.Text = "Annulla";
            btn_annulla.UseVisualStyleBackColor = true;
            btn_annulla.Click += btn_annulla_Click;
            // 
            // dtp_durata
            // 
            dtp_durata.CustomFormat = "HH:mm:ss";
            dtp_durata.Format = DateTimePickerFormat.Custom;
            dtp_durata.Location = new Point(226, 98);
            dtp_durata.Name = "dtp_durata";
            dtp_durata.RightToLeft = RightToLeft.No;
            dtp_durata.ShowUpDown = true;
            dtp_durata.Size = new Size(130, 23);
            dtp_durata.TabIndex = 8;
            dtp_durata.Value = new DateTime(2025, 4, 11, 0, 0, 0, 0);
            // 
            // AggiungiTelefonata
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 191);
            Controls.Add(dtp_durata);
            Controls.Add(btn_annulla);
            Controls.Add(btn_aggiungi);
            Controls.Add(tbx_numero);
            Controls.Add(lbl_durata);
            Controls.Add(lbl_numero);
            Controls.Add(lbl_titolo);
            Name = "AggiungiTelefonata";
            Text = "AggiungiTelefonata";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_titolo;
        private Label lbl_numero;
        private Label lbl_durata;
        private TextBox tbx_numero;
        private DateTimePicker dateTimePicker1;
        private Button btn_aggiungi;
        private Button btn_annulla;
        private DateTimePicker dtp_durata;
    }
}