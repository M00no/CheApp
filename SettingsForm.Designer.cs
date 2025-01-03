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
            SuspendLayout();
            // 
            // buildingsListBox
            // 
            buildingsListBox.FormattingEnabled = true;
            buildingsListBox.ItemHeight = 25;
            buildingsListBox.Location = new Point(184, 141);
            buildingsListBox.Name = "buildingsListBox";
            buildingsListBox.Size = new Size(293, 204);
            buildingsListBox.TabIndex = 0;
            // 
            // roomsListBox
            // 
            roomsListBox.FormattingEnabled = true;
            roomsListBox.ItemHeight = 25;
            roomsListBox.Location = new Point(616, 141);
            roomsListBox.Name = "roomsListBox";
            roomsListBox.Size = new Size(307, 204);
            roomsListBox.TabIndex = 1;
            // 
            // addBuildingButton
            // 
            addBuildingButton.Location = new Point(184, 351);
            addBuildingButton.Name = "addBuildingButton";
            addBuildingButton.Size = new Size(75, 34);
            addBuildingButton.TabIndex = 2;
            addBuildingButton.Text = "Add";
            addBuildingButton.UseVisualStyleBackColor = true;
            addBuildingButton.Click += addBuildingButton_Click;
            // 
            // editBuildingButton
            // 
            editBuildingButton.Location = new Point(265, 351);
            editBuildingButton.Name = "editBuildingButton";
            editBuildingButton.Size = new Size(112, 34);
            editBuildingButton.TabIndex = 3;
            editBuildingButton.Text = "Edit";
            editBuildingButton.UseVisualStyleBackColor = true;
            // 
            // deleteBuildingButton
            // 
            deleteBuildingButton.Location = new Point(383, 351);
            deleteBuildingButton.Name = "deleteBuildingButton";
            deleteBuildingButton.Size = new Size(94, 34);
            deleteBuildingButton.TabIndex = 4;
            deleteBuildingButton.Text = "Delete";
            deleteBuildingButton.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(deleteBuildingButton);
            Controls.Add(editBuildingButton);
            Controls.Add(addBuildingButton);
            Controls.Add(roomsListBox);
            Controls.Add(buildingsListBox);
            Name = "SettingsForm";
            Size = new Size(1095, 573);
            ResumeLayout(false);
        }

        #endregion

        private ListBox buildingsListBox;
        private ListBox roomsListBox;
        private Button addBuildingButton;
        private Button editBuildingButton;
        private Button deleteBuildingButton;
    }
}
