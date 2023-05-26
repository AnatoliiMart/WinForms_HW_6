namespace WinForms_HW_6
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
            colorDialog1 = new ColorDialog();
            comboBox_productsInStock = new ComboBox();
            listBox_selectedProducts = new ListBox();
            textBox_productPrice = new TextBox();
            textBox_totalCost = new TextBox();
            button_addToSelection = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button_addProductToDataBase = new Button();
            SuspendLayout();
            // 
            // comboBox_productsInStock
            // 
            comboBox_productsInStock.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_productsInStock.FormattingEnabled = true;
            comboBox_productsInStock.Location = new Point(12, 53);
            comboBox_productsInStock.Name = "comboBox_productsInStock";
            comboBox_productsInStock.Size = new Size(289, 28);
            comboBox_productsInStock.Sorted = true;
            comboBox_productsInStock.TabIndex = 0;
            comboBox_productsInStock.SelectedIndexChanged += comboBox_productsInStock_SelectedIndexChanged;
            // 
            // listBox_selectedProducts
            // 
            listBox_selectedProducts.FormattingEnabled = true;
            listBox_selectedProducts.ItemHeight = 20;
            listBox_selectedProducts.Location = new Point(330, 53);
            listBox_selectedProducts.Name = "listBox_selectedProducts";
            listBox_selectedProducts.Size = new Size(289, 364);
            listBox_selectedProducts.TabIndex = 1;
            // 
            // textBox_productPrice
            // 
            textBox_productPrice.Location = new Point(80, 101);
            textBox_productPrice.Name = "textBox_productPrice";
            textBox_productPrice.ReadOnly = true;
            textBox_productPrice.Size = new Size(125, 27);
            textBox_productPrice.TabIndex = 2;
            textBox_productPrice.Text = "0";
            textBox_productPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_totalCost
            // 
            textBox_totalCost.Location = new Point(494, 424);
            textBox_totalCost.Name = "textBox_totalCost";
            textBox_totalCost.ReadOnly = true;
            textBox_totalCost.Size = new Size(84, 27);
            textBox_totalCost.TabIndex = 3;
            textBox_totalCost.Text = "0";
            textBox_totalCost.TextAlign = HorizontalAlignment.Center;
            // 
            // button_addToSelection
            // 
            button_addToSelection.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button_addToSelection.Location = new Point(12, 144);
            button_addToSelection.Name = "button_addToSelection";
            button_addToSelection.Size = new Size(289, 33);
            button_addToSelection.TabIndex = 4;
            button_addToSelection.Text = "Добавить в \"выбранные товары\"";
            button_addToSelection.UseVisualStyleBackColor = true;
            button_addToSelection.Click += button_addToSelection_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(269, 41);
            label1.TabIndex = 5;
            label1.Text = "Товары в наличии";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 101);
            label2.Name = "label2";
            label2.Size = new Size(62, 27);
            label2.TabIndex = 6;
            label2.Text = "Цена:";
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(330, 9);
            label3.Name = "label3";
            label3.Size = new Size(289, 41);
            label3.TabIndex = 7;
            label3.Text = "Выбранные товары";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(213, 107);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 8;
            label4.Text = "грн.";
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(330, 424);
            label5.Name = "label5";
            label5.Size = new Size(158, 27);
            label5.TabIndex = 9;
            label5.Text = "Общая стоимость:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(584, 431);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 10;
            label6.Text = "грн.";
            // 
            // button_addProductToDataBase
            // 
            button_addProductToDataBase.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button_addProductToDataBase.Location = new Point(12, 198);
            button_addProductToDataBase.Name = "button_addProductToDataBase";
            button_addProductToDataBase.Size = new Size(289, 33);
            button_addProductToDataBase.TabIndex = 11;
            button_addProductToDataBase.Text = "Добавить продукт в базу данных";
            button_addProductToDataBase.UseVisualStyleBackColor = true;
            button_addProductToDataBase.Click += button_addProductToDataBase_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 453);
            Controls.Add(button_addProductToDataBase);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_addToSelection);
            Controls.Add(textBox_totalCost);
            Controls.Add(textBox_productPrice);
            Controls.Add(listBox_selectedProducts);
            Controls.Add(comboBox_productsInStock);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColorDialog colorDialog1;
        private ComboBox comboBox_productsInStock;
        private ListBox listBox_selectedProducts;
        private TextBox textBox_productPrice;
        private TextBox textBox_totalCost;
        private Button button_addToSelection;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button_addProductToDataBase;
    }
}