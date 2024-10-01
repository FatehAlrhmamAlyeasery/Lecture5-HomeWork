namespace lect5_fath_motaher_abdoh_saleh
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
            this.btnfront_of = new System.Windows.Forms.Button();
            this.btnbottom = new System.Windows.Forms.Button();
            this.go_to_front_of = new System.Windows.Forms.Button();
            this.go_to_down = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnfront_of
            // 
            this.btnfront_of.Location = new System.Drawing.Point(13, 13);
            this.btnfront_of.Name = "btnfront_of";
            this.btnfront_of.Size = new System.Drawing.Size(90, 41);
            this.btnfront_of.TabIndex = 0;
            this.btnfront_of.Text = ">";
            this.btnfront_of.UseVisualStyleBackColor = true;
            // 
            // btnbottom
            // 
            this.btnbottom.Location = new System.Drawing.Point(13, 60);
            this.btnbottom.Name = "btnbottom";
            this.btnbottom.Size = new System.Drawing.Size(47, 70);
            this.btnbottom.TabIndex = 1;
            this.btnbottom.Text = "v";
            this.btnbottom.UseVisualStyleBackColor = true;
            // 
            // go_to_front_of
            // 
            this.go_to_front_of.Location = new System.Drawing.Point(384, 327);
            this.go_to_front_of.Name = "go_to_front_of";
            this.go_to_front_of.Size = new System.Drawing.Size(103, 46);
            this.go_to_front_of.TabIndex = 2;
            this.go_to_front_of.Text = "التحرك للامام";
            this.go_to_front_of.UseVisualStyleBackColor = true;
            this.go_to_front_of.Click += new System.EventHandler(this.go_to_front_of_Click);
            // 
            // go_to_down
            // 
            this.go_to_down.Location = new System.Drawing.Point(176, 327);
            this.go_to_down.Name = "go_to_down";
            this.go_to_down.Size = new System.Drawing.Size(98, 46);
            this.go_to_down.TabIndex = 3;
            this.go_to_down.Text = "التحرك للأسفل";
            this.go_to_down.UseVisualStyleBackColor = true;
            this.go_to_down.Click += new System.EventHandler(this.go_to_down_Click);
            // 
            // btnstop
            // 
            this.btnstop.Location = new System.Drawing.Point(280, 327);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(98, 46);
            this.btnstop.TabIndex = 4;
            this.btnstop.Text = "stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnclose.Location = new System.Drawing.Point(95, 327);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 46);
            this.btnclose.TabIndex = 5;
            this.btnclose.Text = "إغلاق";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 385);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.go_to_down);
            this.Controls.Add(this.go_to_front_of);
            this.Controls.Add(this.btnbottom);
            this.Controls.Add(this.btnfront_of);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnfront_of;
        private System.Windows.Forms.Button btnbottom;
        private System.Windows.Forms.Button go_to_front_of;
        private System.Windows.Forms.Button go_to_down;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Button btnclose;
    }
}

