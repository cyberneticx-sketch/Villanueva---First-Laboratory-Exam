using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HomeSalesTrackingApplication
{
    partial class HomeSalesForm
    {
        private IContainer components = null;
        private Panel pnlHeader;
        private Label lblAppTitle;
        private Button btnSalespersonMenu;
        private Panel pnlSalespersonDropdown;
        private Panel pnlDropdownInner;
        private Label lblHeaderCaption;
        private Panel pnlCodeDanielle;
        private Panel pnlDanielleAccent;
        private Label lblGuideDanielle;
        private Panel pnlCodeEdward;
        private Panel pnlEdwardAccent;
        private Label lblGuideEdward;
        private Panel pnlCodeFatima;
        private Panel pnlFatimaAccent;
        private Label lblGuideFatima;
        private Panel pnlEntryCard;
        private Label lblEntryTitle;
        private Label lblSalesPersonInitial;
        private TextBox txtSalesPersonInitial;
        private Label lblAmountOfSale;
        private TextBox txtAmountOfSale;
        private Button Btn_Submit;
        private Button Btn_Clear;
        private Button Btn_SummaryReport;
        private Panel pnlDisplayCard;
        private Panel pnlDisplayHeader;
        private Label lblDisplayTitle;
        private Label lblDisplay;

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
            pnlHeader = new Panel();
            lblAppTitle = new Label();
            btnSalespersonMenu = new Button();
            pnlSalespersonDropdown = new Panel();
            pnlDropdownInner = new Panel();
            lblHeaderCaption = new Label();
            pnlCodeDanielle = new Panel();
            pnlDanielleAccent = new Panel();
            lblGuideDanielle = new Label();
            pnlCodeEdward = new Panel();
            pnlEdwardAccent = new Panel();
            lblGuideEdward = new Label();
            pnlCodeFatima = new Panel();
            pnlFatimaAccent = new Panel();
            lblGuideFatima = new Label();
            pnlEntryCard = new Panel();
            lblEntryTitle = new Label();
            lblSalesPersonInitial = new Label();
            txtSalesPersonInitial = new TextBox();
            lblAmountOfSale = new Label();
            txtAmountOfSale = new TextBox();
            Btn_Submit = new Button();
            Btn_Clear = new Button();
            Btn_SummaryReport = new Button();
            pnlDisplayCard = new Panel();
            pnlDisplayHeader = new Panel();
            lblDisplayTitle = new Label();
            lblDisplay = new Label();

            pnlHeader.SuspendLayout();
            pnlSalespersonDropdown.SuspendLayout();
            pnlDropdownInner.SuspendLayout();
            pnlCodeDanielle.SuspendLayout();
            pnlCodeEdward.SuspendLayout();
            pnlCodeFatima.SuspendLayout();
            pnlEntryCard.SuspendLayout();
            pnlDisplayCard.SuspendLayout();
            pnlDisplayHeader.SuspendLayout();
            SuspendLayout();

            //
            // pnlHeader
            //
            pnlHeader.BackColor = Color.FromArgb(24, 38, 65);
            pnlHeader.Controls.Add(btnSalespersonMenu);
            pnlHeader.Controls.Add(lblAppTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(580, 68);
            pnlHeader.TabIndex = 0;

            //
            // lblAppTitle
            //
            lblAppTitle.AutoSize = true;
            lblAppTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblAppTitle.ForeColor = Color.White;
            lblAppTitle.Location = new Point(24, 22);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(286, 25);
            lblAppTitle.TabIndex = 0;
            lblAppTitle.Text = "villanueva- First Laboratory Exam";

            //
            // btnSalespersonMenu
            //
            btnSalespersonMenu.AccessibleName = "Salesperson selection menu";
            btnSalespersonMenu.BackColor = Color.FromArgb(35, 51, 79);
            btnSalespersonMenu.Cursor = Cursors.Hand;
            btnSalespersonMenu.FlatAppearance.BorderColor = Color.FromArgb(59, 82, 122);
            btnSalespersonMenu.FlatAppearance.BorderSize = 1;
            btnSalespersonMenu.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 44, 68);
            btnSalespersonMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 66, 102);
            btnSalespersonMenu.FlatStyle = FlatStyle.Flat;
            btnSalespersonMenu.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSalespersonMenu.ForeColor = Color.White;
            btnSalespersonMenu.Location = new Point(354, 15);
            btnSalespersonMenu.Name = "btnSalespersonMenu";
            btnSalespersonMenu.Size = new Size(202, 38);
            btnSalespersonMenu.TabIndex = 1;
            btnSalespersonMenu.Text = "";
            btnSalespersonMenu.UseVisualStyleBackColor = false;
            btnSalespersonMenu.Click += BtnSalespersonMenu_Click;
            btnSalespersonMenu.Paint += BtnSalespersonMenu_Paint;

            //
            // pnlSalespersonDropdown
            //
            pnlSalespersonDropdown.BackColor = Color.FromArgb(59, 82, 122);
            pnlSalespersonDropdown.Controls.Add(pnlDropdownInner);
            pnlSalespersonDropdown.Location = new Point(316, 68);
            pnlSalespersonDropdown.Name = "pnlSalespersonDropdown";
            pnlSalespersonDropdown.Padding = new Padding(1);
            pnlSalespersonDropdown.Size = new Size(240, 0);
            pnlSalespersonDropdown.TabIndex = 3;
            pnlSalespersonDropdown.Visible = false;

            //
            // pnlDropdownInner
            //
            pnlDropdownInner.BackColor = Color.FromArgb(24, 38, 65);
            pnlDropdownInner.Controls.Add(pnlCodeFatima);
            pnlDropdownInner.Controls.Add(pnlCodeEdward);
            pnlDropdownInner.Controls.Add(pnlCodeDanielle);
            pnlDropdownInner.Controls.Add(lblHeaderCaption);
            pnlDropdownInner.Dock = DockStyle.Fill;
            pnlDropdownInner.Location = new Point(1, 1);
            pnlDropdownInner.Name = "pnlDropdownInner";
            pnlDropdownInner.Size = new Size(238, 0);
            pnlDropdownInner.TabIndex = 0;

            //
            // lblHeaderCaption
            //
            lblHeaderCaption.AutoSize = true;
            lblHeaderCaption.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblHeaderCaption.ForeColor = Color.FromArgb(147, 197, 253);
            lblHeaderCaption.Location = new Point(14, 10);
            lblHeaderCaption.Name = "lblHeaderCaption";
            lblHeaderCaption.Size = new Size(128, 13);
            lblHeaderCaption.TabIndex = 0;
            lblHeaderCaption.Text = "SALESPERSON CODES";

            //
            // pnlCodeDanielle
            //
            pnlCodeDanielle.BackColor = Color.FromArgb(35, 51, 79);
            pnlCodeDanielle.Controls.Add(lblGuideDanielle);
            pnlCodeDanielle.Controls.Add(pnlDanielleAccent);
            pnlCodeDanielle.Cursor = Cursors.Hand;
            pnlCodeDanielle.Location = new Point(14, 32);
            pnlCodeDanielle.Name = "pnlCodeDanielle";
            pnlCodeDanielle.Size = new Size(210, 42);
            pnlCodeDanielle.TabIndex = 1;

            pnlDanielleAccent.BackColor = Color.FromArgb(59, 130, 246);
            pnlDanielleAccent.Dock = DockStyle.Left;
            pnlDanielleAccent.Location = new Point(0, 0);
            pnlDanielleAccent.Name = "pnlDanielleAccent";
            pnlDanielleAccent.Size = new Size(4, 42);
            pnlDanielleAccent.TabIndex = 0;

            lblGuideDanielle.Dock = DockStyle.Fill;
            lblGuideDanielle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGuideDanielle.ForeColor = Color.FromArgb(241, 245, 249);
            lblGuideDanielle.Location = new Point(4, 0);
            lblGuideDanielle.Name = "lblGuideDanielle";
            lblGuideDanielle.Padding = new Padding(10, 0, 0, 0);
            lblGuideDanielle.Size = new Size(206, 42);
            lblGuideDanielle.TabIndex = 1;
            lblGuideDanielle.Text = "D - Danielle";
            lblGuideDanielle.TextAlign = ContentAlignment.MiddleLeft;

            //
            // pnlCodeEdward
            //
            pnlCodeEdward.BackColor = Color.FromArgb(35, 51, 79);
            pnlCodeEdward.Controls.Add(lblGuideEdward);
            pnlCodeEdward.Controls.Add(pnlEdwardAccent);
            pnlCodeEdward.Cursor = Cursors.Hand;
            pnlCodeEdward.Location = new Point(14, 80);
            pnlCodeEdward.Name = "pnlCodeEdward";
            pnlCodeEdward.Size = new Size(210, 42);
            pnlCodeEdward.TabIndex = 2;

            pnlEdwardAccent.BackColor = Color.FromArgb(56, 189, 248);
            pnlEdwardAccent.Dock = DockStyle.Left;
            pnlEdwardAccent.Location = new Point(0, 0);
            pnlEdwardAccent.Name = "pnlEdwardAccent";
            pnlEdwardAccent.Size = new Size(4, 42);
            pnlEdwardAccent.TabIndex = 0;

            lblGuideEdward.Dock = DockStyle.Fill;
            lblGuideEdward.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGuideEdward.ForeColor = Color.FromArgb(241, 245, 249);
            lblGuideEdward.Location = new Point(4, 0);
            lblGuideEdward.Name = "lblGuideEdward";
            lblGuideEdward.Padding = new Padding(10, 0, 0, 0);
            lblGuideEdward.Size = new Size(206, 42);
            lblGuideEdward.TabIndex = 1;
            lblGuideEdward.Text = "E - Edward";
            lblGuideEdward.TextAlign = ContentAlignment.MiddleLeft;

            //
            // pnlCodeFatima
            //
            pnlCodeFatima.BackColor = Color.FromArgb(35, 51, 79);
            pnlCodeFatima.Controls.Add(lblGuideFatima);
            pnlCodeFatima.Controls.Add(pnlFatimaAccent);
            pnlCodeFatima.Cursor = Cursors.Hand;
            pnlCodeFatima.Location = new Point(14, 128);
            pnlCodeFatima.Name = "pnlCodeFatima";
            pnlCodeFatima.Size = new Size(210, 42);
            pnlCodeFatima.TabIndex = 3;

            pnlFatimaAccent.BackColor = Color.FromArgb(20, 184, 166);
            pnlFatimaAccent.Dock = DockStyle.Left;
            pnlFatimaAccent.Location = new Point(0, 0);
            pnlFatimaAccent.Name = "pnlFatimaAccent";
            pnlFatimaAccent.Size = new Size(4, 42);
            pnlFatimaAccent.TabIndex = 0;

            lblGuideFatima.Dock = DockStyle.Fill;
            lblGuideFatima.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGuideFatima.ForeColor = Color.FromArgb(241, 245, 249);
            lblGuideFatima.Location = new Point(4, 0);
            lblGuideFatima.Name = "lblGuideFatima";
            lblGuideFatima.Padding = new Padding(10, 0, 0, 0);
            lblGuideFatima.Size = new Size(206, 42);
            lblGuideFatima.TabIndex = 1;
            lblGuideFatima.Text = "F - Fatima";
            lblGuideFatima.TextAlign = ContentAlignment.MiddleLeft;

            //
            // pnlEntryCard
            //
            pnlEntryCard.BackColor = Color.White;
            pnlEntryCard.BorderStyle = BorderStyle.FixedSingle;
            pnlEntryCard.Controls.Add(Btn_SummaryReport);
            pnlEntryCard.Controls.Add(Btn_Clear);
            pnlEntryCard.Controls.Add(Btn_Submit);
            pnlEntryCard.Controls.Add(txtAmountOfSale);
            pnlEntryCard.Controls.Add(lblAmountOfSale);
            pnlEntryCard.Controls.Add(txtSalesPersonInitial);
            pnlEntryCard.Controls.Add(lblSalesPersonInitial);
            pnlEntryCard.Controls.Add(lblEntryTitle);
            pnlEntryCard.Location = new Point(24, 86);
            pnlEntryCard.Name = "pnlEntryCard";
            pnlEntryCard.Size = new Size(532, 186);
            pnlEntryCard.TabIndex = 1;

            //
            // lblEntryTitle
            //
            lblEntryTitle.AutoSize = true;
            lblEntryTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblEntryTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblEntryTitle.Location = new Point(22, 14);
            lblEntryTitle.Name = "lblEntryTitle";
            lblEntryTitle.Size = new Size(168, 19);
            lblEntryTitle.TabIndex = 0;
            lblEntryTitle.Text = "Record Sale Transaction";

            //
            // lblSalesPersonInitial
            //
            lblSalesPersonInitial.Font = new Font("Segoe UI", 10F);
            lblSalesPersonInitial.ForeColor = Color.FromArgb(51, 65, 85);
            lblSalesPersonInitial.Location = new Point(22, 50);
            lblSalesPersonInitial.Name = "lblSalesPersonInitial";
            lblSalesPersonInitial.Size = new Size(190, 27);
            lblSalesPersonInitial.TabIndex = 1;
            lblSalesPersonInitial.Text = "Enter Sales Person Initial :";
            lblSalesPersonInitial.TextAlign = ContentAlignment.MiddleLeft;

            //
            // txtSalesPersonInitial
            //
            txtSalesPersonInitial.BackColor = Color.FromArgb(248, 250, 252);
            txtSalesPersonInitial.Font = new Font("Segoe UI", 10.5F);
            txtSalesPersonInitial.Location = new Point(222, 50);
            txtSalesPersonInitial.Name = "txtSalesPersonInitial";
            txtSalesPersonInitial.PlaceholderText = "D, E, or F";
            txtSalesPersonInitial.Size = new Size(286, 26);
            txtSalesPersonInitial.TabIndex = 0;

            //
            // lblAmountOfSale
            //
            lblAmountOfSale.Font = new Font("Segoe UI", 10F);
            lblAmountOfSale.ForeColor = Color.FromArgb(51, 65, 85);
            lblAmountOfSale.Location = new Point(22, 90);
            lblAmountOfSale.Name = "lblAmountOfSale";
            lblAmountOfSale.Size = new Size(190, 27);
            lblAmountOfSale.TabIndex = 2;
            lblAmountOfSale.Text = "Amount of Sale :";
            lblAmountOfSale.TextAlign = ContentAlignment.MiddleLeft;

            //
            // txtAmountOfSale
            //
            txtAmountOfSale.BackColor = Color.FromArgb(248, 250, 252);
            txtAmountOfSale.Font = new Font("Segoe UI", 10.5F);
            txtAmountOfSale.Location = new Point(222, 90);
            txtAmountOfSale.Name = "txtAmountOfSale";
            txtAmountOfSale.PlaceholderText = "e.g., 1500.00";
            txtAmountOfSale.Size = new Size(286, 26);
            txtAmountOfSale.TabIndex = 1;

            //
            // Btn_Submit
            //
            Btn_Submit.BackColor = Color.FromArgb(37, 99, 235);
            Btn_Submit.Cursor = Cursors.Hand;
            Btn_Submit.FlatAppearance.BorderSize = 0;
            Btn_Submit.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 64, 175);
            Btn_Submit.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            Btn_Submit.FlatStyle = FlatStyle.Flat;
            Btn_Submit.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            Btn_Submit.ForeColor = Color.White;
            Btn_Submit.Location = new Point(22, 132);
            Btn_Submit.Name = "Btn_Submit";
            Btn_Submit.Size = new Size(154, 38);
            Btn_Submit.TabIndex = 2;
            Btn_Submit.Text = "Submit";
            Btn_Submit.UseVisualStyleBackColor = false;
            Btn_Submit.Click += Btn_Submit_Click;

            //
            // Btn_Clear
            //
            Btn_Clear.BackColor = Color.FromArgb(226, 232, 240);
            Btn_Clear.Cursor = Cursors.Hand;
            Btn_Clear.FlatAppearance.BorderSize = 0;
            Btn_Clear.FlatAppearance.MouseDownBackColor = Color.FromArgb(148, 163, 184);
            Btn_Clear.FlatAppearance.MouseOverBackColor = Color.FromArgb(203, 213, 225);
            Btn_Clear.FlatStyle = FlatStyle.Flat;
            Btn_Clear.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            Btn_Clear.ForeColor = Color.FromArgb(30, 41, 59);
            Btn_Clear.Location = new Point(188, 132);
            Btn_Clear.Name = "Btn_Clear";
            Btn_Clear.Size = new Size(154, 38);
            Btn_Clear.TabIndex = 3;
            Btn_Clear.Text = "Clear";
            Btn_Clear.UseVisualStyleBackColor = false;
            Btn_Clear.Click += Btn_Clear_Click;

            //
            // Btn_SummaryReport
            //
            Btn_SummaryReport.BackColor = Color.FromArgb(24, 38, 65);
            Btn_SummaryReport.Cursor = Cursors.Hand;
            Btn_SummaryReport.FlatAppearance.BorderSize = 0;
            Btn_SummaryReport.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 23, 42);
            Btn_SummaryReport.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 57, 94);
            Btn_SummaryReport.FlatStyle = FlatStyle.Flat;
            Btn_SummaryReport.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            Btn_SummaryReport.ForeColor = Color.White;
            Btn_SummaryReport.Location = new Point(354, 132);
            Btn_SummaryReport.Name = "Btn_SummaryReport";
            Btn_SummaryReport.Size = new Size(154, 38);
            Btn_SummaryReport.TabIndex = 4;
            Btn_SummaryReport.Text = "Summary Report";
            Btn_SummaryReport.UseVisualStyleBackColor = false;
            Btn_SummaryReport.Click += Btn_SummaryReport_Click;

            //
            // pnlDisplayCard
            //
            pnlDisplayCard.BackColor = Color.FromArgb(15, 23, 42);
            pnlDisplayCard.BorderStyle = BorderStyle.FixedSingle;
            pnlDisplayCard.Controls.Add(lblDisplay);
            pnlDisplayCard.Controls.Add(pnlDisplayHeader);
            pnlDisplayCard.Location = new Point(24, 288);
            pnlDisplayCard.Name = "pnlDisplayCard";
            pnlDisplayCard.Size = new Size(532, 198);
            pnlDisplayCard.TabIndex = 2;

            //
            // pnlDisplayHeader
            //
            pnlDisplayHeader.BackColor = Color.FromArgb(30, 41, 59);
            pnlDisplayHeader.Controls.Add(lblDisplayTitle);
            pnlDisplayHeader.Dock = DockStyle.Top;
            pnlDisplayHeader.Location = new Point(0, 0);
            pnlDisplayHeader.Name = "pnlDisplayHeader";
            pnlDisplayHeader.Size = new Size(530, 32);
            pnlDisplayHeader.TabIndex = 0;

            //
            // lblDisplayTitle
            //
            lblDisplayTitle.AutoSize = true;
            lblDisplayTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblDisplayTitle.ForeColor = Color.FromArgb(148, 163, 184);
            lblDisplayTitle.Location = new Point(14, 9);
            lblDisplayTitle.Name = "lblDisplayTitle";
            lblDisplayTitle.Size = new Size(280, 15);
            lblDisplayTitle.TabIndex = 0;
            lblDisplayTitle.Text = "TRANSACTION CONFIRMATION & RUNNING TOTALS";
            lblDisplayTitle.UseMnemonic = false;

            //
            // lblDisplay
            //
            lblDisplay.AutoSize = false;
            lblDisplay.BackColor = Color.FromArgb(15, 23, 42);
            lblDisplay.Dock = DockStyle.Fill;
            lblDisplay.Font = new Font("Consolas", 10F);
            lblDisplay.ForeColor = Color.FromArgb(248, 250, 252);
            lblDisplay.Location = new Point(0, 32);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Padding = new Padding(14, 12, 14, 12);
            lblDisplay.Size = new Size(530, 164);
            lblDisplay.TabIndex = 1;
            lblDisplay.Text = "";
            lblDisplay.TextAlign = ContentAlignment.TopLeft;
            lblDisplay.UseMnemonic = false;

            //
            // HomeSalesForm
            //
            AcceptButton = Btn_Submit;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(580, 504);
            Controls.Add(pnlSalespersonDropdown);
            Controls.Add(pnlDisplayCard);
            Controls.Add(pnlEntryCard);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "HomeSalesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "villanueva- First Laboratory Exam";

            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlDropdownInner.ResumeLayout(false);
            pnlDropdownInner.PerformLayout();
            pnlSalespersonDropdown.ResumeLayout(false);
            pnlCodeDanielle.ResumeLayout(false);
            pnlCodeEdward.ResumeLayout(false);
            pnlCodeFatima.ResumeLayout(false);
            pnlEntryCard.ResumeLayout(false);
            pnlEntryCard.PerformLayout();
            pnlDisplayHeader.ResumeLayout(false);
            pnlDisplayHeader.PerformLayout();
            pnlDisplayCard.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
