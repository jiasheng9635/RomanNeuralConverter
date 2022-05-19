namespace RomanNumeralConverter
{
    partial class FrmRomanNumeralConv
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
            this.btnTestRToA = new System.Windows.Forms.Button();
            this.btnTestAToR = new System.Windows.Forms.Button();
            this.lsbMessage = new System.Windows.Forms.ListBox();
            this.inputText = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTestRToA
            // 
            this.btnTestRToA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestRToA.Location = new System.Drawing.Point(12, 12);
            this.btnTestRToA.Name = "btnTestRToA";
            this.btnTestRToA.Size = new System.Drawing.Size(186, 42);
            this.btnTestRToA.TabIndex = 0;
            this.btnTestRToA.Text = "Test RomanToArabic";
            this.btnTestRToA.UseVisualStyleBackColor = true;
            this.btnTestRToA.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTestAToR
            // 
            this.btnTestAToR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestAToR.Location = new System.Drawing.Point(213, 12);
            this.btnTestAToR.Name = "btnTestAToR";
            this.btnTestAToR.Size = new System.Drawing.Size(194, 42);
            this.btnTestAToR.TabIndex = 1;
            this.btnTestAToR.Text = "Test ArabicToRoman";
            this.btnTestAToR.UseVisualStyleBackColor = true;
            this.btnTestAToR.Click += new System.EventHandler(this.button2_Click);
            // 
            // lsbMessage
            // 
            this.lsbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbMessage.FormattingEnabled = true;
            this.lsbMessage.ItemHeight = 20;
            this.lsbMessage.Location = new System.Drawing.Point(12, 116);
            this.lsbMessage.Name = "lsbMessage";
            this.lsbMessage.Size = new System.Drawing.Size(776, 484);
            this.lsbMessage.TabIndex = 2;
            this.lsbMessage.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyUp);
            // 
            // inputText
            // 
            this.inputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputText.Location = new System.Drawing.Point(12, 68);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(258, 29);
            this.inputText.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(431, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 42);
            this.button3.TabIndex = 4;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(294, 60);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 42);
            this.button4.TabIndex = 5;
            this.button4.Text = "Test";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FrmRomanNumeralConv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 629);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.lsbMessage);
            this.Controls.Add(this.btnTestAToR);
            this.Controls.Add(this.btnTestRToA);
            this.Name = "FrmRomanNumeralConv";
            this.Text = "Roman Numeral Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTestRToA;
        private System.Windows.Forms.Button btnTestAToR;
        private System.Windows.Forms.ListBox lsbMessage;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

