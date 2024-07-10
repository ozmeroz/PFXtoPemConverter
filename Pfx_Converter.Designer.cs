namespace PFXtoPemConverter
{
    partial class Pfx_Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pfx_Converter));
            this.Convert = new System.Windows.Forms.Button();
            this.txtPfxPath = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pfxFileLable = new System.Windows.Forms.Label();
            this.passLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(489, 305);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(206, 39);
            this.Convert.TabIndex = 0;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // txtPfxPath
            // 
            this.txtPfxPath.Location = new System.Drawing.Point(117, 31);
            this.txtPfxPath.Name = "txtPfxPath";
            this.txtPfxPath.Size = new System.Drawing.Size(441, 22);
            this.txtPfxPath.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(117, 73);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(441, 22);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(571, 25);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(124, 35);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pfxFileLable
            // 
            this.pfxFileLable.AutoSize = true;
            this.pfxFileLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pfxFileLable.Location = new System.Drawing.Point(12, 31);
            this.pfxFileLable.Name = "pfxFileLable";
            this.pfxFileLable.Size = new System.Drawing.Size(70, 20);
            this.pfxFileLable.TabIndex = 4;
            this.pfxFileLable.Text = "Pfx File:";
            this.pfxFileLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // passLable
            // 
            this.passLable.AutoSize = true;
            this.passLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLable.Location = new System.Drawing.Point(12, 75);
            this.passLable.Name = "passLable";
            this.passLable.Size = new System.Drawing.Size(88, 20);
            this.passLable.TabIndex = 5;
            this.passLable.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(619, 180);
            this.label1.TabIndex = 6;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // Pfx_Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 356);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passLable);
            this.Controls.Add(this.pfxFileLable);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtPfxPath);
            this.Controls.Add(this.Convert);
            this.Name = "Pfx_Converter";
            this.Text = "Pfx to Pem Certificate Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.TextBox txtPfxPath;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label pfxFileLable;
        private System.Windows.Forms.Label passLable;
        private System.Windows.Forms.Label label1;
    }
}