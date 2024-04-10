namespace ClubManager3000
{
    partial class NewActivityForm
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
            this.newActivityTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.novaActivityatLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newActivityTextBox
            // 
            this.newActivityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newActivityTextBox.Location = new System.Drawing.Point(23, 37);
            this.newActivityTextBox.Name = "newActivityTextBox";
            this.newActivityTextBox.Size = new System.Drawing.Size(187, 29);
            this.newActivityTextBox.TabIndex = 0;
            this.newActivityTextBox.TextChanged += new System.EventHandler(this.newActivityTextBox_TextChanged);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(23, 72);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(92, 35);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(118, 72);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(92, 35);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel·lar";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // novaActivityatLabel
            // 
            this.novaActivityatLabel.AutoSize = true;
            this.novaActivityatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novaActivityatLabel.Location = new System.Drawing.Point(19, 14);
            this.novaActivityatLabel.Name = "novaActivityatLabel";
            this.novaActivityatLabel.Size = new System.Drawing.Size(200, 20);
            this.novaActivityatLabel.TabIndex = 3;
            this.novaActivityatLabel.Text = "Nom de la nova activitat";
            // 
            // NewActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 119);
            this.Controls.Add(this.novaActivityatLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.newActivityTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewActivityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova activitat";
            this.Load += new System.EventHandler(this.NewActivityForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newActivityTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label novaActivityatLabel;
    }
}