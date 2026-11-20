using System;
using System.Windows.Forms;

namespace HomeSalesTrackingApplication
{
    public partial class SummaryReportForm : Form
    {
        public SummaryReportForm(double danielleTotal, double edwardTotal, double fatimaTotal)
        {
            InitializeComponent();

            double grandTotal = danielleTotal + edwardTotal + fatimaTotal;

            lblReportDate.Text = $"Generated: {DateTime.Now:MMMM dd, yyyy  hh:mm tt}";
            lblGrandTotal.Text = $"{grandTotal:C2}";
            lblTopSeller.Text = GetTopSeller(danielleTotal, edwardTotal, fatimaTotal);

            UpdateAgentRow(danielleTotal, grandTotal, lblDanielleTotal, lblDanielleShare, pnlDanielleBar, pnlDanielleTrack);
            UpdateAgentRow(edwardTotal, grandTotal, lblEdwardTotal, lblEdwardShare, pnlEdwardBar, pnlEdwardTrack);
            UpdateAgentRow(fatimaTotal, grandTotal, lblFatimaTotal, lblFatimaShare, pnlFatimaBar, pnlFatimaTrack);
        }

        private static void UpdateAgentRow(
            double agentTotal,
            double grandTotal,
            Label lblTotal,
            Label lblShare,
            Panel pnlBar,
            Panel pnlTrack)
        {
            double share = grandTotal > 0 ? (agentTotal / grandTotal) * 100.0 : 0.0;
            lblTotal.Text = $"{agentTotal:C2}";
            lblShare.Text = $"{share:F1}%";

            int fillWidth = (int)Math.Round((share / 100.0) * pnlTrack.Width);
            if (agentTotal > 0 && fillWidth < 4)
            {
                fillWidth = 4;
            }
            pnlBar.Width = fillWidth;
        }

        private static string GetTopSeller(double danielle, double edward, double fatima)
        {
            double d = Math.Round(danielle, 2);
            double e = Math.Round(edward, 2);
            double f = Math.Round(fatima, 2);

            double highest = Math.Max(d, Math.Max(e, f));
            if (highest <= 0)
            {
                return "No sales recorded yet";
            }

            string winners = "";
            if (d == highest) winners += "Danielle (D), ";
            if (e == highest) winners += "Edward (E), ";
            if (f == highest) winners += "Fatima (F), ";

            return $"{winners.TrimEnd(',', ' ')} - {highest:C2}";
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
