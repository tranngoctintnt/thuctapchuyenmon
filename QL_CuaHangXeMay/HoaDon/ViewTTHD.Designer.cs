
namespace QL_CuaHangXeMay.HoaDon
{
    partial class ViewTTHD
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetHD = new QL_CuaHangXeMay.HoaDon.DataSetHD();
            this.inHdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inHdTableAdapter = new QL_CuaHangXeMay.HoaDon.DataSetHDTableAdapters.inHdTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inHdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetHD";
            reportDataSource1.Value = this.inHdBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QL_CuaHangXeMay.HoaDon.ReportHD.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetHD
            // 
            this.DataSetHD.DataSetName = "DataSetHD";
            this.DataSetHD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inHdBindingSource
            // 
            this.inHdBindingSource.DataMember = "inHd";
            this.inHdBindingSource.DataSource = this.DataSetHD;
            // 
            // inHdTableAdapter
            // 
            this.inHdTableAdapter.ClearBeforeFill = true;
            // 
            // ViewTTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ViewTTHD";
            this.Text = "ViewTTHD";
            this.Load += new System.EventHandler(this.ViewTTHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inHdBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource inHdBindingSource;
        private DataSetHD DataSetHD;
        private DataSetHDTableAdapters.inHdTableAdapter inHdTableAdapter;
    }
}