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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tP2_label3_Green = new System.Windows.Forms.Label();
            this.tP2_label2_Blue = new System.Windows.Forms.Label();
            this.tP2_label1_Red = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(356, 256);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tP2_label3_Green);
            this.tabPage2.Controls.Add(this.tP2_label2_Blue);
            this.tabPage2.Controls.Add(this.tP2_label1_Red);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(356, 256);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label tP2_label3_Green;
        private System.Windows.Forms.Label tP2_label2_Blue;
        private System.Windows.Forms.Label tP2_label1_Red;
    }
}

