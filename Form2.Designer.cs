namespace CadastroPOO
{
    partial class Form2
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
            this.btnLimparCads = new System.Windows.Forms.Button();
            this.sbtnListaFuncionario = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSalBase = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDtAdmissao = new System.Windows.Forms.DateTimePicker();
            this.TipoDeFuncionario = new System.Windows.Forms.GroupBox();
            this.rbCLT = new System.Windows.Forms.RadioButton();
            this.rbPJ = new System.Windows.Forms.RadioButton();
            this.rbEstagiario = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCadFuncionario = new System.Windows.Forms.Button();
            this.btnCalFolhaTotal = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFolhaCLT = new System.Windows.Forms.TextBox();
            this.lstUsuario = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFolhaPJ = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFolhaEstagiario = new System.Windows.Forms.TextBox();
            this.TipoDeFuncionario.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimparCads
            // 
            this.btnLimparCads.Location = new System.Drawing.Point(541, 224);
            this.btnLimparCads.Name = "btnLimparCads";
            this.btnLimparCads.Size = new System.Drawing.Size(171, 27);
            this.btnLimparCads.TabIndex = 51;
            this.btnLimparCads.Text = "Limpar Cadastros";
            this.btnLimparCads.UseVisualStyleBackColor = true;
            this.btnLimparCads.Click += new System.EventHandler(this.btnLimparCads_Click);
            // 
            // sbtnListaFuncionario
            // 
            this.sbtnListaFuncionario.Location = new System.Drawing.Point(187, 224);
            this.sbtnListaFuncionario.Name = "sbtnListaFuncionario";
            this.sbtnListaFuncionario.Size = new System.Drawing.Size(171, 27);
            this.sbtnListaFuncionario.TabIndex = 50;
            this.sbtnListaFuncionario.Text = "Listar Funcionário";
            this.sbtnListaFuncionario.UseVisualStyleBackColor = true;
            this.sbtnListaFuncionario.Click += new System.EventHandler(this.sbtnListaFuncionario_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Salário Base:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Data de Admissão";
            // 
            // txtSalBase
            // 
            this.txtSalBase.Location = new System.Drawing.Point(6, 166);
            this.txtSalBase.Name = "txtSalBase";
            this.txtSalBase.Size = new System.Drawing.Size(163, 22);
            this.txtSalBase.TabIndex = 30;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(6, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(387, 22);
            this.txtNome.TabIndex = 29;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(6, 99);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(163, 22);
            this.txtCPF.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "CPF:";
            // 
            // dtpDtAdmissao
            // 
            this.dtpDtAdmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtAdmissao.Location = new System.Drawing.Point(529, 40);
            this.dtpDtAdmissao.Name = "dtpDtAdmissao";
            this.dtpDtAdmissao.Size = new System.Drawing.Size(132, 22);
            this.dtpDtAdmissao.TabIndex = 52;
            // 
            // TipoDeFuncionario
            // 
            this.TipoDeFuncionario.Controls.Add(this.rbEstagiario);
            this.TipoDeFuncionario.Controls.Add(this.rbPJ);
            this.TipoDeFuncionario.Controls.Add(this.rbCLT);
            this.TipoDeFuncionario.Location = new System.Drawing.Point(503, 81);
            this.TipoDeFuncionario.Name = "TipoDeFuncionario";
            this.TipoDeFuncionario.Size = new System.Drawing.Size(191, 106);
            this.TipoDeFuncionario.TabIndex = 53;
            this.TipoDeFuncionario.TabStop = false;
            this.TipoDeFuncionario.Text = "Tipo de Funcionário:";
            // 
            // rbCLT
            // 
            this.rbCLT.AutoSize = true;
            this.rbCLT.Location = new System.Drawing.Point(7, 22);
            this.rbCLT.Name = "rbCLT";
            this.rbCLT.Size = new System.Drawing.Size(126, 20);
            this.rbCLT.TabIndex = 0;
            this.rbCLT.TabStop = true;
            this.rbCLT.Text = "Funcionário CLT";
            this.rbCLT.UseVisualStyleBackColor = true;
            // 
            // rbPJ
            // 
            this.rbPJ.AutoSize = true;
            this.rbPJ.Location = new System.Drawing.Point(7, 48);
            this.rbPJ.Name = "rbPJ";
            this.rbPJ.Size = new System.Drawing.Size(117, 20);
            this.rbPJ.TabIndex = 1;
            this.rbPJ.TabStop = true;
            this.rbPJ.Text = "Funcionário PJ";
            this.rbPJ.UseVisualStyleBackColor = true;
            // 
            // rbEstagiario
            // 
            this.rbEstagiario.AutoSize = true;
            this.rbEstagiario.Location = new System.Drawing.Point(7, 74);
            this.rbEstagiario.Name = "rbEstagiario";
            this.rbEstagiario.Size = new System.Drawing.Size(162, 20);
            this.rbEstagiario.TabIndex = 2;
            this.rbEstagiario.TabStop = true;
            this.rbEstagiario.Text = "Funcionário Estagiário";
            this.rbEstagiario.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.TipoDeFuncionario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpDtAdmissao);
            this.groupBox1.Controls.Add(this.txtCPF);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSalBase);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 193);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Funcionário";
            // 
            // btnCadFuncionario
            // 
            this.btnCadFuncionario.Location = new System.Drawing.Point(10, 224);
            this.btnCadFuncionario.Name = "btnCadFuncionario";
            this.btnCadFuncionario.Size = new System.Drawing.Size(171, 27);
            this.btnCadFuncionario.TabIndex = 55;
            this.btnCadFuncionario.Text = "Cadastrar Funcionário";
            this.btnCadFuncionario.UseVisualStyleBackColor = true;
            this.btnCadFuncionario.Click += new System.EventHandler(this.btnCadFuncionario_Click);
            // 
            // btnCalFolhaTotal
            // 
            this.btnCalFolhaTotal.Location = new System.Drawing.Point(364, 224);
            this.btnCalFolhaTotal.Name = "btnCalFolhaTotal";
            this.btnCalFolhaTotal.Size = new System.Drawing.Size(171, 27);
            this.btnCalFolhaTotal.TabIndex = 56;
            this.btnCalFolhaTotal.Text = "Calcular folha total";
            this.btnCalFolhaTotal.UseVisualStyleBackColor = true;
            this.btnCalFolhaTotal.Click += new System.EventHandler(this.btnCalFolhaTotal_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "Folha do CLT:";
            this.label8.UseWaitCursor = true;
            // 
            // txtFolhaCLT
            // 
            this.txtFolhaCLT.Location = new System.Drawing.Point(6, 237);
            this.txtFolhaCLT.Name = "txtFolhaCLT";
            this.txtFolhaCLT.Size = new System.Drawing.Size(160, 22);
            this.txtFolhaCLT.TabIndex = 45;
            this.txtFolhaCLT.UseWaitCursor = true;
            // 
            // lstUsuario
            // 
            this.lstUsuario.FormattingEnabled = true;
            this.lstUsuario.ItemHeight = 16;
            this.lstUsuario.Location = new System.Drawing.Point(6, 37);
            this.lstUsuario.Name = "lstUsuario";
            this.lstUsuario.Size = new System.Drawing.Size(685, 164);
            this.lstUsuario.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Lista de Usuário";
            this.label6.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtFolhaEstagiario);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtFolhaPJ);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lstUsuario);
            this.groupBox2.Controls.Add(this.txtFolhaCLT);
            this.groupBox2.Location = new System.Drawing.Point(12, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 381);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "Folha do PJ:";
            this.label5.UseWaitCursor = true;
            // 
            // txtFolhaPJ
            // 
            this.txtFolhaPJ.Location = new System.Drawing.Point(6, 295);
            this.txtFolhaPJ.Name = "txtFolhaPJ";
            this.txtFolhaPJ.Size = new System.Drawing.Size(160, 22);
            this.txtFolhaPJ.TabIndex = 47;
            this.txtFolhaPJ.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 16);
            this.label7.TabIndex = 48;
            this.label7.Text = "Folha do Estagiário:";
            this.label7.UseWaitCursor = true;
            // 
            // txtFolhaEstagiario
            // 
            this.txtFolhaEstagiario.Location = new System.Drawing.Point(2, 353);
            this.txtFolhaEstagiario.Name = "txtFolhaEstagiario";
            this.txtFolhaEstagiario.Size = new System.Drawing.Size(166, 22);
            this.txtFolhaEstagiario.TabIndex = 49;
            this.txtFolhaEstagiario.UseWaitCursor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(752, 676);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCalFolhaTotal);
            this.Controls.Add(this.btnCadFuncionario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLimparCads);
            this.Controls.Add(this.sbtnListaFuncionario);
            this.Name = "Form2";
            this.Text = "Form2";
            this.TipoDeFuncionario.ResumeLayout(false);
            this.TipoDeFuncionario.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLimparCads;
        private System.Windows.Forms.Button sbtnListaFuncionario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalBase;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDtAdmissao;
        private System.Windows.Forms.GroupBox TipoDeFuncionario;
        private System.Windows.Forms.RadioButton rbEstagiario;
        private System.Windows.Forms.RadioButton rbPJ;
        private System.Windows.Forms.RadioButton rbCLT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCadFuncionario;
        private System.Windows.Forms.Button btnCalFolhaTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFolhaCLT;
        private System.Windows.Forms.ListBox lstUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFolhaEstagiario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFolhaPJ;
    }
}