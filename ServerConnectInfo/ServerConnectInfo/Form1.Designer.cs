namespace ServerConnectInfo
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
            this.btnFetchData = new System.Windows.Forms.Button();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.DatabaseComboBox = new System.Windows.Forms.ComboBox();
            this.NameComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFetchData
            // 
            this.btnFetchData.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnFetchData.Location = new System.Drawing.Point(97, 123);
            this.btnFetchData.Name = "btnFetchData";
            this.btnFetchData.Size = new System.Drawing.Size(121, 37);
            this.btnFetchData.TabIndex = 0;
            this.btnFetchData.Text = "Get Data";
            this.btnFetchData.UseVisualStyleBackColor = false;
            this.btnFetchData.Click += new System.EventHandler(this.btnFetchData_Click);
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(241, 87);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(46, 20);
            this.txtDatabaseName.TabIndex = 1;
            this.txtDatabaseName.Visible = false;
            // 
            // txtServerName
            // 
            this.txtServerName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtServerName.Location = new System.Drawing.Point(97, 39);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(121, 20);
            this.txtServerName.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUserName.Location = new System.Drawing.Point(241, 61);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(46, 20);
            this.txtUserName.TabIndex = 3;
            this.txtUserName.Visible = false;
            // 
            // DatabaseComboBox
            // 
            this.DatabaseComboBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.DatabaseComboBox.FormattingEnabled = true;
            this.DatabaseComboBox.Location = new System.Drawing.Point(97, 12);
            this.DatabaseComboBox.Name = "DatabaseComboBox";
            this.DatabaseComboBox.Size = new System.Drawing.Size(121, 21);
            this.DatabaseComboBox.TabIndex = 4;
            // 
            // NameComboBox
            // 
            this.NameComboBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.NameComboBox.FormattingEnabled = true;
            this.NameComboBox.Location = new System.Drawing.Point(97, 65);
            this.NameComboBox.Name = "NameComboBox";
            this.NameComboBox.Size = new System.Drawing.Size(121, 21);
            this.NameComboBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "DataBaseName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ServerName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "UserName:";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(97, 92);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(121, 20);
            this.txtIPAddress.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "IpAdress:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(292, 173);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIPAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameComboBox);
            this.Controls.Add(this.DatabaseComboBox);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.txtDatabaseName);
            this.Controls.Add(this.btnFetchData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ServerConnectionInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFetchData;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.ComboBox DatabaseComboBox;
        private System.Windows.Forms.ComboBox NameComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Label label4;
    }
}

