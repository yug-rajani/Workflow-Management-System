namespace Workflow_Management_System
{
    partial class Manager_AssignEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager_AssignEmployee));
            this.taskTableAdapter = new Workflow_Management_System.WorkFlowDBDataSet11TableAdapters.TaskTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workFlowDBDataSet12 = new Workflow_Management_System.WorkFlowDBDataSet12();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new Workflow_Management_System.WorkFlowDBDataSet12TableAdapters.EmployeeTableAdapter();
            this.workFlowDBDataSet13 = new Workflow_Management_System.WorkFlowDBDataSet13();
            this.workFlowDBDataSet14 = new Workflow_Management_System.WorkFlowDBDataSet14();
            this.workFlowDBDataSet11 = new Workflow_Management_System.WorkFlowDBDataSet11();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.workFlowDBDataSet15 = new Workflow_Management_System.WorkFlowDBDataSet15();
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter1 = new Workflow_Management_System.WorkFlowDBDataSet15TableAdapters.EmployeeTableAdapter();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joiningDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDBDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDBDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDBDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDBDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDBDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // taskTableAdapter
            // 
            this.taskTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 80);
            this.panel1.TabIndex = 35;
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(555, 9);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 63);
            this.button6.TabIndex = 9;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(20, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 24);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(74, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assign Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "Search:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(70, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 26);
            this.textBox1.TabIndex = 37;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataMember = "Task";
            this.taskBindingSource.DataSource = this.workFlowDBDataSet11;
            // 
            // workFlowDBDataSet12
            // 
            this.workFlowDBDataSet12.DataSetName = "WorkFlowDBDataSet12";
            this.workFlowDBDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.workFlowDBDataSet12;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // workFlowDBDataSet13
            // 
            this.workFlowDBDataSet13.DataSetName = "WorkFlowDBDataSet13";
            this.workFlowDBDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workFlowDBDataSet14
            // 
            this.workFlowDBDataSet14.DataSetName = "WorkFlowDBDataSet14";
            this.workFlowDBDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workFlowDBDataSet11
            // 
            this.workFlowDBDataSet11.DataSetName = "WorkFlowDBDataSet11";
            this.workFlowDBDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.joiningDateDataGridViewTextBoxColumn,
            this.contactNoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.projectIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(639, 179);
            this.dataGridView1.TabIndex = 41;
            // 
            // workFlowDBDataSet15
            // 
            this.workFlowDBDataSet15.DataSetName = "WorkFlowDBDataSet15";
            this.workFlowDBDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataMember = "Employee";
            this.employeeBindingSource1.DataSource = this.workFlowDBDataSet15;
            // 
            // employeeTableAdapter1
            // 
            this.employeeTableAdapter1.ClearBeforeFill = true;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "Employee_Id";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "Employee_Id";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            this.employeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // joiningDateDataGridViewTextBoxColumn
            // 
            this.joiningDateDataGridViewTextBoxColumn.DataPropertyName = "Joining_Date";
            this.joiningDateDataGridViewTextBoxColumn.HeaderText = "Joining_Date";
            this.joiningDateDataGridViewTextBoxColumn.Name = "joiningDateDataGridViewTextBoxColumn";
            this.joiningDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // contactNoDataGridViewTextBoxColumn
            // 
            this.contactNoDataGridViewTextBoxColumn.DataPropertyName = "Contact_No";
            this.contactNoDataGridViewTextBoxColumn.HeaderText = "Contact_No";
            this.contactNoDataGridViewTextBoxColumn.Name = "contactNoDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // projectIdDataGridViewTextBoxColumn
            // 
            this.projectIdDataGridViewTextBoxColumn.DataPropertyName = "Project_Id";
            this.projectIdDataGridViewTextBoxColumn.HeaderText = "Project_Id";
            this.projectIdDataGridViewTextBoxColumn.Name = "projectIdDataGridViewTextBoxColumn";
            // 
            // Manager_AssignEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 341);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Name = "Manager_AssignEmployee";
            this.Text = "Manager_AssignEmployee";
            this.Load += new System.EventHandler(this.Manager_AssignEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDBDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDBDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDBDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDBDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDBDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WorkFlowDBDataSet11TableAdapters.TaskTableAdapter taskTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private WorkFlowDBDataSet12 workFlowDBDataSet12;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private WorkFlowDBDataSet12TableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private WorkFlowDBDataSet13 workFlowDBDataSet13;
        private WorkFlowDBDataSet14 workFlowDBDataSet14;
        private WorkFlowDBDataSet11 workFlowDBDataSet11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WorkFlowDBDataSet15 workFlowDBDataSet15;
        private System.Windows.Forms.BindingSource employeeBindingSource1;
        private WorkFlowDBDataSet15TableAdapters.EmployeeTableAdapter employeeTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn joiningDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectIdDataGridViewTextBoxColumn;
    }
}