namespace WindowsFormsApplication2
{
    partial class Form9
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
            this.libraryDataSet1 = new WindowsFormsApplication2.LibraryDataSet1();
            this.mEMBERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEMBERTableAdapter = new WindowsFormsApplication2.LibraryDataSet1TableAdapters.MEMBERTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.libraryDataSet3 = new WindowsFormsApplication2.LibraryDataSet3();
            this.libraryDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEMBERBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mEMBERTableAdapter1 = new WindowsFormsApplication2.LibraryDataSet3TableAdapters.MEMBERTableAdapter();
            this.mEMBERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gENDERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROFESSIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOFRegisterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfExpireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBERBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back to Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // libraryDataSet1
            // 
            this.libraryDataSet1.DataSetName = "LibraryDataSet1";
            this.libraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mEMBERBindingSource
            // 
            this.mEMBERBindingSource.DataMember = "MEMBER";
            this.mEMBERBindingSource.DataSource = this.libraryDataSet1;
            // 
            // mEMBERTableAdapter
            // 
            this.mEMBERTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mEMBERIDDataGridViewTextBoxColumn,
            this.sSNDataGridViewTextBoxColumn,
            this.fNAMEDataGridViewTextBoxColumn,
            this.lNAMEDataGridViewTextBoxColumn,
            this.mNAMEDataGridViewTextBoxColumn,
            this.gENDERDataGridViewTextBoxColumn,
            this.pROFESSIONDataGridViewTextBoxColumn,
            this.aDDRESSDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.dateOFRegisterDataGridViewTextBoxColumn,
            this.dateOfExpireDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mEMBERBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(102, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(967, 237);
            this.dataGridView1.TabIndex = 2;
            // 
            // libraryDataSet3
            // 
            this.libraryDataSet3.DataSetName = "LibraryDataSet3";
            this.libraryDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libraryDataSet3BindingSource
            // 
            this.libraryDataSet3BindingSource.DataSource = this.libraryDataSet3;
            this.libraryDataSet3BindingSource.Position = 0;
            // 
            // mEMBERBindingSource1
            // 
            this.mEMBERBindingSource1.DataMember = "MEMBER";
            this.mEMBERBindingSource1.DataSource = this.libraryDataSet3BindingSource;
            // 
            // mEMBERTableAdapter1
            // 
            this.mEMBERTableAdapter1.ClearBeforeFill = true;
            // 
            // mEMBERIDDataGridViewTextBoxColumn
            // 
            this.mEMBERIDDataGridViewTextBoxColumn.DataPropertyName = "MEMBERID";
            this.mEMBERIDDataGridViewTextBoxColumn.HeaderText = "MEMBERID";
            this.mEMBERIDDataGridViewTextBoxColumn.Name = "mEMBERIDDataGridViewTextBoxColumn";
            // 
            // sSNDataGridViewTextBoxColumn
            // 
            this.sSNDataGridViewTextBoxColumn.DataPropertyName = "SSN";
            this.sSNDataGridViewTextBoxColumn.HeaderText = "SSN";
            this.sSNDataGridViewTextBoxColumn.Name = "sSNDataGridViewTextBoxColumn";
            // 
            // fNAMEDataGridViewTextBoxColumn
            // 
            this.fNAMEDataGridViewTextBoxColumn.DataPropertyName = "FNAME";
            this.fNAMEDataGridViewTextBoxColumn.HeaderText = "FNAME";
            this.fNAMEDataGridViewTextBoxColumn.Name = "fNAMEDataGridViewTextBoxColumn";
            // 
            // lNAMEDataGridViewTextBoxColumn
            // 
            this.lNAMEDataGridViewTextBoxColumn.DataPropertyName = "LNAME";
            this.lNAMEDataGridViewTextBoxColumn.HeaderText = "LNAME";
            this.lNAMEDataGridViewTextBoxColumn.Name = "lNAMEDataGridViewTextBoxColumn";
            // 
            // mNAMEDataGridViewTextBoxColumn
            // 
            this.mNAMEDataGridViewTextBoxColumn.DataPropertyName = "MNAME";
            this.mNAMEDataGridViewTextBoxColumn.HeaderText = "MNAME";
            this.mNAMEDataGridViewTextBoxColumn.Name = "mNAMEDataGridViewTextBoxColumn";
            // 
            // gENDERDataGridViewTextBoxColumn
            // 
            this.gENDERDataGridViewTextBoxColumn.DataPropertyName = "GENDER";
            this.gENDERDataGridViewTextBoxColumn.HeaderText = "GENDER";
            this.gENDERDataGridViewTextBoxColumn.Name = "gENDERDataGridViewTextBoxColumn";
            // 
            // pROFESSIONDataGridViewTextBoxColumn
            // 
            this.pROFESSIONDataGridViewTextBoxColumn.DataPropertyName = "PROFESSION";
            this.pROFESSIONDataGridViewTextBoxColumn.HeaderText = "PROFESSION";
            this.pROFESSIONDataGridViewTextBoxColumn.Name = "pROFESSIONDataGridViewTextBoxColumn";
            // 
            // aDDRESSDataGridViewTextBoxColumn
            // 
            this.aDDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.Name = "aDDRESSDataGridViewTextBoxColumn";
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "E_MAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "E_MAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            // 
            // dateOFRegisterDataGridViewTextBoxColumn
            // 
            this.dateOFRegisterDataGridViewTextBoxColumn.DataPropertyName = "DateOFRegister";
            this.dateOFRegisterDataGridViewTextBoxColumn.HeaderText = "DateOFRegister";
            this.dateOFRegisterDataGridViewTextBoxColumn.Name = "dateOFRegisterDataGridViewTextBoxColumn";
            // 
            // dateOfExpireDataGridViewTextBoxColumn
            // 
            this.dateOfExpireDataGridViewTextBoxColumn.DataPropertyName = "DateOfExpire";
            this.dateOfExpireDataGridViewTextBoxColumn.HeaderText = "DateOfExpire";
            this.dateOfExpireDataGridViewTextBoxColumn.Name = "dateOfExpireDataGridViewTextBoxColumn";
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 261);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form9";
            this.Text = "Members Information";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBERBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private LibraryDataSet1 libraryDataSet1;
        private System.Windows.Forms.BindingSource mEMBERBindingSource;
        private LibraryDataSet1TableAdapters.MEMBERTableAdapter mEMBERTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource libraryDataSet3BindingSource;
        private LibraryDataSet3 libraryDataSet3;
        private System.Windows.Forms.BindingSource mEMBERBindingSource1;
        private LibraryDataSet3TableAdapters.MEMBERTableAdapter mEMBERTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEMBERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gENDERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROFESSIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOFRegisterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfExpireDataGridViewTextBoxColumn;
    }
}