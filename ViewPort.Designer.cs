namespace CheApp
{
    partial class ViewPort
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
            mmTitleTextBox = new TextBox();
            calculatePriceAndExpensesButton = new Button();
            panel1 = new Panel();
            calculateOxygenButton = new Button();
            tabControl = new TabControl();
            oxygenTab = new TabPage();
            calculateOxygenForm1 = new CalculateOxygenForm();
            priceAndExpensesTab = new TabPage();
            calculatePriceAndExpensesForm1 = new CalculatePriceAndExpensesForm();
            panel1.SuspendLayout();
            tabControl.SuspendLayout();
            oxygenTab.SuspendLayout();
            priceAndExpensesTab.SuspendLayout();
            SuspendLayout();
            // 
            // mmTitleTextBox
            // 
            mmTitleTextBox.BorderStyle = BorderStyle.None;
            mmTitleTextBox.Cursor = Cursors.No;
            mmTitleTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mmTitleTextBox.Location = new Point(17, 20);
            mmTitleTextBox.Margin = new Padding(4, 5, 4, 5);
            mmTitleTextBox.Name = "mmTitleTextBox";
            mmTitleTextBox.ReadOnly = true;
            mmTitleTextBox.Size = new Size(187, 48);
            mmTitleTextBox.TabIndex = 1;
            mmTitleTextBox.Text = "Main Menu";
            mmTitleTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // calculatePriceAndExpensesButton
            // 
            calculatePriceAndExpensesButton.Location = new Point(31, 158);
            calculatePriceAndExpensesButton.Margin = new Padding(4, 5, 4, 5);
            calculatePriceAndExpensesButton.Name = "calculatePriceAndExpensesButton";
            calculatePriceAndExpensesButton.Size = new Size(173, 74);
            calculatePriceAndExpensesButton.TabIndex = 2;
            calculatePriceAndExpensesButton.Text = "Calculate Price And Expenses for room";
            calculatePriceAndExpensesButton.UseVisualStyleBackColor = true;
            calculatePriceAndExpensesButton.Click += calculatePriceAndExpensesButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(calculatePriceAndExpensesButton);
            panel1.Controls.Add(mmTitleTextBox);
            panel1.Controls.Add(calculateOxygenButton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 750);
            panel1.TabIndex = 4;
            // 
            // calculateOxygenButton
            // 
            calculateOxygenButton.Location = new Point(31, 78);
            calculateOxygenButton.Margin = new Padding(4, 5, 4, 5);
            calculateOxygenButton.Name = "calculateOxygenButton";
            calculateOxygenButton.Size = new Size(173, 70);
            calculateOxygenButton.TabIndex = 0;
            calculateOxygenButton.Text = "Calculate Oxygen for room";
            calculateOxygenButton.UseVisualStyleBackColor = true;
            calculateOxygenButton.Click += calculateOxygenButton_Click;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(oxygenTab);
            tabControl.Controls.Add(priceAndExpensesTab);
            tabControl.Location = new Point(236, 20);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(895, 718);
            tabControl.TabIndex = 5;
            // 
            // oxygenTab
            // 
            oxygenTab.Controls.Add(calculateOxygenForm1);
            oxygenTab.Location = new Point(4, 34);
            oxygenTab.Name = "oxygenTab";
            oxygenTab.Padding = new Padding(3);
            oxygenTab.Size = new Size(887, 680);
            oxygenTab.TabIndex = 0;
            oxygenTab.Text = "Oxygen";
            oxygenTab.UseVisualStyleBackColor = true;
            // 
            // calculateOxygenForm1
            // 
            calculateOxygenForm1.BackColor = SystemColors.Control;
            calculateOxygenForm1.Location = new Point(0, 0);
            calculateOxygenForm1.Margin = new Padding(4, 5, 4, 5);
            calculateOxygenForm1.Name = "calculateOxygenForm1";
            calculateOxygenForm1.Size = new Size(887, 680);
            calculateOxygenForm1.TabIndex = 0;
            // 
            // priceAndExpensesTab
            // 
            priceAndExpensesTab.Controls.Add(calculatePriceAndExpensesForm1);
            priceAndExpensesTab.Location = new Point(4, 34);
            priceAndExpensesTab.Name = "priceAndExpensesTab";
            priceAndExpensesTab.Padding = new Padding(3);
            priceAndExpensesTab.Size = new Size(887, 680);
            priceAndExpensesTab.TabIndex = 1;
            priceAndExpensesTab.Text = "P and E";
            priceAndExpensesTab.UseVisualStyleBackColor = true;
            // 
            // calculatePriceAndExpensesForm1
            // 
            calculatePriceAndExpensesForm1.BackColor = SystemColors.Control;
            calculatePriceAndExpensesForm1.Location = new Point(0, -3);
            calculatePriceAndExpensesForm1.Name = "calculatePriceAndExpensesForm1";
            calculatePriceAndExpensesForm1.Size = new Size(887, 680);
            calculatePriceAndExpensesForm1.TabIndex = 0;
            // 
            // ViewPort
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(tabControl);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ViewPort";
            Text = "CHE APP";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl.ResumeLayout(false);
            oxygenTab.ResumeLayout(false);
            priceAndExpensesTab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox mmTitleTextBox;
        private Button calculatePriceAndExpensesButton;
        private Panel panel1;
        private Button calculateOxygenButton;
        private TabControl tabControl;
        private TabPage oxygenTab;
        private TabPage priceAndExpensesTab;
        private CalculateOxygenForm calculateOxygenForm1;
        private CalculatePriceAndExpensesForm calculatePriceAndExpensesForm1;
    }
}
