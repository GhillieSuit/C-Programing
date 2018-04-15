namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblName1 = new System.Windows.Forms.Label();
            this.btnFeed1 = new System.Windows.Forms.Button();
            this.lblLevel1 = new System.Windows.Forms.Label();
            this.btnFeed2 = new System.Windows.Forms.Button();
            this.lblName2 = new System.Windows.Forms.Label();
            this.lblLevel2 = new System.Windows.Forms.Label();
            this.btnFeed3 = new System.Windows.Forms.Button();
            this.lblName3 = new System.Windows.Forms.Label();
            this.lblLevel3 = new System.Windows.Forms.Label();
            this.pbxDog3 = new System.Windows.Forms.PictureBox();
            this.pbxDog2 = new System.Windows.Forms.PictureBox();
            this.pbxDog1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDog1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(12, 12);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(186, 21);
            this.tbxName.TabIndex = 0;
            this.tbxName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(204, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(277, 12);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(353, 23);
            this.lblMsg.TabIndex = 2;
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName1
            // 
            this.lblName1.Location = new System.Drawing.Point(12, 48);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(186, 23);
            this.lblName1.TabIndex = 2;
            this.lblName1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblName1.Visible = false;
            // 
            // btnFeed1
            // 
            this.btnFeed1.Location = new System.Drawing.Point(12, 249);
            this.btnFeed1.Name = "btnFeed1";
            this.btnFeed1.Size = new System.Drawing.Size(186, 23);
            this.btnFeed1.TabIndex = 1;
            this.btnFeed1.Text = "밥 머겅";
            this.btnFeed1.UseVisualStyleBackColor = true;
            this.btnFeed1.Visible = false;
            this.btnFeed1.Click += new System.EventHandler(this.btnFeed1_Click);
            // 
            // lblLevel1
            // 
            this.lblLevel1.Location = new System.Drawing.Point(12, 277);
            this.lblLevel1.Name = "lblLevel1";
            this.lblLevel1.Size = new System.Drawing.Size(186, 23);
            this.lblLevel1.TabIndex = 2;
            this.lblLevel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLevel1.Visible = false;
            // 
            // btnFeed2
            // 
            this.btnFeed2.Location = new System.Drawing.Point(227, 249);
            this.btnFeed2.Name = "btnFeed2";
            this.btnFeed2.Size = new System.Drawing.Size(186, 23);
            this.btnFeed2.TabIndex = 1;
            this.btnFeed2.Text = "밥 머겅";
            this.btnFeed2.UseVisualStyleBackColor = true;
            this.btnFeed2.Visible = false;
            this.btnFeed2.Click += new System.EventHandler(this.btnFeed2_Click_1);
            // 
            // lblName2
            // 
            this.lblName2.Location = new System.Drawing.Point(227, 48);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(186, 23);
            this.lblName2.TabIndex = 2;
            this.lblName2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblName2.Visible = false;
            this.lblName2.Click += new System.EventHandler(this.lblName2_Click);
            // 
            // lblLevel2
            // 
            this.lblLevel2.Location = new System.Drawing.Point(227, 277);
            this.lblLevel2.Name = "lblLevel2";
            this.lblLevel2.Size = new System.Drawing.Size(186, 23);
            this.lblLevel2.TabIndex = 2;
            this.lblLevel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLevel2.Visible = false;
            this.lblLevel2.Click += new System.EventHandler(this.lblLevel2_Click);
            // 
            // btnFeed3
            // 
            this.btnFeed3.Location = new System.Drawing.Point(444, 249);
            this.btnFeed3.Name = "btnFeed3";
            this.btnFeed3.Size = new System.Drawing.Size(186, 23);
            this.btnFeed3.TabIndex = 1;
            this.btnFeed3.Text = "밥 머겅";
            this.btnFeed3.UseVisualStyleBackColor = true;
            this.btnFeed3.Visible = false;
            this.btnFeed3.Click += new System.EventHandler(this.btnFeed3_Click);
            // 
            // lblName3
            // 
            this.lblName3.Location = new System.Drawing.Point(444, 48);
            this.lblName3.Name = "lblName3";
            this.lblName3.Size = new System.Drawing.Size(186, 23);
            this.lblName3.TabIndex = 2;
            this.lblName3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblName3.Visible = false;
            this.lblName3.Click += new System.EventHandler(this.lblName3_Click);
            // 
            // lblLevel3
            // 
            this.lblLevel3.Location = new System.Drawing.Point(444, 277);
            this.lblLevel3.Name = "lblLevel3";
            this.lblLevel3.Size = new System.Drawing.Size(186, 23);
            this.lblLevel3.TabIndex = 2;
            this.lblLevel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLevel3.Visible = false;
            this.lblLevel3.Click += new System.EventHandler(this.lblLevel3_Click);
            // 
            // pbxDog3
            // 
            this.pbxDog3.Image = global::WindowsFormsApp1.Properties.Resources.dog1;
            this.pbxDog3.Location = new System.Drawing.Point(444, 86);
            this.pbxDog3.Name = "pbxDog3";
            this.pbxDog3.Size = new System.Drawing.Size(186, 153);
            this.pbxDog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDog3.TabIndex = 3;
            this.pbxDog3.TabStop = false;
            this.pbxDog3.Visible = false;
            this.pbxDog3.Click += new System.EventHandler(this.pbxDog3_Click);
            // 
            // pbxDog2
            // 
            this.pbxDog2.Image = global::WindowsFormsApp1.Properties.Resources.dog1;
            this.pbxDog2.Location = new System.Drawing.Point(227, 86);
            this.pbxDog2.Name = "pbxDog2";
            this.pbxDog2.Size = new System.Drawing.Size(186, 153);
            this.pbxDog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDog2.TabIndex = 3;
            this.pbxDog2.TabStop = false;
            this.pbxDog2.Visible = false;
            this.pbxDog2.Click += new System.EventHandler(this.pbxDog2_Click);
            // 
            // pbxDog1
            // 
            this.pbxDog1.Image = global::WindowsFormsApp1.Properties.Resources.dog1;
            this.pbxDog1.Location = new System.Drawing.Point(12, 86);
            this.pbxDog1.Name = "pbxDog1";
            this.pbxDog1.Size = new System.Drawing.Size(186, 153);
            this.pbxDog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDog1.TabIndex = 3;
            this.pbxDog1.TabStop = false;
            this.pbxDog1.Visible = false;
            this.pbxDog1.Click += new System.EventHandler(this.pbxDog1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 315);
            this.Controls.Add(this.pbxDog3);
            this.Controls.Add(this.pbxDog2);
            this.Controls.Add(this.pbxDog1);
            this.Controls.Add(this.lblLevel3);
            this.Controls.Add(this.lblLevel2);
            this.Controls.Add(this.lblLevel1);
            this.Controls.Add(this.lblName3);
            this.Controls.Add(this.lblName2);
            this.Controls.Add(this.btnFeed3);
            this.Controls.Add(this.lblName1);
            this.Controls.Add(this.btnFeed2);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnFeed1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.PictureBox pbxDog1;
        private System.Windows.Forms.Button btnFeed1;
        private System.Windows.Forms.Label lblLevel1;
        private System.Windows.Forms.Button btnFeed2;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Label lblLevel2;
        private System.Windows.Forms.PictureBox pbxDog2;
        private System.Windows.Forms.Button btnFeed3;
        private System.Windows.Forms.Label lblName3;
        private System.Windows.Forms.Label lblLevel3;
        private System.Windows.Forms.PictureBox pbxDog3;
    }
}

