namespace gsg_unpack
{
    partial class gsg_unpack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gsg_unpack));
            gameLabel = new Label();
            gameChooser = new ComboBox();
            fileType = new Label();
            fileTypeChooser = new ComboBox();
            resLabel = new Label();
            resChooser = new ComboBox();
            sgIcon = new PictureBox();
            startButton = new Button();
            fileListLabel = new Label();
            fileListBox = new ListBox();
            ((System.ComponentModel.ISupportInitialize)sgIcon).BeginInit();
            SuspendLayout();
            // 
            // gameLabel
            // 
            gameLabel.AutoSize = true;
            gameLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            gameLabel.ForeColor = SystemColors.ControlLightLight;
            gameLabel.Location = new Point(12, 7);
            gameLabel.Name = "gameLabel";
            gameLabel.Size = new Size(106, 45);
            gameLabel.TabIndex = 0;
            gameLabel.Text = "Game";
            // 
            // gameChooser
            // 
            gameChooser.DropDownStyle = ComboBoxStyle.DropDownList;
            gameChooser.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            gameChooser.FormattingEnabled = true;
            gameChooser.Items.AddRange(new object[] { "STEINS;GATE", "STEINS;GATE 0", "STEINS;GATE: Linear Bounded Phenogram", "STEINS;GATE: My Darling's Embrace" });
            gameChooser.Location = new Point(135, 16);
            gameChooser.Name = "gameChooser";
            gameChooser.Size = new Size(445, 38);
            gameChooser.TabIndex = 1;
            gameChooser.SelectedIndexChanged += gameChooser_SelectedIndexChanged;
            // 
            // fileType
            // 
            fileType.AutoSize = true;
            fileType.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            fileType.ForeColor = SystemColors.ControlLightLight;
            fileType.Location = new Point(12, 78);
            fileType.Name = "fileType";
            fileType.Size = new Size(153, 45);
            fileType.TabIndex = 2;
            fileType.Text = "File Type";
            // 
            // fileTypeChooser
            // 
            fileTypeChooser.DropDownStyle = ComboBoxStyle.DropDownList;
            fileTypeChooser.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            fileTypeChooser.FormattingEnabled = true;
            fileTypeChooser.Items.AddRange(new object[] { "MPK", "BK2" });
            fileTypeChooser.Location = new Point(182, 87);
            fileTypeChooser.Name = "fileTypeChooser";
            fileTypeChooser.Size = new Size(398, 38);
            fileTypeChooser.TabIndex = 3;
            fileTypeChooser.SelectedIndexChanged += fileTypeChooser_SelectedIndexChanged;
            // 
            // resLabel
            // 
            resLabel.AutoSize = true;
            resLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            resLabel.ForeColor = SystemColors.ControlLightLight;
            resLabel.Location = new Point(12, 152);
            resLabel.Name = "resLabel";
            resLabel.Size = new Size(179, 45);
            resLabel.TabIndex = 4;
            resLabel.Text = "Resolution";
            // 
            // resChooser
            // 
            resChooser.DropDownStyle = ComboBoxStyle.DropDownList;
            resChooser.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            resChooser.FormattingEnabled = true;
            resChooser.Items.AddRange(new object[] { "1280x720", "1920x1080" });
            resChooser.Location = new Point(208, 159);
            resChooser.Name = "resChooser";
            resChooser.Size = new Size(372, 38);
            resChooser.TabIndex = 5;
            resChooser.SelectedIndexChanged += resChooser_SelectedIndexChanged;
            // 
            // sgIcon
            // 
            sgIcon.Image = Properties.Resources.SGIcon;
            sgIcon.Location = new Point(638, 12);
            sgIcon.Name = "sgIcon";
            sgIcon.Size = new Size(135, 138);
            sgIcon.SizeMode = PictureBoxSizeMode.Zoom;
            sgIcon.TabIndex = 6;
            sgIcon.TabStop = false;
            // 
            // startButton
            // 
            startButton.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startButton.Location = new Point(638, 244);
            startButton.Name = "startButton";
            startButton.Size = new Size(135, 83);
            startButton.TabIndex = 7;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // fileListLabel
            // 
            fileListLabel.AutoSize = true;
            fileListLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            fileListLabel.ForeColor = SystemColors.ControlLightLight;
            fileListLabel.Location = new Point(12, 233);
            fileListLabel.Name = "fileListLabel";
            fileListLabel.Size = new Size(86, 45);
            fileListLabel.TabIndex = 8;
            fileListLabel.Text = "Files";
            // 
            // fileListBox
            // 
            fileListBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fileListBox.FormattingEnabled = true;
            fileListBox.ItemHeight = 30;
            fileListBox.Location = new Point(124, 244);
            fileListBox.Name = "fileListBox";
            fileListBox.SelectionMode = SelectionMode.MultiSimple;
            fileListBox.Size = new Size(445, 184);
            fileListBox.TabIndex = 9;
            // 
            // gsg_unpack
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(fileListBox);
            Controls.Add(fileListLabel);
            Controls.Add(startButton);
            Controls.Add(sgIcon);
            Controls.Add(resChooser);
            Controls.Add(resLabel);
            Controls.Add(fileTypeChooser);
            Controls.Add(fileType);
            Controls.Add(gameChooser);
            Controls.Add(gameLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "gsg_unpack";
            Text = "gsg-unpack";
            Load += gsg_unpack_Load;
            ((System.ComponentModel.ISupportInitialize)sgIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label gameLabel;
        private ComboBox gameChooser;
        private Label fileType;
        private ComboBox fileTypeChooser;
        private Label resLabel;
        private ComboBox resChooser;
        private PictureBox sgIcon;
        private Button startButton;
        private Label fileListLabel;
        private ListBox fileListBox;
    }
}
