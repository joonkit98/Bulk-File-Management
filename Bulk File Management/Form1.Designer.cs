namespace Bulk_File_Management
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btn_OpenFile = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_Process = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioAppendFolder = new System.Windows.Forms.RadioButton();
            this.radioRemoveSpeChar = new System.Windows.Forms.RadioButton();
            this.radioRemoveDoubleSpace = new System.Windows.Forms.RadioButton();
            this.radioRemoveMatch = new System.Windows.Forms.RadioButton();
            this.radioRemove = new System.Windows.Forms.RadioButton();
            this.radioChange = new System.Windows.Forms.RadioButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.contextOpenFile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.contextOpenFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Multiselect = true;
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(267, 20);
            this.textBox1.TabIndex = 0;
            // 
            // Btn_OpenFile
            // 
            this.Btn_OpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_OpenFile.Location = new System.Drawing.Point(285, 11);
            this.Btn_OpenFile.Name = "Btn_OpenFile";
            this.Btn_OpenFile.Size = new System.Drawing.Size(75, 23);
            this.Btn_OpenFile.TabIndex = 1;
            this.Btn_OpenFile.Text = "Open";
            this.Btn_OpenFile.UseVisualStyleBackColor = true;
            this.Btn_OpenFile.UseWaitCursor = true;
            this.Btn_OpenFile.Click += new System.EventHandler(this.Btn_OpenFile_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(12, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(143, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // btn_Process
            // 
            this.btn_Process.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Process.Enabled = false;
            this.btn_Process.Location = new System.Drawing.Point(161, 54);
            this.btn_Process.Name = "btn_Process";
            this.btn_Process.Size = new System.Drawing.Size(75, 23);
            this.btn_Process.TabIndex = 3;
            this.btn_Process.Text = "Process";
            this.btn_Process.UseVisualStyleBackColor = true;
            this.btn_Process.Click += new System.EventHandler(this.btn_Process_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioAppendFolder);
            this.groupBox1.Controls.Add(this.radioRemoveSpeChar);
            this.groupBox1.Controls.Add(this.radioRemoveDoubleSpace);
            this.groupBox1.Controls.Add(this.radioRemoveMatch);
            this.groupBox1.Controls.Add(this.radioRemove);
            this.groupBox1.Controls.Add(this.radioChange);
            this.groupBox1.Location = new System.Drawing.Point(12, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 96);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Function";
            // 
            // radioAppendFolder
            // 
            this.radioAppendFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioAppendFolder.AutoSize = true;
            this.radioAppendFolder.Location = new System.Drawing.Point(183, 65);
            this.radioAppendFolder.Name = "radioAppendFolder";
            this.radioAppendFolder.Size = new System.Drawing.Size(120, 17);
            this.radioAppendFolder.TabIndex = 5;
            this.radioAppendFolder.TabStop = true;
            this.radioAppendFolder.Text = "Append folder name";
            this.radioAppendFolder.UseVisualStyleBackColor = true;
            this.radioAppendFolder.CheckedChanged += new System.EventHandler(this.radioChange_CheckedChanged);
            // 
            // radioRemoveSpeChar
            // 
            this.radioRemoveSpeChar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioRemoveSpeChar.AutoSize = true;
            this.radioRemoveSpeChar.Location = new System.Drawing.Point(182, 42);
            this.radioRemoveSpeChar.Name = "radioRemoveSpeChar";
            this.radioRemoveSpeChar.Size = new System.Drawing.Size(160, 17);
            this.radioRemoveSpeChar.TabIndex = 4;
            this.radioRemoveSpeChar.TabStop = true;
            this.radioRemoveSpeChar.Text = "Remove Specific Characters";
            this.radioRemoveSpeChar.UseVisualStyleBackColor = true;
            this.radioRemoveSpeChar.CheckedChanged += new System.EventHandler(this.radioChange_CheckedChanged);
            // 
            // radioRemoveDoubleSpace
            // 
            this.radioRemoveDoubleSpace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.radioRemoveDoubleSpace.AutoSize = true;
            this.radioRemoveDoubleSpace.Location = new System.Drawing.Point(182, 19);
            this.radioRemoveDoubleSpace.Name = "radioRemoveDoubleSpace";
            this.radioRemoveDoubleSpace.Size = new System.Drawing.Size(132, 17);
            this.radioRemoveDoubleSpace.TabIndex = 3;
            this.radioRemoveDoubleSpace.TabStop = true;
            this.radioRemoveDoubleSpace.Text = "Remove double space";
            this.radioRemoveDoubleSpace.UseVisualStyleBackColor = true;
            this.radioRemoveDoubleSpace.CheckedChanged += new System.EventHandler(this.radioChange_CheckedChanged);
            // 
            // radioRemoveMatch
            // 
            this.radioRemoveMatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.radioRemoveMatch.AutoSize = true;
            this.radioRemoveMatch.Location = new System.Drawing.Point(6, 65);
            this.radioRemoveMatch.Name = "radioRemoveMatch";
            this.radioRemoveMatch.Size = new System.Drawing.Size(140, 17);
            this.radioRemoveMatch.TabIndex = 2;
            this.radioRemoveMatch.TabStop = true;
            this.radioRemoveMatch.Text = "Remove Matching string";
            this.radioRemoveMatch.UseVisualStyleBackColor = true;
            this.radioRemoveMatch.CheckedChanged += new System.EventHandler(this.radioChange_CheckedChanged);
            // 
            // radioRemove
            // 
            this.radioRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.radioRemove.AutoSize = true;
            this.radioRemove.Location = new System.Drawing.Point(6, 42);
            this.radioRemove.Name = "radioRemove";
            this.radioRemove.Size = new System.Drawing.Size(127, 17);
            this.radioRemove.TabIndex = 1;
            this.radioRemove.TabStop = true;
            this.radioRemove.Text = "Remove n characters";
            this.radioRemove.UseVisualStyleBackColor = true;
            this.radioRemove.CheckedChanged += new System.EventHandler(this.radioChange_CheckedChanged);
            // 
            // radioChange
            // 
            this.radioChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.radioChange.AutoSize = true;
            this.radioChange.Location = new System.Drawing.Point(6, 19);
            this.radioChange.Name = "radioChange";
            this.radioChange.Size = new System.Drawing.Size(110, 17);
            this.radioChange.TabIndex = 0;
            this.radioChange.TabStop = true;
            this.radioChange.Text = "Change extension";
            this.radioChange.UseVisualStyleBackColor = true;
            this.radioChange.CheckedChanged += new System.EventHandler(this.radioChange_CheckedChanged);
            // 
            // contextOpenFile
            // 
            this.contextOpenFile.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.contextOpenFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFile,
            this.toolStripFolder});
            this.contextOpenFile.Name = "contextOpenFile";
            this.contextOpenFile.Size = new System.Drawing.Size(181, 70);
            // 
            // toolStripFile
            // 
            this.toolStripFile.Name = "toolStripFile";
            this.toolStripFile.Size = new System.Drawing.Size(180, 22);
            this.toolStripFile.Text = "File";
            this.toolStripFile.Click += new System.EventHandler(this.toolStripFile_Click);
            // 
            // toolStripFolder
            // 
            this.toolStripFolder.Name = "toolStripFolder";
            this.toolStripFolder.Size = new System.Drawing.Size(180, 22);
            this.toolStripFolder.Text = "Folder";
            this.toolStripFolder.Click += new System.EventHandler(this.toolStripFolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(375, 201);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Process);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Btn_OpenFile);
            this.Controls.Add(this.textBox1);
            this.MaximumSize = new System.Drawing.Size(500, 300);
            this.MinimumSize = new System.Drawing.Size(391, 240);
            this.Name = "Form1";
            this.Text = "Bulk File Management";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextOpenFile.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Btn_OpenFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_Process;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioAppendFolder;
        private System.Windows.Forms.RadioButton radioRemoveSpeChar;
        private System.Windows.Forms.RadioButton radioRemoveDoubleSpace;
        private System.Windows.Forms.RadioButton radioRemoveMatch;
        private System.Windows.Forms.RadioButton radioRemove;
        private System.Windows.Forms.RadioButton radioChange;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ContextMenuStrip contextOpenFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripFolder;
    }
}

