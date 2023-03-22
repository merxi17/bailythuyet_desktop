
namespace bailythuyet
{
    partial class Form4
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
            this.Lbdanhsach = new System.Windows.Forms.ListBox();
            this.Lbdanhsachchon = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbdanhsach
            // 
            this.Lbdanhsach.ForeColor = System.Drawing.Color.Blue;
            this.Lbdanhsach.FormattingEnabled = true;
            this.Lbdanhsach.ItemHeight = 20;
            this.Lbdanhsach.Items.AddRange(new object[] {
            "s",
            "đá",
            "sfasd",
            "sadasd",
            "vdsvgr",
            "dsfwrio",
            "gegsdhgiyd",
            "iowrghjh",
            "fishflskdc",
            "ìóidfhckmsd"});
            this.Lbdanhsach.Location = new System.Drawing.Point(30, 97);
            this.Lbdanhsach.Name = "Lbdanhsach";
            this.Lbdanhsach.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.Lbdanhsach.Size = new System.Drawing.Size(266, 304);
            this.Lbdanhsach.TabIndex = 0;
            // 
            // Lbdanhsachchon
            // 
            this.Lbdanhsachchon.ForeColor = System.Drawing.Color.Magenta;
            this.Lbdanhsachchon.FormattingEnabled = true;
            this.Lbdanhsachchon.ItemHeight = 20;
            this.Lbdanhsachchon.Location = new System.Drawing.Point(498, 97);
            this.Lbdanhsachchon.Name = "Lbdanhsachchon";
            this.Lbdanhsachchon.Size = new System.Drawing.Size(243, 304);
            this.Lbdanhsachchon.TabIndex = 1;
            this.Lbdanhsachchon.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(26, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách sinh viên lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(494, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh sách tham gia bóng đá";
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(353, 151);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(85, 39);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "Chọn";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(353, 238);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 36);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbdanhsachchon);
            this.Controls.Add(this.Lbdanhsach);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lbdanhsach;
        private System.Windows.Forms.ListBox Lbdanhsachchon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnXoa;
    }
}