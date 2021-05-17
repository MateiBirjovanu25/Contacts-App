using System;

namespace WindowsFormsApp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_nume = new System.Windows.Forms.TextBox();
            this.txt_nume2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dtv_grid = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_numar = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nrtel = new System.Windows.Forms.TextBox();
            this.cmb_gen = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dialog = new System.Windows.Forms.ColorDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nume
            // 
            this.txt_nume.BackColor = System.Drawing.Color.RoyalBlue;
            this.txt_nume.Location = new System.Drawing.Point(188, 68);
            this.txt_nume.Name = "txt_nume";
            this.txt_nume.Size = new System.Drawing.Size(243, 22);
            this.txt_nume.TabIndex = 0;
            // 
            // txt_nume2
            // 
            this.txt_nume2.BackColor = System.Drawing.Color.RoyalBlue;
            this.txt_nume2.Location = new System.Drawing.Point(188, 114);
            this.txt_nume2.Name = "txt_nume2";
            this.txt_nume2.Size = new System.Drawing.Size(243, 22);
            this.txt_nume2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(188, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 59);
            this.button2.TabIndex = 2;
            this.button2.Text = "add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtv_grid
            // 
            this.dtv_grid.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dtv_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_grid.GridColor = System.Drawing.Color.DarkSalmon;
            this.dtv_grid.Location = new System.Drawing.Point(509, 260);
            this.dtv_grid.Name = "dtv_grid";
            this.dtv_grid.ReadOnly = true;
            this.dtv_grid.RowHeadersWidth = 51;
            this.dtv_grid.RowTemplate.Height = 24;
            this.dtv_grid.Size = new System.Drawing.Size(539, 370);
            this.dtv_grid.TabIndex = 3;
            this.dtv_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_grid_CellContentClick);
            this.dtv_grid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtv_grid_RowHeaderMouseClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Cyan;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(188, 393);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 55);
            this.button4.TabIndex = 5;
            this.button4.Text = "clear";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1094, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(188, 483);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 54);
            this.button3.TabIndex = 7;
            this.button3.Text = "update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_numar
            // 
            this.txt_numar.BackColor = System.Drawing.Color.RoyalBlue;
            this.txt_numar.Location = new System.Drawing.Point(188, 24);
            this.txt_numar.Name = "txt_numar";
            this.txt_numar.ReadOnly = true;
            this.txt_numar.Size = new System.Drawing.Size(243, 22);
            this.txt_numar.TabIndex = 8;
            this.txt_numar.TextChanged += new System.EventHandler(this.txt_numar_TextChanged);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Crimson;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(188, 562);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 54);
            this.button5.TabIndex = 9;
            this.button5.Text = "delete";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txt_search.ForeColor = System.Drawing.Color.Violet;
            this.txt_search.Location = new System.Drawing.Point(602, 206);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(446, 22);
            this.txt_search.TabIndex = 10;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(509, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "SEARCH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(148, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(57, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "FIRST NAME";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(63, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "LAST NAME";
            // 
            // txt_nrtel
            // 
            this.txt_nrtel.BackColor = System.Drawing.Color.RoyalBlue;
            this.txt_nrtel.Location = new System.Drawing.Point(188, 160);
            this.txt_nrtel.Name = "txt_nrtel";
            this.txt_nrtel.Size = new System.Drawing.Size(243, 22);
            this.txt_nrtel.TabIndex = 15;
            // 
            // cmb_gen
            // 
            this.cmb_gen.BackColor = System.Drawing.Color.RoyalBlue;
            this.cmb_gen.DisplayMember = "MALE";
            this.cmb_gen.FormattingEnabled = true;
            this.cmb_gen.Items.AddRange(new object[] {
            "MALE",
            "FEMALE",
            "OTHER"});
            this.cmb_gen.Location = new System.Drawing.Point(188, 202);
            this.cmb_gen.Name = "cmb_gen";
            this.cmb_gen.Size = new System.Drawing.Size(243, 24);
            this.cmb_gen.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(17, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "PHONE NUMBER";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(89, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "GENDER";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(459, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1162, 654);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_gen);
            this.Controls.Add(this.txt_nrtel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txt_numar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dtv_grid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_nume2);
            this.Controls.Add(this.txt_nume);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.TextBox nume;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nume2;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TextBox txt_nume;
        private System.Windows.Forms.TextBox txt_nume2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dtv_grid;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_numar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nrtel;
        private System.Windows.Forms.ComboBox cmb_gen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColorDialog dialog;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

