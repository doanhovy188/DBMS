
namespace DBMS {
    partial class Remove_Acc {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Remove_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UserName_Textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Remove_Button
            // 
            this.Remove_Button.Location = new System.Drawing.Point(102, 101);
            this.Remove_Button.Name = "Remove_Button";
            this.Remove_Button.Size = new System.Drawing.Size(75, 23);
            this.Remove_Button.TabIndex = 0;
            this.Remove_Button.Text = "OK";
            this.Remove_Button.UseVisualStyleBackColor = true;
            this.Remove_Button.Click += new System.EventHandler(this.Remove_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập username cần xoá";
            // 
            // UserName_Textbox
            // 
            this.UserName_Textbox.Location = new System.Drawing.Point(50, 58);
            this.UserName_Textbox.Name = "UserName_Textbox";
            this.UserName_Textbox.Size = new System.Drawing.Size(178, 20);
            this.UserName_Textbox.TabIndex = 2;
            // 
            // Remove_Acc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 140);
            this.Controls.Add(this.UserName_Textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Remove_Button);
            this.Name = "Remove_Acc";
            this.Text = "Remove_Acc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Remove_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserName_Textbox;
    }
}