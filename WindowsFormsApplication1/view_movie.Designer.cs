namespace WindowsFormsApplication1
{
    partial class view_movie
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
            this.id = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.director = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.Label();
            this.rate = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.ForeColor = System.Drawing.Color.White;
            this.id.Location = new System.Drawing.Point(187, 36);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(23, 20);
            this.id.TabIndex = 0;
            this.id.Text = "id";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(187, 77);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(39, 20);
            this.title.TabIndex = 1;
            this.title.Text = "title";
            // 
            // director
            // 
            this.director.AutoSize = true;
            this.director.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.director.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.director.ForeColor = System.Drawing.Color.White;
            this.director.Location = new System.Drawing.Point(187, 117);
            this.director.Name = "director";
            this.director.Size = new System.Drawing.Size(70, 20);
            this.director.TabIndex = 2;
            this.director.Text = "director";
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year.ForeColor = System.Drawing.Color.White;
            this.year.Location = new System.Drawing.Point(187, 168);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(43, 20);
            this.year.TabIndex = 3;
            this.year.Text = "year";
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre.ForeColor = System.Drawing.Color.White;
            this.genre.Location = new System.Drawing.Point(187, 208);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(55, 20);
            this.genre.TabIndex = 4;
            this.genre.Text = "genre";
            // 
            // rate
            // 
            this.rate.AutoSize = true;
            this.rate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rate.ForeColor = System.Drawing.Color.White;
            this.rate.Location = new System.Drawing.Point(187, 260);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(41, 20);
            this.rate.TabIndex = 5;
            this.rate.Text = "rate";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Black;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(12, 329);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 30);
            this.back.TabIndex = 6;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(364, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Watch";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // view_movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(451, 364);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.year);
            this.Controls.Add(this.director);
            this.Controls.Add(this.title);
            this.Controls.Add(this.id);
            this.Name = "view_movie";
            this.Text = "view_movie";
            this.Load += new System.EventHandler(this.view_movie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label director;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label genre;
        private System.Windows.Forms.Label rate;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button1;
    }
}