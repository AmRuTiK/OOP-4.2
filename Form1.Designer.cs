namespace OOP_4._2
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
            textBoxa = new TextBox();
            textBoxb = new TextBox();
            textBoxc = new TextBox();
            trackBara = new TrackBar();
            trackBarb = new TrackBar();
            trackBarc = new TrackBar();
            numericUpDowna = new NumericUpDown();
            numericUpDownb = new NumericUpDown();
            numericUpDownc = new NumericUpDown();
            labela = new Label();
            labelb = new Label();
            labelc = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBara).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDowna).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownc).BeginInit();
            SuspendLayout();
            // 
            // textBoxa
            // 
            textBoxa.Location = new Point(63, 88);
            textBoxa.Name = "textBoxa";
            textBoxa.Size = new Size(120, 23);
            textBoxa.TabIndex = 0;
            textBoxa.KeyDown += textBoxa_KeyDown;
            // 
            // textBoxb
            // 
            textBoxb.Location = new Point(218, 88);
            textBoxb.Name = "textBoxb";
            textBoxb.Size = new Size(120, 23);
            textBoxb.TabIndex = 1;
            textBoxb.KeyDown += textBoxb_KeyDown;
            // 
            // textBoxc
            // 
            textBoxc.Location = new Point(378, 88);
            textBoxc.Name = "textBoxc";
            textBoxc.Size = new Size(120, 23);
            textBoxc.TabIndex = 2;
            textBoxc.KeyDown += textBoxc_KeyDown;
            // 
            // trackBara
            // 
            trackBara.Location = new Point(63, 179);
            trackBara.Maximum = 100;
            trackBara.Name = "trackBara";
            trackBara.Size = new Size(120, 45);
            trackBara.TabIndex = 3;
            trackBara.Scroll += trackBara_Scroll;
            // 
            // trackBarb
            // 
            trackBarb.Location = new Point(218, 179);
            trackBarb.Maximum = 100;
            trackBarb.Name = "trackBarb";
            trackBarb.Size = new Size(120, 45);
            trackBarb.TabIndex = 4;
            trackBarb.Scroll += trackBarb_Scroll;
            // 
            // trackBarc
            // 
            trackBarc.Location = new Point(378, 179);
            trackBarc.Maximum = 100;
            trackBarc.Name = "trackBarc";
            trackBarc.Size = new Size(120, 45);
            trackBarc.TabIndex = 5;
            trackBarc.Scroll += trackBarc_Scroll;
            // 
            // numericUpDowna
            // 
            numericUpDowna.Location = new Point(63, 133);
            numericUpDowna.Name = "numericUpDowna";
            numericUpDowna.Size = new Size(120, 23);
            numericUpDowna.TabIndex = 6;
            numericUpDowna.ValueChanged += numericUpDowna_ValueChanged;
            // 
            // numericUpDownb
            // 
            numericUpDownb.Location = new Point(218, 133);
            numericUpDownb.Name = "numericUpDownb";
            numericUpDownb.Size = new Size(120, 23);
            numericUpDownb.TabIndex = 7;
            numericUpDownb.ValueChanged += numericUpDownb_ValueChanged;
            // 
            // numericUpDownc
            // 
            numericUpDownc.Location = new Point(378, 133);
            numericUpDownc.Name = "numericUpDownc";
            numericUpDownc.Size = new Size(120, 23);
            numericUpDownc.TabIndex = 8;
            numericUpDownc.ValueChanged += numericUpDownc_ValueChanged;
            // 
            // labela
            // 
            labela.AutoSize = true;
            labela.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labela.Location = new Point(108, 38);
            labela.Name = "labela";
            labela.Size = new Size(29, 32);
            labela.TabIndex = 9;
            labela.Text = "A";
            // 
            // labelb
            // 
            labelb.AutoSize = true;
            labelb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelb.Location = new Point(258, 38);
            labelb.Name = "labelb";
            labelb.Size = new Size(28, 32);
            labelb.TabIndex = 10;
            labelb.Text = "B";
            // 
            // labelc
            // 
            labelc.AutoSize = true;
            labelc.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelc.Location = new Point(423, 38);
            labelc.Name = "labelc";
            labelc.Size = new Size(29, 32);
            labelc.TabIndex = 11;
            labelc.Text = "C";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(174, 38);
            label1.Name = "label1";
            label1.Size = new Size(46, 32);
            label1.TabIndex = 12;
            label1.Text = "<=";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(332, 38);
            label2.Name = "label2";
            label2.Size = new Size(46, 32);
            label2.TabIndex = 13;
            label2.Text = "<=";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelc);
            Controls.Add(labelb);
            Controls.Add(labela);
            Controls.Add(numericUpDownc);
            Controls.Add(numericUpDownb);
            Controls.Add(numericUpDowna);
            Controls.Add(trackBarc);
            Controls.Add(trackBarb);
            Controls.Add(trackBara);
            Controls.Add(textBoxc);
            Controls.Add(textBoxb);
            Controls.Add(textBoxa);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)trackBara).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarb).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarc).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDowna).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownb).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxa;
        private TextBox textBoxb;
        private TextBox textBoxc;
        private TrackBar trackBara;
        private TrackBar trackBarb;
        private TrackBar trackBarc;
        private NumericUpDown numericUpDowna;
        private NumericUpDown numericUpDownb;
        private NumericUpDown numericUpDownc;
        private Label labela;
        private Label labelb;
        private Label labelc;
        private Label label1;
        private Label label2;
    }
}