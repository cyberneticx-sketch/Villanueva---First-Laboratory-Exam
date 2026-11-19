using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace HomeSalesTrackingApplication
{
    public partial class HomeSalesForm : Form
    {
        private static readonly Color DefaultMenuAccentColor = Color.FromArgb(147, 197, 253);
        private static readonly Color CardDefaultBackColor = Color.FromArgb(35, 51, 79);
        private static readonly Color CardHoverBackColor = Color.FromArgb(47, 68, 104);
        private static readonly Color CardSelectedBackColor = Color.FromArgb(43, 64, 100);
        private static readonly Color CardSelectedHoverBackColor = Color.FromArgb(53, 78, 120);

        // Class-level (global) variables to maintain running totals across clicks
        private double danielleTotal = 0;
        private double edwardTotal = 0;
        private double fatimaTotal = 0;

        private SalespersonOption[] salespersonOptions;
        private SalespersonOption selectedOption;
        private Timer dropdownTimer;
        private int dropdownExpandedHeight;
        private int dropdownAnimationStep;
        private bool isDropdownOpen;
        private int highlightedOptionIndex = -1;

        public HomeSalesForm()
        {
            InitializeComponent();
            InitializeSalespersonMenu();
            ActiveControl = txtSalesPersonInitial;
        }

        private sealed class SalespersonOption
        {
            public SalespersonOption(string code, string displayName, Color accentColor, Panel cardPanel, Label textLabel)
            {
                Code = code;
                DisplayName = displayName;
                AccentColor = accentColor;
                CardPanel = cardPanel;
                TextLabel = textLabel;
            }

            public string Code { get; }
            public string DisplayName { get; }
            public Color AccentColor { get; }
            public Panel CardPanel { get; }
            public Label TextLabel { get; }
            public bool IsHovered { get; set; }
        }

        private void InitializeSalespersonMenu()
        {
            components ??= new Container();
            dropdownTimer = new Timer(components)
            {
                Interval = 15
            };
            dropdownTimer.Tick += DropdownTimer_Tick;

            dropdownExpandedHeight = pnlCodeFatima.Bottom + lblHeaderCaption.Top + pnlSalespersonDropdown.Padding.Vertical;
            dropdownAnimationStep = Math.Max(16, dropdownExpandedHeight / 6);
            pnlSalespersonDropdown.Width = pnlCodeFatima.Right + pnlCodeFatima.Left + pnlSalespersonDropdown.Padding.Horizontal;

            salespersonOptions = new[]
            {
                new SalespersonOption("D", "D - Danielle", Color.FromArgb(59, 130, 246), pnlCodeDanielle, lblGuideDanielle),
                new SalespersonOption("E", "E - Edward", Color.FromArgb(56, 189, 248), pnlCodeEdward, lblGuideEdward),
                new SalespersonOption("F", "F - Fatima", Color.FromArgb(20, 184, 166), pnlCodeFatima, lblGuideFatima)
            };

            for (int i = 0; i < salespersonOptions.Length; i++)
            {
                SalespersonOption option = salespersonOptions[i];
                AttachOptionEvents(option);
            }

            txtSalesPersonInitial.TextChanged += TxtSalesPersonInitial_TextChanged;
            MouseDown += OutsideControl_MouseDown;
            Deactivate += (sender, e) => CloseSalespersonMenu();
            AttachCloseOnClickOutside(this);
            pnlSalespersonDropdown.BringToFront();
            RefreshOptionStyles();
        }

        private void AttachOptionEvents(SalespersonOption option)
        {
            option.TextLabel.Paint += (sender, e) => OptionLabel_Paint(option, e);

            void OnClick(object sender, EventArgs e) => SelectSalesperson(option);
            void OnEnter(object sender, EventArgs e)
            {
                if (!option.IsHovered)
                {
                    option.IsHovered = true;
                    highlightedOptionIndex = -1;
                    RefreshOptionStyles();
                }
            }
            void OnLeave(object sender, EventArgs e)
            {
                if (!option.CardPanel.ClientRectangle.Contains(option.CardPanel.PointToClient(Cursor.Position)))
                {
                    option.IsHovered = false;
                    RefreshOptionStyles();
                }
            }

            foreach (Control control in option.CardPanel.Controls)
            {
                control.Cursor = Cursors.Hand;
                control.Click += OnClick;
                control.MouseEnter += OnEnter;
                control.MouseLeave += OnLeave;
            }

            option.CardPanel.Click += OnClick;
            option.CardPanel.MouseEnter += OnEnter;
            option.CardPanel.MouseLeave += OnLeave;
        }

        private void AttachCloseOnClickOutside(Control root)
        {
            foreach (Control child in root.Controls)
            {
                if (child == btnSalespersonMenu || child == pnlSalespersonDropdown)
                {
                    continue;
                }

                child.MouseDown += OutsideControl_MouseDown;
                if (child.HasChildren)
                {
                    AttachCloseOnClickOutside(child);
                }
                else
                {
                    child.Enter += OutsideControl_Enter;
                }
            }
        }

        private void OutsideControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (isDropdownOpen)
            {
                CloseSalespersonMenu();
            }
        }

        private void OutsideControl_Enter(object sender, EventArgs e)
        {
            if (isDropdownOpen && !btnSalespersonMenu.Focused)
            {
                CloseSalespersonMenu();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (isDropdownOpen)
            {
                switch (keyData)
                {
                    case Keys.Escape:
                        CloseSalespersonMenu();
                        btnSalespersonMenu.Focus();
                        return true;

                    case Keys.Down:
                        highlightedOptionIndex = (highlightedOptionIndex + 1) % salespersonOptions.Length;
                        RefreshOptionStyles();
                        return true;

                    case Keys.Up:
                        highlightedOptionIndex = highlightedOptionIndex <= 0
                            ? salespersonOptions.Length - 1
                            : highlightedOptionIndex - 1;
                        RefreshOptionStyles();
                        return true;

                    case Keys.Enter:
                    case Keys.Space:
                        if (!txtSalesPersonInitial.Focused
                            && !txtAmountOfSale.Focused
                            && highlightedOptionIndex >= 0
                            && highlightedOptionIndex < salespersonOptions.Length)
                        {
                            SelectSalesperson(salespersonOptions[highlightedOptionIndex]);
                            return true;
                        }
                        break;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void BtnSalespersonMenu_Click(object sender, EventArgs e)
        {
            if (isDropdownOpen)
            {
                CloseSalespersonMenu();
            }
            else
            {
                OpenSalespersonMenu();
            }
        }

        private void OpenSalespersonMenu()
        {
            isDropdownOpen = true;
            highlightedOptionIndex = Array.IndexOf(salespersonOptions, selectedOption);
            pnlSalespersonDropdown.Location = new Point(
                btnSalespersonMenu.Right - pnlSalespersonDropdown.Width,
                pnlHeader.Bottom);
            pnlSalespersonDropdown.BringToFront();
            pnlSalespersonDropdown.Visible = true;
            btnSalespersonMenu.Focus();
            dropdownTimer.Start();
            btnSalespersonMenu.Invalidate();
            RefreshOptionStyles();
        }

        private void CloseSalespersonMenu()
        {
            if (!isDropdownOpen && !pnlSalespersonDropdown.Visible)
            {
                return;
            }

            isDropdownOpen = false;
            highlightedOptionIndex = -1;
            foreach (SalespersonOption option in salespersonOptions)
            {
                option.IsHovered = false;
            }

            dropdownTimer.Start();
            btnSalespersonMenu.Invalidate();
            RefreshOptionStyles();
        }

        private void DropdownTimer_Tick(object sender, EventArgs e)
        {
            int targetHeight = isDropdownOpen ? dropdownExpandedHeight : 0;
            int currentHeight = pnlSalespersonDropdown.Height;

            if (currentHeight == targetHeight)
            {
                dropdownTimer.Stop();
                if (!isDropdownOpen)
                {
                    pnlSalespersonDropdown.Visible = false;
                }
                return;
            }

            if (isDropdownOpen)
            {
                pnlSalespersonDropdown.Height = Math.Min(targetHeight, currentHeight + dropdownAnimationStep);
            }
            else
            {
                int nextHeight = Math.Max(0, currentHeight - dropdownAnimationStep);
                pnlSalespersonDropdown.Height = nextHeight;
                if (nextHeight == 0)
                {
                    pnlSalespersonDropdown.Visible = false;
                    dropdownTimer.Stop();
                }
            }
        }

        private void SelectSalesperson(SalespersonOption option)
        {
            txtSalesPersonInitial.Text = option.Code;
            CloseSalespersonMenu();
            txtAmountOfSale.Focus();
            txtAmountOfSale.SelectAll();
        }

        private void TxtSalesPersonInitial_TextChanged(object sender, EventArgs e)
        {
            SyncSelectedSalespersonFromText();
        }

        private void SyncSelectedSalespersonFromText()
        {
            string code = (txtSalesPersonInitial.Text ?? "").Trim().ToUpperInvariant();
            SalespersonOption matched = null;

            foreach (SalespersonOption option in salespersonOptions)
            {
                if (option.Code == code)
                {
                    matched = option;
                    break;
                }
            }

            if (selectedOption != matched)
            {
                selectedOption = matched;
                btnSalespersonMenu.Invalidate();
                RefreshOptionStyles();
            }
        }

        private void RefreshOptionStyles()
        {
            for (int i = 0; i < salespersonOptions.Length; i++)
            {
                SalespersonOption option = salespersonOptions[i];
                bool isSelected = option == selectedOption;
                bool isHighlighted = isSelected || i == highlightedOptionIndex;

                if (isHighlighted && option.IsHovered)
                {
                    option.CardPanel.BackColor = CardSelectedHoverBackColor;
                }
                else if (isHighlighted)
                {
                    option.CardPanel.BackColor = CardSelectedBackColor;
                }
                else if (option.IsHovered)
                {
                    option.CardPanel.BackColor = CardHoverBackColor;
                }
                else
                {
                    option.CardPanel.BackColor = CardDefaultBackColor;
                }

                option.CardPanel.Invalidate();
                option.TextLabel.Invalidate();
            }
        }

        private void BtnSalespersonMenu_Paint(object sender, PaintEventArgs e)
        {
            Rectangle bounds = btnSalespersonMenu.ClientRectangle;
            Color accentColor = selectedOption?.AccentColor ?? DefaultMenuAccentColor;
            float scale = Math.Max(1F, bounds.Height / 38F);
            int accentWidth = Math.Max(4, (int)Math.Round(4F * scale));

            // Left accent strip matching the salesperson card design
            using (SolidBrush accentBrush = new SolidBrush(accentColor))
            {
                e.Graphics.FillRectangle(accentBrush, new Rectangle(1, 1, accentWidth, bounds.Height - 2));
            }

            // Three-bar hamburger icon
            int iconX = accentWidth + Math.Max(9, (int)Math.Round(9F * scale));
            int iconWidth = Math.Max(14, (int)Math.Round(13F * scale));
            int barHeight = Math.Max(2, (int)Math.Round(2F * scale));
            int barStep = Math.Max(5, (int)Math.Round(5F * scale));
            int centerY = bounds.Height / 2;
            int topBarY = centerY - barStep - (barHeight / 2);
            using (SolidBrush iconBrush = new SolidBrush(accentColor))
            {
                e.Graphics.FillRectangle(iconBrush, iconX, topBarY, iconWidth, barHeight);
                e.Graphics.FillRectangle(iconBrush, iconX, topBarY + barStep, iconWidth, barHeight);
                e.Graphics.FillRectangle(iconBrush, iconX, topBarY + (barStep * 2), iconWidth, barHeight);
            }

            // Button text
            string labelText = selectedOption != null ? selectedOption.DisplayName : "Select Salesperson";
            Color textColor = selectedOption != null ? Color.White : Color.FromArgb(226, 232, 240);
            int textLeft = iconX + iconWidth + Math.Max(8, (int)Math.Round(8F * scale));
            int chevronMargin = Math.Max(26, (int)Math.Round(24F * scale));
            Rectangle textRect = new Rectangle(textLeft, 0, Math.Max(10, bounds.Width - textLeft - chevronMargin), bounds.Height);
            TextRenderer.DrawText(
                e.Graphics,
                labelText,
                btnSalespersonMenu.Font,
                textRect,
                textColor,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis | TextFormatFlags.NoPrefix);

            // Top-down / collapsed chevron
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            int chevronX = bounds.Width - Math.Max(16, (int)Math.Round(15F * scale));
            int chevronHalfW = Math.Max(4, (int)Math.Round(4F * scale));
            int chevronHalfH = Math.Max(2, (int)Math.Round(2F * scale));
            using Pen chevronPen = new Pen(Color.FromArgb(148, 163, 184), Math.Max(1.8F, 1.6F * scale))
            {
                StartCap = LineCap.Round,
                EndCap = LineCap.Round,
                LineJoin = LineJoin.Round
            };
            Point[] chevronPoints = isDropdownOpen
                ? new[]
                {
                    new Point(chevronX - chevronHalfW, centerY + chevronHalfH),
                    new Point(chevronX, centerY - chevronHalfH),
                    new Point(chevronX + chevronHalfW, centerY + chevronHalfH)
                }
                : new[]
                {
                    new Point(chevronX - chevronHalfW, centerY - chevronHalfH),
                    new Point(chevronX, centerY + chevronHalfH),
                    new Point(chevronX + chevronHalfW, centerY - chevronHalfH)
                };
            e.Graphics.DrawLines(chevronPen, chevronPoints);
        }

        private void OptionLabel_Paint(SalespersonOption option, PaintEventArgs e)
        {
            int index = Array.IndexOf(salespersonOptions, option);
            bool isSelected = option == selectedOption;
            bool isFocused = index == highlightedOptionIndex;

            if (isSelected || isFocused)
            {
                Color borderColor = isFocused
                    ? option.AccentColor
                    : Color.FromArgb(150, option.AccentColor);
                using Pen borderPen = new Pen(borderColor, 1F);
                int maxX = option.TextLabel.Width - 1;
                int maxY = option.TextLabel.Height - 1;
                e.Graphics.DrawLine(borderPen, 0, 0, maxX, 0);
                e.Graphics.DrawLine(borderPen, maxX, 0, maxX, maxY);
                e.Graphics.DrawLine(borderPen, 0, maxY, maxX, maxY);
            }

            if (!isSelected)
            {
                return;
            }

            float scale = Math.Max(1F, option.TextLabel.Height / 42F);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            int checkX = option.TextLabel.Width - Math.Max(22, (int)Math.Round(20F * scale));
            int checkY = option.TextLabel.Height / 2;
            using Pen checkPen = new Pen(option.AccentColor, Math.Max(2.2F, 2F * scale))
            {
                StartCap = LineCap.Round,
                EndCap = LineCap.Round,
                LineJoin = LineJoin.Round
            };
            e.Graphics.DrawLines(checkPen, new[]
            {
                new Point(checkX - (int)Math.Round(5F * scale), checkY),
                new Point(checkX - (int)Math.Round(1F * scale), checkY + (int)Math.Round(4F * scale)),
                new Point(checkX + (int)Math.Round(6F * scale), checkY - (int)Math.Round(4F * scale))
            });
        }

        private void getSalesPerson_Amount(String salesInitial, double salesAmount)
        {
            if (salesAmount <= 0 || double.IsNaN(salesAmount) || double.IsInfinity(salesAmount))
            {
                ShowInputError("Please enter a valid sale amount greater than zero.", txtAmountOfSale);
                return;
            }

            if (double.IsInfinity(danielleTotal + edwardTotal + fatimaTotal + salesAmount))
            {
                ShowInputError("The entered sale amount exceeds the maximum supported total.", txtAmountOfSale);
                return;
            }

            String initial = (salesInitial ?? "").Trim().ToUpper();
            String name;

            switch (initial)
            {
                case "D":
                    danielleTotal += salesAmount;
                    name = "Danielle";
                    break;

                case "E":
                    edwardTotal += salesAmount;
                    name = "Edward";
                    break;

                case "F":
                    fatimaTotal += salesAmount;
                    name = "Fatima";
                    break;

                default:
                    ShowInputError("Invalid salesperson initial. Please enter D, E, or F.", txtSalesPersonInitial);
                    return;
            }

            double grandTotal = danielleTotal + edwardTotal + fatimaTotal;

            lblDisplay.Text =
                $"Transaction Recorded: {name} ({initial}) - {salesAmount:C2}\n\n" +
                $"Running Totals:\n" +
                $"  D - Danielle : {danielleTotal:C2}\n" +
                $"  E - Edward   : {edwardTotal:C2}\n" +
                $"  F - Fatima   : {fatimaTotal:C2}\n" +
                $"  ----------------------------------------\n" +
                $"  Grand Total  : {grandTotal:C2}";

            txtSalesPersonInitial.Clear();
            txtAmountOfSale.Clear();
            txtSalesPersonInitial.Focus();
        }

        private void clearEntry()
        {
            txtSalesPersonInitial.Clear();
            txtAmountOfSale.Clear();
            lblDisplay.Text = "";
            txtSalesPersonInitial.Focus();
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSalesPersonInitial.Text))
                {
                    ShowInputError("Please enter a salesperson initial (D, E, or F).", txtSalesPersonInitial);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtAmountOfSale.Text))
                {
                    ShowInputError("Please enter the amount of sale.", txtAmountOfSale);
                    return;
                }

                if (!double.TryParse(txtAmountOfSale.Text.Trim(), out double amount))
                {
                    ShowInputError("Invalid amount. Please enter numbers only (e.g., 1500.00).", txtAmountOfSale);
                    return;
                }

                getSalesPerson_Amount(txtSalesPersonInitial.Text, amount);
            }
            catch (OverflowException)
            {
                ShowInputError("The entered sale amount is too large.", txtAmountOfSale);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An unexpected error occurred: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            clearEntry();
        }

        private void Btn_SummaryReport_Click(object sender, EventArgs e)
        {
            OpenSummaryReport();
        }

        private void OpenSummaryReport()
        {
            try
            {
                using SummaryReportForm reportForm = new SummaryReportForm(danielleTotal, edwardTotal, fatimaTotal);
                reportForm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to open the summary report: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private static void ShowInputError(String message, TextBox targetBox)
        {
            MessageBox.Show(message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            targetBox.Focus();
            targetBox.SelectAll();
        }
    }
}
