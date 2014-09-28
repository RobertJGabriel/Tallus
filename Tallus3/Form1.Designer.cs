namespace Tallus3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label student_InformationLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label maleLabel;
            System.Windows.Forms.Label femaleLabel;
            System.Windows.Forms.Label passwordsLabel;
            System.Windows.Forms.Label pointsLabel;
            System.Windows.Forms.Label mugshot_locationLabel;
            this.tallusDatabaseDataSet = new Tallus3.TallusDatabaseDataSet();
            this.studentsinformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsinformationTableAdapter = new Tallus3.TallusDatabaseDataSetTableAdapters.StudentsinformationTableAdapter();
            this.tableAdapterManager = new Tallus3.TallusDatabaseDataSetTableAdapters.TableAdapterManager();
            this.studentsinformationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.studentsinformationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.student_InformationTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.maleCheckBox = new System.Windows.Forms.CheckBox();
            this.femaleCheckBox = new System.Windows.Forms.CheckBox();
            this.passwordsTextBox = new System.Windows.Forms.TextBox();
            this.pointsTextBox = new System.Windows.Forms.TextBox();
            this.mugshot_locationTextBox = new System.Windows.Forms.TextBox();
            student_InformationLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            maleLabel = new System.Windows.Forms.Label();
            femaleLabel = new System.Windows.Forms.Label();
            passwordsLabel = new System.Windows.Forms.Label();
            pointsLabel = new System.Windows.Forms.Label();
            mugshot_locationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tallusDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsinformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsinformationBindingNavigator)).BeginInit();
            this.studentsinformationBindingNavigator.SuspendLayout();
            this.SuspendLayout();
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
            this.tableAdapterManager.StudentsinformationTableAdapter = this.studentsinformationTableAdapter;
            this.tableAdapterManager.TeacherInformationTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Tallus3.TallusDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentsinformationBindingNavigator
            // 
            this.studentsinformationBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studentsinformationBindingNavigator.BindingSource = this.studentsinformationBindingSource;
            this.studentsinformationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studentsinformationBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studentsinformationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.studentsinformationBindingNavigatorSaveItem});
            this.studentsinformationBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.studentsinformationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studentsinformationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studentsinformationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studentsinformationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studentsinformationBindingNavigator.Name = "studentsinformationBindingNavigator";
            this.studentsinformationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studentsinformationBindingNavigator.Size = new System.Drawing.Size(387, 25);
            this.studentsinformationBindingNavigator.TabIndex = 0;
            this.studentsinformationBindingNavigator.Text = "bindingNavigator1";
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
            // studentsinformationBindingNavigatorSaveItem
            // 
            this.studentsinformationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studentsinformationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studentsinformationBindingNavigatorSaveItem.Image")));
            this.studentsinformationBindingNavigatorSaveItem.Name = "studentsinformationBindingNavigatorSaveItem";
            this.studentsinformationBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.studentsinformationBindingNavigatorSaveItem.Text = "Save Data";
            this.studentsinformationBindingNavigatorSaveItem.Click += new System.EventHandler(this.studentsinformationBindingNavigatorSaveItem_Click);
            // 
            // student_InformationLabel
            // 
            student_InformationLabel.AutoSize = true;
            student_InformationLabel.Location = new System.Drawing.Point(155, 68);
            student_InformationLabel.Name = "student_InformationLabel";
            student_InformationLabel.Size = new System.Drawing.Size(102, 13);
            student_InformationLabel.TabIndex = 1;
            student_InformationLabel.Text = "Student-Information:";
            // 
            // student_InformationTextBox
            // 
            this.student_InformationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsinformationBindingSource, "Student-Information", true));
            this.student_InformationTextBox.Location = new System.Drawing.Point(263, 65);
            this.student_InformationTextBox.Name = "student_InformationTextBox";
            this.student_InformationTextBox.Size = new System.Drawing.Size(104, 20);
            this.student_InformationTextBox.TabIndex = 2;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(155, 94);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsinformationBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(263, 91);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(104, 20);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(155, 120);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsinformationBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(263, 117);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(104, 20);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(155, 146);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 7;
            addressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsinformationBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(263, 143);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(104, 20);
            this.addressTextBox.TabIndex = 8;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(155, 172);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(29, 13);
            ageLabel.TabIndex = 9;
            ageLabel.Text = "Age:";
            // 
            // ageTextBox
            // 
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsinformationBindingSource, "Age", true));
            this.ageTextBox.Location = new System.Drawing.Point(263, 169);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(104, 20);
            this.ageTextBox.TabIndex = 10;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(155, 198);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 11;
            phoneLabel.Text = "Phone:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsinformationBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(263, 195);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(104, 20);
            this.phoneTextBox.TabIndex = 12;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(155, 224);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsinformationBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(263, 221);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(104, 20);
            this.emailTextBox.TabIndex = 14;
            // 
            // maleLabel
            // 
            maleLabel.AutoSize = true;
            maleLabel.Location = new System.Drawing.Point(155, 252);
            maleLabel.Name = "maleLabel";
            maleLabel.Size = new System.Drawing.Size(33, 13);
            maleLabel.TabIndex = 15;
            maleLabel.Text = "Male:";
            // 
            // maleCheckBox
            // 
            this.maleCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.studentsinformationBindingSource, "Male", true));
            this.maleCheckBox.Location = new System.Drawing.Point(263, 247);
            this.maleCheckBox.Name = "maleCheckBox";
            this.maleCheckBox.Size = new System.Drawing.Size(104, 24);
            this.maleCheckBox.TabIndex = 16;
            this.maleCheckBox.Text = "checkBox1";
            this.maleCheckBox.UseVisualStyleBackColor = true;
            // 
            // femaleLabel
            // 
            femaleLabel.AutoSize = true;
            femaleLabel.Location = new System.Drawing.Point(155, 282);
            femaleLabel.Name = "femaleLabel";
            femaleLabel.Size = new System.Drawing.Size(44, 13);
            femaleLabel.TabIndex = 17;
            femaleLabel.Text = "Female:";
            // 
            // femaleCheckBox
            // 
            this.femaleCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.studentsinformationBindingSource, "Female", true));
            this.femaleCheckBox.Location = new System.Drawing.Point(263, 277);
            this.femaleCheckBox.Name = "femaleCheckBox";
            this.femaleCheckBox.Size = new System.Drawing.Size(104, 24);
            this.femaleCheckBox.TabIndex = 18;
            this.femaleCheckBox.Text = "checkBox1";
            this.femaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // passwordsLabel
            // 
            passwordsLabel.AutoSize = true;
            passwordsLabel.Location = new System.Drawing.Point(155, 310);
            passwordsLabel.Name = "passwordsLabel";
            passwordsLabel.Size = new System.Drawing.Size(61, 13);
            passwordsLabel.TabIndex = 19;
            passwordsLabel.Text = "Passwords:";
            // 
            // passwordsTextBox
            // 
            this.passwordsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsinformationBindingSource, "Passwords", true));
            this.passwordsTextBox.Location = new System.Drawing.Point(263, 307);
            this.passwordsTextBox.Name = "passwordsTextBox";
            this.passwordsTextBox.Size = new System.Drawing.Size(104, 20);
            this.passwordsTextBox.TabIndex = 20;
            // 
            // pointsLabel
            // 
            pointsLabel.AutoSize = true;
            pointsLabel.Location = new System.Drawing.Point(155, 336);
            pointsLabel.Name = "pointsLabel";
            pointsLabel.Size = new System.Drawing.Size(39, 13);
            pointsLabel.TabIndex = 21;
            pointsLabel.Text = "Points:";
            // 
            // pointsTextBox
            // 
            this.pointsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsinformationBindingSource, "Points", true));
            this.pointsTextBox.Location = new System.Drawing.Point(263, 333);
            this.pointsTextBox.Name = "pointsTextBox";
            this.pointsTextBox.Size = new System.Drawing.Size(104, 20);
            this.pointsTextBox.TabIndex = 22;
            // 
            // mugshot_locationLabel
            // 
            mugshot_locationLabel.AutoSize = true;
            mugshot_locationLabel.Location = new System.Drawing.Point(155, 362);
            mugshot_locationLabel.Name = "mugshot_locationLabel";
            mugshot_locationLabel.Size = new System.Drawing.Size(91, 13);
            mugshot_locationLabel.TabIndex = 23;
            mugshot_locationLabel.Text = "Mugshot-location:";
            // 
            // mugshot_locationTextBox
            // 
            this.mugshot_locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsinformationBindingSource, "Mugshot-location", true));
            this.mugshot_locationTextBox.Location = new System.Drawing.Point(263, 359);
            this.mugshot_locationTextBox.Name = "mugshot_locationTextBox";
            this.mugshot_locationTextBox.Size = new System.Drawing.Size(104, 20);
            this.mugshot_locationTextBox.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 399);
            this.Controls.Add(student_InformationLabel);
            this.Controls.Add(this.student_InformationTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(ageLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(maleLabel);
            this.Controls.Add(this.maleCheckBox);
            this.Controls.Add(femaleLabel);
            this.Controls.Add(this.femaleCheckBox);
            this.Controls.Add(passwordsLabel);
            this.Controls.Add(this.passwordsTextBox);
            this.Controls.Add(pointsLabel);
            this.Controls.Add(this.pointsTextBox);
            this.Controls.Add(mugshot_locationLabel);
            this.Controls.Add(this.mugshot_locationTextBox);
            this.Controls.Add(this.studentsinformationBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tallusDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsinformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsinformationBindingNavigator)).EndInit();
            this.studentsinformationBindingNavigator.ResumeLayout(false);
            this.studentsinformationBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TallusDatabaseDataSet tallusDatabaseDataSet;
        private System.Windows.Forms.BindingSource studentsinformationBindingSource;
        private TallusDatabaseDataSetTableAdapters.StudentsinformationTableAdapter studentsinformationTableAdapter;
        private TallusDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator studentsinformationBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton studentsinformationBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox student_InformationTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.CheckBox maleCheckBox;
        private System.Windows.Forms.CheckBox femaleCheckBox;
        private System.Windows.Forms.TextBox passwordsTextBox;
        private System.Windows.Forms.TextBox pointsTextBox;
        private System.Windows.Forms.TextBox mugshot_locationTextBox;
    }
}