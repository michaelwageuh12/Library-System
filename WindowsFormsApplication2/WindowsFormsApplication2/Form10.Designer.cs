namespace WindowsFormsApplication2
{
    partial class Form10
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
            this.button1 = new System.Windows.Forms.Button();
            this.libraryDataSet3 = new WindowsFormsApplication2.LibraryDataSet3();
            this.bOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKTableAdapter = new WindowsFormsApplication2.LibraryDataSet3TableAdapters.BOOKTableAdapter();
            this.bOOKBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.libraryDataSet5 = new WindowsFormsApplication2.LibraryDataSet5();
            this.libraryDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKCATEGORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOK_CATEGORYTableAdapter = new WindowsFormsApplication2.LibraryDataSet5TableAdapters.BOOK_CATEGORYTableAdapter();
            this.bOOKIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORYNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKCATEGORYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back to Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // libraryDataSet3
            // 
            this.libraryDataSet3.DataSetName = "LibraryDataSet3";
            this.libraryDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bOOKBindingSource
            // 
            this.bOOKBindingSource.DataMember = "BOOK";
            this.bOOKBindingSource.DataSource = this.libraryDataSet3;
            // 
            // bOOKTableAdapter
            // 
            this.bOOKTableAdapter.ClearBeforeFill = true;
            // 
            // bOOKBindingSource1
            // 
            this.bOOKBindingSource1.DataMember = "BOOK";
            this.bOOKBindingSource1.DataSource = this.libraryDataSet3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bOOKIDDataGridViewTextBoxColumn,
            this.bOOKNAMEDataGridViewTextBoxColumn,
            this.cATEGORYNAMEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bOOKCATEGORYBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(129, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 151);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // libraryDataSet5
            // 
            this.libraryDataSet5.DataSetName = "LibraryDataSet5";
            this.libraryDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libraryDataSet5BindingSource
            // 
            this.libraryDataSet5BindingSource.DataSource = this.libraryDataSet5;
            this.libraryDataSet5BindingSource.Position = 0;
            // 
            // bOOKCATEGORYBindingSource
            // 
            this.bOOKCATEGORYBindingSource.DataMember = "BOOK CATEGORY";
            this.bOOKCATEGORYBindingSource.DataSource = this.libraryDataSet5;
            // 
            // bOOK_CATEGORYTableAdapter
            // 
            this.bOOK_CATEGORYTableAdapter.ClearBeforeFill = true;
            // 
            // bOOKIDDataGridViewTextBoxColumn
            // 
            this.bOOKIDDataGridViewTextBoxColumn.DataPropertyName = "BOOKID";
            this.bOOKIDDataGridViewTextBoxColumn.HeaderText = "BOOKID";
            this.bOOKIDDataGridViewTextBoxColumn.Name = "bOOKIDDataGridViewTextBoxColumn";
            // 
            // bOOKNAMEDataGridViewTextBoxColumn
            // 
            this.bOOKNAMEDataGridViewTextBoxColumn.DataPropertyName = "BOOKNAME";
            this.bOOKNAMEDataGridViewTextBoxColumn.HeaderText = "BOOKNAME";
            this.bOOKNAMEDataGridViewTextBoxColumn.Name = "bOOKNAMEDataGridViewTextBoxColumn";
            // 
            // cATEGORYNAMEDataGridViewTextBoxColumn
            // 
            this.cATEGORYNAMEDataGridViewTextBoxColumn.DataPropertyName = "CATEGORYNAME";
            this.cATEGORYNAMEDataGridViewTextBoxColumn.HeaderText = "CATEGORYNAME";
            this.cATEGORYNAMEDataGridViewTextBoxColumn.Name = "cATEGORYNAMEDataGridViewTextBoxColumn";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 185);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form10";
            this.Text = "Books Information";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKCATEGORYBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private LibraryDataSet3 libraryDataSet3;
        private System.Windows.Forms.BindingSource bOOKBindingSource;
        private LibraryDataSet3TableAdapters.BOOKTableAdapter bOOKTableAdapter;
        private System.Windows.Forms.BindingSource bOOKBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource libraryDataSet5BindingSource;
        private LibraryDataSet5 libraryDataSet5;
        private System.Windows.Forms.BindingSource bOOKCATEGORYBindingSource;
        private LibraryDataSet5TableAdapters.BOOK_CATEGORYTableAdapter bOOK_CATEGORYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEGORYNAMEDataGridViewTextBoxColumn;
    }
}