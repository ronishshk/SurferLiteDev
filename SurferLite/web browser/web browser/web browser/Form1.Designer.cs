namespace web_browser
{
    partial class FrmWebBrowser
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
            this.lbl_Address = new System.Windows.Forms.Label();
            this.txt_Url = new System.Windows.Forms.TextBox();
            this.btn_Go = new System.Windows.Forms.Button();
            this.wbBrwsr = new System.Windows.Forms.WebBrowser();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Address.Location = new System.Drawing.Point(11, 44);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(56, 13);
            this.lbl_Address.TabIndex = 0;
            this.lbl_Address.Text = "Address:";
            // 
            // txt_Url
            // 
            this.txt_Url.Location = new System.Drawing.Point(73, 37);
            this.txt_Url.Name = "txt_Url";
            this.txt_Url.Size = new System.Drawing.Size(418, 20);
            this.txt_Url.TabIndex = 1;
            // 
            // btn_Go
            // 
            this.btn_Go.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_Go.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Go.Location = new System.Drawing.Point(497, 34);
            this.btn_Go.Name = "btn_Go";
            this.btn_Go.Size = new System.Drawing.Size(56, 23);
            this.btn_Go.TabIndex = 2;
            this.btn_Go.Text = "Go";
            this.btn_Go.UseVisualStyleBackColor = false;
            this.btn_Go.Click += new System.EventHandler(this.btn_Go_Click);
            // 
            // wbBrwsr
            // 
            this.wbBrwsr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.wbBrwsr.Location = new System.Drawing.Point(-2, 63);
            this.wbBrwsr.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrwsr.Name = "wbBrwsr";
            this.wbBrwsr.Size = new System.Drawing.Size(570, 337);
            this.wbBrwsr.TabIndex = 3;
            this.wbBrwsr.Url = new System.Uri("http://www.yahoo.com", System.UriKind.Absolute);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(268, 8);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 4;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(157, 8);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 5;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // FrmWebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 398);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.wbBrwsr);
            this.Controls.Add(this.btn_Go);
            this.Controls.Add(this.txt_Url);
            this.Controls.Add(this.lbl_Address);
            this.Name = "FrmWebBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web Browswer Contorol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox txt_Url;
        private System.Windows.Forms.Button btn_Go;
        private System.Windows.Forms.WebBrowser wbBrwsr;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_stop;
    }
}

