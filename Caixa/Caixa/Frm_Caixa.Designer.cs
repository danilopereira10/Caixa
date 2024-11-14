namespace Caixa
{
    partial class Frm_Caixa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NP = new System.Windows.Forms.TextBox();
            this.txt_QP = new System.Windows.Forms.TextBox();
            this.txt_VU = new System.Windows.Forms.TextBox();
            this.lst1 = new System.Windows.Forms.ListBox();
            this.txt_VP = new System.Windows.Forms.TextBox();
            this.lbl_PT = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_T = new System.Windows.Forms.Label();
            this.btn_Incluir = new System.Windows.Forms.Button();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_Tr = new System.Windows.Forms.Button();
            this.lst2 = new System.Windows.Forms.ListBox();
            this.lst3 = new System.Windows.Forms.ListBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade do produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor unitário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome do produto:";
            // 
            // txt_NP
            // 
            this.txt_NP.Location = new System.Drawing.Point(279, 21);
            this.txt_NP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NP.Name = "txt_NP";
            this.txt_NP.Size = new System.Drawing.Size(148, 23);
            this.txt_NP.TabIndex = 0;
            // 
            // txt_QP
            // 
            this.txt_QP.Location = new System.Drawing.Point(279, 66);
            this.txt_QP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_QP.Name = "txt_QP";
            this.txt_QP.Size = new System.Drawing.Size(148, 23);
            this.txt_QP.TabIndex = 1;
            // 
            // txt_VU
            // 
            this.txt_VU.Location = new System.Drawing.Point(279, 114);
            this.txt_VU.Margin = new System.Windows.Forms.Padding(4);
            this.txt_VU.Name = "txt_VU";
            this.txt_VU.Size = new System.Drawing.Size(148, 23);
            this.txt_VU.TabIndex = 2;
            // 
            // lst1
            // 
            this.lst1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lst1.FormattingEnabled = true;
            this.lst1.ItemHeight = 16;
            this.lst1.Location = new System.Drawing.Point(459, 21);
            this.lst1.Margin = new System.Windows.Forms.Padding(4);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(244, 180);
            this.lst1.TabIndex = 16;
            this.lst1.UseTabStops = false;
            this.lst1.SelectedIndexChanged += new System.EventHandler(this.lst1_SelectedIndexChanged);
            // 
            // txt_VP
            // 
            this.txt_VP.Location = new System.Drawing.Point(279, 235);
            this.txt_VP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_VP.Name = "txt_VP";
            this.txt_VP.Size = new System.Drawing.Size(148, 23);
            this.txt_VP.TabIndex = 7;
            // 
            // lbl_PT
            // 
            this.lbl_PT.AutoSize = true;
            this.lbl_PT.Location = new System.Drawing.Point(188, 186);
            this.lbl_PT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PT.Name = "lbl_PT";
            this.lbl_PT.Size = new System.Drawing.Size(97, 17);
            this.lbl_PT.TabIndex = 18;
            this.lbl_PT.Text = "Preço Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 235);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valor Pago:";
            // 
            // lbl_T
            // 
            this.lbl_T.AutoSize = true;
            this.lbl_T.Location = new System.Drawing.Point(183, 338);
            this.lbl_T.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_T.Name = "lbl_T";
            this.lbl_T.Size = new System.Drawing.Size(55, 17);
            this.lbl_T.TabIndex = 10;
            this.lbl_T.Text = "Troco:";
            // 
            // btn_Incluir
            // 
            this.btn_Incluir.BackColor = System.Drawing.Color.Brown;
            this.btn_Incluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Incluir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Incluir.Location = new System.Drawing.Point(459, 230);
            this.btn_Incluir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Incluir.Name = "btn_Incluir";
            this.btn_Incluir.Size = new System.Drawing.Size(756, 28);
            this.btn_Incluir.TabIndex = 3;
            this.btn_Incluir.Text = "INCLUIR";
            this.btn_Incluir.UseVisualStyleBackColor = false;
            this.btn_Incluir.Click += new System.EventHandler(this.btn_Incluir_Click);
            // 
            // btn_Remover
            // 
            this.btn_Remover.BackColor = System.Drawing.Color.Brown;
            this.btn_Remover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Remover.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Remover.Location = new System.Drawing.Point(459, 284);
            this.btn_Remover.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(756, 28);
            this.btn_Remover.TabIndex = 4;
            this.btn_Remover.Text = "REMOVER";
            this.btn_Remover.UseVisualStyleBackColor = false;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.BackColor = System.Drawing.Color.Brown;
            this.btn_Calcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Calcular.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Calcular.Location = new System.Drawing.Point(459, 367);
            this.btn_Calcular.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(756, 28);
            this.btn_Calcular.TabIndex = 6;
            this.btn_Calcular.Text = "CALCULAR";
            this.btn_Calcular.UseVisualStyleBackColor = false;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_Tr
            // 
            this.btn_Tr.BackColor = System.Drawing.Color.Brown;
            this.btn_Tr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Tr.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Tr.Location = new System.Drawing.Point(172, 284);
            this.btn_Tr.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Tr.Name = "btn_Tr";
            this.btn_Tr.Size = new System.Drawing.Size(112, 28);
            this.btn_Tr.TabIndex = 8;
            this.btn_Tr.Text = "CONFIRMAR";
            this.btn_Tr.UseVisualStyleBackColor = false;
            this.btn_Tr.Click += new System.EventHandler(this.btn_Tr_Click);
            // 
            // lst2
            // 
            this.lst2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lst2.FormattingEnabled = true;
            this.lst2.ItemHeight = 16;
            this.lst2.Location = new System.Drawing.Point(714, 21);
            this.lst2.Margin = new System.Windows.Forms.Padding(4);
            this.lst2.Name = "lst2";
            this.lst2.Size = new System.Drawing.Size(244, 180);
            this.lst2.TabIndex = 17;
            this.lst2.SelectedIndexChanged += new System.EventHandler(this.lst2_SelectedIndexChanged);
            // 
            // lst3
            // 
            this.lst3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lst3.FormattingEnabled = true;
            this.lst3.ItemHeight = 16;
            this.lst3.Location = new System.Drawing.Point(969, 21);
            this.lst3.Margin = new System.Windows.Forms.Padding(4);
            this.lst3.Name = "lst3";
            this.lst3.Size = new System.Drawing.Size(244, 180);
            this.lst3.TabIndex = 18;
            this.lst3.SelectedIndexChanged += new System.EventHandler(this.lst3_SelectedIndexChanged);
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(810, 320);
            this.txt_senha.Margin = new System.Windows.Forms.Padding(4);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(148, 23);
            this.txt_senha.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(710, 324);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Senha:";
            // 
            // Frm_Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1242, 446);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.lst3);
            this.Controls.Add(this.lst2);
            this.Controls.Add(this.btn_Tr);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.btn_Remover);
            this.Controls.Add(this.btn_Incluir);
            this.Controls.Add(this.lbl_T);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_PT);
            this.Controls.Add(this.txt_VP);
            this.Controls.Add(this.lst1);
            this.Controls.Add(this.txt_VU);
            this.Controls.Add(this.txt_QP);
            this.Controls.Add(this.txt_NP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Caixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mercado Extrafour";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NP;
        private System.Windows.Forms.TextBox txt_QP;
        private System.Windows.Forms.TextBox txt_VU;
        private System.Windows.Forms.ListBox lst1;
        private System.Windows.Forms.TextBox txt_VP;
        private System.Windows.Forms.Label lbl_PT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_T;
        private System.Windows.Forms.Button btn_Incluir;
        private System.Windows.Forms.Button btn_Remover;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_Tr;
        private System.Windows.Forms.ListBox lst2;
        private System.Windows.Forms.ListBox lst3;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label label4;
    }
}

