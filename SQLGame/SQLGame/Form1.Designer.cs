
namespace SQLGame
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
            this.components = new System.ComponentModel.Container();
            this.tmrMove = new System.Windows.Forms.Timer(this.components);
            this.tmrAnimate = new System.Windows.Forms.Timer(this.components);
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnUpdateShow = new System.Windows.Forms.Button();
            this.pbGuy = new System.Windows.Forms.PictureBox();
            this.pbRock1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrMove
            // 
            this.tmrMove.Enabled = true;
            this.tmrMove.Tick += new System.EventHandler(this.tmrMove_Tick);
            // 
            // tmrAnimate
            // 
            this.tmrAnimate.Enabled = true;
            this.tmrAnimate.Interval = 333;
            this.tmrAnimate.Tick += new System.EventHandler(this.tmrAnimate_Tick);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(329, 12);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(459, 224);
            this.dgvData.TabIndex = 1;
            // 
            // btnUpdateShow
            // 
            this.btnUpdateShow.Location = new System.Drawing.Point(329, 242);
            this.btnUpdateShow.Name = "btnUpdateShow";
            this.btnUpdateShow.Size = new System.Drawing.Size(459, 41);
            this.btnUpdateShow.TabIndex = 2;
            this.btnUpdateShow.Text = "Update and Show Database";
            this.btnUpdateShow.UseVisualStyleBackColor = true;
            this.btnUpdateShow.Click += new System.EventHandler(this.btnUpdateShow_Click);
            // 
            // pbGuy
            // 
            this.pbGuy.Image = global::SQLGame.Properties.Resources.down2;
            this.pbGuy.Location = new System.Drawing.Point(47, 52);
            this.pbGuy.Name = "pbGuy";
            this.pbGuy.Size = new System.Drawing.Size(53, 67);
            this.pbGuy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGuy.TabIndex = 0;
            this.pbGuy.TabStop = false;
            this.pbGuy.Move += new System.EventHandler(this.pbGuy_Move);
            // 
            // pbRock1
            // 
            this.pbRock1.Image = global::SQLGame.Properties.Resources.LSG_Isarauen_Isarschotter_Nagelfluh_2;
            this.pbRock1.Location = new System.Drawing.Point(12, 388);
            this.pbRock1.Name = "pbRock1";
            this.pbRock1.Size = new System.Drawing.Size(67, 50);
            this.pbRock1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRock1.TabIndex = 3;
            this.pbRock1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SQLGame.Properties.Resources.LSG_Isarauen_Isarschotter_Nagelfluh_2;
            this.pictureBox1.Location = new System.Drawing.Point(176, 313);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SQLGame.Properties.Resources.LSG_Isarauen_Isarschotter_Nagelfluh_2;
            this.pictureBox2.Location = new System.Drawing.Point(349, 374);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SQLGame.Properties.Resources.LSG_Isarauen_Isarschotter_Nagelfluh_2;
            this.pictureBox3.Location = new System.Drawing.Point(202, 108);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(67, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SQLGame.Properties.Resources.LSG_Isarauen_Isarschotter_Nagelfluh_2;
            this.pictureBox4.Location = new System.Drawing.Point(89, 218);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(67, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::SQLGame.Properties.Resources.LSG_Isarauen_Isarschotter_Nagelfluh_2;
            this.pictureBox5.Location = new System.Drawing.Point(599, 322);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(67, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbRock1);
            this.Controls.Add(this.btnUpdateShow);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.pbGuy);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGuy;
        private System.Windows.Forms.Timer tmrMove;
        private System.Windows.Forms.Timer tmrAnimate;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnUpdateShow;
        private System.Windows.Forms.PictureBox pbRock1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

