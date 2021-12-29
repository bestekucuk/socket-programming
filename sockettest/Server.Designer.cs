
namespace sockettest
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
            this.txtHost1 = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.Label();
            this.txtPort1 = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtHost1
            // 
            this.txtHost1.Location = new System.Drawing.Point(84, 23);
            this.txtHost1.Multiline = true;
            this.txtHost1.Name = "txtHost1";
            this.txtHost1.Size = new System.Drawing.Size(164, 58);
            this.txtHost1.TabIndex = 0;
            this.txtHost1.Text = "127.0.0.1";
            // 
            // txtHost
            // 
            this.txtHost.AutoSize = true;
            this.txtHost.Location = new System.Drawing.Point(32, 36);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(37, 17);
            this.txtHost.TabIndex = 1;
            this.txtHost.Text = "Host";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(603, 23);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(102, 46);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtPort
            // 
            this.txtPort.AutoSize = true;
            this.txtPort.Location = new System.Drawing.Point(277, 36);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(34, 17);
            this.txtPort.TabIndex = 4;
            this.txtPort.Text = "Port";
            // 
            // txtPort1
            // 
            this.txtPort1.Location = new System.Drawing.Point(367, 23);
            this.txtPort1.Multiline = true;
            this.txtPort1.Name = "txtPort1";
            this.txtPort1.Size = new System.Drawing.Size(188, 58);
            this.txtPort1.TabIndex = 3;
            this.txtPort1.Text = "8910";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(603, 97);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(102, 46);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(35, 125);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(542, 295);
            this.txtStatus.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtPort1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.txtHost1);
            this.Name = "Form1";
            this.Text = "SERVER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHost1;
        private System.Windows.Forms.Label txtHost;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label txtPort;
        private System.Windows.Forms.TextBox txtPort1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtStatus;
    }
}

