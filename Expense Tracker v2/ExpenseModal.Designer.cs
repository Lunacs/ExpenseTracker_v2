namespace Expense_Tracker_v2
{
    partial class ExpenseModal
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpenseModal));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties17 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties18 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties19 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties20 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties21 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties22 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties23 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties24 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.expenseDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.expense_category = new Bunifu.UI.WinForms.BunifuDropdown();
            this.expense_name = new Bunifu.UI.WinForms.BunifuTextBox();
            this.expense_addBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.expense_amount = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuFormCaptionButton1 = new Bunifu.UI.WinForms.BunifuFormCaptionButton();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.expense_description = new Bunifu.UI.WinForms.BunifuTextBox();
            this.SuspendLayout();
            // 
            // expenseDate
            // 
            this.expenseDate.BackColor = System.Drawing.Color.Transparent;
            this.expenseDate.BorderColor = System.Drawing.Color.Silver;
            this.expenseDate.BorderRadius = 10;
            this.expenseDate.Color = System.Drawing.Color.Silver;
            this.expenseDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.expenseDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.expenseDate.DisabledColor = System.Drawing.Color.Gray;
            this.expenseDate.DisplayWeekNumbers = false;
            this.expenseDate.DPHeight = 0;
            this.expenseDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.expenseDate.FillDatePicker = false;
            this.expenseDate.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseDate.ForeColor = System.Drawing.Color.Black;
            this.expenseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.expenseDate.Icon = ((System.Drawing.Image)(resources.GetObject("expenseDate.Icon")));
            this.expenseDate.IconColor = System.Drawing.Color.Gray;
            this.expenseDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.expenseDate.LeftTextMargin = 5;
            this.expenseDate.Location = new System.Drawing.Point(50, 81);
            this.expenseDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.expenseDate.MinimumSize = new System.Drawing.Size(4, 40);
            this.expenseDate.Name = "expenseDate";
            this.expenseDate.Size = new System.Drawing.Size(344, 40);
            this.expenseDate.TabIndex = 0;
            this.expenseDate.Value = new System.DateTime(2024, 12, 8, 15, 29, 54, 0);
            this.expenseDate.ValueChanged += new System.EventHandler(this.bunifuDatePicker1_ValueChanged);
            // 
            // expense_category
            // 
            this.expense_category.BackColor = System.Drawing.Color.Transparent;
            this.expense_category.BackgroundColor = System.Drawing.Color.White;
            this.expense_category.BorderColor = System.Drawing.Color.Silver;
            this.expense_category.BorderRadius = 10;
            this.expense_category.Color = System.Drawing.Color.Silver;
            this.expense_category.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.expense_category.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.expense_category.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.expense_category.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.expense_category.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.expense_category.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.expense_category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.expense_category.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.expense_category.DropDownHeight = 112;
            this.expense_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.expense_category.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.expense_category.FillDropDown = true;
            this.expense_category.FillIndicator = false;
            this.expense_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expense_category.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.expense_category.ForeColor = System.Drawing.Color.Black;
            this.expense_category.FormattingEnabled = true;
            this.expense_category.Icon = null;
            this.expense_category.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.expense_category.IndicatorColor = System.Drawing.Color.DarkGray;
            this.expense_category.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.expense_category.IndicatorThickness = 2;
            this.expense_category.IntegralHeight = false;
            this.expense_category.IsDropdownOpened = false;
            this.expense_category.ItemBackColor = System.Drawing.Color.White;
            this.expense_category.ItemBorderColor = System.Drawing.Color.White;
            this.expense_category.ItemForeColor = System.Drawing.Color.Black;
            this.expense_category.ItemHeight = 34;
            this.expense_category.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.expense_category.ItemHighLightForeColor = System.Drawing.Color.White;
            this.expense_category.ItemTopMargin = 3;
            this.expense_category.Location = new System.Drawing.Point(50, 163);
            this.expense_category.Name = "expense_category";
            this.expense_category.Size = new System.Drawing.Size(344, 40);
            this.expense_category.TabIndex = 1;
            this.expense_category.Text = null;
            this.expense_category.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.expense_category.TextLeftMargin = 5;
            // 
            // expense_name
            // 
            this.expense_name.AcceptsReturn = false;
            this.expense_name.AcceptsTab = false;
            this.expense_name.AnimationSpeed = 200;
            this.expense_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.expense_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.expense_name.AutoSizeHeight = true;
            this.expense_name.BackColor = System.Drawing.Color.Transparent;
            this.expense_name.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("expense_name.BackgroundImage")));
            this.expense_name.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.expense_name.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.expense_name.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.expense_name.BorderColorIdle = System.Drawing.Color.Silver;
            this.expense_name.BorderRadius = 20;
            this.expense_name.BorderThickness = 1;
            this.expense_name.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.expense_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.expense_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.expense_name.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.expense_name.DefaultText = "";
            this.expense_name.FillColor = System.Drawing.Color.White;
            this.expense_name.HideSelection = true;
            this.expense_name.IconLeft = null;
            this.expense_name.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.expense_name.IconPadding = 10;
            this.expense_name.IconRight = null;
            this.expense_name.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.expense_name.Lines = new string[0];
            this.expense_name.Location = new System.Drawing.Point(50, 245);
            this.expense_name.MaxLength = 32767;
            this.expense_name.MinimumSize = new System.Drawing.Size(1, 1);
            this.expense_name.Modified = false;
            this.expense_name.Multiline = false;
            this.expense_name.Name = "expense_name";
            stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.expense_name.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.expense_name.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.expense_name.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.expense_name.OnIdleState = stateProperties16;
            this.expense_name.Padding = new System.Windows.Forms.Padding(3);
            this.expense_name.PasswordChar = '\0';
            this.expense_name.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.expense_name.PlaceholderText = "Enter item name";
            this.expense_name.ReadOnly = false;
            this.expense_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.expense_name.SelectedText = "";
            this.expense_name.SelectionLength = 0;
            this.expense_name.SelectionStart = 0;
            this.expense_name.ShortcutsEnabled = true;
            this.expense_name.Size = new System.Drawing.Size(344, 43);
            this.expense_name.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.expense_name.TabIndex = 2;
            this.expense_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.expense_name.TextMarginBottom = 0;
            this.expense_name.TextMarginLeft = 3;
            this.expense_name.TextMarginTop = 1;
            this.expense_name.TextPlaceholder = "Enter item name";
            this.expense_name.UseSystemPasswordChar = false;
            this.expense_name.WordWrap = true;
            this.expense_name.TextChanged += new System.EventHandler(this.bunifuTextBox1_TextChanged);
            // 
            // expense_addBtn
            // 
            this.expense_addBtn.AllowAnimations = true;
            this.expense_addBtn.AllowMouseEffects = true;
            this.expense_addBtn.AllowToggling = false;
            this.expense_addBtn.AnimationSpeed = 200;
            this.expense_addBtn.AutoGenerateColors = false;
            this.expense_addBtn.AutoRoundBorders = false;
            this.expense_addBtn.AutoSizeLeftIcon = true;
            this.expense_addBtn.AutoSizeRightIcon = true;
            this.expense_addBtn.BackColor = System.Drawing.Color.Transparent;
            this.expense_addBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.expense_addBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("expense_addBtn.BackgroundImage")));
            this.expense_addBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.expense_addBtn.ButtonText = "Add Expense";
            this.expense_addBtn.ButtonTextMarginLeft = 0;
            this.expense_addBtn.ColorContrastOnClick = 45;
            this.expense_addBtn.ColorContrastOnHover = 45;
            this.expense_addBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.expense_addBtn.CustomizableEdges = borderEdges3;
            this.expense_addBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.expense_addBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.expense_addBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.expense_addBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.expense_addBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.expense_addBtn.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_addBtn.ForeColor = System.Drawing.Color.White;
            this.expense_addBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expense_addBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.expense_addBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.expense_addBtn.IconMarginLeft = 11;
            this.expense_addBtn.IconPadding = 10;
            this.expense_addBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.expense_addBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.expense_addBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.expense_addBtn.IconSize = 25;
            this.expense_addBtn.IdleBorderColor = System.Drawing.Color.Transparent;
            this.expense_addBtn.IdleBorderRadius = 20;
            this.expense_addBtn.IdleBorderThickness = 1;
            this.expense_addBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.expense_addBtn.IdleIconLeftImage = null;
            this.expense_addBtn.IdleIconRightImage = null;
            this.expense_addBtn.IndicateFocus = false;
            this.expense_addBtn.Location = new System.Drawing.Point(50, 516);
            this.expense_addBtn.Name = "expense_addBtn";
            this.expense_addBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.expense_addBtn.OnDisabledState.BorderRadius = 20;
            this.expense_addBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.expense_addBtn.OnDisabledState.BorderThickness = 1;
            this.expense_addBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.expense_addBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.expense_addBtn.OnDisabledState.IconLeftImage = null;
            this.expense_addBtn.OnDisabledState.IconRightImage = null;
            this.expense_addBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.expense_addBtn.onHoverState.BorderRadius = 20;
            this.expense_addBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.expense_addBtn.onHoverState.BorderThickness = 1;
            this.expense_addBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.expense_addBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.expense_addBtn.onHoverState.IconLeftImage = null;
            this.expense_addBtn.onHoverState.IconRightImage = null;
            this.expense_addBtn.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.expense_addBtn.OnIdleState.BorderRadius = 20;
            this.expense_addBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.expense_addBtn.OnIdleState.BorderThickness = 1;
            this.expense_addBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.expense_addBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.expense_addBtn.OnIdleState.IconLeftImage = null;
            this.expense_addBtn.OnIdleState.IconRightImage = null;
            this.expense_addBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.expense_addBtn.OnPressedState.BorderRadius = 20;
            this.expense_addBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.expense_addBtn.OnPressedState.BorderThickness = 1;
            this.expense_addBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.expense_addBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.expense_addBtn.OnPressedState.IconLeftImage = null;
            this.expense_addBtn.OnPressedState.IconRightImage = null;
            this.expense_addBtn.Size = new System.Drawing.Size(344, 52);
            this.expense_addBtn.TabIndex = 3;
            this.expense_addBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.expense_addBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.expense_addBtn.TextMarginLeft = 0;
            this.expense_addBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.expense_addBtn.UseDefaultRadiusAndThickness = true;
            this.expense_addBtn.Click += new System.EventHandler(this.expense_addBtn_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(50, 45);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(103, 30);
            this.bunifuLabel1.TabIndex = 4;
            this.bunifuLabel1.Text = "Date Added";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(50, 127);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(82, 30);
            this.bunifuLabel2.TabIndex = 5;
            this.bunifuLabel2.Text = "Category";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel2.Click += new System.EventHandler(this.bunifuLabel2_Click);
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.Location = new System.Drawing.Point(50, 209);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(52, 30);
            this.bunifuLabel3.TabIndex = 6;
            this.bunifuLabel3.Text = "Name";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel4.Location = new System.Drawing.Point(50, 420);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(70, 30);
            this.bunifuLabel4.TabIndex = 7;
            this.bunifuLabel4.Text = "Amount";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // expense_amount
            // 
            this.expense_amount.AcceptsReturn = false;
            this.expense_amount.AcceptsTab = false;
            this.expense_amount.AnimationSpeed = 200;
            this.expense_amount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.expense_amount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.expense_amount.AutoSizeHeight = true;
            this.expense_amount.BackColor = System.Drawing.Color.Transparent;
            this.expense_amount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("expense_amount.BackgroundImage")));
            this.expense_amount.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.expense_amount.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.expense_amount.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.expense_amount.BorderColorIdle = System.Drawing.Color.Silver;
            this.expense_amount.BorderRadius = 20;
            this.expense_amount.BorderThickness = 1;
            this.expense_amount.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.expense_amount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.expense_amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.expense_amount.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.expense_amount.DefaultText = "";
            this.expense_amount.FillColor = System.Drawing.Color.White;
            this.expense_amount.HideSelection = true;
            this.expense_amount.IconLeft = null;
            this.expense_amount.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.expense_amount.IconPadding = 10;
            this.expense_amount.IconRight = null;
            this.expense_amount.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.expense_amount.Lines = new string[0];
            this.expense_amount.Location = new System.Drawing.Point(50, 456);
            this.expense_amount.MaxLength = 32767;
            this.expense_amount.MinimumSize = new System.Drawing.Size(1, 1);
            this.expense_amount.Modified = false;
            this.expense_amount.Multiline = false;
            this.expense_amount.Name = "expense_amount";
            stateProperties17.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties17.FillColor = System.Drawing.Color.Empty;
            stateProperties17.ForeColor = System.Drawing.Color.Empty;
            stateProperties17.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.expense_amount.OnActiveState = stateProperties17;
            stateProperties18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties18.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.expense_amount.OnDisabledState = stateProperties18;
            stateProperties19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties19.FillColor = System.Drawing.Color.Empty;
            stateProperties19.ForeColor = System.Drawing.Color.Empty;
            stateProperties19.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.expense_amount.OnHoverState = stateProperties19;
            stateProperties20.BorderColor = System.Drawing.Color.Silver;
            stateProperties20.FillColor = System.Drawing.Color.White;
            stateProperties20.ForeColor = System.Drawing.Color.Empty;
            stateProperties20.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.expense_amount.OnIdleState = stateProperties20;
            this.expense_amount.Padding = new System.Windows.Forms.Padding(3);
            this.expense_amount.PasswordChar = '\0';
            this.expense_amount.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.expense_amount.PlaceholderText = "Enter amount";
            this.expense_amount.ReadOnly = false;
            this.expense_amount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.expense_amount.SelectedText = "";
            this.expense_amount.SelectionLength = 0;
            this.expense_amount.SelectionStart = 0;
            this.expense_amount.ShortcutsEnabled = true;
            this.expense_amount.Size = new System.Drawing.Size(344, 43);
            this.expense_amount.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.expense_amount.TabIndex = 9;
            this.expense_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.expense_amount.TextMarginBottom = 0;
            this.expense_amount.TextMarginLeft = 3;
            this.expense_amount.TextMarginTop = 1;
            this.expense_amount.TextPlaceholder = "Enter amount";
            this.expense_amount.UseSystemPasswordChar = false;
            this.expense_amount.WordWrap = true;
            // 
            // bunifuFormCaptionButton1
            // 
            this.bunifuFormCaptionButton1.AllowAnimations = true;
            this.bunifuFormCaptionButton1.AllowBorderColorChanges = true;
            this.bunifuFormCaptionButton1.AllowDefaults = true;
            this.bunifuFormCaptionButton1.AllowMouseEffects = true;
            this.bunifuFormCaptionButton1.AnimationSpeed = 200;
            this.bunifuFormCaptionButton1.AutoSizeCaptions = true;
            this.bunifuFormCaptionButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFormCaptionButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.bunifuFormCaptionButton1.BackHoverColor = System.Drawing.Color.LightGray;
            this.bunifuFormCaptionButton1.BackPressedColor = System.Drawing.Color.Silver;
            this.bunifuFormCaptionButton1.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuFormCaptionButton1.BorderHoverColor = System.Drawing.Color.Transparent;
            this.bunifuFormCaptionButton1.BorderPressedColor = System.Drawing.Color.Transparent;
            this.bunifuFormCaptionButton1.BorderRadius = 1;
            this.bunifuFormCaptionButton1.BorderStyle = Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderStyles.Solid;
            this.bunifuFormCaptionButton1.BorderThickness = 1;
            this.bunifuFormCaptionButton1.CaptionType = Bunifu.UI.WinForms.BunifuFormCaptionButton.CaptionTypes.Close;
            this.bunifuFormCaptionButton1.ColorContrastOnClick = 30;
            this.bunifuFormCaptionButton1.ColorContrastOnHover = 30;
            this.bunifuFormCaptionButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.bunifuFormCaptionButton1.CustomizableEdges = borderEdges4;
            this.bunifuFormCaptionButton1.DefaultBorderColor = System.Drawing.Color.Silver;
            this.bunifuFormCaptionButton1.DefaultColor = System.Drawing.Color.Gainsboro;
            this.bunifuFormCaptionButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuFormCaptionButton1.IconColor = System.Drawing.Color.Black;
            this.bunifuFormCaptionButton1.IconHoverColor = System.Drawing.Color.Salmon;
            this.bunifuFormCaptionButton1.IconPressedColor = System.Drawing.Color.Tomato;
            this.bunifuFormCaptionButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuFormCaptionButton1.Image")));
            this.bunifuFormCaptionButton1.ImageMargin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.bunifuFormCaptionButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.bunifuFormCaptionButton1.Location = new System.Drawing.Point(383, 0);
            this.bunifuFormCaptionButton1.Name = "bunifuFormCaptionButton1";
            this.bunifuFormCaptionButton1.ShowBorders = true;
            this.bunifuFormCaptionButton1.Size = new System.Drawing.Size(58, 42);
            this.bunifuFormCaptionButton1.TabIndex = 10;
            this.bunifuFormCaptionButton1.Click += new System.EventHandler(this.bunifuFormCaptionButton1_Click);
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel5.Location = new System.Drawing.Point(50, 294);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(99, 30);
            this.bunifuLabel5.TabIndex = 11;
            this.bunifuLabel5.Text = "Description";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // expense_description
            // 
            this.expense_description.AcceptsReturn = false;
            this.expense_description.AcceptsTab = false;
            this.expense_description.AnimationSpeed = 200;
            this.expense_description.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.expense_description.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.expense_description.AutoSizeHeight = true;
            this.expense_description.BackColor = System.Drawing.Color.Transparent;
            this.expense_description.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("expense_description.BackgroundImage")));
            this.expense_description.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.expense_description.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.expense_description.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.expense_description.BorderColorIdle = System.Drawing.Color.Silver;
            this.expense_description.BorderRadius = 20;
            this.expense_description.BorderThickness = 1;
            this.expense_description.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.expense_description.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.expense_description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.expense_description.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.expense_description.DefaultText = "";
            this.expense_description.FillColor = System.Drawing.Color.White;
            this.expense_description.HideSelection = true;
            this.expense_description.IconLeft = null;
            this.expense_description.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.expense_description.IconPadding = 10;
            this.expense_description.IconRight = null;
            this.expense_description.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.expense_description.Lines = new string[0];
            this.expense_description.Location = new System.Drawing.Point(50, 330);
            this.expense_description.MaxLength = 32767;
            this.expense_description.MinimumSize = new System.Drawing.Size(1, 1);
            this.expense_description.Modified = false;
            this.expense_description.Multiline = true;
            this.expense_description.Name = "expense_description";
            stateProperties21.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties21.FillColor = System.Drawing.Color.Empty;
            stateProperties21.ForeColor = System.Drawing.Color.Empty;
            stateProperties21.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.expense_description.OnActiveState = stateProperties21;
            stateProperties22.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties22.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties22.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.expense_description.OnDisabledState = stateProperties22;
            stateProperties23.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties23.FillColor = System.Drawing.Color.Empty;
            stateProperties23.ForeColor = System.Drawing.Color.Empty;
            stateProperties23.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.expense_description.OnHoverState = stateProperties23;
            stateProperties24.BorderColor = System.Drawing.Color.Silver;
            stateProperties24.FillColor = System.Drawing.Color.White;
            stateProperties24.ForeColor = System.Drawing.Color.Empty;
            stateProperties24.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.expense_description.OnIdleState = stateProperties24;
            this.expense_description.Padding = new System.Windows.Forms.Padding(3);
            this.expense_description.PasswordChar = '\0';
            this.expense_description.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.expense_description.PlaceholderText = "Enter item description";
            this.expense_description.ReadOnly = false;
            this.expense_description.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.expense_description.SelectedText = "";
            this.expense_description.SelectionLength = 0;
            this.expense_description.SelectionStart = 0;
            this.expense_description.ShortcutsEnabled = true;
            this.expense_description.Size = new System.Drawing.Size(344, 84);
            this.expense_description.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.expense_description.TabIndex = 12;
            this.expense_description.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.expense_description.TextMarginBottom = 0;
            this.expense_description.TextMarginLeft = 3;
            this.expense_description.TextMarginTop = 1;
            this.expense_description.TextPlaceholder = "Enter item description";
            this.expense_description.UseSystemPasswordChar = false;
            this.expense_description.WordWrap = true;
            // 
            // ExpenseModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.expense_description);
            this.Controls.Add(this.bunifuLabel5);
            this.Controls.Add(this.bunifuFormCaptionButton1);
            this.Controls.Add(this.expense_amount);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.expense_addBtn);
            this.Controls.Add(this.expense_name);
            this.Controls.Add(this.expense_category);
            this.Controls.Add(this.expenseDate);
            this.Name = "ExpenseModal";
            this.Size = new System.Drawing.Size(441, 592);
            this.Load += new System.EventHandler(this.ExpenseModal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDatePicker expenseDate;
        private Bunifu.UI.WinForms.BunifuDropdown expense_category;
        private Bunifu.UI.WinForms.BunifuTextBox expense_name;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 expense_addBtn;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuTextBox expense_amount;
        private Bunifu.UI.WinForms.BunifuFormCaptionButton bunifuFormCaptionButton1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuTextBox expense_description;
    }
}
