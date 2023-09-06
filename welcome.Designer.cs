namespace EmployeeManagement
{
    partial class welcome
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
            this.btnadd = new System.Windows.Forms.Button();
            this.btndisplay = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndisplay1rec = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnsign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Tomato;
            this.btnadd.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.SystemColors.Window;
            this.btnadd.Location = new System.Drawing.Point(494, 244);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(206, 39);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Add Record";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btndisplay
            // 
            this.btndisplay.BackColor = System.Drawing.Color.Tomato;
            this.btndisplay.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndisplay.ForeColor = System.Drawing.SystemColors.Window;
            this.btndisplay.Location = new System.Drawing.Point(772, 244);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(206, 39);
            this.btndisplay.TabIndex = 1;
            this.btndisplay.Text = "Display all Records";
            this.btndisplay.UseVisualStyleBackColor = false;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Tomato;
            this.btnupdate.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnupdate.Location = new System.Drawing.Point(494, 367);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(206, 39);
            this.btnupdate.TabIndex = 3;
            this.btnupdate.Text = "Update a Record";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.button3_Click);
            // 
            // btndisplay1rec
            // 
            this.btndisplay1rec.BackColor = System.Drawing.Color.Tomato;
            this.btndisplay1rec.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndisplay1rec.ForeColor = System.Drawing.SystemColors.Window;
            this.btndisplay1rec.Location = new System.Drawing.Point(772, 367);
            this.btndisplay1rec.Name = "btndisplay1rec";
            this.btndisplay1rec.Size = new System.Drawing.Size(206, 39);
            this.btndisplay1rec.TabIndex = 4;
            this.btndisplay1rec.Text = "Delete Record";
            this.btndisplay1rec.UseVisualStyleBackColor = false;
            this.btndisplay1rec.Click += new System.EventHandler(this.btndisplay1rec_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Tomato;
            this.btnexit.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnexit.Location = new System.Drawing.Point(643, 485);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(206, 39);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Exit ";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.White;
            this.btnlogin.ForeColor = System.Drawing.Color.Blue;
            this.btnlogin.Location = new System.Drawing.Point(911, 554);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(81, 23);
            this.btnlogin.TabIndex = 6;
            this.btnlogin.Text = "back to login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnsign
            // 
            this.btnsign.BackColor = System.Drawing.Color.White;
            this.btnsign.ForeColor = System.Drawing.Color.Blue;
            this.btnsign.Location = new System.Drawing.Point(911, 583);
            this.btnsign.Name = "btnsign";
            this.btnsign.Size = new System.Drawing.Size(94, 23);
            this.btnsign.TabIndex = 7;
            this.btnsign.Text = "back to sign up";
            this.btnsign.UseVisualStyleBackColor = false;
            this.btnsign.Click += new System.EventHandler(this.btnsign_Click);
            // 
            // welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmployeeManagement.Properties.Resources.Modern_v__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.btnsign);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btndisplay1rec);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndisplay);
            this.Controls.Add(this.btnadd);
            this.DoubleBuffered = true;
            this.Name = "welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "welcome";
            this.Load += new System.EventHandler(this.welcome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndisplay1rec;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnsign;
    }
}