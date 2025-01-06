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
            titleTextBox.Location = new Point(3, 3);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.ReadOnly = true;
            titleTextBox.Size = new Size(324, 32);
            titleTextBox.TabIndex = 12;
            titleTextBox.Text = "Calculate Price And Expenses";
            titleTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // chooseRoomTextBox
            // 
            chooseRoomTextBox.BorderStyle = BorderStyle.None;
            chooseRoomTextBox.Cursor = Cursors.No;
            chooseRoomTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chooseRoomTextBox.Location = new Point(38, 52);
            chooseRoomTextBox.Name = "chooseRoomTextBox";
            chooseRoomTextBox.ReadOnly = true;
            chooseRoomTextBox.Size = new Size(174, 22);
            chooseRoomTextBox.TabIndex = 17;
            chooseRoomTextBox.Text = "Choose Room";
            chooseRoomTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // roomsListBox
            // 
            roomsListBox.FormattingEnabled = true;
            roomsListBox.ItemHeight = 15;
            roomsListBox.Location = new Point(38, 79);
            roomsListBox.Name = "roomsListBox";
            roomsListBox.Size = new Size(174, 109);
            roomsListBox.TabIndex = 16;
            roomsListBox.SelectedIndexChanged += roomsListBox_SelectedIndexChanged;
            // 
            // roomInfoValueTextBox
            // 
            roomInfoValueTextBox.Location = new Point(45, 292);
            roomInfoValueTextBox.Name = "roomInfoValueTextBox";
            roomInfoValueTextBox.ReadOnly = true;
            roomInfoValueTextBox.Size = new Size(209, 113);
            roomInfoValueTextBox.TabIndex = 27;
            roomInfoValueTextBox.Text = "";
            // 
            // roomInfoTextBox
            // 
            roomInfoTextBox.BorderStyle = BorderStyle.None;
            roomInfoTextBox.Cursor = Cursors.No;
            roomInfoTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roomInfoTextBox.Location = new Point(45, 265);
            roomInfoTextBox.Name = "roomInfoTextBox";
            roomInfoTextBox.ReadOnly = true;
            roomInfoTextBox.Size = new Size(89, 22);
            roomInfoTextBox.TabIndex = 26;
            roomInfoTextBox.Text = "Room Info";
            roomInfoTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // resultValueTextBox
            // 
            resultValueTextBox.Location = new Point(323, 292);
            resultValueTextBox.Name = "resultValueTextBox";
            resultValueTextBox.ReadOnly = true;
            resultValueTextBox.Size = new Size(259, 113);
            resultValueTextBox.TabIndex = 24;
            resultValueTextBox.Text = "";
            // 
            // resultTextBox
            // 
            resultTextBox.BorderStyle = BorderStyle.None;
            resultTextBox.Cursor = Cursors.No;
            resultTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultTextBox.Location = new Point(323, 265);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.ReadOnly = true;
            resultTextBox.Size = new Size(64, 22);
            resultTextBox.TabIndex = 23;
            resultTextBox.Text = "Result:";
            resultTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // beginDatePicker
            // 
            beginDatePicker.Location = new Point(323, 79);
            beginDatePicker.Margin = new Padding(2, 2, 2, 2);
            beginDatePicker.Name = "beginDatePicker";
            beginDatePicker.Size = new Size(211, 23);
            beginDatePicker.TabIndex = 28;
            beginDatePicker.ValueChanged += beginDatePicker_ValueChanged;
            // 
            // endDatePicker
            // 
            endDatePicker.Location = new Point(323, 127);
            endDatePicker.Margin = new Padding(2, 2, 2, 2);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(211, 23);
            endDatePicker.TabIndex = 29;
            // 
            // beginDateTextBox
            // 
            beginDateTextBox.BorderStyle = BorderStyle.None;
            beginDateTextBox.Cursor = Cursors.No;
            beginDateTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            beginDateTextBox.Location = new Point(323, 55);
            beginDateTextBox.Name = "beginDateTextBox";
            beginDateTextBox.ReadOnly = true;
            beginDateTextBox.Size = new Size(92, 22);
            beginDateTextBox.TabIndex = 32;
            beginDateTextBox.Text = "Begin Date";
            beginDateTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // endDateTextBox
            // 
            endDateTextBox.BorderStyle = BorderStyle.None;
            endDateTextBox.Cursor = Cursors.No;
            endDateTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            endDateTextBox.Location = new Point(323, 103);
            endDateTextBox.Name = "endDateTextBox";
            endDateTextBox.ReadOnly = true;
            endDateTextBox.Size = new Size(82, 22);
            endDateTextBox.TabIndex = 33;
            endDateTextBox.Text = "End Date";
            endDateTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // beginTimeTextBox
            // 
            beginTimeTextBox.BorderStyle = BorderStyle.None;
            beginTimeTextBox.Cursor = Cursors.No;
            beginTimeTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            beginTimeTextBox.Location = new Point(323, 150);
            beginTimeTextBox.Name = "beginTimeTextBox";
            beginTimeTextBox.ReadOnly = true;
            beginTimeTextBox.Size = new Size(92, 22);
            beginTimeTextBox.TabIndex = 34;
            beginTimeTextBox.Text = "Begin Time";
            beginTimeTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // endTimeTextBox
            // 
            endTimeTextBox.BorderStyle = BorderStyle.None;
            endTimeTextBox.Cursor = Cursors.No;
            endTimeTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            endTimeTextBox.Location = new Point(323, 197);
            endTimeTextBox.Name = "endTimeTextBox";
            endTimeTextBox.ReadOnly = true;
            endTimeTextBox.Size = new Size(82, 22);
            endTimeTextBox.TabIndex = 35;
            endTimeTextBox.Text = "End Time";
            endTimeTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(458, 245);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(75, 23);
            calculateButton.TabIndex = 36;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // beginTimePicker
            // 
            beginTimePicker.Location = new Point(323, 174);
            beginTimePicker.Margin = new Padding(2, 2, 2, 2);
            beginTimePicker.Name = "beginTimePicker";
            beginTimePicker.Size = new Size(211, 23);
            beginTimePicker.TabIndex = 37;
            beginTimePicker.ValueChanged += beginTimePicker_ValueChanged;
            // 
            // endTimePicker
            // 
            endTimePicker.Location = new Point(323, 221);
            endTimePicker.Margin = new Padding(2, 2, 2, 2);
            endTimePicker.Name = "endTimePicker";
            endTimePicker.Size = new Size(211, 23);
            endTimePicker.TabIndex = 38;
            // 
            // CalculatePriceAndExpensesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
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
            Margin = new Padding(2, 2, 2, 2);
            Name = "CalculatePriceAndExpensesForm";
            Size = new Size(621, 408);
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
