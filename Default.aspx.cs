using E_Procurement_PO.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Procurement_PO
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //load the report on page load
            this.InitializeReportData();
        }

        /// <summary>
        /// Initializes the report data.
        /// </summary>
        protected void InitializeReportData()
        {
            //show the report
            CIDRZPurchaseOrder report = new CIDRZPurchaseOrder();


            this.ASPxWebDocumentViewer1.Report = report;
            this.ASPxWebDocumentViewer1.DataBind();
        }
    }
}