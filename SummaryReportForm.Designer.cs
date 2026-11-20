using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HomeSalesTrackingApplication
{
    partial class SummaryReportForm
    {
        private IContainer components = null;
        private Panel pnlReportHeader;
        private Label lblReportTitle;
        private Label lblReportDate;
        private Panel pnlGrandTotalCard;
        private Panel pnlGrandTotalAccent;
        private Label lblGrandTotalCaption;
        private Label lblGrandTotal;
        private Panel pnlTopSellerCard;
        private Panel pnlTopSellerAccent;
        private Label lblTopSellerCaption;
        private Label lblTopSeller;
        private Label lblBreakdownHeading;
        private Panel pnlDanielleCard;
        private Label lblDanielleName;
        private Label lblDanielleShare;
        private Label lblDanielleTotal;
        private Panel pnlDanielleTrack;
        private Panel pnlDanielleBar;
        private Panel pnlEdwardCard;
        private Label lblEdwardName;
        private Label lblEdwardShare;
        private Label lblEdwardTotal;
        private Panel pnlEdwardTrack;
        private Panel pnlEdwardBar;
        private Panel pnlFatimaCard;
        private Label lblFatimaName;
        private Label lblFatimaShare;
        private Label lblFatimaTotal;
        private Panel pnlFatimaTrack;
        private Panel pnlFatimaBar;
        private Button Btn_Close;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlReportHeader = new Panel();
            lblReportDate = new Label();
            lblReportTitle = new Label();
            pnlGrandTotalCard = new Panel();
            pnlGrandTotalAccent = new Panel();
            lblGrandTotalCaption = new Label();
            lblGrandTotal = new Label();
            pnlTopSellerCard = new Panel();
            pnlTopSellerAccent = new Panel();
            lblTopSellerCaption = new Label();
            lblTopSeller = new Label();
            lblBreakdownHeading = new Label();
            pnlDanielleCard = new Panel();
            lblDanielleName = new Label();
            lblDanielleShare = new Label();
            lblDanielleTotal = new Label();
            pnlDanielleTrack = new Panel();
            pnlDanielleBar = new Panel();
            pnlEdwardCard = new Panel();
            lblEdwardName = new Label();
            lblEdwardShare = new Label();
            lblEdwardTotal = new Label();
            pnlEdwardTrack = new Panel();
            pnlEdwardBar = new Panel();
            pnlFatimaCard = new Panel();
            lblFatimaName = new Label();
            lblFatimaShare = new Label();
            lblFatimaTotal = new Label();
            pnlFatimaTrack = new Panel();
            pnlFatimaBar = new Panel();
            Btn_Close = new Button();

            pnlReportHeader.SuspendLayout();
            pnlGrandTotalCard.SuspendLayout();
            pnlTopSellerCard.SuspendLayout();
            pnlDanielleCard.SuspendLayout();
            pnlDanielleTrack.SuspendLayout();
            pnlEdwardCard.SuspendLayout();
            pnlEdwardTrack.SuspendLayout();
            pnlFatimaCard.SuspendLayout();
            pnlFatimaTrack.SuspendLayout();
            SuspendLayout();

            //
            // pnlReportHeader
            //
            pnlReportHeader.BackColor = Color.FromArgb(24, 38, 65);
            pnlReportHeader.Controls.Add(lblReportDate);
            pnlReportHeader.Controls.Add(lblReportTitle);
            pnlReportHeader.Dock = DockStyle.Top;
            pnlReportHeader.Location = new Point(0, 0);
            pnlReportHeader.Name = "pnlReportHeader";
            pnlReportHeader.Size = new Size(540, 82);
            pnlReportHeader.TabIndex = 0;

            lblReportTitle.AutoSize = true;
            lblReportTitle.Font = new Font("Segoe UI", 14.5F, FontStyle.Bold);
            lblReportTitle.ForeColor = Color.White;
            lblReportTitle.Location = new Point(24, 14);
            lblReportTitle.Name = "lblReportTitle";
            lblReportTitle.Size = new Size(275, 26);
            lblReportTitle.TabIndex = 0;
            lblReportTitle.Text = "villanueva- First Laboratory Exam";

            lblReportDate.AutoSize = true;
            lblReportDate.Font = new Font("Segoe UI", 9F);
            lblReportDate.ForeColor = Color.FromArgb(203, 213, 225);
            lblReportDate.Location = new Point(24, 48);
            lblReportDate.Name = "lblReportDate";
            lblReportDate.Size = new Size(180, 15);
            lblReportDate.TabIndex = 1;
            lblReportDate.Text = "Generated:";

            //
            // pnlGrandTotalCard
            //
            pnlGrandTotalCard.BackColor = Color.White;
            pnlGrandTotalCard.BorderStyle = BorderStyle.FixedSingle;
            pnlGrandTotalCard.Controls.Add(lblGrandTotal);
            pnlGrandTotalCard.Controls.Add(lblGrandTotalCaption);
            pnlGrandTotalCard.Controls.Add(pnlGrandTotalAccent);
            pnlGrandTotalCard.Location = new Point(24, 100);
            pnlGrandTotalCard.Name = "pnlGrandTotalCard";
            pnlGrandTotalCard.Size = new Size(220, 78);
            pnlGrandTotalCard.TabIndex = 1;

            pnlGrandTotalAccent.BackColor = Color.FromArgb(37, 99, 235);
            pnlGrandTotalAccent.Dock = DockStyle.Left;
            pnlGrandTotalAccent.Location = new Point(0, 0);
            pnlGrandTotalAccent.Name = "pnlGrandTotalAccent";
            pnlGrandTotalAccent.Size = new Size(4, 76);
            pnlGrandTotalAccent.TabIndex = 0;

            lblGrandTotalCaption.AutoSize = true;
            lblGrandTotalCaption.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblGrandTotalCaption.ForeColor = Color.FromArgb(100, 116, 139);
            lblGrandTotalCaption.Location = new Point(16, 12);
            lblGrandTotalCaption.Name = "lblGrandTotalCaption";
            lblGrandTotalCaption.Size = new Size(125, 13);
            lblGrandTotalCaption.TabIndex = 1;
            lblGrandTotalCaption.Text = "GRAND TOTAL SALES";

            lblGrandTotal.Font = new Font("Segoe UI", 14.5F, FontStyle.Bold);
            lblGrandTotal.ForeColor = Color.FromArgb(37, 99, 235);
            lblGrandTotal.Location = new Point(16, 32);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(192, 32);
            lblGrandTotal.TabIndex = 2;
            lblGrandTotal.Text = "0.00";
            lblGrandTotal.TextAlign = ContentAlignment.MiddleLeft;

            //
            // pnlTopSellerCard
            //
            pnlTopSellerCard.BackColor = Color.White;
            pnlTopSellerCard.BorderStyle = BorderStyle.FixedSingle;
            pnlTopSellerCard.Controls.Add(lblTopSeller);
            pnlTopSellerCard.Controls.Add(lblTopSellerCaption);
            pnlTopSellerCard.Controls.Add(pnlTopSellerAccent);
            pnlTopSellerCard.Location = new Point(256, 100);
            pnlTopSellerCard.Name = "pnlTopSellerCard";
            pnlTopSellerCard.Size = new Size(260, 78);
            pnlTopSellerCard.TabIndex = 2;

            pnlTopSellerAccent.BackColor = Color.FromArgb(13, 148, 136);
            pnlTopSellerAccent.Dock = DockStyle.Left;
            pnlTopSellerAccent.Location = new Point(0, 0);
            pnlTopSellerAccent.Name = "pnlTopSellerAccent";
            pnlTopSellerAccent.Size = new Size(4, 76);
            pnlTopSellerAccent.TabIndex = 0;

            lblTopSellerCaption.AutoSize = true;
            lblTopSellerCaption.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblTopSellerCaption.ForeColor = Color.FromArgb(100, 116, 139);
            lblTopSellerCaption.Location = new Point(16, 12);
            lblTopSellerCaption.Name = "lblTopSellerCaption";
            lblTopSellerCaption.Size = new Size(105, 13);
            lblTopSellerCaption.TabIndex = 1;
            lblTopSellerCaption.Text = "TOP SALESPERSON";

            lblTopSeller.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTopSeller.ForeColor = Color.FromArgb(15, 118, 110);
            lblTopSeller.Location = new Point(16, 31);
            lblTopSeller.Name = "lblTopSeller";
            lblTopSeller.Size = new Size(232, 38);
            lblTopSeller.TabIndex = 2;
            lblTopSeller.Text = "No sales recorded yet";
            lblTopSeller.TextAlign = ContentAlignment.MiddleLeft;

            //
            // lblBreakdownHeading
            //
            lblBreakdownHeading.AutoSize = true;
            lblBreakdownHeading.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBreakdownHeading.ForeColor = Color.FromArgb(51, 65, 85);
            lblBreakdownHeading.Location = new Point(24, 194);
            lblBreakdownHeading.Name = "lblBreakdownHeading";
            lblBreakdownHeading.Size = new Size(160, 19);
            lblBreakdownHeading.TabIndex = 3;
            lblBreakdownHeading.Text = "Salesperson Breakdown";

            //
            // pnlDanielleCard
            //
            pnlDanielleCard.BackColor = Color.White;
            pnlDanielleCard.BorderStyle = BorderStyle.FixedSingle;
            pnlDanielleCard.Controls.Add(pnlDanielleTrack);
            pnlDanielleCard.Controls.Add(lblDanielleTotal);
            pnlDanielleCard.Controls.Add(lblDanielleShare);
            pnlDanielleCard.Controls.Add(lblDanielleName);
            pnlDanielleCard.Location = new Point(24, 220);
            pnlDanielleCard.Name = "pnlDanielleCard";
            pnlDanielleCard.Size = new Size(492, 66);
            pnlDanielleCard.TabIndex = 4;

            lblDanielleName.AutoSize = true;
            lblDanielleName.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblDanielleName.ForeColor = Color.FromArgb(30, 41, 59);
            lblDanielleName.Location = new Point(16, 12);
            lblDanielleName.Name = "lblDanielleName";
            lblDanielleName.Size = new Size(92, 19);
            lblDanielleName.TabIndex = 0;
            lblDanielleName.Text = "D - Danielle";

            lblDanielleShare.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblDanielleShare.ForeColor = Color.FromArgb(37, 99, 235);
            lblDanielleShare.Location = new Point(228, 12);
            lblDanielleShare.Name = "lblDanielleShare";
            lblDanielleShare.Size = new Size(76, 20);
            lblDanielleShare.TabIndex = 1;
            lblDanielleShare.Text = "0.0%";
            lblDanielleShare.TextAlign = ContentAlignment.MiddleRight;

            lblDanielleTotal.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblDanielleTotal.ForeColor = Color.FromArgb(15, 23, 42);
            lblDanielleTotal.Location = new Point(312, 11);
            lblDanielleTotal.Name = "lblDanielleTotal";
            lblDanielleTotal.Size = new Size(162, 22);
            lblDanielleTotal.TabIndex = 2;
            lblDanielleTotal.Text = "0.00";
            lblDanielleTotal.TextAlign = ContentAlignment.MiddleRight;

            pnlDanielleTrack.BackColor = Color.FromArgb(226, 232, 240);
            pnlDanielleTrack.Controls.Add(pnlDanielleBar);
            pnlDanielleTrack.Location = new Point(16, 42);
            pnlDanielleTrack.Name = "pnlDanielleTrack";
            pnlDanielleTrack.Size = new Size(458, 10);
            pnlDanielleTrack.TabIndex = 3;

            pnlDanielleBar.BackColor = Color.FromArgb(37, 99, 235);
            pnlDanielleBar.Location = new Point(0, 0);
            pnlDanielleBar.Name = "pnlDanielleBar";
            pnlDanielleBar.Size = new Size(0, 10);
            pnlDanielleBar.TabIndex = 0;

            //
            // pnlEdwardCard
            //
            pnlEdwardCard.BackColor = Color.White;
            pnlEdwardCard.BorderStyle = BorderStyle.FixedSingle;
            pnlEdwardCard.Controls.Add(pnlEdwardTrack);
            pnlEdwardCard.Controls.Add(lblEdwardTotal);
            pnlEdwardCard.Controls.Add(lblEdwardShare);
            pnlEdwardCard.Controls.Add(lblEdwardName);
            pnlEdwardCard.Location = new Point(24, 296);
            pnlEdwardCard.Name = "pnlEdwardCard";
            pnlEdwardCard.Size = new Size(492, 66);
            pnlEdwardCard.TabIndex = 5;

            lblEdwardName.AutoSize = true;
            lblEdwardName.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblEdwardName.ForeColor = Color.FromArgb(30, 41, 59);
            lblEdwardName.Location = new Point(16, 12);
            lblEdwardName.Name = "lblEdwardName";
            lblEdwardName.Size = new Size(88, 19);
            lblEdwardName.TabIndex = 0;
            lblEdwardName.Text = "E - Edward";

            lblEdwardShare.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblEdwardShare.ForeColor = Color.FromArgb(2, 132, 199);
            lblEdwardShare.Location = new Point(228, 12);
            lblEdwardShare.Name = "lblEdwardShare";
            lblEdwardShare.Size = new Size(76, 20);
            lblEdwardShare.TabIndex = 1;
            lblEdwardShare.Text = "0.0%";
            lblEdwardShare.TextAlign = ContentAlignment.MiddleRight;

            lblEdwardTotal.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblEdwardTotal.ForeColor = Color.FromArgb(15, 23, 42);
            lblEdwardTotal.Location = new Point(312, 11);
            lblEdwardTotal.Name = "lblEdwardTotal";
            lblEdwardTotal.Size = new Size(162, 22);
            lblEdwardTotal.TabIndex = 2;
            lblEdwardTotal.Text = "0.00";
            lblEdwardTotal.TextAlign = ContentAlignment.MiddleRight;

            pnlEdwardTrack.BackColor = Color.FromArgb(226, 232, 240);
            pnlEdwardTrack.Controls.Add(pnlEdwardBar);
            pnlEdwardTrack.Location = new Point(16, 42);
            pnlEdwardTrack.Name = "pnlEdwardTrack";
            pnlEdwardTrack.Size = new Size(458, 10);
            pnlEdwardTrack.TabIndex = 3;

            pnlEdwardBar.BackColor = Color.FromArgb(2, 132, 199);
            pnlEdwardBar.Location = new Point(0, 0);
            pnlEdwardBar.Name = "pnlEdwardBar";
            pnlEdwardBar.Size = new Size(0, 10);
            pnlEdwardBar.TabIndex = 0;

            //
            // pnlFatimaCard
            //
            pnlFatimaCard.BackColor = Color.White;
            pnlFatimaCard.BorderStyle = BorderStyle.FixedSingle;
            pnlFatimaCard.Controls.Add(pnlFatimaTrack);
            pnlFatimaCard.Controls.Add(lblFatimaTotal);
            pnlFatimaCard.Controls.Add(lblFatimaShare);
            pnlFatimaCard.Controls.Add(lblFatimaName);
            pnlFatimaCard.Location = new Point(24, 372);
            pnlFatimaCard.Name = "pnlFatimaCard";
            pnlFatimaCard.Size = new Size(492, 66);
            pnlFatimaCard.TabIndex = 6;

            lblFatimaName.AutoSize = true;
            lblFatimaName.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblFatimaName.ForeColor = Color.FromArgb(30, 41, 59);
            lblFatimaName.Location = new Point(16, 12);
            lblFatimaName.Name = "lblFatimaName";
            lblFatimaName.Size = new Size(84, 19);
            lblFatimaName.TabIndex = 0;
            lblFatimaName.Text = "F - Fatima";

            lblFatimaShare.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblFatimaShare.ForeColor = Color.FromArgb(13, 148, 136);
            lblFatimaShare.Location = new Point(228, 12);
            lblFatimaShare.Name = "lblFatimaShare";
            lblFatimaShare.Size = new Size(76, 20);
            lblFatimaShare.TabIndex = 1;
            lblFatimaShare.Text = "0.0%";
            lblFatimaShare.TextAlign = ContentAlignment.MiddleRight;

            lblFatimaTotal.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblFatimaTotal.ForeColor = Color.FromArgb(15, 23, 42);
            lblFatimaTotal.Location = new Point(312, 11);
            lblFatimaTotal.Name = "lblFatimaTotal";
            lblFatimaTotal.Size = new Size(162, 22);
            lblFatimaTotal.TabIndex = 2;
            lblFatimaTotal.Text = "0.00";
            lblFatimaTotal.TextAlign = ContentAlignment.MiddleRight;

            pnlFatimaTrack.BackColor = Color.FromArgb(226, 232, 240);
            pnlFatimaTrack.Controls.Add(pnlFatimaBar);
            pnlFatimaTrack.Location = new Point(16, 42);
            pnlFatimaTrack.Name = "pnlFatimaTrack";
            pnlFatimaTrack.Size = new Size(458, 10);
            pnlFatimaTrack.TabIndex = 3;

            pnlFatimaBar.BackColor = Color.FromArgb(13, 148, 136);
            pnlFatimaBar.Location = new Point(0, 0);
            pnlFatimaBar.Name = "pnlFatimaBar";
            pnlFatimaBar.Size = new Size(0, 10);
            pnlFatimaBar.TabIndex = 0;

            //
            // Btn_Close
            //
            Btn_Close.BackColor = Color.FromArgb(24, 38, 65);
            Btn_Close.Cursor = Cursors.Hand;
            Btn_Close.FlatAppearance.BorderSize = 0;
            Btn_Close.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 23, 42);
            Btn_Close.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 57, 94);
            Btn_Close.FlatStyle = FlatStyle.Flat;
            Btn_Close.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            Btn_Close.ForeColor = Color.White;
            Btn_Close.Location = new Point(396, 456);
            Btn_Close.Name = "Btn_Close";
            Btn_Close.Size = new Size(120, 38);
            Btn_Close.TabIndex = 7;
            Btn_Close.Text = "Close";
            Btn_Close.UseVisualStyleBackColor = false;
            Btn_Close.Click += Btn_Close_Click;

            //
            // SummaryReportForm
            //
            AcceptButton = Btn_Close;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            CancelButton = Btn_Close;
            ClientSize = new Size(540, 512);
            Controls.Add(Btn_Close);
            Controls.Add(pnlFatimaCard);
            Controls.Add(pnlEdwardCard);
            Controls.Add(pnlDanielleCard);
            Controls.Add(lblBreakdownHeading);
            Controls.Add(pnlTopSellerCard);
            Controls.Add(pnlGrandTotalCard);
            Controls.Add(pnlReportHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SummaryReportForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "villanueva- First Laboratory Exam";

            pnlReportHeader.ResumeLayout(false);
            pnlReportHeader.PerformLayout();
            pnlGrandTotalCard.ResumeLayout(false);
            pnlGrandTotalCard.PerformLayout();
            pnlTopSellerCard.ResumeLayout(false);
            pnlTopSellerCard.PerformLayout();
            pnlDanielleTrack.ResumeLayout(false);
            pnlDanielleCard.ResumeLayout(false);
            pnlDanielleCard.PerformLayout();
            pnlEdwardTrack.ResumeLayout(false);
            pnlEdwardCard.ResumeLayout(false);
            pnlEdwardCard.PerformLayout();
            pnlFatimaTrack.ResumeLayout(false);
            pnlFatimaCard.ResumeLayout(false);
            pnlFatimaCard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
