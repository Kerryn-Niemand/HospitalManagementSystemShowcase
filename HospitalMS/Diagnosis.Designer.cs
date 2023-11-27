namespace HospitalMS
{
    partial class Diagnosis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diagnosis));
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.homeLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.diagIdTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.diagPatIdCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.diagSympCLB = new System.Windows.Forms.CheckedListBox();
            this.diagDataGridView = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.crossBTN = new System.Windows.Forms.Button();
            this.diagPatNameTb = new System.Windows.Forms.TextBox();
            this.diagPMTb = new System.Windows.Forms.TextBox();
            this.diagTestTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(12, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(117, 110);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // homeLabel
            // 
            this.homeLabel.AutoSize = true;
            this.homeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLabel.Location = new System.Drawing.Point(135, 98);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(126, 24);
            this.homeLabel.TabIndex = 11;
            this.homeLabel.Text = "DIAGNOSIS:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(134, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "DIAGNOSIS ID";
            // 
            // diagIdTb
            // 
            this.diagIdTb.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.diagIdTb.Location = new System.Drawing.Point(286, 152);
            this.diagIdTb.Name = "diagIdTb";
            this.diagIdTb.Size = new System.Drawing.Size(210, 20);
            this.diagIdTb.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "PATIENT ID";
            // 
            // diagPatIdCB
            // 
            this.diagPatIdCB.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.diagPatIdCB.FormattingEnabled = true;
            this.diagPatIdCB.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Other"});
            this.diagPatIdCB.Location = new System.Drawing.Point(286, 238);
            this.diagPatIdCB.Name = "diagPatIdCB";
            this.diagPatIdCB.Size = new System.Drawing.Size(198, 21);
            this.diagPatIdCB.TabIndex = 26;
            this.diagPatIdCB.SelectionChangeCommitted += new System.EventHandler(this.diagPatIdCB_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "PATIENT NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(593, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "SYMPTOMS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(593, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "DIAGNOSTIC TEST";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(593, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 25);
            this.label6.TabIndex = 33;
            this.label6.Text = "PRESCRIBED MEDICINE";
            // 
            // diagSympCLB
            // 
            this.diagSympCLB.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.diagSympCLB.FormattingEnabled = true;
            this.diagSympCLB.Items.AddRange(new object[] {
            "Headache",
            "Cough",
            "Pain",
            "Inflammation",
            "Shortness of Breath",
            "Infection (Bacterial)"});
            this.diagSympCLB.Location = new System.Drawing.Point(827, 152);
            this.diagSympCLB.Name = "diagSympCLB";
            this.diagSympCLB.Size = new System.Drawing.Size(198, 34);
            this.diagSympCLB.TabIndex = 35;
            this.diagSympCLB.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.diagSympCLB_ItemCheck);
            // 
            // diagDataGridView
            // 
            this.diagDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.diagDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.diagDataGridView.Location = new System.Drawing.Point(139, 376);
            this.diagDataGridView.Name = "diagDataGridView";
            this.diagDataGridView.Size = new System.Drawing.Size(898, 150);
            this.diagDataGridView.TabIndex = 37;
            this.diagDataGridView.DoubleClick += new System.EventHandler(this.diagDataGridView_DoubleClick);
            // 
            // addBtn
            // 
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(139, 557);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(106, 44);
            this.addBtn.TabIndex = 38;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(343, 557);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(106, 44);
            this.updateBtn.TabIndex = 39;
            this.updateBtn.Text = "UPDATE";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtn.Location = new System.Drawing.Point(540, 557);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(106, 44);
            this.delBtn.TabIndex = 40;
            this.delBtn.Text = "DELETE";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(734, 557);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(106, 44);
            this.resetBtn.TabIndex = 41;
            this.resetBtn.Text = "RESET";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.homeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.Location = new System.Drawing.Point(931, 557);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(106, 44);
            this.homeBtn.TabIndex = 42;
            this.homeBtn.Text = "HOME";
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // crossBTN
            // 
            this.crossBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.crossBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crossBTN.Location = new System.Drawing.Point(1144, -2);
            this.crossBTN.Name = "crossBTN";
            this.crossBTN.Size = new System.Drawing.Size(39, 39);
            this.crossBTN.TabIndex = 43;
            this.crossBTN.Text = "X";
            this.crossBTN.UseVisualStyleBackColor = true;
            this.crossBTN.Click += new System.EventHandler(this.crossBTN_Click);
            // 
            // diagPatNameTb
            // 
            this.diagPatNameTb.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.diagPatNameTb.Location = new System.Drawing.Point(286, 318);
            this.diagPatNameTb.Name = "diagPatNameTb";
            this.diagPatNameTb.Size = new System.Drawing.Size(210, 20);
            this.diagPatNameTb.TabIndex = 49;
            // 
            // diagPMTb
            // 
            this.diagPMTb.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.diagPMTb.Location = new System.Drawing.Point(827, 312);
            this.diagPMTb.Name = "diagPMTb";
            this.diagPMTb.Size = new System.Drawing.Size(210, 20);
            this.diagPMTb.TabIndex = 50;
            // 
            // diagTestTb
            // 
            this.diagTestTb.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.diagTestTb.Location = new System.Drawing.Point(827, 232);
            this.diagTestTb.Name = "diagTestTb";
            this.diagTestTb.Size = new System.Drawing.Size(210, 20);
            this.diagTestTb.TabIndex = 51;
            // 
            // Diagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1183, 662);
            this.Controls.Add(this.diagTestTb);
            this.Controls.Add(this.diagPMTb);
            this.Controls.Add(this.diagPatNameTb);
            this.Controls.Add(this.crossBTN);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.diagDataGridView);
            this.Controls.Add(this.diagSympCLB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.diagPatIdCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.diagIdTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.homeLabel);
            this.Controls.Add(this.pictureBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Diagnosis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Diagnosis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox diagIdTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox diagPatIdCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox diagSympCLB;
        private System.Windows.Forms.DataGridView diagDataGridView;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button crossBTN;
        private System.Windows.Forms.TextBox diagPatNameTb;
        private System.Windows.Forms.TextBox diagPMTb;
        private System.Windows.Forms.TextBox diagTestTb;
    }
}