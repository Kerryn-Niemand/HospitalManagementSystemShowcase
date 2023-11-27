namespace HospitalMS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.headingLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminLabel = new System.Windows.Forms.Label();
            this.adminRTB = new System.Windows.Forms.RichTextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordRTB = new System.Windows.Forms.RichTextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.crossBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLabel.Location = new System.Drawing.Point(38, 42);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(353, 24);
            this.headingLabel.TabIndex = 0;
            this.headingLabel.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(166, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLabel.Location = new System.Drawing.Point(12, 233);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(70, 24);
            this.adminLabel.TabIndex = 2;
            this.adminLabel.Text = "Admin";
            // 
            // adminRTB
            // 
            this.adminRTB.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.adminRTB.Location = new System.Drawing.Point(134, 233);
            this.adminRTB.Name = "adminRTB";
            this.adminRTB.Size = new System.Drawing.Size(257, 24);
            this.adminRTB.TabIndex = 3;
            this.adminRTB.Text = "";
            this.adminRTB.TextChanged += new System.EventHandler(this.adminRTB_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(12, 333);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(100, 24);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password";
            // 
            // passwordRTB
            // 
            this.passwordRTB.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.passwordRTB.Location = new System.Drawing.Point(134, 333);
            this.passwordRTB.Name = "passwordRTB";
            this.passwordRTB.Size = new System.Drawing.Size(257, 24);
            this.passwordRTB.TabIndex = 5;
            this.passwordRTB.Text = "";
            this.passwordRTB.TextChanged += new System.EventHandler(this.passwordRTB_TextChanged);
            this.passwordRTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordRTB_KeyPress);
            // 
            // loginBtn
            // 
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(166, 404);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(106, 44);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(166, 466);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(106, 44);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "CLEAR";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // crossBTN
            // 
            this.crossBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.crossBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crossBTN.Location = new System.Drawing.Point(393, 0);
            this.crossBTN.Name = "crossBTN";
            this.crossBTN.Size = new System.Drawing.Size(39, 39);
            this.crossBTN.TabIndex = 8;
            this.crossBTN.Text = "X";
            this.crossBTN.UseVisualStyleBackColor = true;
            this.crossBTN.Click += new System.EventHandler(this.crossBTN_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(427, 538);
            this.Controls.Add(this.crossBTN);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordRTB);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.adminRTB);
            this.Controls.Add(this.adminLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.headingLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label adminLabel;
        private System.Windows.Forms.RichTextBox adminRTB;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.RichTextBox passwordRTB;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button crossBTN;
    }
}

