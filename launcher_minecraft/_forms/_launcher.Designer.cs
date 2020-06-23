namespace launcher_minecraft
{
    partial class _launcher
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._resizeButton = new Guna.UI2.WinForms.Guna2ResizeBox();
            this.resizeMethod = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this._полеИмя = new Guna.UI2.WinForms.Guna2TextBox();
            this._название = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this._head = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this._группаНовости = new Guna.UI2.WinForms.Guna2GroupBox();
            this._админПанель = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this._версияЛокальная = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this._выйти = new Guna.UI2.WinForms.Guna2Button();
            this._версияСервер = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this._обновления = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this._парольПоле = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.shadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this._войти = new Guna.UI2.WinForms.Guna2Button();
            this._сохранитьПароль = new Guna.UI2.WinForms.Guna2CheckBox();
            this._head.SuspendLayout();
            this._группаНовости.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _resizeButton
            // 
            this._resizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._resizeButton.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this._resizeButton.ForeColor = System.Drawing.Color.Empty;
            this._resizeButton.Location = new System.Drawing.Point(1018, 520);
            this._resizeButton.Name = "_resizeButton";
            this._resizeButton.Size = new System.Drawing.Size(17, 17);
            this._resizeButton.TabIndex = 0;
            this._resizeButton.TargetControl = this;
            // 
            // _полеИмя
            // 
            this._полеИмя.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._полеИмя.Animated = true;
            this._полеИмя.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._полеИмя.DefaultText = "";
            this._полеИмя.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this._полеИмя.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this._полеИмя.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._полеИмя.DisabledState.Parent = this._полеИмя;
            this._полеИмя.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._полеИмя.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._полеИмя.FocusedState.Parent = this._полеИмя;
            this._полеИмя.Font = new System.Drawing.Font("Century Gothic", 10F);
            this._полеИмя.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this._полеИмя.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._полеИмя.HoverState.Parent = this._полеИмя;
            this._полеИмя.Location = new System.Drawing.Point(98, 474);
            this._полеИмя.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._полеИмя.Name = "_полеИмя";
            this._полеИмя.PasswordChar = '\0';
            this._полеИмя.PlaceholderText = "";
            this._полеИмя.SelectedText = "";
            this._полеИмя.ShadowDecoration.Parent = this._полеИмя;
            this._полеИмя.Size = new System.Drawing.Size(135, 21);
            this._полеИмя.TabIndex = 1;
            // 
            // _название
            // 
            this._название.BackColor = System.Drawing.Color.Transparent;
            this._название.Font = new System.Drawing.Font("Century Gothic", 12F);
            this._название.ForeColor = System.Drawing.Color.White;
            this._название.Location = new System.Drawing.Point(8, 0);
            this._название.Name = "_название";
            this._название.Size = new System.Drawing.Size(99, 23);
            this._название.TabIndex = 2;
            this._название.Text = "305 LOADER";
            // 
            // _head
            // 
            this._head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this._head.Controls.Add(this.guna2ControlBox3);
            this._head.Controls.Add(this.guna2ControlBox2);
            this._head.Controls.Add(this.guna2ControlBox1);
            this._head.Controls.Add(this._название);
            this._head.Dock = System.Windows.Forms.DockStyle.Top;
            this._head.Location = new System.Drawing.Point(0, 0);
            this._head.Name = "_head";
            this._head.ShadowDecoration.Parent = this._head;
            this._head.Size = new System.Drawing.Size(1040, 23);
            this._head.TabIndex = 3;
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
            this.guna2ControlBox3.Location = new System.Drawing.Point(955, -1);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.ShadowDecoration.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.Size = new System.Drawing.Size(38, 24);
            this.guna2ControlBox3.TabIndex = 12;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.Animated = true;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(911, -1);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(38, 24);
            this.guna2ControlBox2.TabIndex = 11;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(999, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(38, 24);
            this.guna2ControlBox1.TabIndex = 10;
            // 
            // _группаНовости
            // 
            this._группаНовости.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._группаНовости.BorderColor = System.Drawing.Color.Transparent;
            this._группаНовости.Controls.Add(this._админПанель);
            this._группаНовости.Controls.Add(this.guna2PictureBox1);
            this._группаНовости.Controls.Add(this.guna2HtmlLabel3);
            this._группаНовости.Controls.Add(this._версияЛокальная);
            this._группаНовости.Controls.Add(this._выйти);
            this._группаНовости.Controls.Add(this._версияСервер);
            this._группаНовости.Controls.Add(this._обновления);
            this._группаНовости.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this._группаНовости.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._группаНовости.ForeColor = System.Drawing.Color.White;
            this._группаНовости.Location = new System.Drawing.Point(5, 27);
            this._группаНовости.Name = "_группаНовости";
            this._группаНовости.ShadowDecoration.Parent = this._группаНовости;
            this._группаНовости.Size = new System.Drawing.Size(1030, 431);
            this._группаНовости.TabIndex = 4;
            this._группаНовости.Text = "Новости";
            // 
            // _админПанель
            // 
            this._админПанель.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._админПанель.Animated = true;
            this._админПанель.CheckedState.Parent = this._админПанель;
            this._админПанель.Cursor = System.Windows.Forms.Cursors.Hand;
            this._админПанель.CustomImages.Parent = this._админПанель;
            this._админПанель.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this._админПанель.Font = new System.Drawing.Font("Century Gothic", 10F);
            this._админПанель.ForeColor = System.Drawing.Color.White;
            this._админПанель.HoverState.Parent = this._админПанель;
            this._админПанель.Location = new System.Drawing.Point(818, 9);
            this._админПанель.Name = "_админПанель";
            this._админПанель.ShadowDecoration.Parent = this._админПанель;
            this._админПанель.Size = new System.Drawing.Size(128, 23);
            this._админПанель.TabIndex = 13;
            this._админПанель.Text = "АДМИН ПАНЕЛЬ";
            this._админПанель.Visible = false;
            this._админПанель.Click += new System.EventHandler(this._админПанель_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::launcher_minecraft.Properties.Resources._logo;
            this.guna2PictureBox1.Location = new System.Drawing.Point(7, 44);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(318, 197);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 11;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(7, 247);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(318, 152);
            this.guna2HtmlLabel3.TabIndex = 12;
            this.guna2HtmlLabel3.Text = "Разработчик лаунчера: eas1ly\r\nРазработчик сервера: FallenDenica\r\n";
            // 
            // _версияЛокальная
            // 
            this._версияЛокальная.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._версияЛокальная.AutoSize = false;
            this._версияЛокальная.BackColor = System.Drawing.Color.Transparent;
            this._версияЛокальная.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this._версияЛокальная.Location = new System.Drawing.Point(753, 405);
            this._версияЛокальная.Name = "_версияЛокальная";
            this._версияЛокальная.Size = new System.Drawing.Size(270, 23);
            this._версияЛокальная.TabIndex = 2;
            this._версияЛокальная.Text = "Версия у вас:";
            // 
            // _выйти
            // 
            this._выйти.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._выйти.Animated = true;
            this._выйти.CheckedState.Parent = this._выйти;
            this._выйти.Cursor = System.Windows.Forms.Cursors.Hand;
            this._выйти.CustomImages.Parent = this._выйти;
            this._выйти.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this._выйти.Font = new System.Drawing.Font("Century Gothic", 10F);
            this._выйти.ForeColor = System.Drawing.Color.White;
            this._выйти.HoverState.Parent = this._выйти;
            this._выйти.Location = new System.Drawing.Point(952, 9);
            this._выйти.Name = "_выйти";
            this._выйти.ShadowDecoration.Parent = this._выйти;
            this._выйти.Size = new System.Drawing.Size(70, 23);
            this._выйти.TabIndex = 10;
            this._выйти.Text = "ВЫЙТИ";
            this._выйти.Visible = false;
            this._выйти.Click += new System.EventHandler(this._выйти_Click);
            // 
            // _версияСервер
            // 
            this._версияСервер.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._версияСервер.AutoSize = false;
            this._версияСервер.BackColor = System.Drawing.Color.Transparent;
            this._версияСервер.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this._версияСервер.Location = new System.Drawing.Point(7, 405);
            this._версияСервер.Name = "_версияСервер";
            this._версияСервер.Size = new System.Drawing.Size(388, 23);
            this._версияСервер.TabIndex = 1;
            this._версияСервер.Text = "Версия на сервере:";
            // 
            // _обновления
            // 
            this._обновления.AutoSize = false;
            this._обновления.BackColor = System.Drawing.Color.Transparent;
            this._обновления.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this._обновления.Location = new System.Drawing.Point(331, 44);
            this._обновления.Name = "_обновления";
            this._обновления.Size = new System.Drawing.Size(692, 355);
            this._обновления.TabIndex = 0;
            this._обновления.Text = "ОБНОВЛЕНИЯ";
            // 
            // drag
            // 
            this.drag.TargetControl = this._head;
            this.drag.UseTransparentDrag = true;
            // 
            // _парольПоле
            // 
            this._парольПоле.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._парольПоле.Animated = true;
            this._парольПоле.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._парольПоле.DefaultText = "";
            this._парольПоле.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this._парольПоле.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this._парольПоле.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._парольПоле.DisabledState.Parent = this._парольПоле;
            this._парольПоле.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._парольПоле.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._парольПоле.FocusedState.Parent = this._парольПоле;
            this._парольПоле.Font = new System.Drawing.Font("Century Gothic", 10F);
            this._парольПоле.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this._парольПоле.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._парольПоле.HoverState.Parent = this._парольПоле;
            this._парольПоле.Location = new System.Drawing.Point(98, 501);
            this._парольПоле.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._парольПоле.Name = "_парольПоле";
            this._парольПоле.PasswordChar = '\0';
            this._парольПоле.PlaceholderText = "";
            this._парольПоле.SelectedText = "";
            this._парольПоле.ShadowDecoration.Parent = this._парольПоле;
            this._парольПоле.Size = new System.Drawing.Size(135, 21);
            this._парольПоле.TabIndex = 5;
            this._парольПоле.UseSystemPasswordChar = true;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 472);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(80, 23);
            this.guna2HtmlLabel1.TabIndex = 6;
            this.guna2HtmlLabel1.Text = "Никнейм:";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(25, 499);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(67, 23);
            this.guna2HtmlLabel2.TabIndex = 7;
            this.guna2HtmlLabel2.Text = "Пароль:";
            // 
            // _войти
            // 
            this._войти.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._войти.Animated = true;
            this._войти.CheckedState.Parent = this._войти;
            this._войти.Cursor = System.Windows.Forms.Cursors.Hand;
            this._войти.CustomImages.Parent = this._войти;
            this._войти.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this._войти.Font = new System.Drawing.Font("Century Gothic", 10F);
            this._войти.ForeColor = System.Drawing.Color.White;
            this._войти.HoverState.Parent = this._войти;
            this._войти.Location = new System.Drawing.Point(239, 474);
            this._войти.Name = "_войти";
            this._войти.ShadowDecoration.Parent = this._войти;
            this._войти.Size = new System.Drawing.Size(145, 23);
            this._войти.TabIndex = 8;
            this._войти.Text = "ВОЙТИ";
            this._войти.Click += new System.EventHandler(this._войти_Click);
            // 
            // _сохранитьПароль
            // 
            this._сохранитьПароль.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._сохранитьПароль.Animated = true;
            this._сохранитьПароль.AutoSize = true;
            this._сохранитьПароль.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this._сохранитьПароль.CheckedState.BorderRadius = 0;
            this._сохранитьПароль.CheckedState.BorderThickness = 0;
            this._сохранитьПароль.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this._сохранитьПароль.Cursor = System.Windows.Forms.Cursors.Hand;
            this._сохранитьПароль.Font = new System.Drawing.Font("Century Gothic", 9F);
            this._сохранитьПароль.Location = new System.Drawing.Point(239, 501);
            this._сохранитьПароль.Name = "_сохранитьПароль";
            this._сохранитьПароль.Size = new System.Drawing.Size(91, 21);
            this._сохранитьПароль.TabIndex = 9;
            this._сохранитьПароль.Text = "Сохранить";
            this._сохранитьПароль.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this._сохранитьПароль.UncheckedState.BorderRadius = 0;
            this._сохранитьПароль.UncheckedState.BorderThickness = 0;
            this._сохранитьПароль.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // _launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 540);
            this.Controls.Add(this._сохранитьПароль);
            this.Controls.Add(this._войти);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this._парольПоле);
            this.Controls.Add(this._группаНовости);
            this.Controls.Add(this._head);
            this.Controls.Add(this._полеИмя);
            this.Controls.Add(this._resizeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(790, 380);
            this.Name = "_launcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this._launcher_Load);
            this._head.ResumeLayout(false);
            this._head.PerformLayout();
            this._группаНовости.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ResizeBox _resizeButton;
        private Guna.UI2.WinForms.Guna2ResizeForm resizeMethod;
        private Guna.UI2.WinForms.Guna2TextBox _полеИмя;
        private Guna.UI2.WinForms.Guna2Panel _head;
        private Guna.UI2.WinForms.Guna2HtmlLabel _название;
        private Guna.UI2.WinForms.Guna2GroupBox _группаНовости;
        private Guna.UI2.WinForms.Guna2HtmlLabel _обновления;
        private Guna.UI2.WinForms.Guna2HtmlLabel _версияСервер;
        private Guna.UI2.WinForms.Guna2HtmlLabel _версияЛокальная;
        private Guna.UI2.WinForms.Guna2DragControl drag;
        private Guna.UI2.WinForms.Guna2TextBox _парольПоле;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ShadowForm shadow;
        private Guna.UI2.WinForms.Guna2Button _войти;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2CheckBox _сохранитьПароль;
        private Guna.UI2.WinForms.Guna2Button _выйти;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Button _админПанель;
    }
}

