
namespace MineUTF3_0
{
    partial class FormCredits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCredits));
            this.richTextBoxCredits = new System.Windows.Forms.RichTextBox();
            this.buttonSpigot = new System.Windows.Forms.Button();
            this.buttonIcons = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxCredits
            // 
            this.richTextBoxCredits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxCredits.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxCredits.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxCredits.Name = "richTextBoxCredits";
            this.richTextBoxCredits.ReadOnly = true;
            this.richTextBoxCredits.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxCredits.Size = new System.Drawing.Size(260, 165);
            this.richTextBoxCredits.TabIndex = 0;
            this.richTextBoxCredits.TabStop = false;
            this.richTextBoxCredits.Text = resources.GetString("richTextBoxCredits.Text");
            // 
            // buttonSpigot
            // 
            this.buttonSpigot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSpigot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpigot.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSpigot.Location = new System.Drawing.Point(12, 219);
            this.buttonSpigot.Name = "buttonSpigot";
            this.buttonSpigot.Size = new System.Drawing.Size(260, 30);
            this.buttonSpigot.TabIndex = 1;
            this.buttonSpigot.TabStop = false;
            this.buttonSpigot.Text = "Автор на форуме";
            this.buttonSpigot.UseVisualStyleBackColor = true;
            this.buttonSpigot.Click += new System.EventHandler(this.buttonSpigot_Click);
            // 
            // buttonIcons
            // 
            this.buttonIcons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIcons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIcons.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonIcons.Location = new System.Drawing.Point(12, 183);
            this.buttonIcons.Name = "buttonIcons";
            this.buttonIcons.Size = new System.Drawing.Size(260, 30);
            this.buttonIcons.TabIndex = 2;
            this.buttonIcons.TabStop = false;
            this.buttonIcons.Text = "Сайт с иконками";
            this.buttonIcons.UseVisualStyleBackColor = true;
            this.buttonIcons.Click += new System.EventHandler(this.buttonIcons_Click);
            // 
            // FormCredits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonIcons);
            this.Controls.Add(this.buttonSpigot);
            this.Controls.Add(this.richTextBoxCredits);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCredits";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MineUTF";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxCredits;
        private System.Windows.Forms.Button buttonSpigot;
        private System.Windows.Forms.Button buttonIcons;
    }
}