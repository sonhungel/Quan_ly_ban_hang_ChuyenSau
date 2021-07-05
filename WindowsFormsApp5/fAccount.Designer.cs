namespace WindowsFormsApp5
{
    partial class fAccount
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txbReEnterPass = new System.Windows.Forms.TextBox();
            this.txbNewPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbDisPlayName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPassWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.roundPnlAcc = new WindowsFormsApp5.Tools.EclipseControl();
            this.pnlAccInf = new System.Windows.Forms.Panel();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.roundPnlPass = new WindowsFormsApp5.Tools.EclipseControl();
            this.rBtnUpdate = new WindowsFormsApp5.Tools.EclipseControl();
            this.rtxbUsername = new WindowsFormsApp5.Tools.EclipseControl();
            this.rtxbDisplayName = new WindowsFormsApp5.Tools.EclipseControl();
            this.rtxbPassword = new WindowsFormsApp5.Tools.EclipseControl();
            this.rtxbNewPass = new WindowsFormsApp5.Tools.EclipseControl();
            this.rtxbReEnterPass = new WindowsFormsApp5.Tools.EclipseControl();
            this.pnlAccInf.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbReEnterPass
            // 
            this.txbReEnterPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbReEnterPass.Location = new System.Drawing.Point(206, 203);
            this.txbReEnterPass.Name = "txbReEnterPass";
            this.txbReEnterPass.Size = new System.Drawing.Size(250, 41);
            this.txbReEnterPass.TabIndex = 14;
            this.txbReEnterPass.UseSystemPasswordChar = true;
            // 
            // txbNewPass
            // 
            this.txbNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNewPass.Location = new System.Drawing.Point(206, 96);
            this.txbNewPass.Name = "txbNewPass";
            this.txbNewPass.Size = new System.Drawing.Size(250, 41);
            this.txbNewPass.TabIndex = 13;
            this.txbNewPass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(37, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nhập lại";
            // 
            // txbUserName
            // 
            this.txbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUserName.Location = new System.Drawing.Point(209, 48);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.ReadOnly = true;
            this.txbUserName.Size = new System.Drawing.Size(250, 41);
            this.txbUserName.TabIndex = 17;
            this.txbUserName.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(37, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mật khẩu mới";
            // 
            // txbDisPlayName
            // 
            this.txbDisPlayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDisPlayName.Location = new System.Drawing.Point(209, 146);
            this.txbDisPlayName.Name = "txbDisPlayName";
            this.txbDisPlayName.Size = new System.Drawing.Size(250, 41);
            this.txbDisPlayName.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên đăng nhập";
            // 
            // txbPassWord
            // 
            this.txbPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassWord.Location = new System.Drawing.Point(209, 253);
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.Size = new System.Drawing.Size(250, 41);
            this.txbPassWord.TabIndex = 12;
            this.txbPassWord.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên hiển thị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mật khẩu";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Image = global::WindowsFormsApp5.Properties.Resources.update;
            this.btnUpdate.Location = new System.Drawing.Point(491, 538);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(201, 53);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // roundPnlAcc
            // 
            this.roundPnlAcc.CornerRadius = 30;
            this.roundPnlAcc.TargetControl = this.pnlAccInf;
            // 
            // pnlAccInf
            // 
            this.pnlAccInf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlAccInf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlAccInf.Controls.Add(this.label1);
            this.pnlAccInf.Controls.Add(this.label2);
            this.pnlAccInf.Controls.Add(this.txbDisPlayName);
            this.pnlAccInf.Controls.Add(this.txbUserName);
            this.pnlAccInf.Controls.Add(this.txbPassWord);
            this.pnlAccInf.Controls.Add(this.label3);
            this.pnlAccInf.Location = new System.Drawing.Point(73, 114);
            this.pnlAccInf.Name = "pnlAccInf";
            this.pnlAccInf.Size = new System.Drawing.Size(503, 345);
            this.pnlAccInf.TabIndex = 18;
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlPassword.Controls.Add(this.label4);
            this.pnlPassword.Controls.Add(this.txbNewPass);
            this.pnlPassword.Controls.Add(this.txbReEnterPass);
            this.pnlPassword.Controls.Add(this.label5);
            this.pnlPassword.Location = new System.Drawing.Point(621, 114);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(500, 342);
            this.pnlPassword.TabIndex = 19;
            // 
            // roundPnlPass
            // 
            this.roundPnlPass.CornerRadius = 30;
            this.roundPnlPass.TargetControl = this.pnlPassword;
            // 
            // rBtnUpdate
            // 
            this.rBtnUpdate.CornerRadius = 10;
            this.rBtnUpdate.TargetControl = this.btnUpdate;
            // 
            // rtxbUsername
            // 
            this.rtxbUsername.CornerRadius = 10;
            this.rtxbUsername.TargetControl = this.txbUserName;
            // 
            // rtxbDisplayName
            // 
            this.rtxbDisplayName.CornerRadius = 10;
            this.rtxbDisplayName.TargetControl = this.txbDisPlayName;
            // 
            // rtxbPassword
            // 
            this.rtxbPassword.CornerRadius = 10;
            this.rtxbPassword.TargetControl = this.txbPassWord;
            // 
            // rtxbNewPass
            // 
            this.rtxbNewPass.CornerRadius = 10;
            this.rtxbNewPass.TargetControl = this.txbNewPass;
            // 
            // rtxbReEnterPass
            // 
            this.rtxbReEnterPass.CornerRadius = 10;
            this.rtxbReEnterPass.TargetControl = this.txbReEnterPass;
            // 
            // fAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.pnlPassword);
            this.Controls.Add(this.pnlAccInf);
            this.Controls.Add(this.btnUpdate);
            this.Name = "fAccount";
            this.Size = new System.Drawing.Size(1207, 705);
            this.Load += new System.EventHandler(this.fAccount_Load);
            this.pnlAccInf.ResumeLayout(false);
            this.pnlAccInf.PerformLayout();
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbReEnterPass;
        private System.Windows.Forms.TextBox txbNewPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbDisPlayName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPassWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ToolTip toolTip1;
        private Tools.EclipseControl roundPnlAcc;
        private System.Windows.Forms.Panel pnlAccInf;
        private System.Windows.Forms.Panel pnlPassword;
        private Tools.EclipseControl roundPnlPass;
        private Tools.EclipseControl rBtnUpdate;
        private Tools.EclipseControl rtxbUsername;
        private Tools.EclipseControl rtxbDisplayName;
        private Tools.EclipseControl rtxbPassword;
        private Tools.EclipseControl rtxbNewPass;
        private Tools.EclipseControl rtxbReEnterPass;
    }
}
