namespace EmployeeManagement
{
    partial class Display_all_Record
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
            this.dgvdisplay = new System.Windows.Forms.DataGridView();
            this.btnclosegridview = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.Button();
            this.deletename = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdisplay
            // 
            this.dgvdisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdisplay.Location = new System.Drawing.Point(39, 193);
            this.dgvdisplay.Name = "dgvdisplay";
            this.dgvdisplay.RowHeadersWidth = 51;
            this.dgvdisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdisplay.Size = new System.Drawing.Size(945, 297);
            this.dgvdisplay.TabIndex = 0;
            this.dgvdisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdisplay_CellContentClick);
            this.dgvdisplay.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdisplay_RowEnter);
            this.dgvdisplay.Click += new System.EventHandler(this.btnclosegridview_Click);
            // 
            // btnclosegridview
            // 
            this.btnclosegridview.Location = new System.Drawing.Point(944, 652);
            this.btnclosegridview.Name = "btnclosegridview";
            this.btnclosegridview.Size = new System.Drawing.Size(75, 23);
            this.btnclosegridview.TabIndex = 1;
            this.btnclosegridview.Text = "CLOSE";
            this.btnclosegridview.UseVisualStyleBackColor = true;
            this.btnclosegridview.Click += new System.EventHandler(this.btnclosegridview_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(436, 531);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 2;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Visible = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.Color.Tomato;
            this.view.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.ForeColor = System.Drawing.Color.White;
            this.view.Location = new System.Drawing.Point(640, 548);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(120, 38);
            this.view.TabIndex = 3;
            this.view.Text = "view";
            this.view.UseVisualStyleBackColor = false;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // deletename
            // 
            this.deletename.Location = new System.Drawing.Point(224, 534);
            this.deletename.Margin = new System.Windows.Forms.Padding(2);
            this.deletename.Name = "deletename";
            this.deletename.Size = new System.Drawing.Size(158, 20);
            this.deletename.TabIndex = 4;
            this.deletename.Visible = false;
            this.deletename.TextChanged += new System.EventHandler(this.deletename_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(845, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "CLOSE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Display_all_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmployeeManagement.Properties.Resources.Modern_v__2_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deletename);
            this.Controls.Add(this.view);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.btnclosegridview);
            this.Controls.Add(this.dgvdisplay);
            this.Name = "Display_all_Record";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display_all_Record";
            this.Load += new System.EventHandler(this.Display_all_Record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnclosegridview;
        public System.Windows.Forms.DataGridView dgvdisplay;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.TextBox deletename;
        private System.Windows.Forms.Button button1;
    }
}