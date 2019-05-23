namespace KRIP_SHIFR_VERNAMA
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShifrText = new System.Windows.Forms.TextBox();
            this.Text = new System.Windows.Forms.TextBox();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.button_unShifr = new System.Windows.Forms.Button();
            this.button_Shifr = new System.Windows.Forms.Button();
            this.GenerationKey = new System.Windows.Forms.Button();
            this.BoxGenerationKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShifrText
            // 
            this.ShifrText.Location = new System.Drawing.Point(100, 259);
            this.ShifrText.Name = "ShifrText";
            this.ShifrText.Size = new System.Drawing.Size(549, 20);
            this.ShifrText.TabIndex = 9;
            // 
            // Text
            // 
            this.Text.Location = new System.Drawing.Point(100, 52);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(549, 20);
            this.Text.TabIndex = 8;
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(100, 156);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(549, 20);
            this.keyBox.TabIndex = 7;
            // 
            // button_unShifr
            // 
            this.button_unShifr.Location = new System.Drawing.Point(275, 219);
            this.button_unShifr.Name = "button_unShifr";
            this.button_unShifr.Size = new System.Drawing.Size(217, 23);
            this.button_unShifr.TabIndex = 6;
            this.button_unShifr.Text = "Расшифровать";
            this.button_unShifr.UseVisualStyleBackColor = true;
            this.button_unShifr.Click += new System.EventHandler(this.button_unShifr_Click);
            // 
            // button_Shifr
            // 
            this.button_Shifr.Location = new System.Drawing.Point(275, 105);
            this.button_Shifr.Name = "button_Shifr";
            this.button_Shifr.Size = new System.Drawing.Size(217, 23);
            this.button_Shifr.TabIndex = 5;
            this.button_Shifr.Text = "Зашифровать";
            this.button_Shifr.UseVisualStyleBackColor = true;
            this.button_Shifr.Click += new System.EventHandler(this.button_Shifr_Click);
            // 
            // GenerationKey
            // 
            this.GenerationKey.Location = new System.Drawing.Point(275, 345);
            this.GenerationKey.Name = "GenerationKey";
            this.GenerationKey.Size = new System.Drawing.Size(217, 23);
            this.GenerationKey.TabIndex = 10;
            this.GenerationKey.Text = "Сгенерировать";
            this.GenerationKey.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GenerationKey.UseVisualStyleBackColor = true;
            this.GenerationKey.Click += new System.EventHandler(this.GenerationKey_Click);
            // 
            // BoxGenerationKey
            // 
            this.BoxGenerationKey.Location = new System.Drawing.Point(100, 387);
            this.BoxGenerationKey.Name = "BoxGenerationKey";
            this.BoxGenerationKey.Size = new System.Drawing.Size(549, 20);
            this.BoxGenerationKey.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxGenerationKey);
            this.Controls.Add(this.GenerationKey);
            this.Controls.Add(this.ShifrText);
            this.Controls.Add(this.Text);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.button_unShifr);
            this.Controls.Add(this.button_Shifr);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ShifrText;
        private System.Windows.Forms.TextBox Text;
        private System.Windows.Forms.TextBox keyBox;
        private System.Windows.Forms.Button button_unShifr;
        private System.Windows.Forms.Button button_Shifr;
        private System.Windows.Forms.Button GenerationKey;
        private System.Windows.Forms.TextBox BoxGenerationKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

