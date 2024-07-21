namespace MineUTF3_0
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.textBoxConvert = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.pictureBoxConvert = new System.Windows.Forms.PictureBox();
            this.pictureBoxCopy = new System.Windows.Forms.PictureBox();
            this.pictureBoxSave = new System.Windows.Forms.PictureBox();
            this.pictureBoxOther = new System.Windows.Forms.PictureBox();
            this.pictureBoxAbout = new System.Windows.Forms.PictureBox();
            this.pictureBoxRestart = new System.Windows.Forms.PictureBox();
            this.pictureBoxClear = new System.Windows.Forms.PictureBox();
            this.labelSelect = new System.Windows.Forms.Label();
            this.timerCopy = new System.Windows.Forms.Timer(this.components);
            this.labelCopied = new System.Windows.Forms.Label();
            this.labelWarn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConvert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOther)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClear)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxConvert
            // 
            this.textBoxConvert.Enabled = false;
            this.textBoxConvert.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxConvert.Location = new System.Drawing.Point(12, 68);
            this.textBoxConvert.Multiline = true;
            this.textBoxConvert.Name = "textBoxConvert";
            this.textBoxConvert.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxConvert.Size = new System.Drawing.Size(360, 360);
            this.textBoxConvert.TabIndex = 2;
            this.textBoxConvert.TabStop = false;
            this.textBoxConvert.TextChanged += new System.EventHandler(this.textBoxConvert_TextChanged);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Enabled = false;
            this.textBoxResult.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult.Location = new System.Drawing.Point(533, 68);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(360, 360);
            this.textBoxResult.TabIndex = 8;
            this.textBoxResult.TabStop = false;
            this.textBoxResult.TextChanged += new System.EventHandler(this.textBoxResult_TextChanged);
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.BackColor = System.Drawing.Color.White;
            this.comboBoxMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Items.AddRange(new object[] {
            "[1] Big Latin: ABCD = ＡＢＣＤ + abcd = ａｂｃｄ + 1234 = ₁₂₃₄",
            "[2] Better Latin: ABCD = ᴀʙᴄᴅ + 1234 = ₁₂₃₄",
            "[3] Cyrillic: АБВГ = ᴀбʙᴦ + 1234 = ₁₂₃₄",
            "[4] RNum: 1234 = ①②③④"});
            this.comboBoxMode.Location = new System.Drawing.Point(12, 35);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(360, 27);
            this.comboBoxMode.TabIndex = 15;
            this.comboBoxMode.TabStop = false;
            this.comboBoxMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxMode_SelectedIndexChanged);
            // 
            // pictureBoxConvert
            // 
            this.pictureBoxConvert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxConvert.Image = global::MineUTF3_0.Properties.Resources.convertIcon;
            this.pictureBoxConvert.Location = new System.Drawing.Point(377, 68);
            this.pictureBoxConvert.Name = "pictureBoxConvert";
            this.pictureBoxConvert.Size = new System.Drawing.Size(150, 360);
            this.pictureBoxConvert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxConvert.TabIndex = 22;
            this.pictureBoxConvert.TabStop = false;
            this.pictureBoxConvert.Visible = false;
            this.pictureBoxConvert.Click += new System.EventHandler(this.pictureBoxConvert_Click);
            // 
            // pictureBoxCopy
            // 
            this.pictureBoxCopy.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCopy.Image = global::MineUTF3_0.Properties.Resources.copyIcon;
            this.pictureBoxCopy.Location = new System.Drawing.Point(542, 391);
            this.pictureBoxCopy.Name = "pictureBoxCopy";
            this.pictureBoxCopy.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCopy.TabIndex = 21;
            this.pictureBoxCopy.TabStop = false;
            this.pictureBoxCopy.Visible = false;
            this.pictureBoxCopy.Click += new System.EventHandler(this.pictureBoxCopy_Click);
            // 
            // pictureBoxSave
            // 
            this.pictureBoxSave.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSave.Image = global::MineUTF3_0.Properties.Resources.saveIcon;
            this.pictureBoxSave.Location = new System.Drawing.Point(843, 391);
            this.pictureBoxSave.Name = "pictureBoxSave";
            this.pictureBoxSave.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSave.TabIndex = 20;
            this.pictureBoxSave.TabStop = false;
            this.pictureBoxSave.Visible = false;
            this.pictureBoxSave.Click += new System.EventHandler(this.pictureBoxSave_Click);
            // 
            // pictureBoxOther
            // 
            this.pictureBoxOther.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxOther.Image = global::MineUTF3_0.Properties.Resources.otherIcon;
            this.pictureBoxOther.Location = new System.Drawing.Point(731, 12);
            this.pictureBoxOther.MaximumSize = new System.Drawing.Size(50, 50);
            this.pictureBoxOther.Name = "pictureBoxOther";
            this.pictureBoxOther.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxOther.TabIndex = 19;
            this.pictureBoxOther.TabStop = false;
            this.pictureBoxOther.Click += new System.EventHandler(this.pictureBoxOther_Click);
            // 
            // pictureBoxAbout
            // 
            this.pictureBoxAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAbout.Image = global::MineUTF3_0.Properties.Resources.aboutIcon;
            this.pictureBoxAbout.Location = new System.Drawing.Point(787, 12);
            this.pictureBoxAbout.MaximumSize = new System.Drawing.Size(50, 50);
            this.pictureBoxAbout.Name = "pictureBoxAbout";
            this.pictureBoxAbout.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxAbout.TabIndex = 18;
            this.pictureBoxAbout.TabStop = false;
            this.pictureBoxAbout.Click += new System.EventHandler(this.pictureBoxAbout_Click);
            // 
            // pictureBoxRestart
            // 
            this.pictureBoxRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRestart.Image = global::MineUTF3_0.Properties.Resources.restartIcon;
            this.pictureBoxRestart.Location = new System.Drawing.Point(843, 12);
            this.pictureBoxRestart.Name = "pictureBoxRestart";
            this.pictureBoxRestart.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxRestart.TabIndex = 17;
            this.pictureBoxRestart.TabStop = false;
            this.pictureBoxRestart.Click += new System.EventHandler(this.pictureBoxRestart_Click);
            // 
            // pictureBoxClear
            // 
            this.pictureBoxClear.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClear.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClear.Image")));
            this.pictureBoxClear.Location = new System.Drawing.Point(16, 391);
            this.pictureBoxClear.Name = "pictureBoxClear";
            this.pictureBoxClear.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClear.TabIndex = 16;
            this.pictureBoxClear.TabStop = false;
            this.pictureBoxClear.Visible = false;
            this.pictureBoxClear.Click += new System.EventHandler(this.pictureBoxClear_Click);
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.labelSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSelect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelect.Location = new System.Drawing.Point(12, 13);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(146, 19);
            this.labelSelect.TabIndex = 23;
            this.labelSelect.Text = "Выберите режим...";
            // 
            // timerCopy
            // 
            this.timerCopy.Interval = 1000;
            this.timerCopy.Tick += new System.EventHandler(this.timerCopy_Tick);
            // 
            // labelCopied
            // 
            this.labelCopied.AutoSize = true;
            this.labelCopied.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCopied.Location = new System.Drawing.Point(573, 397);
            this.labelCopied.Name = "labelCopied";
            this.labelCopied.Size = new System.Drawing.Size(110, 19);
            this.labelCopied.TabIndex = 24;
            this.labelCopied.Text = "Скопировано!";
            this.labelCopied.Visible = false;
            // 
            // labelWarn
            // 
            this.labelWarn.AutoSize = true;
            this.labelWarn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelWarn.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWarn.ForeColor = System.Drawing.Color.Brown;
            this.labelWarn.Location = new System.Drawing.Point(374, 19);
            this.labelWarn.Name = "labelWarn";
            this.labelWarn.Size = new System.Drawing.Size(79, 13);
            this.labelWarn.TabIndex = 25;
            this.labelWarn.Text = "%labelwarn%";
            this.labelWarn.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 457);
            this.Controls.Add(this.labelWarn);
            this.Controls.Add(this.labelCopied);
            this.Controls.Add(this.labelSelect);
            this.Controls.Add(this.pictureBoxConvert);
            this.Controls.Add(this.pictureBoxCopy);
            this.Controls.Add(this.pictureBoxSave);
            this.Controls.Add(this.pictureBoxOther);
            this.Controls.Add(this.pictureBoxAbout);
            this.Controls.Add(this.pictureBoxRestart);
            this.Controls.Add(this.pictureBoxClear);
            this.Controls.Add(this.comboBoxMode);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxConvert);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MineUTF";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConvert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOther)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxConvert;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.PictureBox pictureBoxClear;
        private System.Windows.Forms.PictureBox pictureBoxRestart;
        private System.Windows.Forms.PictureBox pictureBoxAbout;
        private System.Windows.Forms.PictureBox pictureBoxOther;
        private System.Windows.Forms.PictureBox pictureBoxSave;
        private System.Windows.Forms.PictureBox pictureBoxCopy;
        private System.Windows.Forms.PictureBox pictureBoxConvert;
        private System.Windows.Forms.Label labelSelect;
        private System.Windows.Forms.Timer timerCopy;
        private System.Windows.Forms.Label labelCopied;
        private System.Windows.Forms.Label labelWarn;
    }
}

