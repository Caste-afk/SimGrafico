namespace SimGrafico
{
    partial class Durata
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
            lbl_numero = new Label();
            tbx_numero = new TextBox();
            btn_ok = new Button();
            btn_annulla = new Button();
            SuspendLayout();
            // 
            // lbl_numero
            // 
            lbl_numero.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_numero.Location = new Point(23, 79);
            lbl_numero.Name = "lbl_numero";
            lbl_numero.Size = new Size(155, 37);
            lbl_numero.TabIndex = 0;
            lbl_numero.Text = "Inserire numero";
            // 
            // tbx_numero
            // 
            tbx_numero.Location = new Point(230, 84);
            tbx_numero.Name = "tbx_numero";
            tbx_numero.Size = new Size(211, 23);
            tbx_numero.TabIndex = 1;
            // 
            // btn_ok
            // 
            btn_ok.Location = new Point(88, 186);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(120, 27);
            btn_ok.TabIndex = 2;
            btn_ok.Text = "Visualizza";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // btn_annulla
            // 
            btn_annulla.Location = new Point(283, 186);
            btn_annulla.Name = "btn_annulla";
            btn_annulla.Size = new Size(120, 27);
            btn_annulla.TabIndex = 3;
            btn_annulla.Text = "Annulla";
            btn_annulla.UseVisualStyleBackColor = true;
            btn_annulla.Click += btn_annulla_Click;
            // 
            // Durata
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 241);
            Controls.Add(btn_annulla);
            Controls.Add(btn_ok);
            Controls.Add(tbx_numero);
            Controls.Add(lbl_numero);
            Name = "Durata";
            Text = "Durata";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_numero;
        private TextBox tbx_numero;
        private Button btn_ok;
        private Button btn_annulla;
    }
}