
namespace FilmLibrary
{
    partial class MovieManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieManager));
            this.button5 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Button();
            this.Uploads = new System.Windows.Forms.Button();
            this.Movies = new System.Windows.Forms.Button();
            this.dashboard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Form2 = new System.Windows.Forms.DataGridView();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Form2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Maroon;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button5.Location = new System.Drawing.Point(584, 75);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(356, 49);
            this.button5.TabIndex = 24;
            this.button5.Text = "Downloads";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.pictureBox11);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.Logout);
            this.panel5.Controls.Add(this.Uploads);
            this.panel5.Controls.Add(this.Movies);
            this.panel5.Controls.Add(this.dashboard);
            this.panel5.Location = new System.Drawing.Point(-1, 69);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(201, 414);
            this.panel5.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.label8.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(45, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Copyright2021-22";
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Logout.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.White;
            this.Logout.Location = new System.Drawing.Point(0, 293);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(201, 46);
            this.Logout.TabIndex = 1;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = false;
            // 
            // Uploads
            // 
            this.Uploads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.Uploads.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Uploads.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uploads.ForeColor = System.Drawing.Color.White;
            this.Uploads.Location = new System.Drawing.Point(0, 248);
            this.Uploads.Name = "Uploads";
            this.Uploads.Size = new System.Drawing.Size(201, 47);
            this.Uploads.TabIndex = 1;
            this.Uploads.Text = "Upload Movies";
            this.Uploads.UseVisualStyleBackColor = false;
            this.Uploads.Click += new System.EventHandler(this.Movies_Click);
            this.Uploads.Enter += new System.EventHandler(this.Uploads_Enter);
            this.Uploads.Leave += new System.EventHandler(this.Uploads_Leave);
            // 
            // Movies
            // 
            this.Movies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.Movies.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Movies.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Movies.ForeColor = System.Drawing.Color.White;
            this.Movies.Location = new System.Drawing.Point(0, 200);
            this.Movies.Name = "Movies";
            this.Movies.Size = new System.Drawing.Size(201, 51);
            this.Movies.TabIndex = 1;
            this.Movies.Text = "Movie Manager";
            this.Movies.UseVisualStyleBackColor = false;
            this.Movies.Enter += new System.EventHandler(this.Movies_Enter);
            this.Movies.Leave += new System.EventHandler(this.Movies_Leave);
            // 
            // dashboard
            // 
            this.dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dashboard.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.ForeColor = System.Drawing.Color.White;
            this.dashboard.Location = new System.Drawing.Point(0, 156);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(201, 49);
            this.dashboard.TabIndex = 1;
            this.dashboard.Text = "Dashboard";
            this.dashboard.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 73);
            this.panel1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(128, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "User";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.Location = new System.Drawing.Point(209, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(369, 49);
            this.button1.TabIndex = 24;
            this.button1.Text = "Uploads";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.Form2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Form2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Form2.Location = new System.Drawing.Point(209, 132);
            this.Form2.Name = "Form2";
            this.Form2.Size = new System.Drawing.Size(731, 335);
            this.Form2.TabIndex = 25;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox11.BackgroundImage")));
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox11.Image = global::FilmLibrary.Properties.Resources.Copyright_icon;
            this.pictureBox11.Location = new System.Drawing.Point(17, 379);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(22, 22);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 38;
            this.pictureBox11.TabStop = false;
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel9.BackgroundImage")));
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Location = new System.Drawing.Point(0, 211);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(39, 30);
            this.panel9.TabIndex = 8;
            // 
            // panel10
            // 
            this.panel10.BackgroundImage = global::FilmLibrary.Properties.Resources.Logout_Logo;
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel10.Location = new System.Drawing.Point(0, 301);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(39, 31);
            this.panel10.TabIndex = 7;
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = global::FilmLibrary.Properties.Resources.Upload_Logo;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Location = new System.Drawing.Point(0, 257);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(39, 31);
            this.panel8.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::FilmLibrary.Properties.Resources.Dashboard_Logo;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Location = new System.Drawing.Point(0, 163);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(39, 31);
            this.panel7.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.BackgroundImage = global::FilmLibrary.Properties.Resources.Exit;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(901, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(29, 29);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::FilmLibrary.Properties.Resources.Admin_Logo;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(12, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(97, 75);
            this.panel3.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(65, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 20);
            this.label13.TabIndex = 40;
            this.label13.Text = "FilmoTech";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::FilmLibrary.Properties.Resources.Logo1;
            this.pictureBox2.Location = new System.Drawing.Point(18, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(170, 132);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // MovieManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 479);
            this.Controls.Add(this.Form2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Name = "MovieManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovieManager";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Form2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Form2;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button Uploads;
        private System.Windows.Forms.Button Movies;
        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}