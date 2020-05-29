namespace Workflow_Management_System
{
    partial class Employee_ViewQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_ViewQuery));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.workFlowDBDataSet6 = new Workflow_Management_System.WorkFlowDBDataSet6();
            this.queryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.queryTableAdapter = new Workflow_Management_System.WorkFlowDBDataSet6TableAdapters.QueryTableAdapter();
            this.queryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queryDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queryResolutionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.queryIdDataGridViewTextBoxColumn,
            this.taskIdDataGridViewTextBoxColumn,
            this.queryDateDataGridViewTextBoxColumn,
            this.queryDescriptionDataGridViewTextBoxColumn,
            this.queryResolutionDataGridViewTextBoxColumn,
            this.employeeIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.queryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(639, 173);
            this.dataGridView1.TabIndex = 23;
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
            this.panel1.TabIndex = 22;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(74, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Queries";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Your Employee ID:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(244, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 25;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(142, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 26);
            this.textBox1.TabIndex = 24;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(361, 301);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 32);
            this.button4.TabIndex = 27;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // workFlowDBDataSet6
            // 
            this.workFlowDBDataSet6.DataSetName = "WorkFlowDBDataSet6";
            this.workFlowDBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // queryBindingSource
            // 
            this.queryBindingSource.DataMember = "Query";
            this.queryBindingSource.DataSource = this.workFlowDBDataSet6;
            // 
            // queryTableAdapter
            // 
            this.queryTableAdapter.ClearBeforeFill = true;
            // 
            // queryIdDataGridViewTextBoxColumn
            // 
            this.queryIdDataGridViewTextBoxColumn.DataPropertyName = "Query_Id";
            this.queryIdDataGridViewTextBoxColumn.HeaderText = "Query_Id";
            this.queryIdDataGridViewTextBoxColumn.Name = "queryIdDataGridViewTextBoxColumn";
            this.queryIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taskIdDataGridViewTextBoxColumn
            // 
            this.taskIdDataGridViewTextBoxColumn.DataPropertyName = "Task_Id";
            this.taskIdDataGridViewTextBoxColumn.HeaderText = "Task_Id";
            this.taskIdDataGridViewTextBoxColumn.Name = "taskIdDataGridViewTextBoxColumn";
            this.taskIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // queryDateDataGridViewTextBoxColumn
            // 
            this.queryDateDataGridViewTextBoxColumn.DataPropertyName = "Query_Date";
            this.queryDateDataGridViewTextBoxColumn.HeaderText = "Query_Date";
            this.queryDateDataGridViewTextBoxColumn.Name = "queryDateDataGridViewTextBoxColumn";
            this.queryDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // queryDescriptionDataGridViewTextBoxColumn
            // 
            this.queryDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Query_Description";
            this.queryDescriptionDataGridViewTextBoxColumn.HeaderText = "Query_Description";
            this.queryDescriptionDataGridViewTextBoxColumn.Name = "queryDescriptionDataGridViewTextBoxColumn";
            this.queryDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // queryResolutionDataGridViewTextBoxColumn
            // 
            this.queryResolutionDataGridViewTextBoxColumn.DataPropertyName = "Query_Resolution";
            this.queryResolutionDataGridViewTextBoxColumn.HeaderText = "Query_Resolution";
            this.queryResolutionDataGridViewTextBoxColumn.Name = "queryResolutionDataGridViewTextBoxColumn";
            this.queryResolutionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "Employee_Id";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "Employee_Id";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            this.employeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Employee_ViewQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 341);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Name = "Employee_ViewQuery";
            this.Text = "Employee_ViewQuery";
            this.Load += new System.EventHandler(this.Employee_ViewQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private WorkFlowDBDataSet6 workFlowDBDataSet6;
        private System.Windows.Forms.BindingSource queryBindingSource;
        private WorkFlowDBDataSet6TableAdapters.QueryTableAdapter queryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn queryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn queryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn queryDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn queryResolutionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
    }
}