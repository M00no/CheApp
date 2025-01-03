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
            calculateExpensesButton = new Button();
            rentReservationButton = new Button();
            panel1 = new Panel();
            settingsButton = new Button();
            calculateOxygenButton = new Button();
            calculateOxygenMenu1 = new CalculateOxygenMenu();
            panel1.SuspendLayout();
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
            // calculateExpensesButton
            // 
            calculateExpensesButton.Location = new Point(17, 228);
            calculateExpensesButton.Margin = new Padding(4, 5, 4, 5);
            calculateExpensesButton.Name = "calculateExpensesButton";
            calculateExpensesButton.Size = new Size(173, 70);
            calculateExpensesButton.TabIndex = 2;
            calculateExpensesButton.Text = "Calculate Expenses for room";
            calculateExpensesButton.UseVisualStyleBackColor = true;
            // 
            // rentReservationButton
            // 
            rentReservationButton.Location = new Point(17, 308);
            rentReservationButton.Margin = new Padding(4, 5, 4, 5);
            rentReservationButton.Name = "rentReservationButton";
            rentReservationButton.Size = new Size(173, 93);
            rentReservationButton.TabIndex = 3;
            rentReservationButton.Text = "Make a rent reservation for government";
            rentReservationButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(settingsButton);
            panel1.Controls.Add(calculateExpensesButton);
            panel1.Controls.Add(rentReservationButton);
            panel1.Controls.Add(mmTitleTextBox);
            panel1.Controls.Add(calculateOxygenButton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 750);
            panel1.TabIndex = 4;
            // 
            // settingsButton
            // 
            settingsButton.Location = new Point(17, 89);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(173, 51);
            settingsButton.TabIndex = 5;
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += settingsButton_Click;
            // 
            // calculateOxygenButton
            // 
            calculateOxygenButton.Location = new Point(17, 148);
            calculateOxygenButton.Margin = new Padding(4, 5, 4, 5);
            calculateOxygenButton.Name = "calculateOxygenButton";
            calculateOxygenButton.Size = new Size(173, 70);
            calculateOxygenButton.TabIndex = 0;
            calculateOxygenButton.Text = "Calculate Oxygen for room";
            calculateOxygenButton.UseVisualStyleBackColor = true;
            calculateOxygenButton.Click += calculateOxygenButton_Click;
            // 
            // calculateOxygenMenu1
            // 
            calculateOxygenMenu1.BackColor = SystemColors.Control;
            calculateOxygenMenu1.Location = new Point(239, 17);
            calculateOxygenMenu1.Margin = new Padding(6, 8, 6, 8);
            calculateOxygenMenu1.Name = "calculateOxygenMenu1";
            calculateOxygenMenu1.Size = new Size(889, 710);
            calculateOxygenMenu1.TabIndex = 5;
            calculateOxygenMenu1.Visible = false;
            // 
            // ViewPort
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(calculateOxygenMenu1);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ViewPort";
            Text = "Main Menu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox mmTitleTextBox;
        private Button calculateExpensesButton;
        private Button rentReservationButton;
        private Panel panel1;
        private CalculateOxygenMenu calculateOxygenMenu1;
        private Button settingsButton;
        private Button calculateOxygenButton;
    }
}
