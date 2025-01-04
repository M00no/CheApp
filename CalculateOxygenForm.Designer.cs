namespace CheApp
{
    partial class CalculateOxygenForm
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
            titleTextBox = new TextBox();
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
            resultValueTextBox.Location = new Point(431, 483);
            resultValueTextBox.Margin = new Padding(4, 5, 4, 5);
            resultValueTextBox.Name = "resultValueTextBox";
            resultValueTextBox.ReadOnly = true;
            resultValueTextBox.Size = new Size(368, 186);
            resultValueTextBox.TabIndex = 19;
            resultValueTextBox.Text = "";
            // 
            // resultTextBox
            // 
            resultTextBox.BorderStyle = BorderStyle.None;
            resultTextBox.Cursor = Cursors.No;
            resultTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultTextBox.Location = new Point(431, 437);
            resultTextBox.Margin = new Padding(4, 5, 4, 5);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.ReadOnly = true;
            resultTextBox.Size = new Size(91, 32);
            resultTextBox.TabIndex = 18;
            resultTextBox.Text = "Result:";
            resultTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // howLongTextBox
            // 
            howLongTextBox.BorderStyle = BorderStyle.None;
            howLongTextBox.Cursor = Cursors.No;
            howLongTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            howLongTextBox.Location = new Point(431, 198);
            howLongTextBox.Margin = new Padding(4, 5, 4, 5);
            howLongTextBox.Name = "howLongTextBox";
            howLongTextBox.ReadOnly = true;
            howLongTextBox.Size = new Size(199, 32);
            howLongTextBox.TabIndex = 17;
            howLongTextBox.Text = "How Long In Hours";
            howLongTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // howManyTextBox
            // 
            howManyTextBox.BorderStyle = BorderStyle.None;
            howManyTextBox.Cursor = Cursors.No;
            howManyTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            howManyTextBox.Location = new Point(431, 103);
            howManyTextBox.Margin = new Padding(4, 5, 4, 5);
            howManyTextBox.Name = "howManyTextBox";
            howManyTextBox.ReadOnly = true;
            howManyTextBox.Size = new Size(199, 32);
            howManyTextBox.TabIndex = 16;
            howManyTextBox.Text = "How Many People";
            howManyTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // chooseRoomTextBox
            // 
            chooseRoomTextBox.BorderStyle = BorderStyle.None;
            chooseRoomTextBox.Cursor = Cursors.No;
            chooseRoomTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chooseRoomTextBox.Location = new Point(34, 102);
            chooseRoomTextBox.Margin = new Padding(4, 5, 4, 5);
            chooseRoomTextBox.Name = "chooseRoomTextBox";
            chooseRoomTextBox.ReadOnly = true;
            chooseRoomTextBox.Size = new Size(249, 32);
            chooseRoomTextBox.TabIndex = 15;
            chooseRoomTextBox.Text = "Choose Room";
            chooseRoomTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // roomListBox
            // 
            roomListBox.FormattingEnabled = true;
            roomListBox.ItemHeight = 25;
            roomListBox.Location = new Point(34, 148);
            roomListBox.Margin = new Padding(4, 5, 4, 5);
            roomListBox.Name = "roomListBox";
            roomListBox.Size = new Size(247, 179);
            roomListBox.TabIndex = 14;
            roomListBox.SelectedIndexChanged += roomListBox_SelectedIndexChanged;
            // 
            // howLongInHoursNumeric
            // 
            howLongInHoursNumeric.Location = new Point(431, 245);
            howLongInHoursNumeric.Margin = new Padding(4, 5, 4, 5);
            howLongInHoursNumeric.Name = "howLongInHoursNumeric";
            howLongInHoursNumeric.Size = new Size(199, 31);
            howLongInHoursNumeric.TabIndex = 13;
            // 
            // howManyPeopleNumeric
            // 
            howManyPeopleNumeric.Location = new Point(431, 150);
            howManyPeopleNumeric.Margin = new Padding(4, 5, 4, 5);
            howManyPeopleNumeric.Name = "howManyPeopleNumeric";
            howManyPeopleNumeric.Size = new Size(199, 31);
            howManyPeopleNumeric.TabIndex = 12;
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
            titleTextBox.Size = new Size(279, 48);
            titleTextBox.TabIndex = 11;
            titleTextBox.Text = "Calculate Oxygen";
            titleTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // calculateOxygenButton
            // 
            calculateOxygenButton.Location = new Point(431, 343);
            calculateOxygenButton.Margin = new Padding(4, 5, 4, 5);
            calculateOxygenButton.Name = "calculateOxygenButton";
            calculateOxygenButton.Size = new Size(107, 38);
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
            roomInfoTextBox.Location = new Point(34, 437);
            roomInfoTextBox.Margin = new Padding(4, 5, 4, 5);
            roomInfoTextBox.Name = "roomInfoTextBox";
            roomInfoTextBox.ReadOnly = true;
            roomInfoTextBox.Size = new Size(127, 32);
            roomInfoTextBox.TabIndex = 21;
            roomInfoTextBox.Text = "Room Info";
            roomInfoTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // roomInfoValueTextBox
            // 
            roomInfoValueTextBox.Location = new Point(34, 483);
            roomInfoValueTextBox.Margin = new Padding(4, 5, 4, 5);
            roomInfoValueTextBox.Name = "roomInfoValueTextBox";
            roomInfoValueTextBox.ReadOnly = true;
            roomInfoValueTextBox.Size = new Size(297, 186);
            roomInfoValueTextBox.TabIndex = 22;
            roomInfoValueTextBox.Text = "";
            // 
            // refreshRoomsButton
            // 
            refreshRoomsButton.Location = new Point(34, 343);
            refreshRoomsButton.Margin = new Padding(4, 5, 4, 5);
            refreshRoomsButton.Name = "refreshRoomsButton";
            refreshRoomsButton.Size = new Size(107, 38);
            refreshRoomsButton.TabIndex = 23;
            refreshRoomsButton.Text = "Refresh";
            refreshRoomsButton.UseVisualStyleBackColor = true;
            refreshRoomsButton.Click += refreshRoomsButton_Click;
            // 
            // CalculateOxygenForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
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
            Controls.Add(titleTextBox);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CalculateOxygenForm";
            Size = new Size(889, 710);
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
        private TextBox titleTextBox;
        private Button calculateOxygenButton;
        private TextBox roomInfoTextBox;
        private RichTextBox roomInfoValueTextBox;
        private Button refreshRoomsButton;
    }
}
