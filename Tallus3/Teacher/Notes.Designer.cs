namespace Tallus3.Teacher
{
    partial class Notes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notes));
            System.Windows.Forms.Label teacher_InformationLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label passwordsLabel;
            System.Windows.Forms.Label informationLabel;
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tallusDatabaseDataSet = new Tallus3.TallusDatabaseDataSet();
            this.teacherInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherInformationTableAdapter = new Tallus3.TallusDatabaseDataSetTableAdapters.TeacherInformationTableAdapter();
            this.tableAdapterManager = new Tallus3.TallusDatabaseDataSetTableAdapters.TableAdapterManager();
            this.teacherInformationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.teacherInformationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.teacher_InformationTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordsTextBox = new System.Windows.Forms.TextBox();
            this.informationTextBox = new System.Windows.Forms.TextBox();
            teacher_InformationLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            passwordsLabel = new System.Windows.Forms.Label();
            informationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tallusDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherInformationBindingNavigator)).BeginInit();
            this.teacherInformationBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(495, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(388, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tallusDatabaseDataSet
            // 
            this.tallusDatabaseDataSet.DataSetName = "TallusDatabaseDataSet";
            this.tallusDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Icons_ControlTableAdapter = null;
            this.tableAdapterManager.Icons_offTableAdapter = null;
            this.tableAdapterManager.notesTableAdapter = null;
            this.tableAdapterManager.StudentsinformationTableAdapter = null;
            this.tableAdapterManager.TeacherInformationTableAdapter = this.teacherInformationTableAdapter;
            this.tableAdapterManager.UpdateOrder = Tallus3.TallusDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // teacherInformationBindingNavigator
            // 
            this.teacherInformationBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.teacherInformationBindingNavigator.BindingSource = this.teacherInformationBindingSource;
            this.teacherInformationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.teacherInformationBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.teacherInformationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.teacherInformationBindingNavigatorSaveItem});
            this.teacherInformationBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.teacherInformationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.teacherInformationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.teacherInformationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.teacherInformationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.teacherInformationBindingNavigator.Name = "teacherInformationBindingNavigator";
            this.teacherInformationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.teacherInformationBindingNavigator.Size = new System.Drawing.Size(735, 25);
            this.teacherInformationBindingNavigator.TabIndex = 10;
            this.teacherInformationBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // teacherInformationBindingNavigatorSaveItem
            // 
            this.teacherInformationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.teacherInformationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("teacherInformationBindingNavigatorSaveItem.Image")));
            this.teacherInformationBindingNavigatorSaveItem.Name = "teacherInformationBindingNavigatorSaveItem";
            this.teacherInformationBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.teacherInformationBindingNavigatorSaveItem.Text = "Save Data";
            this.teacherInformationBindingNavigatorSaveItem.Click += new System.EventHandler(this.teacherInformationBindingNavigatorSaveItem_Click);
            // 
            // teacher_InformationLabel
            // 
            teacher_InformationLabel.AutoSize = true;
            teacher_InformationLabel.Location = new System.Drawing.Point(291, 83);
            teacher_InformationLabel.Name = "teacher_InformationLabel";
            teacher_InformationLabel.Size = new System.Drawing.Size(105, 13);
            teacher_InformationLabel.TabIndex = 10;
            teacher_InformationLabel.Text = "Teacher-Information:";
            // 
            // teacher_InformationTextBox
            // 
            this.teacher_InformationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherInformationBindingSource, "Teacher-Information", true));
            this.teacher_InformationTextBox.Location = new System.Drawing.Point(402, 80);
            this.teacher_InformationTextBox.Name = "teacher_InformationTextBox";
            this.teacher_InformationTextBox.Size = new System.Drawing.Size(100, 20);
            this.teacher_InformationTextBox.TabIndex = 11;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(291, 109);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 12;
            firstNameLabel.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherInformationBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(402, 106);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 13;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(291, 135);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 14;
            lastNameLabel.Text = "Last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherInformationBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(402, 132);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 15;
            // 
            // passwordsLabel
            // 
            passwordsLabel.AutoSize = true;
            passwordsLabel.Location = new System.Drawing.Point(291, 161);
            passwordsLabel.Name = "passwordsLabel";
            passwordsLabel.Size = new System.Drawing.Size(61, 13);
            passwordsLabel.TabIndex = 16;
            passwordsLabel.Text = "Passwords:";
            // 
            // passwordsTextBox
            // 
            this.passwordsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherInformationBindingSource, "Passwords", true));
            this.passwordsTextBox.Location = new System.Drawing.Point(402, 158);
            this.passwordsTextBox.Name = "passwordsTextBox";
            this.passwordsTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordsTextBox.TabIndex = 17;
            // 
            // informationLabel
            // 
            informationLabel.AutoSize = true;
            informationLabel.Location = new System.Drawing.Point(291, 187);
            informationLabel.Name = "informationLabel";
            informationLabel.Size = new System.Drawing.Size(61, 13);
            informationLabel.TabIndex = 18;
            informationLabel.Text = "information:";
            // 
            // informationTextBox
            // 
            this.informationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherInformationBindingSource, "information", true));
            this.informationTextBox.Location = new System.Drawing.Point(402, 184);
            this.informationTextBox.Name = "informationTextBox";
            this.informationTextBox.Size = new System.Drawing.Size(100, 20);
            this.informationTextBox.TabIndex = 19;
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 317);
            this.Controls.Add(teacher_InformationLabel);
            this.Controls.Add(this.teacher_InformationTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(passwordsLabel);
            this.Controls.Add(this.passwordsTextBox);
            this.Controls.Add(informationLabel);
            this.Controls.Add(this.informationTextBox);
            this.Controls.Add(this.teacherInformationBindingNavigator);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Notes";
            this.Text = "Notes";
            this.Load += new System.EventHandler(this.Notes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tallusDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherInformationBindingNavigator)).EndInit();
            this.teacherInformationBindingNavigator.ResumeLayout(false);
            this.teacherInformationBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private TallusDatabaseDataSet tallusDatabaseDataSet;
        private System.Windows.Forms.BindingSource teacherInformationBindingSource;
        private TallusDatabaseDataSetTableAdapters.TeacherInformationTableAdapter teacherInformationTableAdapter;
        private TallusDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator teacherInformationBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton teacherInformationBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox teacher_InformationTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox passwordsTextBox;
        private System.Windows.Forms.TextBox informationTextBox;
    }
}