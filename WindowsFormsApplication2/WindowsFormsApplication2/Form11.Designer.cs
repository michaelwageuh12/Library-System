namespace WindowsFormsApplication2
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LibraryDataSet8 = new WindowsFormsApplication2.LibraryDataSet8();
            this.MEMBERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MEMBERTableAdapter = new WindowsFormsApplication2.LibraryDataSet8TableAdapters.MEMBERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LibraryDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MEMBERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.MEMBERBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication2.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(39, 24);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(704, 375);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // LibraryDataSet8
            // 
            this.LibraryDataSet8.DataSetName = "LibraryDataSet8";
            this.LibraryDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MEMBERBindingSource
            // 
            this.MEMBERBindingSource.DataMember = "MEMBER";
            this.MEMBERBindingSource.DataSource = this.LibraryDataSet8;
            // 
            // MEMBERTableAdapter
            // 
            this.MEMBERTableAdapter.ClearBeforeFill = true;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 431);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form11";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LibraryDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MEMBERBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MEMBERBindingSource;
        private LibraryDataSet8 LibraryDataSet8;
        private LibraryDataSet8TableAdapters.MEMBERTableAdapter MEMBERTableAdapter;
    }
}