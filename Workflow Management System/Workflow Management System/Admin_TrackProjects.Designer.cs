namespace Workflow_Management_System
{
    partial class Admin_TrackProjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_TrackProjects));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.projectIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectDeadlineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectDefinitionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workFlowDBDataSet4 = new Workflow_Management_System.WorkFlowDBDataSet4();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.projectTableAdapter = new Workflow_Management_System.WorkFlowDBDataSet4TableAdapters.ProjectTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDBDataSet4)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectIdDataGridViewTextBoxColumn,
            this.projectStatusDataGridViewTextBoxColumn,
            this.projectStartDateDataGridViewTextBoxColumn,
            this.projectDeadlineDataGridViewTextBoxColumn,
            this.projectDefinitionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.projectBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(639, 173);
            this.dataGridView1.TabIndex = 16;
            // 
            // projectIdDataGridViewTextBoxColumn
            // 
            this.projectIdDataGridViewTextBoxColumn.DataPropertyName = "Project_Id";
            this.projectIdDataGridViewTextBoxColumn.HeaderText = "Project_Id";
            this.projectIdDataGridViewTextBoxColumn.Name = "projectIdDataGridViewTextBoxColumn";
            this.projectIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // projectStatusDataGridViewTextBoxColumn
            // 
            this.projectStatusDataGridViewTextBoxColumn.DataPropertyName = "Project_Status";
            this.projectStatusDataGridViewTextBoxColumn.HeaderText = "Project_Status";
            this.projectStatusDataGridViewTextBoxColumn.Name = "projectStatusDataGridViewTextBoxColumn";
            // 
            // projectStartDateDataGridViewTextBoxColumn
            // 
            this.projectStartDateDataGridViewTextBoxColumn.DataPropertyName = "Project_StartDate";
            this.projectStartDateDataGridViewTextBoxColumn.HeaderText = "Project_StartDate";
            this.projectStartDateDataGridViewTextBoxColumn.Name = "projectStartDateDataGridViewTextBoxColumn";
            // 
            // projectDeadlineDataGridViewTextBoxColumn
            // 
            this.projectDeadlineDataGridViewTextBoxColumn.DataPropertyName = "Project_Deadline";
            this.projectDeadlineDataGridViewTextBoxColumn.HeaderText = "Project_Deadline";
            this.projectDeadlineDataGridViewTextBoxColumn.Name = "projectDeadlineDataGridViewTextBoxColumn";
            // 
            // projectDefinitionDataGridViewTextBoxColumn
            // 
            this.projectDefinitionDataGridViewTextBoxColumn.DataPropertyName = "Project_Definition";
            this.projectDefinitionDataGridViewTextBoxColumn.HeaderText = "Project_Definition";
            this.projectDefinitionDataGridViewTextBoxColumn.Name = "projectDefinitionDataGridViewTextBoxColumn";
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataMember = "Project";
            this.projectBindingSource.DataSource = this.workFlowDBDataSet4;
            // 
            // workFlowDBDataSet4
            // 
            this.workFlowDBDataSet4.DataSetName = "WorkFlowDBDataSet4";
            this.workFlowDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(70, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 26);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.panel1.TabIndex = 15;
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
            this.label1.Size = new System.Drawing.Size(121, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projects";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Search:";
            // 
            // projectTableAdapter
            // 
            this.projectTableAdapter.ClearBeforeFill = true;
            // 
            // Admin_TrackProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 341);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "Admin_TrackProjects";
            this.Text = "Admin_TrackProjects";
            this.Load += new System.EventHandler(this.Admin_TrackProjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDBDataSet4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private WorkFlowDBDataSet4 workFlowDBDataSet4;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private WorkFlowDBDataSet4TableAdapters.ProjectTableAdapter projectTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectDeadlineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectDefinitionDataGridViewTextBoxColumn;
    }
}