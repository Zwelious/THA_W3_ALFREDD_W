namespace THA_W3_Alfredd_W
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
            this.next_btn = new System.Windows.Forms.Button();
            this.name_lbl = new System.Windows.Forms.Label();
            this.name_text = new System.Windows.Forms.TextBox();
            this.artist_text = new System.Windows.Forms.TextBox();
            this.artist_lbl = new System.Windows.Forms.Label();
            this.true_check = new System.Windows.Forms.CheckBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // next_btn
            // 
            this.next_btn.Location = new System.Drawing.Point(106, 257);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(136, 31);
            this.next_btn.TabIndex = 0;
            this.next_btn.Text = "Open Next Form";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(103, 91);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(44, 16);
            this.name_lbl.TabIndex = 1;
            this.name_lbl.Text = "Name";
            // 
            // name_text
            // 
            this.name_text.Location = new System.Drawing.Point(232, 88);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(173, 22);
            this.name_text.TabIndex = 2;
            this.name_text.TextChanged += new System.EventHandler(this.name_text_TextChanged);
            // 
            // artist_text
            // 
            this.artist_text.Location = new System.Drawing.Point(232, 124);
            this.artist_text.Name = "artist_text";
            this.artist_text.Size = new System.Drawing.Size(173, 22);
            this.artist_text.TabIndex = 3;
            this.artist_text.TextChanged += new System.EventHandler(this.artist_text_TextChanged);
            // 
            // artist_lbl
            // 
            this.artist_lbl.AutoSize = true;
            this.artist_lbl.Location = new System.Drawing.Point(103, 130);
            this.artist_lbl.Name = "artist_lbl";
            this.artist_lbl.Size = new System.Drawing.Size(109, 16);
            this.artist_lbl.TabIndex = 4;
            this.artist_lbl.Text = "My Favorite Artist";
            // 
            // true_check
            // 
            this.true_check.AutoSize = true;
            this.true_check.Location = new System.Drawing.Point(106, 176);
            this.true_check.Name = "true_check";
            this.true_check.Size = new System.Drawing.Size(221, 20);
            this.true_check.TabIndex = 5;
            this.true_check.Text = "All the content I put above is true!";
            this.true_check.UseVisualStyleBackColor = true;
            this.true_check.CheckedChanged += new System.EventHandler(this.true_check_CheckedChanged);
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(106, 215);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(75, 23);
            this.submit_btn.TabIndex = 6;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.true_check);
            this.Controls.Add(this.artist_lbl);
            this.Controls.Add(this.artist_text);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.next_btn);
            this.Name = "Form1";
            this.Text = "Main Window Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.TextBox artist_text;
        private System.Windows.Forms.Label artist_lbl;
        private System.Windows.Forms.CheckBox true_check;
        private System.Windows.Forms.Button submit_btn;
    }
}

