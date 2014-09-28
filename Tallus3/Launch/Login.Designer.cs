namespace Tallus3
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
            this.components = new System.ComponentModel.Container();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tallusDatabaseDataSet = new Tallus3.TallusDatabaseDataSet();
            this.studentsinformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsinformationTableAdapter = new Tallus3.TallusDatabaseDataSetTableAdapters.StudentsinformationTableAdapter();
            this.tableAdapterManager = new Tallus3.TallusDatabaseDataSetTableAdapters.TableAdapterManager();
            this.icons_ControlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.icons_ControlTableAdapter = new Tallus3.TallusDatabaseDataSetTableAdapters.Icons_ControlTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.teacherInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherInformationTableAdapter = new Tallus3.TallusDatabaseDataSetTableAdapters.TeacherInformationTableAdapter();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tallusDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsinformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icons_ControlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(550, 182);
            this.panel3.MaximumSize = new System.Drawing.Size(234, 224);
            this.panel3.MinimumSize = new System.Drawing.Size(234, 224);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(234, 224);
            this.panel3.TabIndex = 11;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Tallus3.Properties.Resources.Talluslogo;
            this.pictureBox1.Location = new System.Drawing.Point(9, 3);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(221, 106);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(221, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 106);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Tallus3.Properties.Resources.mainheader;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(9, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 106);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Tallus3.Properties.Resources.mainheader;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 23);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sign In";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(202, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(171, 31);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(53, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Name";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(53, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(119, 21);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Password";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tallusDatabaseDataSet
            // 
            this.tallusDatabaseDataSet.DataSetName = "TallusDatabaseDataSet";
            this.tallusDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsinformationBindingSource
            // 
            this.studentsinformationBindingSource.DataMember = "Studentsinformation";
            this.studentsinformationBindingSource.DataSource = this.tallusDatabaseDataSet;
            // 
            // studentsinformationTableAdapter
            // 
            this.studentsinformationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Icons_ControlTableAdapter = null;
            this.tableAdapterManager.Icons_offTableAdapter = null;
            this.tableAdapterManager.notesTableAdapter = null;
            this.tableAdapterManager.StudentsinformationTableAdapter = this.studentsinformationTableAdapter;
            this.tableAdapterManager.TeacherInformationTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Tallus3.TallusDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // icons_ControlBindingSource
            // 
            this.icons_ControlBindingSource.DataMember = "Icons Control";
            this.icons_ControlBindingSource.DataSource = this.tallusDatabaseDataSet;
            // 
            // icons_ControlTableAdapter
            // 
            this.icons_ControlTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // teacherInformationBindingSource
            // 
            this.teacherInformationBindingSource.DataMember = "TeacherInformation";
            this.teacherInformationBindingSource.DataSource = this.tallusDatabaseDataSet;
            // 
            // teacherInformationTableAdapter
            // 
            this.teacherInformationTableAdapter.ClearBeforeFill = true;
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Tallus3.Properties.Resources.mainheader;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 709);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(873, 18);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tallus3.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(873, 727);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tallusDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsinformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icons_ControlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private TallusDatabaseDataSet tallusDatabaseDataSet;
        private System.Windows.Forms.BindingSource studentsinformationBindingSource;
        private TallusDatabaseDataSetTableAdapters.StudentsinformationTableAdapter studentsinformationTableAdapter;
        private TallusDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource icons_ControlBindingSource;
        private TallusDatabaseDataSetTableAdapters.Icons_ControlTableAdapter icons_ControlTableAdapter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource teacherInformationBindingSource;
        private TallusDatabaseDataSetTableAdapters.TeacherInformationTableAdapter teacherInformationTableAdapter;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox pictureBox2;

        public System.EventHandler timer2_Tick { get; set; }
    }
}

