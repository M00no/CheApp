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
            calculateOxygenButton = new Button();
            mmTitleTextBox = new TextBox();
            calculateExpensesButton = new Button();
            rentReservationButton = new Button();
            panel1 = new Panel();
            calculateOxygenMenu1 = new CalculateOxygenMenu();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // calculateOxygenButton
            // 
            calculateOxygenButton.Location = new Point(12, 77);
            calculateOxygenButton.Name = "calculateOxygenButton";
            calculateOxygenButton.Size = new Size(121, 42);
            calculateOxygenButton.TabIndex = 0;
            calculateOxygenButton.Text = "Calculate Oxygen for room";
            calculateOxygenButton.UseVisualStyleBackColor = true;
            calculateOxygenButton.Click += calculateOxygenButton_Click;
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
            // calculateExpensesButton
            // 
            calculateExpensesButton.Location = new Point(12, 125);
            calculateExpensesButton.Name = "calculateExpensesButton";
            calculateExpensesButton.Size = new Size(121, 42);
            calculateExpensesButton.TabIndex = 2;
            calculateExpensesButton.Text = "Calculate Expenses for room";
            calculateExpensesButton.UseVisualStyleBackColor = true;
            // 
            // rentReservationButton
            // 
            rentReservationButton.Location = new Point(12, 173);
            rentReservationButton.Name = "rentReservationButton";
            rentReservationButton.Size = new Size(121, 56);
            rentReservationButton.TabIndex = 3;
            rentReservationButton.Text = "Make a rent reservation for government";
            rentReservationButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(calculateExpensesButton);
            panel1.Controls.Add(rentReservationButton);
            panel1.Controls.Add(mmTitleTextBox);
            panel1.Controls.Add(calculateOxygenButton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 450);
            panel1.TabIndex = 4;
            // 
            // calculateOxygenMenu1
            // 
            calculateOxygenMenu1.BackColor = SystemColors.Control;
            calculateOxygenMenu1.Location = new Point(166, 12);
            calculateOxygenMenu1.Name = "calculateOxygenMenu1";
            calculateOxygenMenu1.Size = new Size(622, 426);
            calculateOxygenMenu1.TabIndex = 5;
            calculateOxygenMenu1.Visible = false;
            // 
            // ViewPort
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(calculateOxygenMenu1);
            Controls.Add(panel1);
            Name = "ViewPort";
            Text = "Main Menu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button calculateOxygenButton;
        private TextBox mmTitleTextBox;
        private Button calculateExpensesButton;
        private Button rentReservationButton;
        private Panel panel1;
        private CalculateOxygenMenu calculateOxygenMenu1;
    }
}
