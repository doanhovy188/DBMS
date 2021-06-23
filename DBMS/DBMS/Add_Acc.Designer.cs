
namespace DBMS {
    partial class Add_Acc {
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
            this.userName_Textbox = new System.Windows.Forms.TextBox();
            this.passWord_Textbox = new System.Windows.Forms.TextBox();
            this.Add_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userName_Textbox
            // 
            this.userName_Textbox.Location = new System.Drawing.Point(85, 57);
            this.userName_Textbox.Name = "userName_Textbox";
            this.userName_Textbox.Size = new System.Drawing.Size(218, 20);
            this.userName_Textbox.TabIndex = 0;
            // 
            // passWord_Textbox
            // 
            this.passWord_Textbox.Location = new System.Drawing.Point(85, 101);
            this.passWord_Textbox.Name = "passWord_Textbox";
            this.passWord_Textbox.Size = new System.Drawing.Size(218, 20);
            this.passWord_Textbox.TabIndex = 1;
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(129, 148);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(75, 23);
            this.Add_button.TabIndex = 2;
            this.Add_button.Text = "Ok";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PassWord";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thêm Tài khoản mới";
            // 
            // Add_Acc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 193);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.passWord_Textbox);
            this.Controls.Add(this.userName_Textbox);
            this.Name = "Add_Acc";
            this.Text = "Add_Acc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userName_Textbox;
        private System.Windows.Forms.TextBox passWord_Textbox;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}