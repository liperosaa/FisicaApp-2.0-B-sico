namespace FisicaApp_2._0
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
            panel1 = new Panel();
            label1 = new Label();
            num4 = new NumericUpDown();
            lblResult = new Label();
            lbl = new Label();
            btTorri = new Button();
            btMovi = new Button();
            btAce = new Button();
            btVelo = new Button();
            num3 = new NumericUpDown();
            num2 = new NumericUpDown();
            num1 = new NumericUpDown();
            entrada3 = new Label();
            entrada2 = new Label();
            entrada1 = new Label();
            lblInterface = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(num4);
            panel1.Controls.Add(lblResult);
            panel1.Controls.Add(lbl);
            panel1.Controls.Add(btTorri);
            panel1.Controls.Add(btMovi);
            panel1.Controls.Add(btAce);
            panel1.Controls.Add(btVelo);
            panel1.Controls.Add(num3);
            panel1.Controls.Add(num2);
            panel1.Controls.Add(num1);
            panel1.Controls.Add(entrada3);
            panel1.Controls.Add(entrada2);
            panel1.Controls.Add(entrada1);
            panel1.Location = new Point(107, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(466, 301);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 138);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 12;
            label1.Text = "Entrada 4:";
            // 
            // num4
            // 
            num4.Location = new Point(135, 136);
            num4.Name = "num4";
            num4.Size = new Size(150, 27);
            num4.TabIndex = 11;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(134, 255);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 2;
            lblResult.Click += lblResult_Click;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(53, 255);
            lbl.Name = "lbl";
            lbl.Size = new Size(78, 20);
            lbl.TabIndex = 10;
            lbl.Text = "Resultado:";
            // 
            // btTorri
            // 
            btTorri.Location = new Point(334, 182);
            btTorri.Name = "btTorri";
            btTorri.Size = new Size(94, 47);
            btTorri.TabIndex = 9;
            btTorri.Text = "Torricelli";
            btTorri.UseVisualStyleBackColor = true;
            btTorri.Click += btTorri_Click;
            // 
            // btMovi
            // 
            btMovi.Location = new Point(234, 182);
            btMovi.Name = "btMovi";
            btMovi.Size = new Size(94, 47);
            btMovi.TabIndex = 8;
            btMovi.Text = "Movimento";
            btMovi.UseVisualStyleBackColor = true;
            btMovi.Click += btMovi_Click;
            // 
            // btAce
            // 
            btAce.Location = new Point(134, 182);
            btAce.Name = "btAce";
            btAce.Size = new Size(94, 47);
            btAce.TabIndex = 7;
            btAce.Text = "Aceleração";
            btAce.UseVisualStyleBackColor = true;
            btAce.Click += btAce_Click;
            // 
            // btVelo
            // 
            btVelo.Location = new Point(34, 182);
            btVelo.Name = "btVelo";
            btVelo.Size = new Size(94, 47);
            btVelo.TabIndex = 6;
            btVelo.Text = "Velocidade";
            btVelo.UseVisualStyleBackColor = true;
            btVelo.Click += btVelo_Click;
            // 
            // num3
            // 
            num3.Location = new Point(135, 103);
            num3.Name = "num3";
            num3.Size = new Size(150, 27);
            num3.TabIndex = 5;
            // 
            // num2
            // 
            num2.Location = new Point(135, 73);
            num2.Name = "num2";
            num2.Size = new Size(150, 27);
            num2.TabIndex = 4;
            num2.ValueChanged += num2_ValueChanged;
            // 
            // num1
            // 
            num1.Location = new Point(135, 40);
            num1.Name = "num1";
            num1.Size = new Size(150, 27);
            num1.TabIndex = 3;
            num1.ValueChanged += num1_ValueChanged;
            // 
            // entrada3
            // 
            entrada3.AutoSize = true;
            entrada3.Location = new Point(54, 105);
            entrada3.Name = "entrada3";
            entrada3.Size = new Size(75, 20);
            entrada3.TabIndex = 2;
            entrada3.Text = "Entrada 3:";
            // 
            // entrada2
            // 
            entrada2.AutoSize = true;
            entrada2.Location = new Point(54, 74);
            entrada2.Name = "entrada2";
            entrada2.Size = new Size(75, 20);
            entrada2.TabIndex = 1;
            entrada2.Text = "Entrada 2:";
            // 
            // entrada1
            // 
            entrada1.AutoSize = true;
            entrada1.Location = new Point(54, 40);
            entrada1.Name = "entrada1";
            entrada1.Size = new Size(75, 20);
            entrada1.TabIndex = 0;
            entrada1.Text = "Entrada 1:";
            // 
            // lblInterface
            // 
            lblInterface.AutoSize = true;
            lblInterface.Location = new Point(277, 28);
            lblInterface.Name = "lblInterface";
            lblInterface.Size = new Size(136, 20);
            lblInterface.TabIndex = 1;
            lblInterface.Text = "INTERFACE BÁSICA";
            lblInterface.Click += lblInterface_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 418);
            Controls.Add(lblInterface);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "FisicaApp 2.0 - Básica";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num4).EndInit();
            ((System.ComponentModel.ISupportInitialize)num3).EndInit();
            ((System.ComponentModel.ISupportInitialize)num2).EndInit();
            ((System.ComponentModel.ISupportInitialize)num1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblInterface;
        private NumericUpDown num3;
        private NumericUpDown num2;
        private NumericUpDown num1;
        private Label entrada3;
        private Label entrada2;
        private Label entrada1;
        private Button btTorri;
        private Button btMovi;
        private Button btAce;
        private Button btVelo;
        private Label lblResult;
        private Label lbl;
        private Label label1;
        private NumericUpDown num4;
    }
}
