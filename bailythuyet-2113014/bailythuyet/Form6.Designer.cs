
namespace bailythuyet
{
    partial class Form6
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chkMauchu = new System.Windows.Forms.CheckBox();
            this.chkMaunen = new System.Windows.Forms.CheckBox();
            this.rdflat = new System.Windows.Forms.RadioButton();
            this.rdpopup = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aquamarine;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(79, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Button";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(79, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Button Flat";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // chkMauchu
            // 
            this.chkMauchu.AutoSize = true;
            this.chkMauchu.Location = new System.Drawing.Point(354, 68);
            this.chkMauchu.Name = "chkMauchu";
            this.chkMauchu.Size = new System.Drawing.Size(159, 24);
            this.chkMauchu.TabIndex = 2;
            this.chkMauchu.Text = "Thay đổi màu chữ";
            this.chkMauchu.UseVisualStyleBackColor = true;
            this.chkMauchu.CheckedChanged += new System.EventHandler(this.chkMauchu_CheckedChanged);
            // 
            // chkMaunen
            // 
            this.chkMaunen.AutoSize = true;
            this.chkMaunen.Location = new System.Drawing.Point(354, 111);
            this.chkMaunen.Name = "chkMaunen";
            this.chkMaunen.Size = new System.Drawing.Size(160, 24);
            this.chkMaunen.TabIndex = 3;
            this.chkMaunen.Text = "Thay đổi màu nền";
            this.chkMaunen.UseVisualStyleBackColor = true;
            this.chkMaunen.CheckedChanged += new System.EventHandler(this.chkMaunen_CheckedChanged);
            // 
            // rdflat
            // 
            this.rdflat.AutoSize = true;
            this.rdflat.Location = new System.Drawing.Point(354, 185);
            this.rdflat.Name = "rdflat";
            this.rdflat.Size = new System.Drawing.Size(96, 24);
            this.rdflat.TabIndex = 4;
            this.rdflat.TabStop = true;
            this.rdflat.Text = "Kiểu Flat";
            this.rdflat.UseVisualStyleBackColor = true;
            this.rdflat.CheckedChanged += new System.EventHandler(this.rdflat_CheckedChanged);
            // 
            // rdpopup
            // 
            this.rdpopup.AutoSize = true;
            this.rdpopup.Location = new System.Drawing.Point(354, 228);
            this.rdpopup.Name = "rdpopup";
            this.rdpopup.Size = new System.Drawing.Size(115, 24);
            this.rdpopup.TabIndex = 5;
            this.rdpopup.TabStop = true;
            this.rdpopup.Text = "Kiểu Popup";
            this.rdpopup.UseVisualStyleBackColor = true;
            this.rdpopup.CheckedChanged += new System.EventHandler(this.rdpopup_CheckedChanged);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 357);
            this.Controls.Add(this.rdpopup);
            this.Controls.Add(this.rdflat);
            this.Controls.Add(this.chkMaunen);
            this.Controls.Add(this.chkMauchu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form6";
            this.Text = "Buttons";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox chkMauchu;
        private System.Windows.Forms.CheckBox chkMaunen;
        private System.Windows.Forms.RadioButton rdflat;
        private System.Windows.Forms.RadioButton rdpopup;
    }
}