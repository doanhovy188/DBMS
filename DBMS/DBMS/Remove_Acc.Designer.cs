
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
            this.Remove_Button.Location = new System.Drawing.Point(170, 179);
            this.Remove_Button.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Remove_Button.Name = "Remove_Button";
            this.Remove_Button.Size = new System.Drawing.Size(125, 41);
            this.Remove_Button.TabIndex = 0;
            this.Remove_Button.Text = "OK";
            this.Remove_Button.UseVisualStyleBackColor = true;
            this.Remove_Button.Click += new System.EventHandler(this.Remove_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập username cần xoá";
            // 
            // UserName_Textbox
            // 
            this.UserName_Textbox.Location = new System.Drawing.Point(83, 103);
            this.UserName_Textbox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.UserName_Textbox.Name = "UserName_Textbox";
            this.UserName_Textbox.Size = new System.Drawing.Size(294, 30);
            this.UserName_Textbox.TabIndex = 2;
            // 
            // Remove_Acc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 248);
            this.Controls.Add(this.UserName_Textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Remove_Button);
            this.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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