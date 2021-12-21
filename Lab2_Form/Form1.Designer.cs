
namespace Lab2_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.upperButton = new System.Windows.Forms.RadioButton();
            this.wordCountButton = new System.Windows.Forms.RadioButton();
            this.decryptButton = new System.Windows.Forms.RadioButton();
            this.encryptButton = new System.Windows.Forms.RadioButton();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.executeButton = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.saveNameButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.operationsButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите исходный текст";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(241, 49);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(351, 405);
            this.inputBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.upperButton);
            this.groupBox1.Controls.Add(this.wordCountButton);
            this.groupBox1.Controls.Add(this.decryptButton);
            this.groupBox1.Controls.Add(this.encryptButton);
            this.groupBox1.Location = new System.Drawing.Point(610, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 158);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите опцию";
            // 
            // upperButton
            // 
            this.upperButton.AutoSize = true;
            this.upperButton.Location = new System.Drawing.Point(202, 102);
            this.upperButton.Name = "upperButton";
            this.upperButton.Size = new System.Drawing.Size(291, 21);
            this.upperButton.TabIndex = 3;
            this.upperButton.TabStop = true;
            this.upperButton.Text = "Перевести все слова в верхний регистр";
            this.upperButton.UseVisualStyleBackColor = true;
            // 
            // wordCountButton
            // 
            this.wordCountButton.AutoSize = true;
            this.wordCountButton.Location = new System.Drawing.Point(202, 47);
            this.wordCountButton.Name = "wordCountButton";
            this.wordCountButton.Size = new System.Drawing.Size(213, 21);
            this.wordCountButton.TabIndex = 2;
            this.wordCountButton.TabStop = true;
            this.wordCountButton.Text = "Посчитать количество слов";
            this.wordCountButton.UseVisualStyleBackColor = true;
            // 
            // decryptButton
            // 
            this.decryptButton.AutoSize = true;
            this.decryptButton.Location = new System.Drawing.Point(6, 102);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(168, 21);
            this.decryptButton.TabIndex = 1;
            this.decryptButton.TabStop = true;
            this.decryptButton.Text = "Расшифровать текст";
            this.decryptButton.UseVisualStyleBackColor = true;
            // 
            // encryptButton
            // 
            this.encryptButton.AutoSize = true;
            this.encryptButton.Location = new System.Drawing.Point(6, 47);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(161, 21);
            this.encryptButton.TabIndex = 0;
            this.encryptButton.TabStop = true;
            this.encryptButton.Text = "Зашифровать текст";
            this.encryptButton.UseVisualStyleBackColor = true;
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(12, 122);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(100, 22);
            this.keyBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите ключ";
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(610, 185);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(504, 55);
            this.executeButton.TabIndex = 5;
            this.executeButton.Text = "Выполнить";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(610, 304);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(510, 84);
            this.outputBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(613, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Вывод";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Введите имя";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(9, 51);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 22);
            this.nameBox.TabIndex = 10;
            // 
            // saveNameButton
            // 
            this.saveNameButton.Location = new System.Drawing.Point(9, 212);
            this.saveNameButton.Name = "saveNameButton";
            this.saveNameButton.Size = new System.Drawing.Size(115, 57);
            this.saveNameButton.TabIndex = 11;
            this.saveNameButton.Text = "Сохранить имя и ключ";
            this.saveNameButton.UseVisualStyleBackColor = true;
            this.saveNameButton.Click += new System.EventHandler(this.saveNameButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(9, 147);
            this.label5.MaximumSize = new System.Drawing.Size(180, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "*ключ должен состоять из 4 цифр от 1 до 4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(9, 173);
            this.label6.MaximumSize = new System.Drawing.Size(180, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "*все цифры должны быть разделены пробелом";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.nameBox);
            this.groupBox2.Controls.Add(this.saveNameButton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.keyBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(23, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 278);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Заполните данные";
            // 
            // operationsButton
            // 
            this.operationsButton.Location = new System.Drawing.Point(666, 412);
            this.operationsButton.Name = "operationsButton";
            this.operationsButton.Size = new System.Drawing.Size(281, 42);
            this.operationsButton.TabIndex = 15;
            this.operationsButton.Text = "Вывести количество выполненных операций";
            this.operationsButton.UseVisualStyleBackColor = true;
            this.operationsButton.Click += new System.EventHandler(this.operationsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 473);
            this.Controls.Add(this.operationsButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "WorkWithText";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton upperButton;
        private System.Windows.Forms.RadioButton wordCountButton;
        private System.Windows.Forms.RadioButton decryptButton;
        private System.Windows.Forms.RadioButton encryptButton;
        private System.Windows.Forms.TextBox keyBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button saveNameButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button operationsButton;
    }
}

