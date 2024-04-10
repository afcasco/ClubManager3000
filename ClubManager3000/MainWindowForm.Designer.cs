namespace ClubManager3000
{
    partial class FormClubManager3000
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClubManager3000));
            this.socisListBox = new System.Windows.Forms.ListBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.sociActionsGroup = new System.Windows.Forms.GroupBox();
            this.dadesSociGroupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.removeActivitatButton = new System.Windows.Forms.Button();
            this.addActivitatButton = new System.Windows.Forms.Button();
            this.dataAltaTextBox = new System.Windows.Forms.TextBox();
            this.dataAltaLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.mobilTextBox = new System.Windows.Forms.TextBox();
            this.mobilLabel = new System.Windows.Forms.Label();
            this.llistaActivitatsListBox = new System.Windows.Forms.Label();
            this.activitatsListBox = new System.Windows.Forms.ListBox();
            this.cognomsTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.cognomsLabel = new System.Windows.Forms.Label();
            this.nomLabel = new System.Windows.Forms.Label();
            this.toolTipControl = new System.Windows.Forms.ToolTip(this.components);
            this.headerTextLabel = new System.Windows.Forms.Label();
            this.removeSociButton = new System.Windows.Forms.Button();
            this.addSociButton = new System.Windows.Forms.Button();
            this.saveSociButton = new System.Windows.Forms.Button();
            this.modifySociButton = new System.Windows.Forms.Button();
            this.headerPictureBox = new System.Windows.Forms.PictureBox();
            this.sociActionsGroup.SuspendLayout();
            this.dadesSociGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // socisListBox
            // 
            this.socisListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.socisListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.socisListBox.FormattingEnabled = true;
            this.socisListBox.ItemHeight = 20;
            this.socisListBox.Location = new System.Drawing.Point(6, 25);
            this.socisListBox.Name = "socisListBox";
            this.socisListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.socisListBox.Size = new System.Drawing.Size(180, 402);
            this.socisListBox.TabIndex = 1;
            this.socisListBox.SelectedIndexChanged += new System.EventHandler(this.SocisListBox_SelectedIndexChanged);
            // 
            // statusTextBox
            // 
            this.statusTextBox.Enabled = false;
            this.statusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTextBox.Location = new System.Drawing.Point(12, 632);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(548, 26);
            this.statusTextBox.TabIndex = 2;
            // 
            // sociActionsGroup
            // 
            this.sociActionsGroup.Controls.Add(this.socisListBox);
            this.sociActionsGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sociActionsGroup.Location = new System.Drawing.Point(12, 189);
            this.sociActionsGroup.Name = "sociActionsGroup";
            this.sociActionsGroup.Size = new System.Drawing.Size(195, 437);
            this.sociActionsGroup.TabIndex = 5;
            this.sociActionsGroup.TabStop = false;
            this.sociActionsGroup.Text = "Socis Actius";
            // 
            // dadesSociGroupBox
            // 
            this.dadesSociGroupBox.Controls.Add(this.pictureBox1);
            this.dadesSociGroupBox.Controls.Add(this.removeActivitatButton);
            this.dadesSociGroupBox.Controls.Add(this.addActivitatButton);
            this.dadesSociGroupBox.Controls.Add(this.dataAltaTextBox);
            this.dadesSociGroupBox.Controls.Add(this.dataAltaLabel);
            this.dadesSociGroupBox.Controls.Add(this.emailTextBox);
            this.dadesSociGroupBox.Controls.Add(this.emailLabel);
            this.dadesSociGroupBox.Controls.Add(this.mobilTextBox);
            this.dadesSociGroupBox.Controls.Add(this.mobilLabel);
            this.dadesSociGroupBox.Controls.Add(this.llistaActivitatsListBox);
            this.dadesSociGroupBox.Controls.Add(this.activitatsListBox);
            this.dadesSociGroupBox.Controls.Add(this.cognomsTextBox);
            this.dadesSociGroupBox.Controls.Add(this.nomTextBox);
            this.dadesSociGroupBox.Controls.Add(this.cognomsLabel);
            this.dadesSociGroupBox.Controls.Add(this.nomLabel);
            this.dadesSociGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dadesSociGroupBox.Location = new System.Drawing.Point(213, 189);
            this.dadesSociGroupBox.Name = "dadesSociGroupBox";
            this.dadesSociGroupBox.Size = new System.Drawing.Size(347, 437);
            this.dadesSociGroupBox.TabIndex = 6;
            this.dadesSociGroupBox.TabStop = false;
            this.dadesSociGroupBox.Text = "Dades del soci seleccionat";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(6, 389);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 38);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // removeActivitatButton
            // 
            this.removeActivitatButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeActivitatButton.BackgroundImage")));
            this.removeActivitatButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.removeActivitatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeActivitatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeActivitatButton.ForeColor = System.Drawing.Color.Black;
            this.removeActivitatButton.Location = new System.Drawing.Point(121, 352);
            this.removeActivitatButton.Name = "removeActivitatButton";
            this.removeActivitatButton.Size = new System.Drawing.Size(25, 25);
            this.removeActivitatButton.TabIndex = 20;
            this.removeActivitatButton.UseCompatibleTextRendering = true;
            this.removeActivitatButton.UseVisualStyleBackColor = true;
            this.removeActivitatButton.Click += new System.EventHandler(this.RemoveActivitatButton_Click);
            // 
            // addActivitatButton
            // 
            this.addActivitatButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addActivitatButton.BackgroundImage")));
            this.addActivitatButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addActivitatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addActivitatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addActivitatButton.ForeColor = System.Drawing.Color.Black;
            this.addActivitatButton.Location = new System.Drawing.Point(90, 352);
            this.addActivitatButton.Name = "addActivitatButton";
            this.addActivitatButton.Size = new System.Drawing.Size(25, 25);
            this.addActivitatButton.TabIndex = 19;
            this.addActivitatButton.UseCompatibleTextRendering = true;
            this.addActivitatButton.UseVisualStyleBackColor = true;
            this.addActivitatButton.Click += new System.EventHandler(this.AddActivitatButton_Click);
            // 
            // dataAltaTextBox
            // 
            this.dataAltaTextBox.Location = new System.Drawing.Point(153, 147);
            this.dataAltaTextBox.Name = "dataAltaTextBox";
            this.dataAltaTextBox.Size = new System.Drawing.Size(179, 24);
            this.dataAltaTextBox.TabIndex = 18;
            // 
            // dataAltaLabel
            // 
            this.dataAltaLabel.AutoSize = true;
            this.dataAltaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataAltaLabel.ForeColor = System.Drawing.Color.Black;
            this.dataAltaLabel.Location = new System.Drawing.Point(14, 149);
            this.dataAltaLabel.Name = "dataAltaLabel";
            this.dataAltaLabel.Size = new System.Drawing.Size(126, 20);
            this.dataAltaLabel.TabIndex = 17;
            this.dataAltaLabel.Text = "Data matrícula";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(153, 117);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(179, 24);
            this.emailTextBox.TabIndex = 16;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.Black;
            this.emailLabel.Location = new System.Drawing.Point(14, 119);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(53, 20);
            this.emailLabel.TabIndex = 15;
            this.emailLabel.Text = "Email";
            // 
            // mobilTextBox
            // 
            this.mobilTextBox.Location = new System.Drawing.Point(153, 87);
            this.mobilTextBox.Name = "mobilTextBox";
            this.mobilTextBox.Size = new System.Drawing.Size(178, 24);
            this.mobilTextBox.TabIndex = 14;
            // 
            // mobilLabel
            // 
            this.mobilLabel.AutoSize = true;
            this.mobilLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobilLabel.ForeColor = System.Drawing.Color.Black;
            this.mobilLabel.Location = new System.Drawing.Point(14, 91);
            this.mobilLabel.Name = "mobilLabel";
            this.mobilLabel.Size = new System.Drawing.Size(51, 20);
            this.mobilLabel.TabIndex = 13;
            this.mobilLabel.Text = "Mòbil";
            // 
            // llistaActivitatsListBox
            // 
            this.llistaActivitatsListBox.AutoSize = true;
            this.llistaActivitatsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llistaActivitatsListBox.ForeColor = System.Drawing.Color.Black;
            this.llistaActivitatsListBox.Location = new System.Drawing.Point(15, 177);
            this.llistaActivitatsListBox.Name = "llistaActivitatsListBox";
            this.llistaActivitatsListBox.Size = new System.Drawing.Size(83, 20);
            this.llistaActivitatsListBox.TabIndex = 12;
            this.llistaActivitatsListBox.Text = "Activitats";
            // 
            // activitatsListBox
            // 
            this.activitatsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.activitatsListBox.FormattingEnabled = true;
            this.activitatsListBox.ItemHeight = 18;
            this.activitatsListBox.Location = new System.Drawing.Point(152, 177);
            this.activitatsListBox.Name = "activitatsListBox";
            this.activitatsListBox.Size = new System.Drawing.Size(178, 200);
            this.activitatsListBox.TabIndex = 0;
            // 
            // cognomsTextBox
            // 
            this.cognomsTextBox.Location = new System.Drawing.Point(153, 55);
            this.cognomsTextBox.Name = "cognomsTextBox";
            this.cognomsTextBox.Size = new System.Drawing.Size(178, 24);
            this.cognomsTextBox.TabIndex = 11;
            // 
            // nomTextBox
            // 
            this.nomTextBox.Location = new System.Drawing.Point(152, 25);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(179, 24);
            this.nomTextBox.TabIndex = 10;
            // 
            // cognomsLabel
            // 
            this.cognomsLabel.AutoSize = true;
            this.cognomsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cognomsLabel.ForeColor = System.Drawing.Color.Black;
            this.cognomsLabel.Location = new System.Drawing.Point(14, 57);
            this.cognomsLabel.Name = "cognomsLabel";
            this.cognomsLabel.Size = new System.Drawing.Size(84, 20);
            this.cognomsLabel.TabIndex = 9;
            this.cognomsLabel.Text = "Cognoms";
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomLabel.ForeColor = System.Drawing.Color.Black;
            this.nomLabel.Location = new System.Drawing.Point(14, 27);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(45, 20);
            this.nomLabel.TabIndex = 8;
            this.nomLabel.Text = "Nom";
            // 
            // toolTipControl
            // 
            this.toolTipControl.Popup += new System.Windows.Forms.PopupEventHandler(this.ToolTipControl_Popup);
            // 
            // headerTextLabel
            // 
            this.headerTextLabel.AutoSize = true;
            this.headerTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerTextLabel.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(236)))), ((int)(((byte)(230)))));
            this.headerTextLabel.Location = new System.Drawing.Point(12, 47);
            this.headerTextLabel.Name = "headerTextLabel";
            this.headerTextLabel.Size = new System.Drawing.Size(297, 35);
            this.headerTextLabel.TabIndex = 7;
            this.headerTextLabel.Text = "CLUB MANAGER 3K";
            // 
            // removeSociButton
            // 
            this.removeSociButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(133)))), ((int)(((byte)(99)))));
            this.removeSociButton.BackgroundImage = global::ClubManager3000.Properties.Resources.REMOVE_BUTTON_3_;
            this.removeSociButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.removeSociButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.removeSociButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.removeSociButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(74)))), ((int)(((byte)(46)))));
            this.removeSociButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSociButton.Location = new System.Drawing.Point(432, 122);
            this.removeSociButton.Name = "removeSociButton";
            this.removeSociButton.Size = new System.Drawing.Size(128, 50);
            this.removeSociButton.TabIndex = 4;
            this.removeSociButton.UseVisualStyleBackColor = false;
            this.removeSociButton.Click += new System.EventHandler(this.RemoveSociButton_Click);
            // 
            // addSociButton
            // 
            this.addSociButton.AutoSize = true;
            this.addSociButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(133)))), ((int)(((byte)(99)))));
            this.addSociButton.BackgroundImage = global::ClubManager3000.Properties.Resources.ADD_BUTTON;
            this.addSociButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addSociButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.addSociButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addSociButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(74)))), ((int)(((byte)(46)))));
            this.addSociButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSociButton.ForeColor = System.Drawing.Color.Transparent;
            this.addSociButton.Location = new System.Drawing.Point(12, 122);
            this.addSociButton.Name = "addSociButton";
            this.addSociButton.Size = new System.Drawing.Size(128, 50);
            this.addSociButton.TabIndex = 3;
            this.addSociButton.UseVisualStyleBackColor = false;
            this.addSociButton.Click += new System.EventHandler(this.AddSociButton_Click);
            // 
            // saveSociButton
            // 
            this.saveSociButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(133)))), ((int)(((byte)(99)))));
            this.saveSociButton.BackgroundImage = global::ClubManager3000.Properties.Resources.SAVE_BUTTON;
            this.saveSociButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveSociButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.saveSociButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveSociButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(74)))), ((int)(((byte)(46)))));
            this.saveSociButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSociButton.Location = new System.Drawing.Point(293, 122);
            this.saveSociButton.Name = "saveSociButton";
            this.saveSociButton.Size = new System.Drawing.Size(128, 50);
            this.saveSociButton.TabIndex = 9;
            this.saveSociButton.UseVisualStyleBackColor = false;
            this.saveSociButton.Click += new System.EventHandler(this.SaveSociButton_Click);
            // 
            // modifySociButton
            // 
            this.modifySociButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(133)))), ((int)(((byte)(99)))));
            this.modifySociButton.BackgroundImage = global::ClubManager3000.Properties.Resources.EDIT_BUTTON;
            this.modifySociButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.modifySociButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.modifySociButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modifySociButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(74)))), ((int)(((byte)(46)))));
            this.modifySociButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifySociButton.Location = new System.Drawing.Point(153, 122);
            this.modifySociButton.Name = "modifySociButton";
            this.modifySociButton.Size = new System.Drawing.Size(128, 50);
            this.modifySociButton.TabIndex = 8;
            this.modifySociButton.UseVisualStyleBackColor = false;
            this.modifySociButton.Click += new System.EventHandler(this.ModifySociButton_Click);
            // 
            // headerPictureBox
            // 
            this.headerPictureBox.BackgroundImage = global::ClubManager3000.Properties.Resources.MAIN_HEADER;
            this.headerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.headerPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.headerPictureBox.Location = new System.Drawing.Point(12, 12);
            this.headerPictureBox.Name = "headerPictureBox";
            this.headerPictureBox.Size = new System.Drawing.Size(548, 101);
            this.headerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.headerPictureBox.TabIndex = 0;
            this.headerPictureBox.TabStop = false;
            // 
            // FormClubManager3000
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(570, 670);
            this.Controls.Add(this.removeSociButton);
            this.Controls.Add(this.addSociButton);
            this.Controls.Add(this.saveSociButton);
            this.Controls.Add(this.headerTextLabel);
            this.Controls.Add(this.dadesSociGroupBox);
            this.Controls.Add(this.sociActionsGroup);
            this.Controls.Add(this.modifySociButton);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.headerPictureBox);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormClubManager3000";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClubManager3000";
            this.sociActionsGroup.ResumeLayout(false);
            this.dadesSociGroupBox.ResumeLayout(false);
            this.dadesSociGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox headerPictureBox;
        private System.Windows.Forms.ListBox socisListBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Button addSociButton;
        private System.Windows.Forms.Button removeSociButton;
        private System.Windows.Forms.GroupBox sociActionsGroup;
        private System.Windows.Forms.GroupBox dadesSociGroupBox;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.Label cognomsLabel;
        private System.Windows.Forms.TextBox cognomsTextBox;
        private System.Windows.Forms.Button modifySociButton;
        private System.Windows.Forms.Button saveSociButton;
        private System.Windows.Forms.ToolTip toolTipControl;
        private System.Windows.Forms.Label llistaActivitatsListBox;
        private System.Windows.Forms.ListBox activitatsListBox;
        private System.Windows.Forms.Label headerTextLabel;
        private System.Windows.Forms.Label dataAltaLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox mobilTextBox;
        private System.Windows.Forms.Label mobilLabel;
        private System.Windows.Forms.TextBox dataAltaTextBox;
        private System.Windows.Forms.Button removeActivitatButton;
        private System.Windows.Forms.Button addActivitatButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

