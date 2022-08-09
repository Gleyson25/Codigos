namespace TesteDoForEach
{
    partial class frmTesteDoForEach
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
            this.btnMensagem = new System.Windows.Forms.Button();
            this.btnDesvConv = new System.Windows.Forms.Button();
            this.btnDesvConvEnc = new System.Windows.Forms.Button();
            this.btnSwitchCase = new System.Windows.Forms.Button();
            this.btnImpTxtWhile = new System.Windows.Forms.Button();
            this.lstbxPreferencias = new System.Windows.Forms.ListBox();
            this.btnImpTxtDoWhile = new System.Windows.Forms.Button();
            this.btnImpTxtFor = new System.Windows.Forms.Button();
            this.btnImpTxtForEach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMensagem
            // 
            this.btnMensagem.Location = new System.Drawing.Point(2, 3);
            this.btnMensagem.Name = "btnMensagem";
            this.btnMensagem.Size = new System.Drawing.Size(121, 40);
            this.btnMensagem.TabIndex = 0;
            this.btnMensagem.Text = "Clique para ver a mensagem";
            this.btnMensagem.UseVisualStyleBackColor = true;
            this.btnMensagem.Click += new System.EventHandler(this.btnMensagem_Click);
            // 
            // btnDesvConv
            // 
            this.btnDesvConv.Location = new System.Drawing.Point(2, 49);
            this.btnDesvConv.Name = "btnDesvConv";
            this.btnDesvConv.Size = new System.Drawing.Size(121, 40);
            this.btnDesvConv.TabIndex = 1;
            this.btnDesvConv.Text = "Desvio Condicional";
            this.btnDesvConv.UseVisualStyleBackColor = true;
            this.btnDesvConv.Click += new System.EventHandler(this.btnDesvConv_Click);
            // 
            // btnDesvConvEnc
            // 
            this.btnDesvConvEnc.Location = new System.Drawing.Point(2, 95);
            this.btnDesvConvEnc.Name = "btnDesvConvEnc";
            this.btnDesvConvEnc.Size = new System.Drawing.Size(121, 40);
            this.btnDesvConvEnc.TabIndex = 2;
            this.btnDesvConvEnc.Text = "Desvio Condicional encadeado\\aninhado";
            this.btnDesvConvEnc.UseVisualStyleBackColor = true;
            this.btnDesvConvEnc.Click += new System.EventHandler(this.btnDesvConvEnc_Click);
            // 
            // btnSwitchCase
            // 
            this.btnSwitchCase.Location = new System.Drawing.Point(2, 141);
            this.btnSwitchCase.Name = "btnSwitchCase";
            this.btnSwitchCase.Size = new System.Drawing.Size(121, 40);
            this.btnSwitchCase.TabIndex = 3;
            this.btnSwitchCase.Text = "Estrutura de escolha";
            this.btnSwitchCase.UseVisualStyleBackColor = true;
            this.btnSwitchCase.Click += new System.EventHandler(this.btnSwitchCase_Click);
            // 
            // btnImpTxtWhile
            // 
            this.btnImpTxtWhile.Location = new System.Drawing.Point(2, 187);
            this.btnImpTxtWhile.Name = "btnImpTxtWhile";
            this.btnImpTxtWhile.Size = new System.Drawing.Size(121, 40);
            this.btnImpTxtWhile.TabIndex = 4;
            this.btnImpTxtWhile.Text = "Importar Texto While";
            this.btnImpTxtWhile.UseVisualStyleBackColor = true;
            this.btnImpTxtWhile.Click += new System.EventHandler(this.btnImpTxtWhile_Click);
            // 
            // lstbxPreferencias
            // 
            this.lstbxPreferencias.FormattingEnabled = true;
            this.lstbxPreferencias.Location = new System.Drawing.Point(129, 3);
            this.lstbxPreferencias.Name = "lstbxPreferencias";
            this.lstbxPreferencias.Size = new System.Drawing.Size(153, 355);
            this.lstbxPreferencias.TabIndex = 5;
            // 
            // btnImpTxtDoWhile
            // 
            this.btnImpTxtDoWhile.Location = new System.Drawing.Point(2, 233);
            this.btnImpTxtDoWhile.Name = "btnImpTxtDoWhile";
            this.btnImpTxtDoWhile.Size = new System.Drawing.Size(121, 40);
            this.btnImpTxtDoWhile.TabIndex = 6;
            this.btnImpTxtDoWhile.Text = "Importar Texto Do While";
            this.btnImpTxtDoWhile.UseVisualStyleBackColor = true;
            this.btnImpTxtDoWhile.Click += new System.EventHandler(this.btnImpTxtDoWhile_Click);
            // 
            // btnImpTxtFor
            // 
            this.btnImpTxtFor.Location = new System.Drawing.Point(2, 279);
            this.btnImpTxtFor.Name = "btnImpTxtFor";
            this.btnImpTxtFor.Size = new System.Drawing.Size(121, 40);
            this.btnImpTxtFor.TabIndex = 7;
            this.btnImpTxtFor.Text = "Importar Texto For";
            this.btnImpTxtFor.UseVisualStyleBackColor = true;
            this.btnImpTxtFor.Click += new System.EventHandler(this.btnImpTxtFor_Click);
            // 
            // btnImpTxtForEach
            // 
            this.btnImpTxtForEach.Location = new System.Drawing.Point(2, 321);
            this.btnImpTxtForEach.Name = "btnImpTxtForEach";
            this.btnImpTxtForEach.Size = new System.Drawing.Size(121, 40);
            this.btnImpTxtForEach.TabIndex = 8;
            this.btnImpTxtForEach.Text = "Importar Texto For Each";
            this.btnImpTxtForEach.UseVisualStyleBackColor = true;
            this.btnImpTxtForEach.Click += new System.EventHandler(this.btnImpTxtForEach_Click);
            // 
            // frmTesteDoForEach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 366);
            this.Controls.Add(this.btnImpTxtForEach);
            this.Controls.Add(this.btnImpTxtFor);
            this.Controls.Add(this.btnImpTxtDoWhile);
            this.Controls.Add(this.lstbxPreferencias);
            this.Controls.Add(this.btnImpTxtWhile);
            this.Controls.Add(this.btnSwitchCase);
            this.Controls.Add(this.btnDesvConvEnc);
            this.Controls.Add(this.btnDesvConv);
            this.Controls.Add(this.btnMensagem);
            this.Name = "frmTesteDoForEach";
            this.Text = "Teste Do ForEach";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMensagem;
        private System.Windows.Forms.Button btnDesvConv;
        private System.Windows.Forms.Button btnDesvConvEnc;
        private System.Windows.Forms.Button btnSwitchCase;
        private System.Windows.Forms.Button btnImpTxtWhile;
        private System.Windows.Forms.ListBox lstbxPreferencias;
        private System.Windows.Forms.Button btnImpTxtDoWhile;
        private System.Windows.Forms.Button btnImpTxtFor;
        private System.Windows.Forms.Button btnImpTxtForEach;
    }
}

