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
            makeReservationButton = new Button();
            calculateOxygenButton = new Button();
            tabControl = new TabControl();
            oxygenTab = new TabPage();
            calculateOxygenForm1 = new CalculateOxygenForm();
            priceAndExpensesTab = new TabPage();
            calculatePriceAndExpensesForm1 = new CalculatePriceAndExpensesForm();
            findReservationTab = new TabPage();
            findReservationForm1 = new FindReservationForm();
            panel1.SuspendLayout();
            tabControl.SuspendLayout();
            oxygenTab.SuspendLayout();
            priceAndExpensesTab.SuspendLayout();
            findReservationTab.SuspendLayout();
            SuspendLayout();
            // 
            // mmTitleTextBox
            // 
            mmTitleTextBox.BorderStyle = BorderStyle.None;
            mmTitleTextBox.Cursor = Cursors.No;
            mmTitleTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mmTitleTextBox.Location = new Point(12, 12);
            mmTitleTextBox.Name = "mmTitleTextBox";
            mmTitleTextBox.ReadOnly = true;
            mmTitleTextBox.Size = new Size(131, 32);
            mmTitleTextBox.TabIndex = 1;
            mmTitleTextBox.Text = "Main Menu";
            mmTitleTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // calculatePriceAndExpensesButton
            // 
            calculatePriceAndExpensesButton.Location = new Point(22, 95);
            calculatePriceAndExpensesButton.Name = "calculatePriceAndExpensesButton";
            calculatePriceAndExpensesButton.Size = new Size(121, 44);
            calculatePriceAndExpensesButton.TabIndex = 2;
            calculatePriceAndExpensesButton.Text = "Calculate Price And Expenses for room";
            calculatePriceAndExpensesButton.UseVisualStyleBackColor = true;
            calculatePriceAndExpensesButton.Click += calculatePriceAndExpensesButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(makeReservationButton);
            panel1.Controls.Add(calculatePriceAndExpensesButton);
            panel1.Controls.Add(mmTitleTextBox);
            panel1.Controls.Add(calculateOxygenButton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 450);
            panel1.TabIndex = 4;
            // 
            // makeReservationButton
            // 
            makeReservationButton.Location = new Point(22, 145);
            makeReservationButton.Name = "makeReservationButton";
            makeReservationButton.Size = new Size(121, 44);
            makeReservationButton.TabIndex = 3;
            makeReservationButton.Text = "Make a reservation";
            makeReservationButton.UseVisualStyleBackColor = true;
            makeReservationButton.Click += makeReservationButton_Click;
            // 
            // calculateOxygenButton
            // 
            calculateOxygenButton.Location = new Point(22, 47);
            calculateOxygenButton.Name = "calculateOxygenButton";
            calculateOxygenButton.Size = new Size(121, 42);
            calculateOxygenButton.TabIndex = 0;
            calculateOxygenButton.Text = "Calculate Oxygen for room";
            calculateOxygenButton.UseVisualStyleBackColor = true;
            calculateOxygenButton.Click += calculateOxygenButton_Click;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(oxygenTab);
            tabControl.Controls.Add(priceAndExpensesTab);
            tabControl.Controls.Add(findReservationTab);
            tabControl.Location = new Point(165, 12);
            tabControl.Margin = new Padding(2);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(626, 431);
            tabControl.TabIndex = 5;
            // 
            // oxygenTab
            // 
            oxygenTab.Controls.Add(calculateOxygenForm1);
            oxygenTab.Location = new Point(4, 24);
            oxygenTab.Margin = new Padding(2);
            oxygenTab.Name = "oxygenTab";
            oxygenTab.Padding = new Padding(2);
            oxygenTab.Size = new Size(618, 403);
            oxygenTab.TabIndex = 0;
            oxygenTab.Text = "Oxygen";
            oxygenTab.UseVisualStyleBackColor = true;
            // 
            // calculateOxygenForm1
            // 
            calculateOxygenForm1.BackColor = SystemColors.Control;
            calculateOxygenForm1.Location = new Point(0, 0);
            calculateOxygenForm1.Name = "calculateOxygenForm1";
            calculateOxygenForm1.Size = new Size(621, 408);
            calculateOxygenForm1.TabIndex = 0;
            // 
            // priceAndExpensesTab
            // 
            priceAndExpensesTab.Controls.Add(calculatePriceAndExpensesForm1);
            priceAndExpensesTab.Location = new Point(4, 24);
            priceAndExpensesTab.Margin = new Padding(2);
            priceAndExpensesTab.Name = "priceAndExpensesTab";
            priceAndExpensesTab.Padding = new Padding(2);
            priceAndExpensesTab.Size = new Size(618, 403);
            priceAndExpensesTab.TabIndex = 1;
            priceAndExpensesTab.Text = "P and E";
            priceAndExpensesTab.UseVisualStyleBackColor = true;
            // 
            // calculatePriceAndExpensesForm1
            // 
            calculatePriceAndExpensesForm1.BackColor = SystemColors.Control;
            calculatePriceAndExpensesForm1.Location = new Point(0, -2);
            calculatePriceAndExpensesForm1.Margin = new Padding(1);
            calculatePriceAndExpensesForm1.Name = "calculatePriceAndExpensesForm1";
            calculatePriceAndExpensesForm1.Size = new Size(621, 408);
            calculatePriceAndExpensesForm1.TabIndex = 0;
            // 
            // findReservationTab
            // 
            findReservationTab.Controls.Add(findReservationForm1);
            findReservationTab.Location = new Point(4, 24);
            findReservationTab.Name = "findReservationTab";
            findReservationTab.Padding = new Padding(3);
            findReservationTab.Size = new Size(618, 403);
            findReservationTab.TabIndex = 2;
            findReservationTab.Text = "Reservation";
            findReservationTab.UseVisualStyleBackColor = true;
            // 
            // findReservationForm1
            // 
            findReservationForm1.BackColor = SystemColors.Control;
            findReservationForm1.Location = new Point(0, 0);
            findReservationForm1.Name = "findReservationForm1";
            findReservationForm1.Size = new Size(621, 408);
            findReservationForm1.TabIndex = 0;
            // 
            // ViewPort
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl);
            Controls.Add(panel1);
            Name = "ViewPort";
            Text = "CHE APP";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl.ResumeLayout(false);
            oxygenTab.ResumeLayout(false);
            priceAndExpensesTab.ResumeLayout(false);
            findReservationTab.ResumeLayout(false);
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
        private Button makeReservationButton;
        private TabPage findReservationTab;
        private FindReservationForm findReservationForm1;
    }
}
