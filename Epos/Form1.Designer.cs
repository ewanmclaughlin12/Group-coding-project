
namespace Epos
{
    partial class CoffeHouseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoffeHouseForm));
            this.SelectionPanel = new System.Windows.Forms.Panel();
            this.DisplayDataGridView = new System.Windows.Forms.DataGridView();
            this.CoffetypeDataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeCoffeDataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityDataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceDataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.TotalPurchasesCostLabel = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.PurchaseButton = new System.Windows.Forms.Button();
            this.DiplaDataGrid = new System.Windows.Forms.DateTimePicker();
            this.QuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CoffeTypeListBox = new System.Windows.Forms.ListBox();
            this.CoffeSizeListBox = new System.Windows.Forms.ListBox();
            this.ButtonGroupBox = new System.Windows.Forms.GroupBox();
            this.StockReportButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SalesReportButton = new System.Windows.Forms.Button();
            this.ClientDetailsPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.TelephoneTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.TransactionNumberLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SelectionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).BeginInit();
            this.ButtonGroupBox.SuspendLayout();
            this.ClientDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectionPanel
            // 
            this.SelectionPanel.BackColor = System.Drawing.Color.LemonChiffon;
            this.SelectionPanel.Controls.Add(this.DisplayDataGridView);
            this.SelectionPanel.Controls.Add(this.label5);
            this.SelectionPanel.Controls.Add(this.label1);
            this.SelectionPanel.Controls.Add(this.CancelButton);
            this.SelectionPanel.Controls.Add(this.TotalPurchasesCostLabel);
            this.SelectionPanel.Controls.Add(this.RemoveButton);
            this.SelectionPanel.Controls.Add(this.AddOrderButton);
            this.SelectionPanel.Controls.Add(this.PurchaseButton);
            this.SelectionPanel.Controls.Add(this.DiplaDataGrid);
            this.SelectionPanel.Controls.Add(this.QuantityNumericUpDown);
            this.SelectionPanel.Controls.Add(this.label8);
            this.SelectionPanel.Controls.Add(this.label12);
            this.SelectionPanel.Controls.Add(this.label11);
            this.SelectionPanel.Controls.Add(this.label10);
            this.SelectionPanel.Controls.Add(this.label9);
            this.SelectionPanel.Controls.Add(this.CoffeTypeListBox);
            this.SelectionPanel.Controls.Add(this.CoffeSizeListBox);
            this.SelectionPanel.Location = new System.Drawing.Point(12, 12);
            this.SelectionPanel.Name = "SelectionPanel";
            this.SelectionPanel.Size = new System.Drawing.Size(788, 230);
            this.SelectionPanel.TabIndex = 67;
            // 
            // DisplayDataGridView
            // 
            this.DisplayDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DisplayDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DisplayDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DisplayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplayDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CoffetypeDataGrid,
            this.SizeCoffeDataGrid,
            this.QuantityDataGrid,
            this.PriceDataGrid});
            this.DisplayDataGridView.Location = new System.Drawing.Point(480, 48);
            this.DisplayDataGridView.Name = "DisplayDataGridView";
            this.DisplayDataGridView.Size = new System.Drawing.Size(289, 143);
            this.DisplayDataGridView.TabIndex = 78;
            // 
            // CoffetypeDataGrid
            // 
            this.CoffetypeDataGrid.HeaderText = "Coffe";
            this.CoffetypeDataGrid.Name = "CoffetypeDataGrid";
            this.CoffetypeDataGrid.Width = 57;
            // 
            // SizeCoffeDataGrid
            // 
            this.SizeCoffeDataGrid.HeaderText = "size";
            this.SizeCoffeDataGrid.Name = "SizeCoffeDataGrid";
            this.SizeCoffeDataGrid.Width = 50;
            // 
            // QuantityDataGrid
            // 
            this.QuantityDataGrid.HeaderText = "Quantity";
            this.QuantityDataGrid.Name = "QuantityDataGrid";
            this.QuantityDataGrid.Width = 71;
            // 
            // PriceDataGrid
            // 
            this.PriceDataGrid.HeaderText = "Price";
            this.PriceDataGrid.Name = "PriceDataGrid";
            this.PriceDataGrid.Width = 56;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(477, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(292, 21);
            this.label5.TabIndex = 76;
            this.label5.Text = "Display";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(489, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 72;
            this.label1.Text = "Total Price";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(399, 151);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 71;
            this.CancelButton.Text = "&Cancel";
            this.CancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // TotalPurchasesCostLabel
            // 
            this.TotalPurchasesCostLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TotalPurchasesCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalPurchasesCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPurchasesCostLabel.Location = new System.Drawing.Point(573, 198);
            this.TotalPurchasesCostLabel.Name = "TotalPurchasesCostLabel";
            this.TotalPurchasesCostLabel.Size = new System.Drawing.Size(106, 21);
            this.TotalPurchasesCostLabel.TabIndex = 70;
            this.TotalPurchasesCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(399, 100);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 63;
            this.RemoveButton.Text = "&Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Location = new System.Drawing.Point(399, 71);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(75, 23);
            this.AddOrderButton.TabIndex = 40;
            this.AddOrderButton.Text = "Add Order";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // PurchaseButton
            // 
            this.PurchaseButton.Location = new System.Drawing.Point(685, 197);
            this.PurchaseButton.Name = "PurchaseButton";
            this.PurchaseButton.Size = new System.Drawing.Size(75, 23);
            this.PurchaseButton.TabIndex = 46;
            this.PurchaseButton.Text = "&Purchase";
            this.PurchaseButton.UseVisualStyleBackColor = true;
            // 
            // DiplaDataGrid
            // 
            this.DiplaDataGrid.Location = new System.Drawing.Point(57, 22);
            this.DiplaDataGrid.Name = "DiplaDataGrid";
            this.DiplaDataGrid.Size = new System.Drawing.Size(124, 20);
            this.DiplaDataGrid.TabIndex = 41;
            // 
            // QuantityNumericUpDown
            // 
            this.QuantityNumericUpDown.Location = new System.Drawing.Point(264, 180);
            this.QuantityNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.QuantityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuantityNumericUpDown.Name = "QuantityNumericUpDown";
            this.QuantityNumericUpDown.Size = new System.Drawing.Size(95, 20);
            this.QuantityNumericUpDown.TabIndex = 40;
            this.QuantityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(264, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 21);
            this.label8.TabIndex = 39;
            this.label8.Text = "Quantity";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 21);
            this.label12.TabIndex = 38;
            this.label12.Text = "Coffe ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(298, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 21);
            this.label11.TabIndex = 36;
            this.label11.Text = "Extra(Cost)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(229, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 21);
            this.label10.TabIndex = 35;
            this.label10.Text = "Size";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(102, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 21);
            this.label9.TabIndex = 34;
            this.label9.Text = "Price";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CoffeTypeListBox
            // 
            this.CoffeTypeListBox.FormattingEnabled = true;
            this.CoffeTypeListBox.Items.AddRange(new object[] {
            "Expresso                                2.10£",
            "Latte                                      3.00£",
            "Americano                             2.30£",
            "Cappuccino                          3.10£",
            "Flat white                              3.20£",
            "Lungo                                    3.00£",
            "Affogato                                3.50£",
            "Cortado                                 3.35£",
            "Irish                                       3.15£",
            "Macchiato                             3.10£"});
            this.CoffeTypeListBox.Location = new System.Drawing.Point(16, 66);
            this.CoffeTypeListBox.Name = "CoffeTypeListBox";
            this.CoffeTypeListBox.Size = new System.Drawing.Size(189, 134);
            this.CoffeTypeListBox.TabIndex = 31;
            // 
            // CoffeSizeListBox
            // 
            this.CoffeSizeListBox.FormattingEnabled = true;
            this.CoffeSizeListBox.Items.AddRange(new object[] {
            "X-Small                     0.00£",
            "Small                         0.30£",
            "Medium                    0.50£",
            "Large                         1.10£",
            "X-Large                     1.20£"});
            this.CoffeSizeListBox.Location = new System.Drawing.Point(232, 71);
            this.CoffeSizeListBox.Name = "CoffeSizeListBox";
            this.CoffeSizeListBox.Size = new System.Drawing.Size(149, 69);
            this.CoffeSizeListBox.TabIndex = 25;
            // 
            // ButtonGroupBox
            // 
            this.ButtonGroupBox.Controls.Add(this.StockReportButton);
            this.ButtonGroupBox.Controls.Add(this.ExitButton);
            this.ButtonGroupBox.Controls.Add(this.SalesReportButton);
            this.ButtonGroupBox.Location = new System.Drawing.Point(688, 327);
            this.ButtonGroupBox.Name = "ButtonGroupBox";
            this.ButtonGroupBox.Size = new System.Drawing.Size(112, 169);
            this.ButtonGroupBox.TabIndex = 69;
            this.ButtonGroupBox.TabStop = false;
            // 
            // StockReportButton
            // 
            this.StockReportButton.Location = new System.Drawing.Point(20, 64);
            this.StockReportButton.Name = "StockReportButton";
            this.StockReportButton.Size = new System.Drawing.Size(75, 37);
            this.StockReportButton.TabIndex = 62;
            this.StockReportButton.Text = "&Stock Report";
            this.StockReportButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(20, 117);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 45;
            this.ExitButton.Text = "&Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SalesReportButton
            // 
            this.SalesReportButton.Location = new System.Drawing.Point(19, 19);
            this.SalesReportButton.Name = "SalesReportButton";
            this.SalesReportButton.Size = new System.Drawing.Size(75, 39);
            this.SalesReportButton.TabIndex = 44;
            this.SalesReportButton.Text = "&Sales Report";
            this.SalesReportButton.UseVisualStyleBackColor = true;
            // 
            // ClientDetailsPanel
            // 
            this.ClientDetailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientDetailsPanel.Controls.Add(this.pictureBox1);
            this.ClientDetailsPanel.Controls.Add(this.ConfirmButton);
            this.ClientDetailsPanel.Controls.Add(this.EmailTextBox);
            this.ClientDetailsPanel.Controls.Add(this.TelephoneTextBox);
            this.ClientDetailsPanel.Controls.Add(this.AddressTextBox);
            this.ClientDetailsPanel.Controls.Add(this.FullNameTextBox);
            this.ClientDetailsPanel.Controls.Add(this.label21);
            this.ClientDetailsPanel.Controls.Add(this.label20);
            this.ClientDetailsPanel.Controls.Add(this.label19);
            this.ClientDetailsPanel.Controls.Add(this.label18);
            this.ClientDetailsPanel.Controls.Add(this.TransactionNumberLabel);
            this.ClientDetailsPanel.Controls.Add(this.label16);
            this.ClientDetailsPanel.Location = new System.Drawing.Point(28, 250);
            this.ClientDetailsPanel.Name = "ClientDetailsPanel";
            this.ClientDetailsPanel.Size = new System.Drawing.Size(641, 264);
            this.ClientDetailsPanel.TabIndex = 63;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(472, 221);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 10;
            this.ConfirmButton.Text = "C&onfirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(463, 170);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(114, 20);
            this.EmailTextBox.TabIndex = 9;
            this.EmailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TelephoneTextBox
            // 
            this.TelephoneTextBox.Location = new System.Drawing.Point(463, 130);
            this.TelephoneTextBox.Name = "TelephoneTextBox";
            this.TelephoneTextBox.Size = new System.Drawing.Size(114, 20);
            this.TelephoneTextBox.TabIndex = 8;
            this.TelephoneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(463, 96);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(114, 20);
            this.AddressTextBox.TabIndex = 7;
            this.AddressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(463, 57);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(114, 20);
            this.FullNameTextBox.TabIndex = 6;
            this.FullNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(354, 171);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 15);
            this.label21.TabIndex = 5;
            this.label21.Text = "Email: ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(354, 135);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 15);
            this.label20.TabIndex = 4;
            this.label20.Text = "Telephone: ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(354, 97);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 15);
            this.label19.TabIndex = 3;
            this.label19.Text = "Address: ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(354, 62);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 15);
            this.label18.TabIndex = 2;
            this.label18.Text = "Full Name: ";
            // 
            // TransactionNumberLabel
            // 
            this.TransactionNumberLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TransactionNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TransactionNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionNumberLabel.Location = new System.Drawing.Point(463, 24);
            this.TransactionNumberLabel.Name = "TransactionNumberLabel";
            this.TransactionNumberLabel.Size = new System.Drawing.Size(114, 22);
            this.TransactionNumberLabel.TabIndex = 1;
            this.TransactionNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(352, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 15);
            this.label16.TabIndex = 0;
            this.label16.Text = "TRX Number: ";
            // 
            // CoffeHouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 524);
            this.Controls.Add(this.ClientDetailsPanel);
            this.Controls.Add(this.ButtonGroupBox);
            this.Controls.Add(this.SelectionPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CoffeHouseForm";
            this.Text = "CoffeHouse";
            this.SelectionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).EndInit();
            this.ButtonGroupBox.ResumeLayout(false);
            this.ClientDetailsPanel.ResumeLayout(false);
            this.ClientDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SelectionPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox CoffeTypeListBox;
        private System.Windows.Forms.ListBox CoffeSizeListBox;
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.GroupBox ButtonGroupBox;
        private System.Windows.Forms.Button StockReportButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button PurchaseButton;
        private System.Windows.Forms.Button SalesReportButton;
        private System.Windows.Forms.Panel ClientDetailsPanel;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox TelephoneTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label TransactionNumberLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.DateTimePicker DiplaDataGrid;
        private System.Windows.Forms.NumericUpDown QuantityNumericUpDown;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label TotalPurchasesCostLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DisplayDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoffetypeDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeCoffeDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceDataGrid;
    }
}

