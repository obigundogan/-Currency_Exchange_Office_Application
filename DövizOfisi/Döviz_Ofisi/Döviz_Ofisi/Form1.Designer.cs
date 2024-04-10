
namespace Döviz_Ofisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lbldolaralis = new System.Windows.Forms.Label();
            this.lbldolarsatıs = new System.Windows.Forms.Label();
            this.lbleurosatıs = new System.Windows.Forms.Label();
            this.lbleuroalıs = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtkur = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtmiktar = new System.Windows.Forms.TextBox();
            this.btndolaral = new System.Windows.Forms.Button();
            this.btndolarsat = new System.Windows.Forms.Button();
            this.btneurosat = new System.Windows.Forms.Button();
            this.btneuroal = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txttutar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtkalan = new System.Windows.Forms.TextBox();
            this.btnmiktar = new System.Windows.Forms.Button();
            this.btntutar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dolar Alış:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(21, 83);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(206, 44);
            this.label20.TabIndex = 1;
            this.label20.Text = "Dolar Satış:";
            // 
            // lbldolaralis
            // 
            this.lbldolaralis.AutoSize = true;
            this.lbldolaralis.BackColor = System.Drawing.Color.Transparent;
            this.lbldolaralis.ForeColor = System.Drawing.Color.White;
            this.lbldolaralis.Location = new System.Drawing.Point(154, 29);
            this.lbldolaralis.Name = "lbldolaralis";
            this.lbldolaralis.Size = new System.Drawing.Size(42, 44);
            this.lbldolaralis.TabIndex = 2;
            this.lbldolaralis.Text = "0";
            // 
            // lbldolarsatıs
            // 
            this.lbldolarsatıs.AutoSize = true;
            this.lbldolarsatıs.BackColor = System.Drawing.Color.Transparent;
            this.lbldolarsatıs.ForeColor = System.Drawing.Color.White;
            this.lbldolarsatıs.Location = new System.Drawing.Point(154, 83);
            this.lbldolarsatıs.Name = "lbldolarsatıs";
            this.lbldolarsatıs.Size = new System.Drawing.Size(28, 29);
            this.lbldolarsatıs.TabIndex = 3;
            this.lbldolarsatıs.Text = "0";
            // 
            // lbleurosatıs
            // 
            this.lbleurosatıs.AutoSize = true;
            this.lbleurosatıs.BackColor = System.Drawing.Color.Transparent;
            this.lbleurosatıs.ForeColor = System.Drawing.Color.White;
            this.lbleurosatıs.Location = new System.Drawing.Point(154, 207);
            this.lbleurosatıs.Name = "lbleurosatıs";
            this.lbleurosatıs.Size = new System.Drawing.Size(28, 29);
            this.lbleurosatıs.TabIndex = 7;
            this.lbleurosatıs.Text = "0";
            // 
            // lbleuroalıs
            // 
            this.lbleuroalıs.AutoSize = true;
            this.lbleuroalıs.BackColor = System.Drawing.Color.Transparent;
            this.lbleuroalıs.ForeColor = System.Drawing.Color.White;
            this.lbleuroalıs.Location = new System.Drawing.Point(154, 153);
            this.lbleuroalıs.Name = "lbleuroalıs";
            this.lbleuroalıs.Size = new System.Drawing.Size(28, 29);
            this.lbleuroalıs.TabIndex = 6;
            this.lbleuroalıs.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 44);
            this.label7.TabIndex = 5;
            this.label7.Text = "Euro Satış:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(21, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 44);
            this.label8.TabIndex = 4;
            this.label8.Text = "Euro Alış:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btntutar);
            this.groupBox1.Controls.Add(this.btnmiktar);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtkalan);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txttutar);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtmiktar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtkur);
            this.groupBox1.Location = new System.Drawing.Point(343, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 298);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(32, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 29);
            this.label9.TabIndex = 9;
            this.label9.Text = "Kur:";
            // 
            // txtkur
            // 
            this.txtkur.Location = new System.Drawing.Point(100, 45);
            this.txtkur.Name = "txtkur";
            this.txtkur.Size = new System.Drawing.Size(482, 35);
            this.txtkur.TabIndex = 0;
            this.txtkur.TextChanged += new System.EventHandler(this.txtkur_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 29);
            this.label10.TabIndex = 11;
            this.label10.Text = "Miktar:";
            // 
            // txtmiktar
            // 
            this.txtmiktar.Location = new System.Drawing.Point(100, 86);
            this.txtmiktar.Name = "txtmiktar";
            this.txtmiktar.Size = new System.Drawing.Size(482, 35);
            this.txtmiktar.TabIndex = 10;
            // 
            // btndolaral
            // 
            this.btndolaral.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndolaral.Location = new System.Drawing.Point(238, 23);
            this.btndolaral.Name = "btndolaral";
            this.btndolaral.Size = new System.Drawing.Size(45, 40);
            this.btndolaral.TabIndex = 9;
            this.btndolaral.Text = "...";
            this.btndolaral.UseVisualStyleBackColor = true;
            this.btndolaral.Click += new System.EventHandler(this.btndolaral_Click);
            // 
            // btndolarsat
            // 
            this.btndolarsat.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndolarsat.Location = new System.Drawing.Point(238, 77);
            this.btndolarsat.Name = "btndolarsat";
            this.btndolarsat.Size = new System.Drawing.Size(45, 40);
            this.btndolarsat.TabIndex = 10;
            this.btndolarsat.Text = "...";
            this.btndolarsat.UseVisualStyleBackColor = true;
            this.btndolarsat.Click += new System.EventHandler(this.btndolarsat_Click);
            // 
            // btneurosat
            // 
            this.btneurosat.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btneurosat.Location = new System.Drawing.Point(238, 201);
            this.btneurosat.Name = "btneurosat";
            this.btneurosat.Size = new System.Drawing.Size(45, 40);
            this.btneurosat.TabIndex = 12;
            this.btneurosat.Text = "...";
            this.btneurosat.UseVisualStyleBackColor = true;
            this.btneurosat.Click += new System.EventHandler(this.btneurosat_Click);
            // 
            // btneuroal
            // 
            this.btneuroal.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btneuroal.Location = new System.Drawing.Point(238, 147);
            this.btneuroal.Name = "btneuroal";
            this.btneuroal.Size = new System.Drawing.Size(45, 40);
            this.btneuroal.TabIndex = 11;
            this.btneuroal.Text = "...";
            this.btneuroal.UseVisualStyleBackColor = true;
            this.btneuroal.Click += new System.EventHandler(this.btneuroal_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(14, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 29);
            this.label11.TabIndex = 13;
            this.label11.Text = "Tutar:";
            // 
            // txttutar
            // 
            this.txttutar.Location = new System.Drawing.Point(100, 127);
            this.txttutar.Name = "txttutar";
            this.txttutar.Size = new System.Drawing.Size(482, 35);
            this.txttutar.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(14, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 29);
            this.label12.TabIndex = 15;
            this.label12.Text = "Kalan:";
            // 
            // txtkalan
            // 
            this.txtkalan.Location = new System.Drawing.Point(100, 168);
            this.txtkalan.Name = "txtkalan";
            this.txtkalan.Size = new System.Drawing.Size(482, 35);
            this.txtkalan.TabIndex = 14;
            // 
            // btnmiktar
            // 
            this.btnmiktar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmiktar.Location = new System.Drawing.Point(100, 209);
            this.btnmiktar.Name = "btnmiktar";
            this.btnmiktar.Size = new System.Drawing.Size(238, 40);
            this.btnmiktar.TabIndex = 13;
            this.btnmiktar.Text = "Mİktar Al-Sat";
            this.btnmiktar.UseVisualStyleBackColor = true;
            this.btnmiktar.Click += new System.EventHandler(this.btnsatısyap_Click);
            // 
            // btntutar
            // 
            this.btntutar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntutar.Location = new System.Drawing.Point(344, 209);
            this.btntutar.Name = "btntutar";
            this.btntutar.Size = new System.Drawing.Size(238, 40);
            this.btntutar.TabIndex = 16;
            this.btntutar.Text = "Tutar Al-Sat";
            this.btntutar.UseVisualStyleBackColor = true;
            this.btntutar.Click += new System.EventHandler(this.btntutar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1188, 679);
            this.Controls.Add(this.btneurosat);
            this.Controls.Add(this.btneuroal);
            this.Controls.Add(this.btndolarsat);
            this.Controls.Add(this.btndolaral);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbleurosatıs);
            this.Controls.Add(this.lbleuroalıs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbldolarsatıs);
            this.Controls.Add(this.lbldolaralis);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Döviz Bürosu(10.04.2024)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbldolaralis;
        private System.Windows.Forms.Label lbldolarsatıs;
        private System.Windows.Forms.Label lbleurosatıs;
        private System.Windows.Forms.Label lbleuroalıs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnmiktar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtkalan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txttutar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtmiktar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtkur;
        private System.Windows.Forms.Button btndolaral;
        private System.Windows.Forms.Button btndolarsat;
        private System.Windows.Forms.Button btneurosat;
        private System.Windows.Forms.Button btneuroal;
        private System.Windows.Forms.Button btntutar;
    }
}

