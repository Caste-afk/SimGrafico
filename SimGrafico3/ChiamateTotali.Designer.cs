namespace SimGrafico
{
    partial class ChiamateTotali
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
            gdv_chiamate = new DataGridView();
            c1 = new DataGridViewTextBoxColumn();
            c2 = new DataGridViewTextBoxColumn();
            btn_ok = new Button();
            ((System.ComponentModel.ISupportInitialize)gdv_chiamate).BeginInit();
            SuspendLayout();
            // 
            // gdv_chiamate
            // 
            gdv_chiamate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gdv_chiamate.Columns.AddRange(new DataGridViewColumn[] { c1, c2 });
            gdv_chiamate.Location = new Point(14, 12);
            gdv_chiamate.Name = "gdv_chiamate";
            gdv_chiamate.RowTemplate.Height = 25;
            gdv_chiamate.Size = new Size(444, 206);
            gdv_chiamate.TabIndex = 0;
            // 
            // c1
            // 
            c1.HeaderText = "numero chiamato";
            c1.Name = "c1";
            c1.ReadOnly = true;
            c1.Width = 200;
            // 
            // c2
            // 
            c2.HeaderText = "durata";
            c2.MinimumWidth = 30;
            c2.Name = "c2";
            c2.ReadOnly = true;
            c2.Resizable = DataGridViewTriState.False;
            c2.Width = 200;
            // 
            // btn_ok
            // 
            btn_ok.Location = new Point(150, 259);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(185, 23);
            btn_ok.TabIndex = 1;
            btn_ok.Text = "OK";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // ChiamateTotali
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 294);
            Controls.Add(btn_ok);
            Controls.Add(gdv_chiamate);
            Name = "ChiamateTotali";
            Text = "ChiamateTotali";
            ((System.ComponentModel.ISupportInitialize)gdv_chiamate).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gdv_chiamate;
        private DataGridViewTextBoxColumn c1;
        private DataGridViewTextBoxColumn c2;
        private Button btn_ok;
    }
}