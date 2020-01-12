namespace ShutdownAfterInput.UI
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_10_seconds = new System.Windows.Forms.Button();
            this.button_1_minute = new System.Windows.Forms.Button();
            this.button_5_minute = new System.Windows.Forms.Button();
            this.button_10_minute = new System.Windows.Forms.Button();
            this.button_about = new System.Windows.Forms.Button();
            this.label_version = new System.Windows.Forms.Label();
            this.checkBox_i_understand = new System.Windows.Forms.CheckBox();
            this.label_you_must_check_this_check_box = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOREM IPSUM";
            // 
            // button_10_seconds
            // 
            this.button_10_seconds.Location = new System.Drawing.Point(33, 104);
            this.button_10_seconds.Name = "button_10_seconds";
            this.button_10_seconds.Size = new System.Drawing.Size(75, 23);
            this.button_10_seconds.TabIndex = 1;
            this.button_10_seconds.Text = "10 seconds";
            this.button_10_seconds.UseVisualStyleBackColor = true;
            this.button_10_seconds.Click += new System.EventHandler(this.button_10_seconds_Click);
            // 
            // button_1_minute
            // 
            this.button_1_minute.Location = new System.Drawing.Point(115, 103);
            this.button_1_minute.Name = "button_1_minute";
            this.button_1_minute.Size = new System.Drawing.Size(75, 23);
            this.button_1_minute.TabIndex = 2;
            this.button_1_minute.Text = "1 minute";
            this.button_1_minute.UseVisualStyleBackColor = true;
            this.button_1_minute.Click += new System.EventHandler(this.button_1_minute_Click);
            // 
            // button_5_minute
            // 
            this.button_5_minute.Location = new System.Drawing.Point(197, 102);
            this.button_5_minute.Name = "button_5_minute";
            this.button_5_minute.Size = new System.Drawing.Size(75, 23);
            this.button_5_minute.TabIndex = 3;
            this.button_5_minute.Text = "5 minutes";
            this.button_5_minute.UseVisualStyleBackColor = true;
            this.button_5_minute.Click += new System.EventHandler(this.button_5_minute_Click);
            // 
            // button_10_minute
            // 
            this.button_10_minute.Location = new System.Drawing.Point(279, 103);
            this.button_10_minute.Name = "button_10_minute";
            this.button_10_minute.Size = new System.Drawing.Size(75, 23);
            this.button_10_minute.TabIndex = 4;
            this.button_10_minute.Text = "10 minutes";
            this.button_10_minute.UseVisualStyleBackColor = true;
            this.button_10_minute.Click += new System.EventHandler(this.button_10_minute_Click);
            // 
            // button_about
            // 
            this.button_about.Location = new System.Drawing.Point(361, 103);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(132, 23);
            this.button_about.TabIndex = 5;
            this.button_about.Text = "Instructions and about";
            this.button_about.UseVisualStyleBackColor = true;
            this.button_about.Click += new System.EventHandler(this.button_about_Click_1);
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.Location = new System.Drawing.Point(505, 13);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(30, 13);
            this.label_version.TabIndex = 6;
            this.label_version.Text = "vX.X";
            // 
            // checkBox_i_understand
            // 
            this.checkBox_i_understand.AutoSize = true;
            this.checkBox_i_understand.Location = new System.Drawing.Point(12, 227);
            this.checkBox_i_understand.Name = "checkBox_i_understand";
            this.checkBox_i_understand.Size = new System.Drawing.Size(447, 30);
            this.checkBox_i_understand.TabIndex = 7;
            this.checkBox_i_understand.Text = "I understand what will happen after pressing any of the counter buttons.\r\nFor an " +
    "explanation of what will happen go to Instructions and about - Program Instructi" +
    "ons";
            this.checkBox_i_understand.UseVisualStyleBackColor = true;
            // 
            // label_you_must_check_this_check_box
            // 
            this.label_you_must_check_this_check_box.AutoSize = true;
            this.label_you_must_check_this_check_box.ForeColor = System.Drawing.Color.Red;
            this.label_you_must_check_this_check_box.Location = new System.Drawing.Point(12, 208);
            this.label_you_must_check_this_check_box.Name = "label_you_must_check_this_check_box";
            this.label_you_must_check_this_check_box.Size = new System.Drawing.Size(179, 13);
            this.label_you_must_check_this_check_box.TabIndex = 8;
            this.label_you_must_check_this_check_box.Text = "You must check this box to continue";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 269);
            this.Controls.Add(this.label_you_must_check_this_check_box);
            this.Controls.Add(this.checkBox_i_understand);
            this.Controls.Add(this.label_version);
            this.Controls.Add(this.button_about);
            this.Controls.Add(this.button_10_minute);
            this.Controls.Add(this.button_5_minute);
            this.Controls.Add(this.button_1_minute);
            this.Controls.Add(this.button_10_seconds);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_10_seconds;
        private System.Windows.Forms.Button button_1_minute;
        private System.Windows.Forms.Button button_5_minute;
        private System.Windows.Forms.Button button_10_minute;
        private System.Windows.Forms.Button button_about;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.CheckBox checkBox_i_understand;
        private System.Windows.Forms.Label label_you_must_check_this_check_box;
    }
}