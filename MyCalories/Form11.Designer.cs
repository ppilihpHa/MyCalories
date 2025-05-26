namespace MyCalories
{
    partial class Form11
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
            this.wieVielBox = new System.Windows.Forms.TextBox();
            this.mengeBearbGerLabel = new System.Windows.Forms.Label();
            this.closeBtn = new MaterialSkin.Controls.MaterialButton();
            this.saveBtn = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // wieVielBox
            // 
            this.wieVielBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wieVielBox.Location = new System.Drawing.Point(198, 260);
            this.wieVielBox.Name = "wieVielBox";
            this.wieVielBox.Size = new System.Drawing.Size(300, 71);
            this.wieVielBox.TabIndex = 25;
            // 
            // mengeBearbGerLabel
            // 
            this.mengeBearbGerLabel.AutoSize = true;
            this.mengeBearbGerLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mengeBearbGerLabel.Location = new System.Drawing.Point(43, 112);
            this.mengeBearbGerLabel.Name = "mengeBearbGerLabel";
            this.mengeBearbGerLabel.Size = new System.Drawing.Size(639, 128);
            this.mengeBearbGerLabel.TabIndex = 26;
            this.mengeBearbGerLabel.Text = "    neue Menge für das Gericht\r\n(eventuell roh/gebraten beachten):";
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSize = false;
            this.closeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.closeBtn.Depth = 0;
            this.closeBtn.HighEmphasis = true;
            this.closeBtn.Icon = null;
            this.closeBtn.Location = new System.Drawing.Point(711, 15);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.closeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.closeBtn.Size = new System.Drawing.Size(50, 50);
            this.closeBtn.TabIndex = 27;
            this.closeBtn.Text = "X";
            this.closeBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.closeBtn.UseAccentColor = false;
            this.closeBtn.UseCompatibleTextRendering = true;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.AutoSize = false;
            this.saveBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.saveBtn.Depth = 0;
            this.saveBtn.HighEmphasis = true;
            this.saveBtn.Icon = null;
            this.saveBtn.Location = new System.Drawing.Point(661, 464);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.saveBtn.Size = new System.Drawing.Size(100, 50);
            this.saveBtn.TabIndex = 28;
            this.saveBtn.Text = "Fertig";
            this.saveBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveBtn.UseAccentColor = false;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 529);
            this.ControlBox = false;
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.wieVielBox);
            this.Controls.Add(this.mengeBearbGerLabel);
            this.Name = "Form11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wieVielBox;
        private System.Windows.Forms.Label mengeBearbGerLabel;
        private MaterialSkin.Controls.MaterialButton closeBtn;
        private MaterialSkin.Controls.MaterialButton saveBtn;
    }
}