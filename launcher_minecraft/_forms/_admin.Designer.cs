namespace launcher_minecraft._forms
{
    partial class _admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this._head = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this._название = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.resizeMethod = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this._resizeButton = new Guna.UI2.WinForms.Guna2ResizeBox();
            this.drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this._таблицаПользователей = new Guna.UI2.WinForms.Guna2DataGridView();
            this._удалитьАдмин = new Guna.UI2.WinForms.Guna2Button();
            this._добавитьАдмин = new Guna.UI2.WinForms.Guna2Button();
            this._имяАдмин = new Guna.UI2.WinForms.Guna2TextBox();
            this._парольАдмин = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this._статусАдмин = new Guna.UI2.WinForms.Guna2ComboBox();
            this._head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._таблицаПользователей)).BeginInit();
            this.SuspendLayout();
            // 
            // _head
            // 
            this._head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this._head.Controls.Add(this.guna2ControlBox3);
            this._head.Controls.Add(this.guna2ControlBox1);
            this._head.Controls.Add(this._название);
            this._head.Dock = System.Windows.Forms.DockStyle.Top;
            this._head.Location = new System.Drawing.Point(0, 0);
            this._head.Name = "_head";
            this._head.ShadowDecoration.Parent = this._head;
            this._head.Size = new System.Drawing.Size(808, 23);
            this._head.TabIndex = 4;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.Animated = true;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.HoverState.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(723, -1);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.ShadowDecoration.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.Size = new System.Drawing.Size(38, 24);
            this.guna2ControlBox3.TabIndex = 12;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(767, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(38, 24);
            this.guna2ControlBox1.TabIndex = 10;
            // 
            // _название
            // 
            this._название.BackColor = System.Drawing.Color.Transparent;
            this._название.Font = new System.Drawing.Font("Century Gothic", 12F);
            this._название.ForeColor = System.Drawing.Color.White;
            this._название.Location = new System.Drawing.Point(8, 0);
            this._название.Name = "_название";
            this._название.Size = new System.Drawing.Size(141, 23);
            this._название.TabIndex = 2;
            this._название.Text = "305 ADMINPANEL";
            // 
            // _resizeButton
            // 
            this._resizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._resizeButton.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this._resizeButton.ForeColor = System.Drawing.Color.Empty;
            this._resizeButton.Location = new System.Drawing.Point(788, 369);
            this._resizeButton.Name = "_resizeButton";
            this._resizeButton.Size = new System.Drawing.Size(17, 17);
            this._resizeButton.TabIndex = 5;
            this._resizeButton.TargetControl = this;
            // 
            // drag
            // 
            this.drag.TargetControl = this._head;
            this.drag.UseTransparentDrag = true;
            // 
            // _таблицаПользователей
            // 
            this._таблицаПользователей.AllowUserToAddRows = false;
            this._таблицаПользователей.AllowUserToDeleteRows = false;
            this._таблицаПользователей.AllowUserToOrderColumns = true;
            this._таблицаПользователей.AllowUserToResizeColumns = false;
            this._таблицаПользователей.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this._таблицаПользователей.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this._таблицаПользователей.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._таблицаПользователей.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._таблицаПользователей.BackgroundColor = System.Drawing.Color.White;
            this._таблицаПользователей.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._таблицаПользователей.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this._таблицаПользователей.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._таблицаПользователей.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this._таблицаПользователей.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._таблицаПользователей.DefaultCellStyle = dataGridViewCellStyle7;
            this._таблицаПользователей.EnableHeadersVisualStyles = false;
            this._таблицаПользователей.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this._таблицаПользователей.Location = new System.Drawing.Point(302, 29);
            this._таблицаПользователей.Name = "_таблицаПользователей";
            this._таблицаПользователей.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._таблицаПользователей.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this._таблицаПользователей.RowHeadersVisible = false;
            this._таблицаПользователей.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this._таблицаПользователей.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._таблицаПользователей.Size = new System.Drawing.Size(494, 334);
            this._таблицаПользователей.TabIndex = 6;
            this._таблицаПользователей.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this._таблицаПользователей.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this._таблицаПользователей.ThemeStyle.AlternatingRowsStyle.Font = null;
            this._таблицаПользователей.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this._таблицаПользователей.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this._таблицаПользователей.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this._таблицаПользователей.ThemeStyle.BackColor = System.Drawing.Color.White;
            this._таблицаПользователей.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this._таблицаПользователей.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this._таблицаПользователей.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this._таблицаПользователей.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 10F);
            this._таблицаПользователей.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this._таблицаПользователей.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this._таблицаПользователей.ThemeStyle.HeaderStyle.Height = 23;
            this._таблицаПользователей.ThemeStyle.ReadOnly = true;
            this._таблицаПользователей.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this._таблицаПользователей.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this._таблицаПользователей.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 10F);
            this._таблицаПользователей.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this._таблицаПользователей.ThemeStyle.RowsStyle.Height = 22;
            this._таблицаПользователей.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this._таблицаПользователей.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // _удалитьАдмин
            // 
            this._удалитьАдмин.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._удалитьАдмин.Animated = true;
            this._удалитьАдмин.CheckedState.Parent = this._удалитьАдмин;
            this._удалитьАдмин.Cursor = System.Windows.Forms.Cursors.Hand;
            this._удалитьАдмин.CustomImages.Parent = this._удалитьАдмин;
            this._удалитьАдмин.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this._удалитьАдмин.Font = new System.Drawing.Font("Century Gothic", 10F);
            this._удалитьАдмин.ForeColor = System.Drawing.Color.White;
            this._удалитьАдмин.HoverState.Parent = this._удалитьАдмин;
            this._удалитьАдмин.Location = new System.Drawing.Point(8, 339);
            this._удалитьАдмин.Name = "_удалитьАдмин";
            this._удалитьАдмин.ShadowDecoration.Parent = this._удалитьАдмин;
            this._удалитьАдмин.Size = new System.Drawing.Size(288, 23);
            this._удалитьАдмин.TabIndex = 9;
            this._удалитьАдмин.Text = "УДАЛИТЬ ПОЛЬЗОВАТЕЛЯ";
            this._удалитьАдмин.Click += new System.EventHandler(this._удалитьАдмин_Click);
            // 
            // _добавитьАдмин
            // 
            this._добавитьАдмин.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._добавитьАдмин.Animated = true;
            this._добавитьАдмин.CheckedState.Parent = this._добавитьАдмин;
            this._добавитьАдмин.Cursor = System.Windows.Forms.Cursors.Hand;
            this._добавитьАдмин.CustomImages.Parent = this._добавитьАдмин;
            this._добавитьАдмин.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this._добавитьАдмин.Font = new System.Drawing.Font("Century Gothic", 10F);
            this._добавитьАдмин.ForeColor = System.Drawing.Color.White;
            this._добавитьАдмин.HoverState.Parent = this._добавитьАдмин;
            this._добавитьАдмин.Location = new System.Drawing.Point(8, 310);
            this._добавитьАдмин.Name = "_добавитьАдмин";
            this._добавитьАдмин.ShadowDecoration.Parent = this._добавитьАдмин;
            this._добавитьАдмин.Size = new System.Drawing.Size(288, 23);
            this._добавитьАдмин.TabIndex = 11;
            this._добавитьАдмин.Text = "ДОБАВИТЬ ПОЛЬЗОВАТЕЛЯ";
            this._добавитьАдмин.Click += new System.EventHandler(this._добавитьАдмин_Click);
            // 
            // _имяАдмин
            // 
            this._имяАдмин.Animated = true;
            this._имяАдмин.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._имяАдмин.DefaultText = "";
            this._имяАдмин.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this._имяАдмин.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this._имяАдмин.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._имяАдмин.DisabledState.Parent = this._имяАдмин;
            this._имяАдмин.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._имяАдмин.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._имяАдмин.FocusedState.Parent = this._имяАдмин;
            this._имяАдмин.Font = new System.Drawing.Font("Century Gothic", 10F);
            this._имяАдмин.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this._имяАдмин.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._имяАдмин.HoverState.Parent = this._имяАдмин;
            this._имяАдмин.Location = new System.Drawing.Point(131, 65);
            this._имяАдмин.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._имяАдмин.Name = "_имяАдмин";
            this._имяАдмин.PasswordChar = '\0';
            this._имяАдмин.PlaceholderText = "";
            this._имяАдмин.SelectedText = "";
            this._имяАдмин.ShadowDecoration.Parent = this._имяАдмин;
            this._имяАдмин.Size = new System.Drawing.Size(165, 21);
            this._имяАдмин.TabIndex = 12;
            // 
            // _парольАдмин
            // 
            this._парольАдмин.Animated = true;
            this._парольАдмин.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._парольАдмин.DefaultText = "";
            this._парольАдмин.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this._парольАдмин.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this._парольАдмин.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._парольАдмин.DisabledState.Parent = this._парольАдмин;
            this._парольАдмин.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._парольАдмин.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._парольАдмин.FocusedState.Parent = this._парольАдмин;
            this._парольАдмин.Font = new System.Drawing.Font("Century Gothic", 10F);
            this._парольАдмин.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this._парольАдмин.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._парольАдмин.HoverState.Parent = this._парольАдмин;
            this._парольАдмин.Location = new System.Drawing.Point(131, 92);
            this._парольАдмин.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._парольАдмин.Name = "_парольАдмин";
            this._парольАдмин.PasswordChar = '\0';
            this._парольАдмин.PlaceholderText = "";
            this._парольАдмин.SelectedText = "";
            this._парольАдмин.ShadowDecoration.Parent = this._парольАдмин;
            this._парольАдмин.Size = new System.Drawing.Size(165, 21);
            this._парольАдмин.TabIndex = 13;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(42, 63);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(80, 23);
            this.guna2HtmlLabel1.TabIndex = 14;
            this.guna2HtmlLabel1.Text = "Никнейм:";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(55, 92);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(67, 23);
            this.guna2HtmlLabel2.TabIndex = 15;
            this.guna2HtmlLabel2.Text = "Пароль:";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(61, 125);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(61, 23);
            this.guna2HtmlLabel3.TabIndex = 16;
            this.guna2HtmlLabel3.Text = "Статус:";
            // 
            // _статусАдмин
            // 
            this._статусАдмин.Animated = true;
            this._статусАдмин.BackColor = System.Drawing.Color.Transparent;
            this._статусАдмин.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this._статусАдмин.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._статусАдмин.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._статусАдмин.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._статусАдмин.FocusedState.Parent = this._статусАдмин;
            this._статусАдмин.Font = new System.Drawing.Font("Century Gothic", 10F);
            this._статусАдмин.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this._статусАдмин.HoverState.Parent = this._статусАдмин;
            this._статусАдмин.ItemHeight = 30;
            this._статусАдмин.Items.AddRange(new object[] {
            "Игрок",
            "Администратор"});
            this._статусАдмин.ItemsAppearance.Parent = this._статусАдмин;
            this._статусАдмин.Location = new System.Drawing.Point(131, 119);
            this._статусАдмин.Name = "_статусАдмин";
            this._статусАдмин.ShadowDecoration.Parent = this._статусАдмин;
            this._статусАдмин.Size = new System.Drawing.Size(165, 36);
            this._статусАдмин.StartIndex = 0;
            this._статусАдмин.TabIndex = 17;
            // 
            // _admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 388);
            this.Controls.Add(this._статусАдмин);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this._парольАдмин);
            this.Controls.Add(this._имяАдмин);
            this.Controls.Add(this._добавитьАдмин);
            this.Controls.Add(this._удалитьАдмин);
            this.Controls.Add(this._таблицаПользователей);
            this.Controls.Add(this._resizeButton);
            this.Controls.Add(this._head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(760, 290);
            this.Name = "_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_admin";
            this.Load += new System.EventHandler(this._admin_Load);
            this._head.ResumeLayout(false);
            this._head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._таблицаПользователей)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel _head;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel _название;
        private Guna.UI2.WinForms.Guna2ResizeForm resizeMethod;
        private Guna.UI2.WinForms.Guna2ResizeBox _resizeButton;
        private Guna.UI2.WinForms.Guna2DragControl drag;
        private Guna.UI2.WinForms.Guna2DataGridView _таблицаПользователей;
        private Guna.UI2.WinForms.Guna2Button _удалитьАдмин;
        private Guna.UI2.WinForms.Guna2Button _добавитьАдмин;
        private Guna.UI2.WinForms.Guna2TextBox _имяАдмин;
        private Guna.UI2.WinForms.Guna2TextBox _парольАдмин;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox _статусАдмин;
    }
}