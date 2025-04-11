namespace SimGrafico
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_ricarica = new Button();
            btn_durata = new Button();
            btn_agg = new Button();
            btn_info = new Button();
            lbl_numero = new Label();
            lbl_credito = new Label();
            SuspendLayout();
            // 
            // btn_ricarica
            // 
            btn_ricarica.Location = new Point(550, 171);
            btn_ricarica.Name = "btn_ricarica";
            btn_ricarica.Size = new Size(160, 35);
            btn_ricarica.TabIndex = 3;
            btn_ricarica.Text = "Ricarica Sim";
            btn_ricarica.UseVisualStyleBackColor = true;
            btn_ricarica.Click += btn_ricarica_Click;
            // 
            // btn_durata
            // 
            btn_durata.Location = new Point(317, 302);
            btn_durata.Name = "btn_durata";
            btn_durata.Size = new Size(160, 35);
            btn_durata.TabIndex = 5;
            btn_durata.Text = "Durata Telefonata";
            btn_durata.UseVisualStyleBackColor = true;
            // 
            // btn_agg
            // 
            btn_agg.Location = new Point(117, 302);
            btn_agg.Name = "btn_agg";
            btn_agg.Size = new Size(160, 35);
            btn_agg.TabIndex = 4;
            btn_agg.Text = "Aggiungi Telefonata";
            btn_agg.UseVisualStyleBackColor = true;
            btn_agg.Click += btn_agg_Click;
            // 
            // btn_info
            // 
            btn_info.Location = new Point(514, 302);
            btn_info.Name = "btn_info";
            btn_info.Size = new Size(160, 35);
            btn_info.TabIndex = 6;
            btn_info.Text = "Info";
            btn_info.UseVisualStyleBackColor = true;
            // 
            // lbl_numero
            // 
            lbl_numero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_numero.Location = new Point(51, 121);
            lbl_numero.Name = "lbl_numero";
            lbl_numero.Size = new Size(226, 23);
            lbl_numero.TabIndex = 7;
            lbl_numero.Text = "Numero sim:  ";
            // 
            // lbl_credito
            // 
            lbl_credito.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_credito.Location = new Point(51, 176);
            lbl_credito.Name = "lbl_credito";
            lbl_credito.Size = new Size(226, 23);
            lbl_credito.TabIndex = 8;
            lbl_credito.Text = "Credito della sim: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 423);
            Controls.Add(lbl_credito);
            Controls.Add(lbl_numero);
            Controls.Add(btn_info);
            Controls.Add(btn_durata);
            Controls.Add(btn_agg);
            Controls.Add(btn_ricarica);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button btn_ricarica;
        private Button btn_durata;
        private Button btn_agg;
        private Button btn_info;
        private Label lbl_numero;
        private Label lbl_credito;
    }
}
