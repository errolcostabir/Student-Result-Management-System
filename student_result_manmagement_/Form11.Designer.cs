namespace student_result_manmagement_
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.allresultDataSet1 = new student_result_manmagement_.allresultDataSet1();
            this.secompBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.secompTableAdapter = new student_result_manmagement_.allresultDataSet1TableAdapters.secompTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.allresultDataSet3 = new student_result_manmagement_.allresultDataSet3();
            this.compBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compTableAdapter = new student_result_manmagement_.allresultDataSet3TableAdapters.compTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.allresultDataSet4 = new student_result_manmagement_.allresultDataSet4();
            this.compBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.compTableAdapter1 = new student_result_manmagement_.allresultDataSet4TableAdapters.compTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rollNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.allresultDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secompBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allresultDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allresultDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // allresultDataSet1
            // 
            this.allresultDataSet1.DataSetName = "allresultDataSet1";
            this.allresultDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // secompBindingSource
            // 
            this.secompBindingSource.DataMember = "secomp";
            this.secompBindingSource.DataSource = this.allresultDataSet1;
            // 
            // secompTableAdapter
            // 
            this.secompTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(682, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(682, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Go Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(194, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "SE COMPUTER";
            // 
            // allresultDataSet3
            // 
            this.allresultDataSet3.DataSetName = "allresultDataSet3";
            this.allresultDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // compBindingSource
            // 
            this.compBindingSource.DataMember = "comp";
            this.compBindingSource.DataSource = this.allresultDataSet3;
            // 
            // compTableAdapter
            // 
            this.compTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.rollNumberDataGridViewTextBoxColumn,
            this.percentageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.compBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(92, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(445, 261);
            this.dataGridView1.TabIndex = 4;
            // 
            // allresultDataSet4
            // 
            this.allresultDataSet4.DataSetName = "allresultDataSet4";
            this.allresultDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // compBindingSource1
            // 
            this.compBindingSource1.DataMember = "comp";
            this.compBindingSource1.DataSource = this.allresultDataSet4;
            // 
            // compTableAdapter1
            // 
            this.compTableAdapter1.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rollNumberDataGridViewTextBoxColumn
            // 
            this.rollNumberDataGridViewTextBoxColumn.DataPropertyName = "Roll Number";
            this.rollNumberDataGridViewTextBoxColumn.HeaderText = "Roll Number";
            this.rollNumberDataGridViewTextBoxColumn.Name = "rollNumberDataGridViewTextBoxColumn";
            this.rollNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // percentageDataGridViewTextBoxColumn
            // 
            this.percentageDataGridViewTextBoxColumn.DataPropertyName = "Percentage";
            this.percentageDataGridViewTextBoxColumn.HeaderText = "Percentage";
            this.percentageDataGridViewTextBoxColumn.Name = "percentageDataGridViewTextBoxColumn";
            this.percentageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form11";
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allresultDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secompBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allresultDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allresultDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private allresultDataSet1 allresultDataSet1;
        private System.Windows.Forms.BindingSource secompBindingSource;
        private allresultDataSet1TableAdapters.secompTableAdapter secompTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private allresultDataSet3 allresultDataSet3;
        private System.Windows.Forms.BindingSource compBindingSource;
        private allresultDataSet3TableAdapters.compTableAdapter compTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private allresultDataSet4 allresultDataSet4;
        private System.Windows.Forms.BindingSource compBindingSource1;
        private allresultDataSet4TableAdapters.compTableAdapter compTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentageDataGridViewTextBoxColumn;
    }
}