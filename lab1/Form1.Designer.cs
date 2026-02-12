namespace lab1
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.fileButton = new System.Windows.Forms.Button();
            this.text1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.keyLabel = new System.Windows.Forms.Label();
            this.keyText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text1Label = new System.Windows.Forms.Label();
            this.decode = new System.Windows.Forms.Button();
            this.encode = new System.Windows.Forms.Button();
            this.text2 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.saveVig = new System.Windows.Forms.Button();
            this.keyLabelVig = new System.Windows.Forms.Label();
            this.keyVig = new System.Windows.Forms.TextBox();
            this.text2labelVig = new System.Windows.Forms.Label();
            this.text1labelVig = new System.Windows.Forms.Label();
            this.decodeVig = new System.Windows.Forms.Button();
            this.encodeVig = new System.Windows.Forms.Button();
            this.text2Vig = new System.Windows.Forms.TextBox();
            this.text1Vig = new System.Windows.Forms.TextBox();
            this.fileButtonVig = new System.Windows.Forms.Button();
            this.headerLabelVig = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerLabel.ForeColor = System.Drawing.Color.Crimson;
            this.headerLabel.Location = new System.Drawing.Point(20, 20);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(246, 30);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Шифр Плейфейра (англ)";
            // 
            // fileButton
            // 
            this.fileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fileButton.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.fileButton.FlatAppearance.BorderSize = 2;
            this.fileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileButton.ForeColor = System.Drawing.Color.Crimson;
            this.fileButton.Location = new System.Drawing.Point(496, 20);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(148, 52);
            this.fileButton.TabIndex = 1;
            this.fileButton.Text = "Ввести открытый текст из файла";
            this.fileButton.UseVisualStyleBackColor = true;
            this.fileButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // text1
            // 
            this.text1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text1.Location = new System.Drawing.Point(25, 95);
            this.text1.Multiline = true;
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(453, 30);
            this.text1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(675, 387);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MistyRose;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.keyLabel);
            this.tabPage1.Controls.Add(this.keyText);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.text1Label);
            this.tabPage1.Controls.Add(this.decode);
            this.tabPage1.Controls.Add(this.encode);
            this.tabPage1.Controls.Add(this.text2);
            this.tabPage1.Controls.Add(this.text1);
            this.tabPage1.Controls.Add(this.fileButton);
            this.tabPage1.Controls.Add(this.headerLabel);
            this.tabPage1.ForeColor = System.Drawing.Color.Crimson;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(667, 361);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Шифр Плейфейра";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(496, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 52);
            this.button1.TabIndex = 10;
            this.button1.Text = "Сохранить в файл\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keyLabel.Location = new System.Drawing.Point(22, 153);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(41, 17);
            this.keyLabel.TabIndex = 9;
            this.keyLabel.Text = "Ключ";
            // 
            // keyText
            // 
            this.keyText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keyText.Location = new System.Drawing.Point(25, 173);
            this.keyText.Multiline = true;
            this.keyText.Name = "keyText";
            this.keyText.Size = new System.Drawing.Size(453, 30);
            this.keyText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Получившийся текст";
            // 
            // text1Label
            // 
            this.text1Label.AutoSize = true;
            this.text1Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text1Label.Location = new System.Drawing.Point(22, 75);
            this.text1Label.Name = "text1Label";
            this.text1Label.Size = new System.Drawing.Size(101, 17);
            this.text1Label.TabIndex = 6;
            this.text1Label.Text = "Исходный текст";
            // 
            // decode
            // 
            this.decode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decode.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.decode.FlatAppearance.BorderSize = 2;
            this.decode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decode.ForeColor = System.Drawing.Color.Crimson;
            this.decode.Location = new System.Drawing.Point(330, 298);
            this.decode.Name = "decode";
            this.decode.Size = new System.Drawing.Size(148, 52);
            this.decode.TabIndex = 5;
            this.decode.Text = "Дешифровать";
            this.decode.UseVisualStyleBackColor = true;
            this.decode.Click += new System.EventHandler(this.decode_Click);
            // 
            // encode
            // 
            this.encode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.encode.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.encode.FlatAppearance.BorderSize = 2;
            this.encode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encode.ForeColor = System.Drawing.Color.Crimson;
            this.encode.Location = new System.Drawing.Point(25, 298);
            this.encode.Name = "encode";
            this.encode.Size = new System.Drawing.Size(148, 52);
            this.encode.TabIndex = 4;
            this.encode.Text = "Зашифровать";
            this.encode.UseVisualStyleBackColor = true;
            this.encode.Click += new System.EventHandler(this.encode_Click);
            // 
            // text2
            // 
            this.text2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text2.Location = new System.Drawing.Point(25, 253);
            this.text2.Multiline = true;
            this.text2.Name = "text2";
            this.text2.ReadOnly = true;
            this.text2.Size = new System.Drawing.Size(453, 30);
            this.text2.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MistyRose;
            this.tabPage2.Controls.Add(this.saveVig);
            this.tabPage2.Controls.Add(this.keyLabelVig);
            this.tabPage2.Controls.Add(this.keyVig);
            this.tabPage2.Controls.Add(this.text2labelVig);
            this.tabPage2.Controls.Add(this.text1labelVig);
            this.tabPage2.Controls.Add(this.decodeVig);
            this.tabPage2.Controls.Add(this.encodeVig);
            this.tabPage2.Controls.Add(this.text2Vig);
            this.tabPage2.Controls.Add(this.text1Vig);
            this.tabPage2.Controls.Add(this.fileButtonVig);
            this.tabPage2.Controls.Add(this.headerLabelVig);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(667, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Алгоритм Виженера";
            // 
            // saveVig
            // 
            this.saveVig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveVig.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.saveVig.FlatAppearance.BorderSize = 2;
            this.saveVig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveVig.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveVig.ForeColor = System.Drawing.Color.Crimson;
            this.saveVig.Location = new System.Drawing.Point(496, 297);
            this.saveVig.Name = "saveVig";
            this.saveVig.Size = new System.Drawing.Size(148, 52);
            this.saveVig.TabIndex = 21;
            this.saveVig.Text = "Сохранить в файл\r\n";
            this.saveVig.UseVisualStyleBackColor = true;
            this.saveVig.Click += new System.EventHandler(this.saveVig_Click);
            // 
            // keyLabelVig
            // 
            this.keyLabelVig.AutoSize = true;
            this.keyLabelVig.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keyLabelVig.ForeColor = System.Drawing.Color.Crimson;
            this.keyLabelVig.Location = new System.Drawing.Point(22, 152);
            this.keyLabelVig.Name = "keyLabelVig";
            this.keyLabelVig.Size = new System.Drawing.Size(41, 17);
            this.keyLabelVig.TabIndex = 20;
            this.keyLabelVig.Text = "Ключ";
            // 
            // keyVig
            // 
            this.keyVig.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keyVig.Location = new System.Drawing.Point(25, 172);
            this.keyVig.Multiline = true;
            this.keyVig.Name = "keyVig";
            this.keyVig.Size = new System.Drawing.Size(453, 30);
            this.keyVig.TabIndex = 14;
            // 
            // text2labelVig
            // 
            this.text2labelVig.AutoSize = true;
            this.text2labelVig.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text2labelVig.ForeColor = System.Drawing.Color.Crimson;
            this.text2labelVig.Location = new System.Drawing.Point(22, 232);
            this.text2labelVig.Name = "text2labelVig";
            this.text2labelVig.Size = new System.Drawing.Size(130, 17);
            this.text2labelVig.TabIndex = 18;
            this.text2labelVig.Text = "Получившийся текст";
            // 
            // text1labelVig
            // 
            this.text1labelVig.AutoSize = true;
            this.text1labelVig.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text1labelVig.ForeColor = System.Drawing.Color.Crimson;
            this.text1labelVig.Location = new System.Drawing.Point(22, 74);
            this.text1labelVig.Name = "text1labelVig";
            this.text1labelVig.Size = new System.Drawing.Size(101, 17);
            this.text1labelVig.TabIndex = 17;
            this.text1labelVig.Text = "Исходный текст";
            // 
            // decodeVig
            // 
            this.decodeVig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decodeVig.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.decodeVig.FlatAppearance.BorderSize = 2;
            this.decodeVig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decodeVig.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decodeVig.ForeColor = System.Drawing.Color.Crimson;
            this.decodeVig.Location = new System.Drawing.Point(330, 297);
            this.decodeVig.Name = "decodeVig";
            this.decodeVig.Size = new System.Drawing.Size(148, 52);
            this.decodeVig.TabIndex = 16;
            this.decodeVig.Text = "Дешифровать";
            this.decodeVig.UseVisualStyleBackColor = true;
            this.decodeVig.Click += new System.EventHandler(this.decodeVig_Click);
            // 
            // encodeVig
            // 
            this.encodeVig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.encodeVig.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.encodeVig.FlatAppearance.BorderSize = 2;
            this.encodeVig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encodeVig.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encodeVig.ForeColor = System.Drawing.Color.Crimson;
            this.encodeVig.Location = new System.Drawing.Point(25, 297);
            this.encodeVig.Name = "encodeVig";
            this.encodeVig.Size = new System.Drawing.Size(148, 52);
            this.encodeVig.TabIndex = 15;
            this.encodeVig.Text = "Зашифровать";
            this.encodeVig.UseVisualStyleBackColor = true;
            this.encodeVig.Click += new System.EventHandler(this.encodeVig_Click);
            // 
            // text2Vig
            // 
            this.text2Vig.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text2Vig.Location = new System.Drawing.Point(25, 252);
            this.text2Vig.Multiline = true;
            this.text2Vig.Name = "text2Vig";
            this.text2Vig.ReadOnly = true;
            this.text2Vig.Size = new System.Drawing.Size(453, 30);
            this.text2Vig.TabIndex = 19;
            // 
            // text1Vig
            // 
            this.text1Vig.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text1Vig.Location = new System.Drawing.Point(25, 94);
            this.text1Vig.Multiline = true;
            this.text1Vig.Name = "text1Vig";
            this.text1Vig.Size = new System.Drawing.Size(453, 30);
            this.text1Vig.TabIndex = 13;
            // 
            // fileButtonVig
            // 
            this.fileButtonVig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fileButtonVig.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.fileButtonVig.FlatAppearance.BorderSize = 2;
            this.fileButtonVig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileButtonVig.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileButtonVig.ForeColor = System.Drawing.Color.Crimson;
            this.fileButtonVig.Location = new System.Drawing.Point(496, 19);
            this.fileButtonVig.Name = "fileButtonVig";
            this.fileButtonVig.Size = new System.Drawing.Size(148, 52);
            this.fileButtonVig.TabIndex = 12;
            this.fileButtonVig.Text = "Ввести открытый текст из файла";
            this.fileButtonVig.UseVisualStyleBackColor = true;
            this.fileButtonVig.Click += new System.EventHandler(this.fileButtonVig_Click);
            // 
            // headerLabelVig
            // 
            this.headerLabelVig.AutoSize = true;
            this.headerLabelVig.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerLabelVig.ForeColor = System.Drawing.Color.Crimson;
            this.headerLabelVig.Location = new System.Drawing.Point(20, 19);
            this.headerLabelVig.Name = "headerLabelVig";
            this.headerLabelVig.Size = new System.Drawing.Size(279, 30);
            this.headerLabelVig.TabIndex = 11;
            this.headerLabelVig.Text = "Алгоритм Виженера (русск)";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(680, 391);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЛР 1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button decode;
        private System.Windows.Forms.Button encode;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label text1Label;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.TextBox keyText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button saveVig;
        private System.Windows.Forms.Label keyLabelVig;
        private System.Windows.Forms.TextBox keyVig;
        private System.Windows.Forms.Label text2labelVig;
        private System.Windows.Forms.Label text1labelVig;
        private System.Windows.Forms.Button decodeVig;
        private System.Windows.Forms.Button encodeVig;
        private System.Windows.Forms.TextBox text2Vig;
        private System.Windows.Forms.TextBox text1Vig;
        private System.Windows.Forms.Button fileButtonVig;
        private System.Windows.Forms.Label headerLabelVig;
    }
}

