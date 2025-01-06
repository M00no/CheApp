namespace CheApp
{
    partial class CalculatePriceAndExpensesForm
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
            resultValueTextBox = new RichTextBox();
            resultTextBox = new TextBox();
            beginDatePicker = new DateTimePicker();
            endDatePicker = new DateTimePicker();
            beginDateTextBox = new TextBox();
            endDateTextBox = new TextBox();
            beginTimeTextBox = new TextBox();
            endTimeTextBox = new TextBox();
            calculateButton = new Button();
            beginTimePicker = new DateTimePicker();
            endTimePicker = new DateTimePicker();
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
            titleTextBox.Size = new Size(463, 48);
            titleTextBox.TabIndex = 12;
            titleTextBox.Text = "Calculate Price And Expenses";
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
            roomsListBox.SelectedIndexChanged += roomsListBox_SelectedIndexChanged;
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
            // beginDatePicker
            // 
            beginDatePicker.Location = new Point(461, 132);
            beginDatePicker.Name = "beginDatePicker";
            beginDatePicker.Size = new Size(300, 31);
            beginDatePicker.TabIndex = 28;
            beginDatePicker.ValueChanged += beginDatePicker_ValueChanged;
            // 
            // endDatePicker
            // 
            endDatePicker.Location = new Point(461, 211);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(300, 31);
            endDatePicker.TabIndex = 29;
            // 
            // beginDateTextBox
            // 
            beginDateTextBox.BorderStyle = BorderStyle.None;
            beginDateTextBox.Cursor = Cursors.No;
            beginDateTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            beginDateTextBox.Location = new Point(461, 92);
            beginDateTextBox.Margin = new Padding(4, 5, 4, 5);
            beginDateTextBox.Name = "beginDateTextBox";
            beginDateTextBox.ReadOnly = true;
            beginDateTextBox.Size = new Size(132, 32);
            beginDateTextBox.TabIndex = 32;
            beginDateTextBox.Text = "Begin Date";
            beginDateTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // endDateTextBox
            // 
            endDateTextBox.BorderStyle = BorderStyle.None;
            endDateTextBox.Cursor = Cursors.No;
            endDateTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            endDateTextBox.Location = new Point(461, 171);
            endDateTextBox.Margin = new Padding(4, 5, 4, 5);
            endDateTextBox.Name = "endDateTextBox";
            endDateTextBox.ReadOnly = true;
            endDateTextBox.Size = new Size(117, 32);
            endDateTextBox.TabIndex = 33;
            endDateTextBox.Text = "End Date";
            endDateTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // beginTimeTextBox
            // 
            beginTimeTextBox.BorderStyle = BorderStyle.None;
            beginTimeTextBox.Cursor = Cursors.No;
            beginTimeTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            beginTimeTextBox.Location = new Point(461, 250);
            beginTimeTextBox.Margin = new Padding(4, 5, 4, 5);
            beginTimeTextBox.Name = "beginTimeTextBox";
            beginTimeTextBox.ReadOnly = true;
            beginTimeTextBox.Size = new Size(132, 32);
            beginTimeTextBox.TabIndex = 34;
            beginTimeTextBox.Text = "Begin Time";
            beginTimeTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // endTimeTextBox
            // 
            endTimeTextBox.BorderStyle = BorderStyle.None;
            endTimeTextBox.Cursor = Cursors.No;
            endTimeTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            endTimeTextBox.Location = new Point(461, 329);
            endTimeTextBox.Margin = new Padding(4, 5, 4, 5);
            endTimeTextBox.Name = "endTimeTextBox";
            endTimeTextBox.ReadOnly = true;
            endTimeTextBox.Size = new Size(117, 32);
            endTimeTextBox.TabIndex = 35;
            endTimeTextBox.Text = "End Time";
            endTimeTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(654, 408);
            calculateButton.Margin = new Padding(4, 5, 4, 5);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(107, 38);
            calculateButton.TabIndex = 36;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // beginTimePicker
            // 
            beginTimePicker.Location = new Point(461, 290);
            beginTimePicker.Name = "beginTimePicker";
            beginTimePicker.Size = new Size(300, 31);
            beginTimePicker.TabIndex = 37;
            beginTimePicker.ValueChanged += beginTimePicker_ValueChanged;
            // 
            // endTimePicker
            // 
            endTimePicker.Location = new Point(461, 369);
            endTimePicker.Name = "endTimePicker";
            endTimePicker.Size = new Size(300, 31);
            endTimePicker.TabIndex = 38;
            // 
            // CalculatePriceAndExpensesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(endTimePicker);
            Controls.Add(beginTimePicker);
            Controls.Add(calculateButton);
            Controls.Add(endTimeTextBox);
            Controls.Add(beginTimeTextBox);
            Controls.Add(endDateTextBox);
            Controls.Add(beginDateTextBox);
            Controls.Add(endDatePicker);
            Controls.Add(beginDatePicker);
            Controls.Add(roomInfoValueTextBox);
            Controls.Add(roomInfoTextBox);
            Controls.Add(resultValueTextBox);
            Controls.Add(resultTextBox);
            Controls.Add(chooseRoomTextBox);
            Controls.Add(roomsListBox);
            Controls.Add(titleTextBox);
            Name = "CalculatePriceAndExpensesForm";
            Size = new Size(877, 688);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox titleTextBox;
        private TextBox chooseRoomTextBox;
        private ListBox roomsListBox;
        private RichTextBox roomInfoValueTextBox;
        private TextBox roomInfoTextBox;
        private RichTextBox resultValueTextBox;
        private TextBox resultTextBox;
        private DateTimePicker beginDatePicker;
        private DateTimePicker endDatePicker;
        private TextBox beginDateTextBox;
        private TextBox endDateTextBox;
        private TextBox beginTimeTextBox;
        private TextBox endTimeTextBox;
        private Button calculateButton;
        private DateTimePicker beginTimePicker;
        private DateTimePicker endTimePicker;
    }
}
