namespace CheApp
{
    partial class SettingsForm
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
            buildingsListBox = new ListBox();
            roomsListBox = new ListBox();
            addBuildingButton = new Button();
            editBuildingButton = new Button();
            deleteBuildingButton = new Button();
            addRoomButton = new Button();
            editRoomButton = new Button();
            deleteRoomButton = new Button();
            titleTextBox = new TextBox();
            chooseRoomTextBox = new TextBox();
            roomsTextBox = new TextBox();
            SuspendLayout();
            // 
            // buildingsListBox
            // 
            buildingsListBox.FormattingEnabled = true;
            buildingsListBox.ItemHeight = 25;
            buildingsListBox.Location = new Point(78, 164);
            buildingsListBox.Name = "buildingsListBox";
            buildingsListBox.Size = new Size(293, 204);
            buildingsListBox.TabIndex = 0;
            buildingsListBox.SelectedIndexChanged += buildingsListBox_SelectedIndexChanged;
            // 
            // roomsListBox
            // 
            roomsListBox.FormattingEnabled = true;
            roomsListBox.ItemHeight = 25;
            roomsListBox.Location = new Point(510, 164);
            roomsListBox.Name = "roomsListBox";
            roomsListBox.Size = new Size(293, 204);
            roomsListBox.TabIndex = 1;
            // 
            // addBuildingButton
            // 
            addBuildingButton.Location = new Point(78, 374);
            addBuildingButton.Name = "addBuildingButton";
            addBuildingButton.Size = new Size(75, 34);
            addBuildingButton.TabIndex = 2;
            addBuildingButton.Text = "Add";
            addBuildingButton.UseVisualStyleBackColor = true;
            addBuildingButton.Click += addBuildingButton_Click;
            // 
            // editBuildingButton
            // 
            editBuildingButton.Location = new Point(159, 374);
            editBuildingButton.Name = "editBuildingButton";
            editBuildingButton.Size = new Size(112, 34);
            editBuildingButton.TabIndex = 3;
            editBuildingButton.Text = "Edit";
            editBuildingButton.UseVisualStyleBackColor = true;
            // 
            // deleteBuildingButton
            // 
            deleteBuildingButton.Location = new Point(277, 374);
            deleteBuildingButton.Name = "deleteBuildingButton";
            deleteBuildingButton.Size = new Size(94, 34);
            deleteBuildingButton.TabIndex = 4;
            deleteBuildingButton.Text = "Delete";
            deleteBuildingButton.UseVisualStyleBackColor = true;
            deleteBuildingButton.Click += deleteBuildingButton_Click;
            // 
            // addRoomButton
            // 
            addRoomButton.Location = new Point(510, 374);
            addRoomButton.Name = "addRoomButton";
            addRoomButton.Size = new Size(75, 34);
            addRoomButton.TabIndex = 5;
            addRoomButton.Text = "Add";
            addRoomButton.UseVisualStyleBackColor = true;
            // 
            // editRoomButton
            // 
            editRoomButton.Location = new Point(591, 374);
            editRoomButton.Name = "editRoomButton";
            editRoomButton.Size = new Size(112, 34);
            editRoomButton.TabIndex = 6;
            editRoomButton.Text = "Edit";
            editRoomButton.UseVisualStyleBackColor = true;
            // 
            // deleteRoomButton
            // 
            deleteRoomButton.Location = new Point(709, 374);
            deleteRoomButton.Name = "deleteRoomButton";
            deleteRoomButton.Size = new Size(94, 34);
            deleteRoomButton.TabIndex = 7;
            deleteRoomButton.Text = "Delete";
            deleteRoomButton.UseVisualStyleBackColor = true;
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
            titleTextBox.Size = new Size(162, 48);
            titleTextBox.TabIndex = 12;
            titleTextBox.Text = "Settings";
            titleTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // chooseRoomTextBox
            // 
            chooseRoomTextBox.BorderStyle = BorderStyle.None;
            chooseRoomTextBox.Cursor = Cursors.No;
            chooseRoomTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chooseRoomTextBox.Location = new Point(105, 124);
            chooseRoomTextBox.Margin = new Padding(4, 5, 4, 5);
            chooseRoomTextBox.Name = "chooseRoomTextBox";
            chooseRoomTextBox.ReadOnly = true;
            chooseRoomTextBox.Size = new Size(249, 32);
            chooseRoomTextBox.TabIndex = 16;
            chooseRoomTextBox.Text = "Buildings";
            chooseRoomTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // roomsTextBox
            // 
            roomsTextBox.BorderStyle = BorderStyle.None;
            roomsTextBox.Cursor = Cursors.No;
            roomsTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roomsTextBox.Location = new Point(532, 124);
            roomsTextBox.Margin = new Padding(4, 5, 4, 5);
            roomsTextBox.Name = "roomsTextBox";
            roomsTextBox.ReadOnly = true;
            roomsTextBox.Size = new Size(249, 32);
            roomsTextBox.TabIndex = 17;
            roomsTextBox.Text = "Rooms";
            roomsTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(roomsTextBox);
            Controls.Add(chooseRoomTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(deleteRoomButton);
            Controls.Add(editRoomButton);
            Controls.Add(addRoomButton);
            Controls.Add(deleteBuildingButton);
            Controls.Add(editBuildingButton);
            Controls.Add(addBuildingButton);
            Controls.Add(roomsListBox);
            Controls.Add(buildingsListBox);
            Name = "SettingsForm";
            Size = new Size(889, 710);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox buildingsListBox;
        private ListBox roomsListBox;
        private Button addBuildingButton;
        private Button editBuildingButton;
        private Button deleteBuildingButton;
        private Button addRoomButton;
        private Button editRoomButton;
        private Button deleteRoomButton;
        private TextBox titleTextBox;
        private TextBox chooseRoomTextBox;
        private TextBox roomsTextBox;
    }
}
