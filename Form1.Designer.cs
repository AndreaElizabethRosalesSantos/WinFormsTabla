namespace WinFormsTabla
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
            panelprincipal = new Panel();
            label1 = new Label();
            richTextBoxresultados = new RichTextBox();
            buttonver = new Button();
            textBoxnum = new TextBox();
            labelnumero = new Label();
            labeltitulo = new Label();
            panelprincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelprincipal
            // 
            panelprincipal.BackColor = Color.FromArgb(192, 192, 255);
            panelprincipal.Controls.Add(label1);
            panelprincipal.Controls.Add(richTextBoxresultados);
            panelprincipal.Controls.Add(buttonver);
            panelprincipal.Controls.Add(textBoxnum);
            panelprincipal.Controls.Add(labelnumero);
            panelprincipal.Controls.Add(labeltitulo);
            panelprincipal.Location = new Point(12, 21);
            panelprincipal.Name = "panelprincipal";
            panelprincipal.Size = new Size(795, 487);
            panelprincipal.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 12);
            label1.Name = "label1";
            label1.Size = new Size(366, 21);
            label1.TabIndex = 5;
            label1.Text = "ANDREA ELIZABETH ROSALES SANTOS 3ºB";
            // 
            // richTextBoxresultados
            // 
            richTextBoxresultados.BackColor = Color.FromArgb(255, 192, 192);
            richTextBoxresultados.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBoxresultados.Location = new Point(363, 125);
            richTextBoxresultados.Name = "richTextBoxresultados";
            richTextBoxresultados.Size = new Size(174, 298);
            richTextBoxresultados.TabIndex = 4;
            richTextBoxresultados.Text = "";
            // 
            // buttonver
            // 
            buttonver.BackColor = Color.FromArgb(255, 192, 255);
            buttonver.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonver.Location = new Point(126, 208);
            buttonver.Name = "buttonver";
            buttonver.Size = new Size(128, 29);
            buttonver.TabIndex = 3;
            buttonver.Text = "VER TABLA";
            buttonver.UseVisualStyleBackColor = false;
            buttonver.Click += buttonver_Click;
            // 
            // textBoxnum
            // 
            textBoxnum.Location = new Point(129, 163);
            textBoxnum.Name = "textBoxnum";
            textBoxnum.Size = new Size(125, 27);
            textBoxnum.TabIndex = 2;
            // 
            // labelnumero
            // 
            labelnumero.AutoSize = true;
            labelnumero.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelnumero.Location = new Point(102, 127);
            labelnumero.Name = "labelnumero";
            labelnumero.Size = new Size(183, 23);
            labelnumero.TabIndex = 1;
            labelnumero.Text = "¿Cuál tabla quieres?";
            // 
            // labeltitulo
            // 
            labeltitulo.AutoSize = true;
            labeltitulo.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeltitulo.Location = new Point(167, 58);
            labeltitulo.Name = "labeltitulo";
            labeltitulo.Size = new Size(425, 43);
            labeltitulo.TabIndex = 0;
            labeltitulo.Text = "TABLA DE MULTIPLICAR";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 520);
            Controls.Add(panelprincipal);
            Name = "Form1";
            Text = "Form1";
            panelprincipal.ResumeLayout(false);
            panelprincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelprincipal;
        private Label labeltitulo;
        private TextBox textBoxnum;
        private Label labelnumero;
        private Button buttonver;
        private RichTextBox richTextBoxresultados;
        private Label label1;
    }
}
