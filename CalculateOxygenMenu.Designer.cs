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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            resultValueTextBox = new RichTextBox();
            resultTextBox = new TextBox();
            howLongTextBox = new TextBox();
            howManyTextBox = new TextBox();
            chooseRoomTextBox = new TextBox();
            roomListBox = new ListBox();
            howLongInHoursNumeric = new NumericUpDown();
            howManyPeopleNumeric = new NumericUpDown();
            coTitleTextBox = new TextBox();
            calculateOxygenButton = new Button();
            roomInfoTextBox = new TextBox();
            roomInfoValueTextBox = new RichTextBox();
            refreshRoomsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)howLongInHoursNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)howManyPeopleNumeric).BeginInit();
            SuspendLayout();
            // 
            // resultValueTextBox
            // 
            resultValueTextBox.Location = new Point(302, 290);
            resultValueTextBox.Name = "resultValueTextBox";
            resultValueTextBox.ReadOnly = true;
            resultValueTextBox.Size = new Size(259, 113);
            resultValueTextBox.TabIndex = 19;
            resultValueTextBox.Text = "";
            // 
            // resultTextBox
            // 
            resultTextBox.BorderStyle = BorderStyle.None;
            resultTextBox.Cursor = Cursors.No;
            resultTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultTextBox.Location = new Point(302, 262);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.ReadOnly = true;
            resultTextBox.Size = new Size(64, 22);
            resultTextBox.TabIndex = 18;
            resultTextBox.Text = "Result:";
            resultTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // howLongTextBox
            // 
            howLongTextBox.BorderStyle = BorderStyle.None;
            howLongTextBox.Cursor = Cursors.No;
            howLongTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            howLongTextBox.Location = new Point(302, 119);
            howLongTextBox.Name = "howLongTextBox";
            howLongTextBox.ReadOnly = true;
            howLongTextBox.Size = new Size(139, 22);
            howLongTextBox.TabIndex = 17;
            howLongTextBox.Text = "How Long In Hours";
            howLongTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // howManyTextBox
            // 
            howManyTextBox.BorderStyle = BorderStyle.None;
            howManyTextBox.Cursor = Cursors.No;
            howManyTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            howManyTextBox.Location = new Point(302, 62);
            howManyTextBox.Name = "howManyTextBox";
            howManyTextBox.ReadOnly = true;
            howManyTextBox.Size = new Size(139, 22);
            howManyTextBox.TabIndex = 16;
            howManyTextBox.Text = "How Many People";
            howManyTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // chooseRoomTextBox
            // 
            chooseRoomTextBox.BorderStyle = BorderStyle.None;
            chooseRoomTextBox.Cursor = Cursors.No;
            chooseRoomTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chooseRoomTextBox.Location = new Point(24, 61);
            chooseRoomTextBox.Name = "chooseRoomTextBox";
            chooseRoomTextBox.ReadOnly = true;
            chooseRoomTextBox.Size = new Size(174, 22);
            chooseRoomTextBox.TabIndex = 15;
            chooseRoomTextBox.Text = "Choose Room";
            chooseRoomTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // roomListBox
            // 
            roomListBox.FormattingEnabled = true;
            roomListBox.ItemHeight = 15;
            roomListBox.Location = new Point(24, 89);
            roomListBox.Name = "roomListBox";
            roomListBox.Size = new Size(174, 109);
            roomListBox.TabIndex = 14;
            roomListBox.SelectedIndexChanged += roomListBox_SelectedIndexChanged;
            // 
            // howLongInHoursNumeric
            // 
            howLongInHoursNumeric.Location = new Point(302, 147);
            howLongInHoursNumeric.Name = "howLongInHoursNumeric";
            howLongInHoursNumeric.Size = new Size(139, 23);
            howLongInHoursNumeric.TabIndex = 13;
            // 
            // howManyPeopleNumeric
            // 
            howManyPeopleNumeric.Location = new Point(302, 90);
            howManyPeopleNumeric.Name = "howManyPeopleNumeric";
            howManyPeopleNumeric.Size = new Size(139, 23);
            howManyPeopleNumeric.TabIndex = 12;
            // 
            // coTitleTextBox
            // 
            coTitleTextBox.BorderStyle = BorderStyle.None;
            coTitleTextBox.Cursor = Cursors.No;
            coTitleTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            coTitleTextBox.Location = new Point(3, 3);
            coTitleTextBox.Name = "coTitleTextBox";
            coTitleTextBox.ReadOnly = true;
            coTitleTextBox.Size = new Size(195, 32);
            coTitleTextBox.TabIndex = 11;
            coTitleTextBox.Text = "Calculate Oxygen";
            coTitleTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // calculateOxygenButton
            // 
            calculateOxygenButton.Location = new Point(302, 206);
            calculateOxygenButton.Name = "calculateOxygenButton";
            calculateOxygenButton.Size = new Size(75, 23);
            calculateOxygenButton.TabIndex = 20;
            calculateOxygenButton.Text = "Calculate";
            calculateOxygenButton.UseVisualStyleBackColor = true;
            calculateOxygenButton.Click += calculateOxygenButton_Click;
            // 
            // roomInfoTextBox
            // 
            roomInfoTextBox.BorderStyle = BorderStyle.None;
            roomInfoTextBox.Cursor = Cursors.No;
            roomInfoTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roomInfoTextBox.Location = new Point(24, 262);
            roomInfoTextBox.Name = "roomInfoTextBox";
            roomInfoTextBox.ReadOnly = true;
            roomInfoTextBox.Size = new Size(89, 22);
            roomInfoTextBox.TabIndex = 21;
            roomInfoTextBox.Text = "Room Info";
            roomInfoTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // roomInfoValueTextBox
            // 
            roomInfoValueTextBox.Location = new Point(24, 290);
            roomInfoValueTextBox.Name = "roomInfoValueTextBox";
            roomInfoValueTextBox.ReadOnly = true;
            roomInfoValueTextBox.Size = new Size(209, 113);
            roomInfoValueTextBox.TabIndex = 22;
            roomInfoValueTextBox.Text = "";
            // 
            // refreshRoomsButton
            // 
            refreshRoomsButton.Location = new Point(24, 206);
            refreshRoomsButton.Name = "refreshRoomsButton";
            refreshRoomsButton.Size = new Size(75, 23);
            refreshRoomsButton.TabIndex = 23;
            refreshRoomsButton.Text = "Refresh";
            refreshRoomsButton.UseVisualStyleBackColor = true;
            refreshRoomsButton.Click += refreshRoomsButton_Click;
            // 
            // CalculateOxygenMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(refreshRoomsButton);
            Controls.Add(roomInfoValueTextBox);
            Controls.Add(roomInfoTextBox);
            Controls.Add(calculateOxygenButton);
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
            Size = new Size(622, 426);
            ((System.ComponentModel.ISupportInitialize)howLongInHoursNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)howManyPeopleNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox resultValueTextBox;
        private TextBox resultTextBox;
        private TextBox howLongTextBox;
        private TextBox howManyTextBox;
        private TextBox chooseRoomTextBox;
        private ListBox roomListBox;
        private NumericUpDown howLongInHoursNumeric;
        private NumericUpDown howManyPeopleNumeric;
        private TextBox coTitleTextBox;
        private Button calculateOxygenButton;
        private TextBox roomInfoTextBox;
        private RichTextBox roomInfoValueTextBox;
        private Button refreshRoomsButton;
    }
}
