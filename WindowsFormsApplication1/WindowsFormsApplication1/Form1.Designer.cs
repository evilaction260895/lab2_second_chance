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
            this.tP1_label4 = new System.Windows.Forms.Label();
            this.tP2_label3_Green = new System.Windows.Forms.Label();
            this.tP2_label2_Blue = new System.Windows.Forms.Label();
            this.tP2_label1_Red = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(59, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(364, 282);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tP1_label4);
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
            this.tabPage1.Size = new System.Drawing.Size(356, 256);
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
            this.tabPage2.Controls.Add(this.tP2_label3_Green);
            this.tabPage2.Controls.Add(this.tP2_label2_Blue);
            this.tabPage2.Controls.Add(this.tP2_label1_Red);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(420, 303);
            this.tabPage2.Size = new System.Drawing.Size(356, 256);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
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
            // tP1_label4
            // 
            this.tP1_label4.AutoSize = true;
            this.tP1_label4.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tP1_label4.Location = new System.Drawing.Point(148, 13);
            this.tP1_label4.Name = "tP1_label4";
            this.tP1_label4.Size = new System.Drawing.Size(134, 33);
            this.tP1_label4.TabIndex = 7;
            this.tP1_label4.Text = "Умножение";
            this.tP1_label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // tP2_label3_Green
            // 
            this.tP2_label3_Green.AutoSize = true;
            this.tP2_label3_Green.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tP2_label3_Green.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tP2_label3_Green.Location = new System.Drawing.Point(260, 195);
            this.tP2_label3_Green.Name = "tP2_label3_Green";
            this.tP2_label3_Green.Size = new System.Drawing.Size(70, 33);
            this.tP2_label3_Green.TabIndex = 2;
            this.tP2_label3_Green.Text = "Green";
            this.tP2_label3_Green.MouseLeave += new System.EventHandler(this.tP2_label3_Green_MouseLeave);
            this.tP2_label3_Green.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tP2_label3_Green_MouseMove);
            // 
            // tP2_label2_Blue
            // 
            this.tP2_label2_Blue.AutoSize = true;
            this.tP2_label2_Blue.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tP2_label2_Blue.Location = new System.Drawing.Point(137, 104);
            this.tP2_label2_Blue.Name = "tP2_label2_Blue";
            this.tP2_label2_Blue.Size = new System.Drawing.Size(58, 33);
            this.tP2_label2_Blue.TabIndex = 1;
            this.tP2_label2_Blue.Text = "Blue";
            this.tP2_label2_Blue.MouseLeave += new System.EventHandler(this.tP2_label2_Blue_MouseLeave);
            this.tP2_label2_Blue.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tP2_label2_Blue_MouseMove);
            // 
            // tP2_label1_Red
            // 
            this.tP2_label1_Red.AutoSize = true;
            this.tP2_label1_Red.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tP2_label1_Red.Location = new System.Drawing.Point(22, 23);
            this.tP2_label1_Red.Name = "tP2_label1_Red";
            this.tP2_label1_Red.Size = new System.Drawing.Size(52, 33);
            this.tP2_label1_Red.TabIndex = 0;
            this.tP2_label1_Red.Text = "Red";
            this.tP2_label1_Red.MouseLeave += new System.EventHandler(this.tP2_label1_Red_MouseLeave);
            this.tP2_label1_Red.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tP2_label1_Red_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 393);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.Label tP1_label4;
        private System.Windows.Forms.Label tP2_label3_Green;
        private System.Windows.Forms.Label tP2_label2_Blue;
        private System.Windows.Forms.Label tP2_label1_Red;
    }
}

