namespace CheApp
{
    partial class MainMenu
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
            SuspendLayout();
            // 
            // calculateOxygenButton
            // 
            calculateOxygenButton.Location = new Point(173, 98);
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
            calculateExpensesButton.Location = new Point(173, 146);
            calculateExpensesButton.Name = "calculateExpensesButton";
            calculateExpensesButton.Size = new Size(121, 42);
            calculateExpensesButton.TabIndex = 2;
            calculateExpensesButton.Text = "Calculate Expenses for room";
            calculateExpensesButton.UseVisualStyleBackColor = true;
            // 
            // rentReservationButton
            // 
            rentReservationButton.Location = new Point(173, 194);
            rentReservationButton.Name = "rentReservationButton";
            rentReservationButton.Size = new Size(121, 56);
            rentReservationButton.TabIndex = 3;
            rentReservationButton.Text = "Make a rent reservation for government";
            rentReservationButton.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rentReservationButton);
            Controls.Add(calculateExpensesButton);
            Controls.Add(mmTitleTextBox);
            Controls.Add(calculateOxygenButton);
            Name = "MainMenu";
            Text = "Main Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calculateOxygenButton;
        private TextBox mmTitleTextBox;
        private Button calculateExpensesButton;
        private Button rentReservationButton;
    }
}
