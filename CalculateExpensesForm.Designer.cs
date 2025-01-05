namespace CheApp
{
    partial class CalculateExpensesForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleTextBox = new TextBox();
            chooseRoomTextBox = new TextBox();
            roomsListBox = new ListBox();
            roomInfoValueTextBox = new RichTextBox();
            roomInfoTextBox = new TextBox();
            calculateOxygenButton = new Button();
            resultValueTextBox = new RichTextBox();
            resultTextBox = new TextBox();
            beginDateTimePicker = new DateTimePicker();
            endDateTimePicker = new DateTimePicker();
            beginTimeNumericUpDown = new NumericUpDown();
            endTimeNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)beginTimeNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)endTimeNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // titleTextBox
            // 
            titleTextBox.BorderStyle = BorderStyle.None;
            titleTextBox.Cursor = Cursors.No;
            titleTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleTextBox.Location = new Point(4, 5);
            titleTextBox.Margin = new Padding(4, 5, 4, 5);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.ReadOnly = true;
            titleTextBox.Size = new Size(285, 48);
            titleTextBox.TabIndex = 12;
            titleTextBox.Text = "Calculate Expense";
            titleTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // chooseRoomTextBox
            // 
            chooseRoomTextBox.BorderStyle = BorderStyle.None;
            chooseRoomTextBox.Cursor = Cursors.No;
            chooseRoomTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chooseRoomTextBox.Location = new Point(55, 86);
            chooseRoomTextBox.Margin = new Padding(4, 5, 4, 5);
            chooseRoomTextBox.Name = "chooseRoomTextBox";
            chooseRoomTextBox.ReadOnly = true;
            chooseRoomTextBox.Size = new Size(249, 32);
            chooseRoomTextBox.TabIndex = 17;
            chooseRoomTextBox.Text = "Choose Room";
            chooseRoomTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // roomsListBox
            // 
            roomsListBox.FormattingEnabled = true;
            roomsListBox.ItemHeight = 25;
            roomsListBox.Location = new Point(55, 132);
            roomsListBox.Margin = new Padding(4, 5, 4, 5);
            roomsListBox.Name = "roomsListBox";
            roomsListBox.Size = new Size(247, 179);
            roomsListBox.TabIndex = 16;
            // 
            // roomInfoValueTextBox
            // 
            roomInfoValueTextBox.Location = new Point(64, 492);
            roomInfoValueTextBox.Margin = new Padding(4, 5, 4, 5);
            roomInfoValueTextBox.Name = "roomInfoValueTextBox";
            roomInfoValueTextBox.ReadOnly = true;
            roomInfoValueTextBox.Size = new Size(297, 186);
            roomInfoValueTextBox.TabIndex = 27;
            roomInfoValueTextBox.Text = "";
            // 
            // roomInfoTextBox
            // 
            roomInfoTextBox.BorderStyle = BorderStyle.None;
            roomInfoTextBox.Cursor = Cursors.No;
            roomInfoTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roomInfoTextBox.Location = new Point(64, 446);
            roomInfoTextBox.Margin = new Padding(4, 5, 4, 5);
            roomInfoTextBox.Name = "roomInfoTextBox";
            roomInfoTextBox.ReadOnly = true;
            roomInfoTextBox.Size = new Size(127, 32);
            roomInfoTextBox.TabIndex = 26;
            roomInfoTextBox.Text = "Room Info";
            roomInfoTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // calculateOxygenButton
            // 
            calculateOxygenButton.Location = new Point(572, 384);
            calculateOxygenButton.Margin = new Padding(4, 5, 4, 5);
            calculateOxygenButton.Name = "calculateOxygenButton";
            calculateOxygenButton.Size = new Size(107, 38);
            calculateOxygenButton.TabIndex = 25;
            calculateOxygenButton.Text = "Calculate";
            calculateOxygenButton.UseVisualStyleBackColor = true;
            // 
            // resultValueTextBox
            // 
            resultValueTextBox.Location = new Point(461, 492);
            resultValueTextBox.Margin = new Padding(4, 5, 4, 5);
            resultValueTextBox.Name = "resultValueTextBox";
            resultValueTextBox.ReadOnly = true;
            resultValueTextBox.Size = new Size(368, 186);
            resultValueTextBox.TabIndex = 24;
            resultValueTextBox.Text = "";
            // 
            // resultTextBox
            // 
            resultTextBox.BorderStyle = BorderStyle.None;
            resultTextBox.Cursor = Cursors.No;
            resultTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultTextBox.Location = new Point(461, 446);
            resultTextBox.Margin = new Padding(4, 5, 4, 5);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.ReadOnly = true;
            resultTextBox.Size = new Size(91, 32);
            resultTextBox.TabIndex = 23;
            resultTextBox.Text = "Result:";
            resultTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // beginDateTimePicker
            // 
            beginDateTimePicker.Location = new Point(461, 132);
            beginDateTimePicker.Name = "beginDateTimePicker";
            beginDateTimePicker.Size = new Size(300, 31);
            beginDateTimePicker.TabIndex = 28;
            beginDateTimePicker.Value = new DateTime(2025, 1, 5, 21, 26, 6, 0);
            beginDateTimePicker.ValueChanged += beginDateTimePicker_ValueChanged;
            // 
            // endDateTimePicker
            // 
            endDateTimePicker.Location = new Point(461, 199);
            endDateTimePicker.MinDate = new DateTime(2025, 1, 5, 0, 0, 0, 0);
            endDateTimePicker.Name = "endDateTimePicker";
            endDateTimePicker.Size = new Size(300, 31);
            endDateTimePicker.TabIndex = 29;
            endDateTimePicker.Value = new DateTime(2025, 1, 5, 21, 26, 6, 0);
            // 
            // beginTimeNumericUpDown
            // 
            beginTimeNumericUpDown.Location = new Point(461, 280);
            beginTimeNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            beginTimeNumericUpDown.Maximum = new decimal(new int[] { 18, 0, 0, 0 });
            beginTimeNumericUpDown.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            beginTimeNumericUpDown.Name = "beginTimeNumericUpDown";
            beginTimeNumericUpDown.Size = new Size(199, 31);
            beginTimeNumericUpDown.TabIndex = 30;
            beginTimeNumericUpDown.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // endTimeNumericUpDown
            // 
            endTimeNumericUpDown.Location = new Point(461, 321);
            endTimeNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            endTimeNumericUpDown.Maximum = new decimal(new int[] { 18, 0, 0, 0 });
            endTimeNumericUpDown.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            endTimeNumericUpDown.Name = "endTimeNumericUpDown";
            endTimeNumericUpDown.Size = new Size(199, 31);
            endTimeNumericUpDown.TabIndex = 31;
            endTimeNumericUpDown.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // CalculateExpensesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(endTimeNumericUpDown);
            Controls.Add(beginTimeNumericUpDown);
            Controls.Add(endDateTimePicker);
            Controls.Add(beginDateTimePicker);
            Controls.Add(roomInfoValueTextBox);
            Controls.Add(roomInfoTextBox);
            Controls.Add(calculateOxygenButton);
            Controls.Add(resultValueTextBox);
            Controls.Add(resultTextBox);
            Controls.Add(chooseRoomTextBox);
            Controls.Add(roomsListBox);
            Controls.Add(titleTextBox);
            Name = "CalculateExpensesForm";
            Size = new Size(889, 710);
            ((System.ComponentModel.ISupportInitialize)beginTimeNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)endTimeNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox titleTextBox;
        private TextBox chooseRoomTextBox;
        private ListBox roomsListBox;
        private RichTextBox roomInfoValueTextBox;
        private TextBox roomInfoTextBox;
        private Button calculateOxygenButton;
        private RichTextBox resultValueTextBox;
        private TextBox resultTextBox;
        private DateTimePicker beginDateTimePicker;
        private DateTimePicker endDateTimePicker;
        private NumericUpDown beginTimeNumericUpDown;
        private NumericUpDown endTimeNumericUpDown;
    }
}
