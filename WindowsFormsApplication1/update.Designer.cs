namespace WindowsFormsApplication1
{
    partial class update
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.title = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.director = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.genre = new System.Windows.Forms.TextBox();
            this.rating = new System.Windows.Forms.TextBox();
            this.poster = new System.Windows.Forms.TextBox();
            this.titl = new System.Windows.Forms.TextBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.done = new System.Windows.Forms.Button();
            this.choose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(388, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Movie title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(126, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Choose file";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboBox3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(240, 20);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 27;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(495, 21);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(121, 20);
            this.title.TabIndex = 26;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(39, 65);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(121, 20);
            this.id.TabIndex = 30;
            // 
            // director
            // 
            this.director.Location = new System.Drawing.Point(39, 139);
            this.director.Name = "director";
            this.director.Size = new System.Drawing.Size(121, 20);
            this.director.TabIndex = 32;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(39, 169);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(121, 20);
            this.year.TabIndex = 33;
            // 
            // genre
            // 
            this.genre.Location = new System.Drawing.Point(39, 205);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(121, 20);
            this.genre.TabIndex = 34;
            // 
            // rating
            // 
            this.rating.Location = new System.Drawing.Point(39, 247);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(121, 20);
            this.rating.TabIndex = 35;
            // 
            // poster
            // 
            this.poster.Location = new System.Drawing.Point(39, 288);
            this.poster.Name = "poster";
            this.poster.Size = new System.Drawing.Size(121, 20);
            this.poster.TabIndex = 36;
            // 
            // titl
            // 
            this.titl.Location = new System.Drawing.Point(39, 103);
            this.titl.Name = "titl";
            this.titl.Size = new System.Drawing.Size(121, 20);
            this.titl.TabIndex = 37;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.DarkGray;
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(511, 335);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 33);
            this.back_btn.TabIndex = 39;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // done
            // 
            this.done.BackColor = System.Drawing.Color.DarkGray;
            this.done.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.done.Location = new System.Drawing.Point(602, 335);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(75, 33);
            this.done.TabIndex = 38;
            this.done.Text = "Get";
            this.done.UseVisualStyleBackColor = false;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // choose
            // 
            this.choose.BackColor = System.Drawing.Color.DarkGray;
            this.choose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choose.Location = new System.Drawing.Point(85, 314);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(75, 33);
            this.choose.TabIndex = 41;
            this.choose.Text = "Choose";
            this.choose.UseVisualStyleBackColor = false;
            this.choose.Click += new System.EventHandler(this.choose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(224, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.EXAQrN;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(723, 370);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.choose);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.done);
            this.Controls.Add(this.titl);
            this.Controls.Add(this.poster);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.year);
            this.Controls.Add(this.director);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.title);
            this.Name = "update";
            this.Text = "update";
            this.Load += new System.EventHandler(this.update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox director;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.TextBox genre;
        private System.Windows.Forms.TextBox rating;
        private System.Windows.Forms.TextBox poster;
        private System.Windows.Forms.TextBox titl;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.Button choose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}