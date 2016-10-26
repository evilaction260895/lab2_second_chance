namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tP1_label2 = new System.Windows.Forms.Label();
            this.tP1_label1 = new System.Windows.Forms.Label();
            this.tP1_textBox2 = new System.Windows.Forms.TextBox();
            this.tP1_textBox1 = new System.Windows.Forms.TextBox();
            this.tP1_button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tP1_label3 = new System.Windows.Forms.Label();
            this.tP1_textBox3 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(428, 329);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tP1_textBox3);
            this.tabPage1.Controls.Add(this.tP1_label3);
            this.tabPage1.Controls.Add(this.tP1_label2);
            this.tabPage1.Controls.Add(this.tP1_label1);
            this.tabPage1.Controls.Add(this.tP1_textBox2);
            this.tabPage1.Controls.Add(this.tP1_textBox1);
            this.tabPage1.Controls.Add(this.tP1_button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(420, 303);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tP1_label2
            // 
            this.tP1_label2.AutoSize = true;
            this.tP1_label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tP1_label2.Location = new System.Drawing.Point(39, 121);
            this.tP1_label2.Name = "tP1_label2";
            this.tP1_label2.Size = new System.Drawing.Size(196, 25);
            this.tP1_label2.TabIndex = 4;
            this.tP1_label2.Text = "Введите переменную b:";
            // 
            // tP1_label1
            // 
            this.tP1_label1.AutoSize = true;
            this.tP1_label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tP1_label1.Location = new System.Drawing.Point(37, 69);
            this.tP1_label1.Name = "tP1_label1";
            this.tP1_label1.Size = new System.Drawing.Size(196, 25);
            this.tP1_label1.TabIndex = 3;
            this.tP1_label1.Text = "Введите переменную а:";
            // 
            // tP1_textBox2
            // 
            this.tP1_textBox2.Location = new System.Drawing.Point(239, 126);
            this.tP1_textBox2.Name = "tP1_textBox2";
            this.tP1_textBox2.Size = new System.Drawing.Size(118, 20);
            this.tP1_textBox2.TabIndex = 2;
            // 
            // tP1_textBox1
            // 
            this.tP1_textBox1.Location = new System.Drawing.Point(239, 74);
            this.tP1_textBox1.Name = "tP1_textBox1";
            this.tP1_textBox1.Size = new System.Drawing.Size(118, 20);
            this.tP1_textBox1.TabIndex = 1;
            // 
            // tP1_button1
            // 
            this.tP1_button1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tP1_button1.Location = new System.Drawing.Point(164, 182);
            this.tP1_button1.Name = "tP1_button1";
            this.tP1_button1.Size = new System.Drawing.Size(113, 33);
            this.tP1_button1.TabIndex = 0;
            this.tP1_button1.Text = "Вычислить";
            this.tP1_button1.UseVisualStyleBackColor = true;
            this.tP1_button1.Click += new System.EventHandler(this.tP1_button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(420, 303);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tP1_label3
            // 
            this.tP1_label3.AutoSize = true;
            this.tP1_label3.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tP1_label3.Location = new System.Drawing.Point(44, 245);
            this.tP1_label3.Name = "tP1_label3";
            this.tP1_label3.Size = new System.Drawing.Size(105, 25);
            this.tP1_label3.TabIndex = 5;
            this.tP1_label3.Text = "Результат:";
            // 
            // tP1_textBox3
            // 
            this.tP1_textBox3.Location = new System.Drawing.Point(164, 250);
            this.tP1_textBox3.Name = "tP1_textBox3";
            this.tP1_textBox3.Size = new System.Drawing.Size(118, 20);
            this.tP1_textBox3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 353);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button tP1_button1;
        private System.Windows.Forms.Label tP1_label2;
        private System.Windows.Forms.Label tP1_label1;
        private System.Windows.Forms.TextBox tP1_textBox2;
        private System.Windows.Forms.TextBox tP1_textBox1;
        private System.Windows.Forms.Label tP1_label3;
        private System.Windows.Forms.TextBox tP1_textBox3;
    }
}

