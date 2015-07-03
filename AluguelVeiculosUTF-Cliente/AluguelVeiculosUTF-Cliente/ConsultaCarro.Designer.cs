namespace AluguelVeiculosUTF_Cliente
{
    partial class ConsultaCarro
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
            this.listaVeiculosBox = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listaVeiculosBox
            // 
            this.listaVeiculosBox.FormattingEnabled = true;
            this.listaVeiculosBox.Location = new System.Drawing.Point(262, 112);
            this.listaVeiculosBox.Name = "listaVeiculosBox";
            this.listaVeiculosBox.Size = new System.Drawing.Size(334, 21);
            this.listaVeiculosBox.TabIndex = 41;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(481, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 23);
            this.button3.TabIndex = 40;
            this.button3.Text = "Alugar Veículo";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "Voltar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Veículos para locação:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(324, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Caso deseje alugar o carro, clique em Alugar Veículo. Boa procura.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(304, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "o preço desejado e após utilize a opção de Registrar Interesse.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Caso deseje egistrar interesse em algum veículo, informe abaixo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Abaixo, serão listados todos os carros de nossa empresa.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Consulta de veículos para locação";
            // 
            // ConsultaCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 261);
            this.Controls.Add(this.listaVeiculosBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConsultaCarro";
            this.Text = "ConsultaCarro";
            this.Load += new System.EventHandler(this.ConsultaCarro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox listaVeiculosBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}