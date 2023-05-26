namespace WinForms_HW_6
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox_productName = new TextBox();
            textBox_characteristics = new TextBox();
            textBox_description = new TextBox();
            textBox_price = new TextBox();
            button1 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 67);
            label1.Name = "label1";
            label1.Size = new Size(161, 27);
            label1.TabIndex = 0;
            label1.Text = "Наименование:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 100);
            label2.Name = "label2";
            label2.Size = new Size(161, 27);
            label2.TabIndex = 1;
            label2.Text = "Характеристика:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 133);
            label3.Name = "label3";
            label3.Size = new Size(161, 27);
            label3.TabIndex = 2;
            label3.Text = "Описание:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(4, 166);
            label4.Name = "label4";
            label4.Size = new Size(161, 27);
            label4.TabIndex = 3;
            label4.Text = "Цена:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox_productName
            // 
            textBox_productName.Location = new Point(171, 67);
            textBox_productName.Name = "textBox_productName";
            textBox_productName.Size = new Size(274, 27);
            textBox_productName.TabIndex = 4;
            // 
            // textBox_characteristics
            // 
            textBox_characteristics.Location = new Point(171, 100);
            textBox_characteristics.Name = "textBox_characteristics";
            textBox_characteristics.Size = new Size(274, 27);
            textBox_characteristics.TabIndex = 5;
            // 
            // textBox_description
            // 
            textBox_description.Location = new Point(171, 133);
            textBox_description.Name = "textBox_description";
            textBox_description.Size = new Size(274, 27);
            textBox_description.TabIndex = 6;
            // 
            // textBox_price
            // 
            textBox_price.Location = new Point(171, 166);
            textBox_price.Name = "textBox_price";
            textBox_price.Size = new Size(274, 27);
            textBox_price.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(3, 199);
            button1.Name = "button1";
            button1.Size = new Size(177, 54);
            button1.TabIndex = 8;
            button1.Text = "Добавить товар";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.PaleTurquoise;
            label5.Font = new Font("Microsoft YaHei", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(433, 47);
            label5.TabIndex = 9;
            label5.Text = "Добавление товара";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 253);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(textBox_price);
            Controls.Add(textBox_description);
            Controls.Add(textBox_characteristics);
            Controls.Add(textBox_productName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Добавление товара";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox_productName;
        private TextBox textBox_characteristics;
        private TextBox textBox_description;
        private TextBox textBox_price;
        private Button button1;
        private Label label5;
    }
}