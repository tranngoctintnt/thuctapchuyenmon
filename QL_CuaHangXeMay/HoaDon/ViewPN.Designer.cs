
namespace QL_CuaHangXeMay.HoaDon
{
    partial class ViewPN
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
            this.DataSetPN = new QL_CuaHangXeMay.HoaDon.DataSetPN();
            this.inPNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inPNTableAdapter = new QL_CuaHangXeMay.HoaDon.DataSetPNTableAdapters.inPNTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inPNBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetPN";
            reportDataSource1.Value = this.inPNBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QL_CuaHangXeMay.HoaDon.Report_PhieuNhap.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetPN
            // 
            this.DataSetPN.DataSetName = "DataSetPN";
            this.DataSetPN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inPNBindingSource
            // 
            this.inPNBindingSource.DataMember = "inPN";
            this.inPNBindingSource.DataSource = this.DataSetPN;
            // 
            // inPNTableAdapter
            // 
            this.inPNTableAdapter.ClearBeforeFill = true;
            // 
            // ViewPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ViewPN";
            this.Text = "ViewPN";
            this.Load += new System.EventHandler(this.ViewPN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inPNBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource inPNBindingSource;
        private DataSetPN DataSetPN;
        private DataSetPNTableAdapters.inPNTableAdapter inPNTableAdapter;
    }
}