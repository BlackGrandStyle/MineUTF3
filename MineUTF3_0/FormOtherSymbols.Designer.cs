
namespace MineUTF3_0
{
    partial class FormOtherSymbols
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOtherSymbols));
            this.richTextBoxSymbols = new System.Windows.Forms.RichTextBox();
            this.buttonLink = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxSymbols
            // 
            this.richTextBoxSymbols.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxSymbols.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxSymbols.Name = "richTextBoxSymbols";
            this.richTextBoxSymbols.ReadOnly = true;
            this.richTextBoxSymbols.Size = new System.Drawing.Size(360, 501);
            this.richTextBoxSymbols.TabIndex = 0;
            this.richTextBoxSymbols.TabStop = false;
            this.richTextBoxSymbols.Text = resources.GetString("richTextBoxSymbols.Text");
            // 
            // buttonLink
            // 
            this.buttonLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLink.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLink.Location = new System.Drawing.Point(12, 519);
            this.buttonLink.Name = "buttonLink";
            this.buttonLink.Size = new System.Drawing.Size(360, 30);
            this.buttonLink.TabIndex = 1;
            this.buttonLink.TabStop = false;
            this.buttonLink.Text = "Источник...";
            this.buttonLink.UseVisualStyleBackColor = true;
            this.buttonLink.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormOtherSymbols
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.buttonLink);
            this.Controls.Add(this.richTextBoxSymbols);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormOtherSymbols";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MineUTF";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxSymbols;
        private System.Windows.Forms.Button buttonLink;
    }
}