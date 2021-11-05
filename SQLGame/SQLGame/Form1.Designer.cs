
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuy)).BeginInit();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGuy;
        private System.Windows.Forms.Timer tmrMove;
        private System.Windows.Forms.Timer tmrAnimate;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnUpdateShow;
    }
}

