namespace CheApp
{
    partial class FindReservationForm
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
            chooseFloorComboBox = new ComboBox();
            chooseBuildingComboBox = new ComboBox();
            titleTextBox = new TextBox();
            chooseBuildingTextBox = new TextBox();
            chooseFloorTextBox = new TextBox();
            howManyTextBox = new TextBox();
            howManyPeopleNumeric = new NumericUpDown();
            findButton = new Button();
            resultValueTextBox = new RichTextBox();
            resultTextBox = new TextBox();
            durationNumeric = new NumericUpDown();
            durationTextBox = new TextBox();
            datePicker = new DateTimePicker();
            timePicker = new DateTimePicker();
            dateTextBox = new TextBox();
            timeTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)howManyPeopleNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)durationNumeric).BeginInit();
            SuspendLayout();
            // 
            // chooseFloorComboBox
            // 
            chooseFloorComboBox.FormattingEnabled = true;
            chooseFloorComboBox.Location = new Point(89, 148);
            chooseFloorComboBox.Name = "chooseFloorComboBox";
            chooseFloorComboBox.Size = new Size(145, 23);
            chooseFloorComboBox.TabIndex = 0;
            // 
            // chooseBuildingComboBox
            // 
            chooseBuildingComboBox.FormattingEnabled = true;
            chooseBuildingComboBox.Location = new Point(89, 91);
            chooseBuildingComboBox.Name = "chooseBuildingComboBox";
            chooseBuildingComboBox.Size = new Size(145, 23);
            chooseBuildingComboBox.TabIndex = 1;
            // 
            // titleTextBox
            // 
            titleTextBox.BorderStyle = BorderStyle.None;
            titleTextBox.Cursor = Cursors.No;
            titleTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleTextBox.Location = new Point(3, 3);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.ReadOnly = true;
            titleTextBox.Size = new Size(215, 32);
            titleTextBox.TabIndex = 13;
            titleTextBox.Text = "Make a reservation";
            titleTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // chooseBuildingTextBox
            // 
            chooseBuildingTextBox.BorderStyle = BorderStyle.None;
            chooseBuildingTextBox.Cursor = Cursors.No;
            chooseBuildingTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chooseBuildingTextBox.Location = new Point(89, 63);
            chooseBuildingTextBox.Name = "chooseBuildingTextBox";
            chooseBuildingTextBox.ReadOnly = true;
            chooseBuildingTextBox.Size = new Size(120, 22);
            chooseBuildingTextBox.TabIndex = 33;
            chooseBuildingTextBox.Text = "Choose Building";
            chooseBuildingTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // chooseFloorTextBox
            // 
            chooseFloorTextBox.BorderStyle = BorderStyle.None;
            chooseFloorTextBox.Cursor = Cursors.No;
            chooseFloorTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chooseFloorTextBox.Location = new Point(89, 120);
            chooseFloorTextBox.Name = "chooseFloorTextBox";
            chooseFloorTextBox.ReadOnly = true;
            chooseFloorTextBox.Size = new Size(92, 22);
            chooseFloorTextBox.TabIndex = 34;
            chooseFloorTextBox.Text = "Choose Floor";
            chooseFloorTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // howManyTextBox
            // 
            howManyTextBox.BorderStyle = BorderStyle.None;
            howManyTextBox.Cursor = Cursors.No;
            howManyTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            howManyTextBox.Location = new Point(89, 177);
            howManyTextBox.Name = "howManyTextBox";
            howManyTextBox.ReadOnly = true;
            howManyTextBox.Size = new Size(139, 22);
            howManyTextBox.TabIndex = 36;
            howManyTextBox.Text = "How Many People";
            howManyTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // howManyPeopleNumeric
            // 
            howManyPeopleNumeric.Location = new Point(89, 205);
            howManyPeopleNumeric.Name = "howManyPeopleNumeric";
            howManyPeopleNumeric.Size = new Size(139, 23);
            howManyPeopleNumeric.TabIndex = 35;
            // 
            // findButton
            // 
            findButton.Location = new Point(430, 247);
            findButton.Name = "findButton";
            findButton.Size = new Size(75, 23);
            findButton.TabIndex = 37;
            findButton.Text = "Find";
            findButton.UseVisualStyleBackColor = true;
            findButton.Click += findButton_Click;
            // 
            // resultValueTextBox
            // 
            resultValueTextBox.Location = new Point(179, 276);
            resultValueTextBox.Name = "resultValueTextBox";
            resultValueTextBox.ReadOnly = true;
            resultValueTextBox.Size = new Size(259, 113);
            resultValueTextBox.TabIndex = 39;
            resultValueTextBox.Text = "";
            // 
            // resultTextBox
            // 
            resultTextBox.BorderStyle = BorderStyle.None;
            resultTextBox.Cursor = Cursors.No;
            resultTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultTextBox.Location = new Point(179, 248);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.ReadOnly = true;
            resultTextBox.Size = new Size(64, 22);
            resultTextBox.TabIndex = 38;
            resultTextBox.Text = "Result:";
            resultTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // durationNumeric
            // 
            durationNumeric.Location = new Point(305, 205);
            durationNumeric.Name = "durationNumeric";
            durationNumeric.Size = new Size(200, 23);
            durationNumeric.TabIndex = 44;
            // 
            // durationTextBox
            // 
            durationTextBox.BorderStyle = BorderStyle.None;
            durationTextBox.Cursor = Cursors.No;
            durationTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            durationTextBox.Location = new Point(305, 177);
            durationTextBox.Name = "durationTextBox";
            durationTextBox.ReadOnly = true;
            durationTextBox.Size = new Size(75, 22);
            durationTextBox.TabIndex = 45;
            durationTextBox.Text = "Duration";
            durationTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // datePicker
            // 
            datePicker.Location = new Point(305, 88);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(200, 23);
            datePicker.TabIndex = 46;
            // 
            // timePicker
            // 
            timePicker.Location = new Point(305, 145);
            timePicker.Name = "timePicker";
            timePicker.Size = new Size(200, 23);
            timePicker.TabIndex = 47;
            timePicker.ValueChanged += timePicker_ValueChanged;
            // 
            // dateTextBox
            // 
            dateTextBox.BorderStyle = BorderStyle.None;
            dateTextBox.Cursor = Cursors.No;
            dateTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTextBox.Location = new Point(305, 63);
            dateTextBox.Name = "dateTextBox";
            dateTextBox.ReadOnly = true;
            dateTextBox.Size = new Size(47, 22);
            dateTextBox.TabIndex = 48;
            dateTextBox.Text = "Date";
            dateTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // timeTextBox
            // 
            timeTextBox.BorderStyle = BorderStyle.None;
            timeTextBox.Cursor = Cursors.No;
            timeTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeTextBox.Location = new Point(305, 120);
            timeTextBox.Name = "timeTextBox";
            timeTextBox.ReadOnly = true;
            timeTextBox.Size = new Size(47, 22);
            timeTextBox.TabIndex = 49;
            timeTextBox.Text = "Time";
            timeTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // FindReservationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(timeTextBox);
            Controls.Add(dateTextBox);
            Controls.Add(timePicker);
            Controls.Add(datePicker);
            Controls.Add(durationTextBox);
            Controls.Add(durationNumeric);
            Controls.Add(resultValueTextBox);
            Controls.Add(resultTextBox);
            Controls.Add(findButton);
            Controls.Add(howManyTextBox);
            Controls.Add(howManyPeopleNumeric);
            Controls.Add(chooseFloorTextBox);
            Controls.Add(chooseBuildingTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(chooseBuildingComboBox);
            Controls.Add(chooseFloorComboBox);
            Name = "FindReservationForm";
            Size = new Size(621, 408);
            ((System.ComponentModel.ISupportInitialize)howManyPeopleNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)durationNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox chooseFloorComboBox;
        private ComboBox chooseBuildingComboBox;
        private TextBox titleTextBox;
        private TextBox chooseBuildingTextBox;
        private TextBox chooseFloorTextBox;
        private TextBox howManyTextBox;
        private NumericUpDown howManyPeopleNumeric;
        private Button findButton;
        private RichTextBox resultValueTextBox;
        private TextBox resultTextBox;
        private NumericUpDown durationNumeric;
        private TextBox durationTextBox;
        private DateTimePicker datePicker;
        private DateTimePicker timePicker;
        private TextBox dateTextBox;
        private TextBox timeTextBox;
    }
}
