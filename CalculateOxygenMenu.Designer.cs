namespace CheApp
{
    partial class CalculateOxygenMenu
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
            coTitleTextBox = new TextBox();
            howManyPeopleNumeric = new NumericUpDown();
            howLongInHoursNumeric = new NumericUpDown();
            roomListBox = new ListBox();
            chooseRoomTextBox = new TextBox();
            howManyTextBox = new TextBox();
            howLongTextBox = new TextBox();
            resultTextBox = new TextBox();
            resultValueTextBox = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)howManyPeopleNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)howLongInHoursNumeric).BeginInit();
            SuspendLayout();
            // 
            // coTitleTextBox
            // 
            coTitleTextBox.BorderStyle = BorderStyle.None;
            coTitleTextBox.Cursor = Cursors.No;
            coTitleTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            coTitleTextBox.Location = new Point(12, 12);
            coTitleTextBox.Name = "coTitleTextBox";
            coTitleTextBox.ReadOnly = true;
            coTitleTextBox.Size = new Size(195, 32);
            coTitleTextBox.TabIndex = 2;
            coTitleTextBox.Text = "Calculate Oxygen";
            coTitleTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // howManyPeopleNumeric
            // 
            howManyPeopleNumeric.Location = new Point(346, 137);
            howManyPeopleNumeric.Name = "howManyPeopleNumeric";
            howManyPeopleNumeric.Size = new Size(139, 23);
            howManyPeopleNumeric.TabIndex = 3;
            // 
            // howLongInHoursNumeric
            // 
            howLongInHoursNumeric.Location = new Point(346, 194);
            howLongInHoursNumeric.Name = "howLongInHoursNumeric";
            howLongInHoursNumeric.Size = new Size(139, 23);
            howLongInHoursNumeric.TabIndex = 4;
            // 
            // roomListBox
            // 
            roomListBox.FormattingEnabled = true;
            roomListBox.ItemHeight = 15;
            roomListBox.Location = new Point(87, 137);
            roomListBox.Name = "roomListBox";
            roomListBox.Size = new Size(174, 139);
            roomListBox.TabIndex = 5;
            // 
            // chooseRoomTextBox
            // 
            chooseRoomTextBox.BorderStyle = BorderStyle.None;
            chooseRoomTextBox.Cursor = Cursors.No;
            chooseRoomTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chooseRoomTextBox.Location = new Point(87, 109);
            chooseRoomTextBox.Name = "chooseRoomTextBox";
            chooseRoomTextBox.ReadOnly = true;
            chooseRoomTextBox.Size = new Size(174, 22);
            chooseRoomTextBox.TabIndex = 6;
            chooseRoomTextBox.Text = "Choose Room";
            chooseRoomTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // howManyTextBox
            // 
            howManyTextBox.BorderStyle = BorderStyle.None;
            howManyTextBox.Cursor = Cursors.No;
            howManyTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            howManyTextBox.Location = new Point(346, 109);
            howManyTextBox.Name = "howManyTextBox";
            howManyTextBox.ReadOnly = true;
            howManyTextBox.Size = new Size(139, 22);
            howManyTextBox.TabIndex = 7;
            howManyTextBox.Text = "How Many People";
            howManyTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // howLongTextBox
            // 
            howLongTextBox.BorderStyle = BorderStyle.None;
            howLongTextBox.Cursor = Cursors.No;
            howLongTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            howLongTextBox.Location = new Point(346, 166);
            howLongTextBox.Name = "howLongTextBox";
            howLongTextBox.ReadOnly = true;
            howLongTextBox.Size = new Size(139, 22);
            howLongTextBox.TabIndex = 8;
            howLongTextBox.Text = "How Long In Hours";
            howLongTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // resultTextBox
            // 
            resultTextBox.BorderStyle = BorderStyle.None;
            resultTextBox.Cursor = Cursors.No;
            resultTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultTextBox.Location = new Point(332, 284);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.ReadOnly = true;
            resultTextBox.Size = new Size(64, 22);
            resultTextBox.TabIndex = 9;
            resultTextBox.Text = "Result:";
            resultTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // resultValueTextBox
            // 
            resultValueTextBox.Location = new Point(332, 312);
            resultValueTextBox.Name = "resultValueTextBox";
            resultValueTextBox.ReadOnly = true;
            resultValueTextBox.Size = new Size(259, 113);
            resultValueTextBox.TabIndex = 10;
            resultValueTextBox.Text = "";
            // 
            // CalculateOxygenMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultValueTextBox);
            Controls.Add(resultTextBox);
            Controls.Add(howLongTextBox);
            Controls.Add(howManyTextBox);
            Controls.Add(chooseRoomTextBox);
            Controls.Add(roomListBox);
            Controls.Add(howLongInHoursNumeric);
            Controls.Add(howManyPeopleNumeric);
            Controls.Add(coTitleTextBox);
            Name = "CalculateOxygenMenu";
            Text = "Calculate Oxygen";
            ((System.ComponentModel.ISupportInitialize)howManyPeopleNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)howLongInHoursNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox coTitleTextBox;
        private NumericUpDown howManyPeopleNumeric;
        private NumericUpDown howLongInHoursNumeric;
        private ListBox roomListBox;
        private TextBox chooseRoomTextBox;
        private TextBox howManyTextBox;
        private TextBox howLongTextBox;
        private TextBox resultTextBox;
        private RichTextBox resultValueTextBox;
    }
}