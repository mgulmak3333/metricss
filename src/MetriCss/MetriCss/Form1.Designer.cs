
namespace MetriCss
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CloseButton = new Sunny.UI.UIAvatar();
            this.MinimizeButton = new Sunny.UI.UIAvatar();
            this.uıGroupBox1 = new Sunny.UI.UIGroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uıTextBox1 = new Sunny.UI.UITextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.after_metrcis = new Sunny.UI.UIComboBox();
            this.before_metric = new Sunny.UI.UIComboBox();
            this.convert_btn = new Sunny.UI.UIButton();
            this.uıGroupBox2 = new Sunny.UI.UIGroupBox();
            this.uıPanel1 = new Sunny.UI.UIPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.response_label = new System.Windows.Forms.Label();
            this.preview_number = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.uıGroupBox1.SuspendLayout();
            this.uıGroupBox2.SuspendLayout();
            this.uıPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // CloseButton
            // 
            this.CloseButton.AvatarSize = 190;
            this.CloseButton.FillColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.CloseButton, "CloseButton");
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Symbol = 61453;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.AvatarSize = 190;
            this.MinimizeButton.FillColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.MinimizeButton, "MinimizeButton");
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Symbol = 61544;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // uıGroupBox1
            // 
            this.uıGroupBox1.Controls.Add(this.convert_btn);
            this.uıGroupBox1.Controls.Add(this.before_metric);
            this.uıGroupBox1.Controls.Add(this.after_metrcis);
            this.uıGroupBox1.Controls.Add(this.label5);
            this.uıGroupBox1.Controls.Add(this.label4);
            this.uıGroupBox1.Controls.Add(this.uıTextBox1);
            this.uıGroupBox1.Controls.Add(this.label3);
            this.uıGroupBox1.FillColor = System.Drawing.Color.Transparent;
            this.uıGroupBox1.FillColor2 = System.Drawing.Color.White;
            this.uıGroupBox1.FillDisableColor = System.Drawing.Color.White;
            resources.ApplyResources(this.uıGroupBox1, "uıGroupBox1");
            this.uıGroupBox1.ForeColor = System.Drawing.Color.White;
            this.uıGroupBox1.Name = "uıGroupBox1";
            this.uıGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // uıTextBox1
            // 
            this.uıTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uıTextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            resources.ApplyResources(this.uıTextBox1, "uıTextBox1");
            this.uıTextBox1.ForeColor = System.Drawing.Color.White;
            this.uıTextBox1.ForeReadOnlyColor = System.Drawing.Color.White;
            this.uıTextBox1.Name = "uıTextBox1";
            this.uıTextBox1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(75)))), ((int)(((byte)(90)))));
            this.uıTextBox1.RectReadOnlyColor = System.Drawing.Color.White;
            this.uıTextBox1.ShowText = false;
            this.uıTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uıTextBox1.Watermark = "";
            this.uıTextBox1.TextChanged += new System.EventHandler(this.uıTextBox1_TextChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // after_metrcis
            // 
            this.after_metrcis.DataSource = null;
            this.after_metrcis.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(44)))), ((int)(((byte)(56)))));
            resources.ApplyResources(this.after_metrcis, "after_metrcis");
            this.after_metrcis.ForeColor = System.Drawing.Color.White;
            this.after_metrcis.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.after_metrcis.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.after_metrcis.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.after_metrcis.Items.AddRange(new object[] {
            resources.GetString("after_metrcis.Items"),
            resources.GetString("after_metrcis.Items1"),
            resources.GetString("after_metrcis.Items2"),
            resources.GetString("after_metrcis.Items3"),
            resources.GetString("after_metrcis.Items4"),
            resources.GetString("after_metrcis.Items5"),
            resources.GetString("after_metrcis.Items6"),
            resources.GetString("after_metrcis.Items7"),
            resources.GetString("after_metrcis.Items8"),
            resources.GetString("after_metrcis.Items9"),
            resources.GetString("after_metrcis.Items10"),
            resources.GetString("after_metrcis.Items11"),
            resources.GetString("after_metrcis.Items12")});
            this.after_metrcis.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.after_metrcis.Name = "after_metrcis";
            this.after_metrcis.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(75)))), ((int)(((byte)(90)))));
            this.after_metrcis.SymbolSize = 24;
            this.after_metrcis.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.after_metrcis.Watermark = "";
            this.after_metrcis.SelectedIndexChanged += new System.EventHandler(this.after_metrcis_SelectedIndexChanged);
            // 
            // before_metric
            // 
            this.before_metric.DataSource = null;
            this.before_metric.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(44)))), ((int)(((byte)(56)))));
            resources.ApplyResources(this.before_metric, "before_metric");
            this.before_metric.ForeColor = System.Drawing.Color.White;
            this.before_metric.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.before_metric.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.before_metric.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.before_metric.Items.AddRange(new object[] {
            resources.GetString("before_metric.Items"),
            resources.GetString("before_metric.Items1"),
            resources.GetString("before_metric.Items2"),
            resources.GetString("before_metric.Items3"),
            resources.GetString("before_metric.Items4"),
            resources.GetString("before_metric.Items5"),
            resources.GetString("before_metric.Items6"),
            resources.GetString("before_metric.Items7"),
            resources.GetString("before_metric.Items8"),
            resources.GetString("before_metric.Items9"),
            resources.GetString("before_metric.Items10"),
            resources.GetString("before_metric.Items11"),
            resources.GetString("before_metric.Items12")});
            this.before_metric.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.before_metric.Name = "before_metric";
            this.before_metric.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(75)))), ((int)(((byte)(90)))));
            this.before_metric.SymbolSize = 24;
            this.before_metric.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.before_metric.Watermark = "";
            this.before_metric.SelectedIndexChanged += new System.EventHandler(this.before_metric_SelectedIndexChanged);
            // 
            // convert_btn
            // 
            this.convert_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.convert_btn, "convert_btn");
            this.convert_btn.Name = "convert_btn";
            this.convert_btn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.convert_btn.Click += new System.EventHandler(this.convert_btn_Click);
            // 
            // uıGroupBox2
            // 
            this.uıGroupBox2.Controls.Add(this.uıPanel1);
            this.uıGroupBox2.Controls.Add(this.preview_number);
            this.uıGroupBox2.FillColor = System.Drawing.Color.Transparent;
            this.uıGroupBox2.FillColor2 = System.Drawing.Color.White;
            this.uıGroupBox2.FillDisableColor = System.Drawing.Color.White;
            resources.ApplyResources(this.uıGroupBox2, "uıGroupBox2");
            this.uıGroupBox2.ForeColor = System.Drawing.Color.White;
            this.uıGroupBox2.Name = "uıGroupBox2";
            this.uıGroupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uıPanel1
            // 
            this.uıPanel1.Controls.Add(this.response_label);
            this.uıPanel1.Controls.Add(this.label6);
            this.uıPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            resources.ApplyResources(this.uıPanel1, "uıPanel1");
            this.uıPanel1.Name = "uıPanel1";
            this.uıPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Name = "label6";
            // 
            // response_label
            // 
            this.response_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.response_label.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.response_label, "response_label");
            this.response_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.response_label.Name = "response_label";
            this.response_label.Click += new System.EventHandler(this.response_label_Click);
            // 
            // preview_number
            // 
            resources.ApplyResources(this.preview_number, "preview_number");
            this.preview_number.Name = "preview_number";
            this.preview_number.Click += new System.EventHandler(this.preview_number_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Name = "label8";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.uıGroupBox2);
            this.Controls.Add(this.uıGroupBox1);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.uıGroupBox1.ResumeLayout(false);
            this.uıGroupBox1.PerformLayout();
            this.uıGroupBox2.ResumeLayout(false);
            this.uıPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UIAvatar CloseButton;
        private Sunny.UI.UIAvatar MinimizeButton;
        private Sunny.UI.UIGroupBox uıGroupBox1;
        private Sunny.UI.UITextBox uıTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Sunny.UI.UIComboBox after_metrcis;
        private System.Windows.Forms.Label label5;
        private Sunny.UI.UIComboBox before_metric;
        private Sunny.UI.UIButton convert_btn;
        private Sunny.UI.UIGroupBox uıGroupBox2;
        private Sunny.UI.UIPanel uıPanel1;
        private System.Windows.Forms.Label response_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label preview_number;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

