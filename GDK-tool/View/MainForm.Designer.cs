namespace GDK_tool.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.log = new System.Windows.Forms.TextBox();
            this.getCurrentSanboxButton = new System.Windows.Forms.Button();
            this.currentSandboxLable = new System.Windows.Forms.Label();
            this.changeSandboxButton = new System.Windows.Forms.Button();
            this.changeSandboxTextBox = new System.Windows.Forms.TextBox();
            this.installPackageButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.OpenFileDialogButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(477, 32);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.log.Size = new System.Drawing.Size(311, 406);
            this.log.TabIndex = 0;
            // 
            // getCurrentSanboxButton
            // 
            this.getCurrentSanboxButton.Location = new System.Drawing.Point(12, 32);
            this.getCurrentSanboxButton.Name = "getCurrentSanboxButton";
            this.getCurrentSanboxButton.Size = new System.Drawing.Size(195, 34);
            this.getCurrentSanboxButton.TabIndex = 1;
            this.getCurrentSanboxButton.Text = "Get current sanbox";
            this.getCurrentSanboxButton.UseVisualStyleBackColor = true;
            this.getCurrentSanboxButton.Click += new System.EventHandler(this.GetCurrentSandboxButton_Click);
            // 
            // currentSandboxLable
            // 
            this.currentSandboxLable.AutoSize = true;
            this.currentSandboxLable.Location = new System.Drawing.Point(249, 42);
            this.currentSandboxLable.Name = "currentSandboxLable";
            this.currentSandboxLable.Size = new System.Drawing.Size(53, 15);
            this.currentSandboxLable.TabIndex = 2;
            this.currentSandboxLable.Text = "Sandbox";
            // 
            // changeSandboxButton
            // 
            this.changeSandboxButton.Location = new System.Drawing.Point(12, 92);
            this.changeSandboxButton.Name = "changeSandboxButton";
            this.changeSandboxButton.Size = new System.Drawing.Size(195, 34);
            this.changeSandboxButton.TabIndex = 3;
            this.changeSandboxButton.Text = "Change Sandbox";
            this.changeSandboxButton.UseVisualStyleBackColor = true;
            this.changeSandboxButton.Click += new System.EventHandler(this.ChangeSandboxButton_Click);
            // 
            // changeSandboxTextBox
            // 
            this.changeSandboxTextBox.Location = new System.Drawing.Point(249, 99);
            this.changeSandboxTextBox.Name = "changeSandboxTextBox";
            this.changeSandboxTextBox.Size = new System.Drawing.Size(100, 23);
            this.changeSandboxTextBox.TabIndex = 4;
            // 
            // installPackageButton
            // 
            this.installPackageButton.Location = new System.Drawing.Point(12, 158);
            this.installPackageButton.Name = "installPackageButton";
            this.installPackageButton.Size = new System.Drawing.Size(195, 34);
            this.installPackageButton.TabIndex = 5;
            this.installPackageButton.Text = "Install Package";
            this.installPackageButton.UseVisualStyleBackColor = true;
            this.installPackageButton.Click += new System.EventHandler(this.installPackageButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(249, 165);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(190, 23);
            this.filePathTextBox.TabIndex = 6;
            // 
            // OpenFileDialogButton
            // 
            this.OpenFileDialogButton.Location = new System.Drawing.Point(445, 164);
            this.OpenFileDialogButton.Name = "OpenFileDialogButton";
            this.OpenFileDialogButton.Size = new System.Drawing.Size(26, 23);
            this.OpenFileDialogButton.TabIndex = 7;
            this.OpenFileDialogButton.Text = ".";
            this.OpenFileDialogButton.UseVisualStyleBackColor = true;
            this.OpenFileDialogButton.Click += new System.EventHandler(this.OpenFileDialogButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.log);
            this.Controls.Add(this.OpenFileDialogButton);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.installPackageButton);
            this.Controls.Add(this.changeSandboxTextBox);
            this.Controls.Add(this.changeSandboxButton);
            this.Controls.Add(this.currentSandboxLable);
            this.Controls.Add(this.getCurrentSanboxButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.Text = "GDK-Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox log;
        private Button getCurrentSanboxButton;
        private Label currentSandboxLable;
        private Button changeSandboxButton;
        private TextBox changeSandboxTextBox;
        private Button installPackageButton;
        private OpenFileDialog openFileDialog;
        private TextBox filePathTextBox;
        private Button OpenFileDialogButton;
    }
}