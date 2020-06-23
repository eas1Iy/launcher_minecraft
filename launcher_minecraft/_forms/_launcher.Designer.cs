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
            this._группаНовости = new Guna.UI2.WinForms.Guna2GroupBox();
            this._обновления = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this._версияСервер = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this._версияЛокальная = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.shadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
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
            this._полеИмя.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this._полеИмя.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._полеИмя.HoverState.Parent = this._полеИмя;
            this._полеИмя.Location = new System.Drawing.Point(98, 474);
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
            this._название.Location = new System.Drawing.Point(8, 1);
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
            // _группаНовости
            // 
            this._группаНовости.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._группаНовости.BorderColor = System.Drawing.Color.Transparent;
            this._группаНовости.Controls.Add(this._версияЛокальная);
            this._группаНовости.Controls.Add(this.guna2Button2);
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
            // _обновления
            // 
            this._обновления.AutoSize = false;
            this._обновления.BackColor = System.Drawing.Color.Transparent;
            this._обновления.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this._обновления.Location = new System.Drawing.Point(7, 44);
            this._обновления.Name = "_обновления";
            this._обновления.Size = new System.Drawing.Size(1016, 355);
            this._обновления.TabIndex = 0;
            this._обновления.Text = "ОБНОВЛЕНИЯ";
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
            // _версияЛокальная
            // 
            this._версияЛокальная.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._версияЛокальная.AutoSize = false;
            this._версияЛокальная.BackColor = System.Drawing.Color.Transparent;
            this._версияЛокальная.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this._версияЛокальная.Location = new System.Drawing.Point(650, 405);
            this._версияЛокальная.Name = "_версияЛокальная";
            this._версияЛокальная.Size = new System.Drawing.Size(373, 23);
            this._версияЛокальная.TabIndex = 2;
            this._версияЛокальная.Text = "Версия у вас:";
            // 
            // drag
            // 
            this.drag.TargetControl = this._head;
            this.drag.UseTransparentDrag = true;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2TextBox1.Animated = true;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(98, 501);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(135, 21);
            this.guna2TextBox1.TabIndex = 5;
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
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Button1.Animated = true;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(239, 474);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(145, 23);
            this.guna2Button1.TabIndex = 8;
            this.guna2Button1.Text = "ВОЙТИ";
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
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2CheckBox1.Animated = true;
            this.guna2CheckBox1.AutoSize = true;
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this.guna2CheckBox1.CheckedState.BorderRadius = 0;
            this.guna2CheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this.guna2CheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CheckBox1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.guna2CheckBox1.Location = new System.Drawing.Point(239, 501);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(91, 21);
            this.guna2CheckBox1.TabIndex = 9;
            this.guna2CheckBox1.Text = "Сохранить";
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button2.Animated = true;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this.guna2Button2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(952, 9);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(70, 23);
            this.guna2Button2.TabIndex = 10;
            this.guna2Button2.Text = "ВЫЙТИ";
            this.guna2Button2.Visible = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2PictureBox1.Image = global::launcher_minecraft.Properties.Resources._logo;
            this.guna2PictureBox1.Location = new System.Drawing.Point(931, 472);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(96, 59);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 11;
            this.guna2PictureBox1.TabStop = false;
            // 
            // _launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 540);
            this.Controls.Add(this.guna2CheckBox1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this._группаНовости);
            this.Controls.Add(this._head);
            this.Controls.Add(this._полеИмя);
            this.Controls.Add(this._resizeButton);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(790, 380);
            this.Name = "_launcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
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
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ShadowForm shadow;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}

