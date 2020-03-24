namespace WindowsFormsApplication1
{
    partial class RemoveOrUpdate
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
            this.update_btn = new System.Windows.Forms.Button();
            this.REM_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.Black;
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.Color.Blue;
            this.update_btn.Location = new System.Drawing.Point(400, 36);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(206, 55);
            this.update_btn.TabIndex = 3;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // REM_btn
            // 
            this.REM_btn.BackColor = System.Drawing.Color.Black;
            this.REM_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REM_btn.ForeColor = System.Drawing.Color.Blue;
            this.REM_btn.Location = new System.Drawing.Point(136, 36);
            this.REM_btn.Name = "REM_btn";
            this.REM_btn.Size = new System.Drawing.Size(206, 55);
            this.REM_btn.TabIndex = 2;
            this.REM_btn.Text = "Remove";
            this.REM_btn.UseVisualStyleBackColor = false;
            this.REM_btn.Click += new System.EventHandler(this.REM_btn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(12, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RemoveOrUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.pixar__15_years_later_by_blast196x;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(773, 355);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.REM_btn);
            this.Name = "RemoveOrUpdate";
            this.Text = "RemoveOrUpdate";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button REM_btn;
        private System.Windows.Forms.Button button2;
    }
}