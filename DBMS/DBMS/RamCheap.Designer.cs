
namespace DBMS {
    partial class RamCheap {
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
            this.Ram_Textbox = new System.Windows.Forms.TextBox();
            this.OK_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ram_Textbox
            // 
            this.Ram_Textbox.Location = new System.Drawing.Point(107, 106);
            this.Ram_Textbox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Ram_Textbox.Name = "Ram_Textbox";
            this.Ram_Textbox.Size = new System.Drawing.Size(291, 30);
            this.Ram_Textbox.TabIndex = 0;
            // 
            // OK_Button
            // 
            this.OK_Button.Location = new System.Drawing.Point(183, 175);
            this.OK_Button.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(125, 41);
            this.OK_Button.TabIndex = 1;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(158, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm Ram Mong Muốn";
            // 
            // RamCheap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 248);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.Ram_Textbox);
            this.Font = new System.Drawing.Font("Calibri", 14F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "RamCheap";
            this.Text = "RamCheap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Ram_Textbox;
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.Label label1;
    }
}