namespace Flappy
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_Ground = new System.Windows.Forms.PictureBox();
            this.pictureBox_Bottom = new System.Windows.Forms.PictureBox();
            this.pictureBox_Bird = new System.Windows.Forms.PictureBox();
            this.picturebox_top = new System.Windows.Forms.PictureBox();
            this.timer_GameControl = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_top)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "SCORE:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox_Ground
            // 
            this.pictureBox_Ground.Image = global::Flappy.Properties.Resources.ground;
            this.pictureBox_Ground.Location = new System.Drawing.Point(-5, 830);
            this.pictureBox_Ground.Name = "pictureBox_Ground";
            this.pictureBox_Ground.Size = new System.Drawing.Size(1296, 136);
            this.pictureBox_Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Ground.TabIndex = 4;
            this.pictureBox_Ground.TabStop = false;
            // 
            // pictureBox_Bottom
            // 
            this.pictureBox_Bottom.Image = global::Flappy.Properties.Resources.pipe;
            this.pictureBox_Bottom.Location = new System.Drawing.Point(659, 575);
            this.pictureBox_Bottom.Name = "pictureBox_Bottom";
            this.pictureBox_Bottom.Size = new System.Drawing.Size(127, 257);
            this.pictureBox_Bottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Bottom.TabIndex = 3;
            this.pictureBox_Bottom.TabStop = false;
            // 
            // pictureBox_Bird
            // 
            this.pictureBox_Bird.Image = global::Flappy.Properties.Resources.bird;
            this.pictureBox_Bird.Location = new System.Drawing.Point(129, 394);
            this.pictureBox_Bird.Name = "pictureBox_Bird";
            this.pictureBox_Bird.Size = new System.Drawing.Size(100, 76);
            this.pictureBox_Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Bird.TabIndex = 2;
            this.pictureBox_Bird.TabStop = false;
            // 
            // picturebox_top
            // 
            this.picturebox_top.Image = global::Flappy.Properties.Resources.pipedown;
            this.picturebox_top.Location = new System.Drawing.Point(983, -5);
            this.picturebox_top.Name = "picturebox_top";
            this.picturebox_top.Size = new System.Drawing.Size(123, 264);
            this.picturebox_top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox_top.TabIndex = 1;
            this.picturebox_top.TabStop = false;
            // 
            // timer_GameControl
            // 
            this.timer_GameControl.Enabled = true;
            this.timer_GameControl.Interval = 20;
            this.timer_GameControl.Tick += new System.EventHandler(this.gameTimer);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 966);
            this.Controls.Add(this.pictureBox_Ground);
            this.Controls.Add(this.pictureBox_Bottom);
            this.Controls.Add(this.pictureBox_Bird);
            this.Controls.Add(this.picturebox_top);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.game_Down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.game_Up);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_top)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picturebox_top;
        private System.Windows.Forms.PictureBox pictureBox_Bird;
        private System.Windows.Forms.PictureBox pictureBox_Bottom;
        private System.Windows.Forms.PictureBox pictureBox_Ground;
        private System.Windows.Forms.Timer timer_GameControl;
    }
}

