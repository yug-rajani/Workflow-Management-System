namespace Workflow_Management_System
{
    partial class Manager_ManageTasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager_ManageTasks));
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.workFlowDBDataSet11 = new Workflow_Management_System.WorkFlowDBDataSet11();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskTableAdapter = new Workflow_Management_System.WorkFlowDBDataSet11TableAdapters.TaskTableAdapter();
            this.taskIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignedToUserIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignedByUserIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskDefinitionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskDeadlineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDBDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(555, 9);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 63);
            this.button6.TabIndex = 9;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskIdDataGridViewTextBoxColumn,
            this.projectIdDataGridViewTextBoxColumn,
            this.assignedToUserIdDataGridViewTextBoxColumn,
            this.assignedByUserIdDataGridViewTextBoxColumn,
            this.taskDefinitionDataGridViewTextBoxColumn,
            this.taskStartDateDataGridViewTextBoxColumn,
            this.taskDeadlineDataGridViewTextBoxColumn,
            this.taskStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.taskBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(639, 173);
            this.dataGridView1.TabIndex = 30;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(70, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 26);
            this.textBox1.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(558, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 32;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 80);
            this.panel1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(74, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 34;
            this.label2.Text = "Search:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(297, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 33;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // workFlowDBDataSet11
            // 
            this.workFlowDBDataSet11.DataSetName = "WorkFlowDBDataSet11";
            this.workFlowDBDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataMember = "Task";
            this.taskBindingSource.DataSource = this.workFlowDBDataSet11;
            // 
            // taskTableAdapter
            // 
            this.taskTableAdapter.ClearBeforeFill = true;
            // 
            // taskIdDataGridViewTextBoxColumn
            // 
            this.taskIdDataGridViewTextBoxColumn.DataPropertyName = "Task_Id";
            this.taskIdDataGridViewTextBoxColumn.HeaderText = "Task_Id";
            this.taskIdDataGridViewTextBoxColumn.Name = "taskIdDataGridViewTextBoxColumn";
            this.taskIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // projectIdDataGridViewTextBoxColumn
            // 
            this.projectIdDataGridViewTextBoxColumn.DataPropertyName = "Project_Id";
            this.projectIdDataGridViewTextBoxColumn.HeaderText = "Project_Id";
            this.projectIdDataGridViewTextBoxColumn.Name = "projectIdDataGridViewTextBoxColumn";
            // 
            // assignedToUserIdDataGridViewTextBoxColumn
            // 
            this.assignedToUserIdDataGridViewTextBoxColumn.DataPropertyName = "AssignedTo_User_Id";
            this.assignedToUserIdDataGridViewTextBoxColumn.HeaderText = "AssignedTo_User_Id";
            this.assignedToUserIdDataGridViewTextBoxColumn.Name = "assignedToUserIdDataGridViewTextBoxColumn";
            // 
            // assignedByUserIdDataGridViewTextBoxColumn
            // 
            this.assignedByUserIdDataGridViewTextBoxColumn.DataPropertyName = "AssignedBy_User_Id";
            this.assignedByUserIdDataGridViewTextBoxColumn.HeaderText = "AssignedBy_User_Id";
            this.assignedByUserIdDataGridViewTextBoxColumn.Name = "assignedByUserIdDataGridViewTextBoxColumn";
            // 
            // taskDefinitionDataGridViewTextBoxColumn
            // 
            this.taskDefinitionDataGridViewTextBoxColumn.DataPropertyName = "Task_Definition";
            this.taskDefinitionDataGridViewTextBoxColumn.HeaderText = "Task_Definition";
            this.taskDefinitionDataGridViewTextBoxColumn.Name = "taskDefinitionDataGridViewTextBoxColumn";
            // 
            // taskStartDateDataGridViewTextBoxColumn
            // 
            this.taskStartDateDataGridViewTextBoxColumn.DataPropertyName = "Task_StartDate";
            this.taskStartDateDataGridViewTextBoxColumn.HeaderText = "Task_StartDate";
            this.taskStartDateDataGridViewTextBoxColumn.Name = "taskStartDateDataGridViewTextBoxColumn";
            // 
            // taskDeadlineDataGridViewTextBoxColumn
            // 
            this.taskDeadlineDataGridViewTextBoxColumn.DataPropertyName = "Task_Deadline";
            this.taskDeadlineDataGridViewTextBoxColumn.HeaderText = "Task_Deadline";
            this.taskDeadlineDataGridViewTextBoxColumn.Name = "taskDeadlineDataGridViewTextBoxColumn";
            // 
            // taskStatusDataGridViewTextBoxColumn
            // 
            this.taskStatusDataGridViewTextBoxColumn.DataPropertyName = "Task_Status";
            this.taskStatusDataGridViewTextBoxColumn.HeaderText = "Task_Status";
            this.taskStatusDataGridViewTextBoxColumn.Name = "taskStatusDataGridViewTextBoxColumn";
            // 
            // Manager_ManageTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 341);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Name = "Manager_ManageTasks";
            this.Text = "Manager_ManageTasks";
            this.Load += new System.EventHandler(this.Manager_ManageTasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDBDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private WorkFlowDBDataSet11 workFlowDBDataSet11;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private WorkFlowDBDataSet11TableAdapters.TaskTableAdapter taskTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignedToUserIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignedByUserIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskDefinitionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskDeadlineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskStatusDataGridViewTextBoxColumn;
    }
}