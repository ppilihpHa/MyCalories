namespace MyCalories
{
    partial class Form10
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
            this.jaEntfernBtn = new MaterialSkin.Controls.MaterialButton();
            this.neinEntfernBtn = new MaterialSkin.Controls.MaterialButton();
            this.wirklichLoeschenLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // jaEntfernBtn
            // 
            this.jaEntfernBtn.AutoSize = false;
            this.jaEntfernBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.jaEntfernBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.jaEntfernBtn.Depth = 0;
            this.jaEntfernBtn.HighEmphasis = true;
            this.jaEntfernBtn.Icon = null;
            this.jaEntfernBtn.Location = new System.Drawing.Point(543, 155);
            this.jaEntfernBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.jaEntfernBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.jaEntfernBtn.Name = "jaEntfernBtn";
            this.jaEntfernBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.jaEntfernBtn.Size = new System.Drawing.Size(200, 50);
            this.jaEntfernBtn.TabIndex = 2;
            this.jaEntfernBtn.Text = "ja";
            this.jaEntfernBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.jaEntfernBtn.UseAccentColor = false;
            this.jaEntfernBtn.UseVisualStyleBackColor = true;
            this.jaEntfernBtn.Click += new System.EventHandler(this.jaEntfernBtn_Click);
            // 
            // neinEntfernBtn
            // 
            this.neinEntfernBtn.AutoSize = false;
            this.neinEntfernBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.neinEntfernBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.neinEntfernBtn.Depth = 0;
            this.neinEntfernBtn.HighEmphasis = true;
            this.neinEntfernBtn.Icon = null;
            this.neinEntfernBtn.Location = new System.Drawing.Point(246, 155);
            this.neinEntfernBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.neinEntfernBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.neinEntfernBtn.Name = "neinEntfernBtn";
            this.neinEntfernBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.neinEntfernBtn.Size = new System.Drawing.Size(200, 50);
            this.neinEntfernBtn.TabIndex = 3;
            this.neinEntfernBtn.Text = "nein";
            this.neinEntfernBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.neinEntfernBtn.UseAccentColor = false;
            this.neinEntfernBtn.UseVisualStyleBackColor = true;
            this.neinEntfernBtn.Click += new System.EventHandler(this.neinEntfernBtn_Click);
            // 
            // wirklichLoeschenLabel
            // 
            this.wirklichLoeschenLabel.AutoSize = true;
            this.wirklichLoeschenLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wirklichLoeschenLabel.Location = new System.Drawing.Point(45, 29);
            this.wirklichLoeschenLabel.Name = "wirklichLoeschenLabel";
            this.wirklichLoeschenLabel.Size = new System.Drawing.Size(688, 64);
            this.wirklichLoeschenLabel.TabIndex = 4;
            this.wirklichLoeschenLabel.Text = "Zutat wirklich aus Gericht entfernen?\r\n";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 274);
            this.ControlBox = false;
            this.Controls.Add(this.wirklichLoeschenLabel);
            this.Controls.Add(this.neinEntfernBtn);
            this.Controls.Add(this.jaEntfernBtn);
            this.Name = "Form10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton jaEntfernBtn;
        private MaterialSkin.Controls.MaterialButton neinEntfernBtn;
        private System.Windows.Forms.Label wirklichLoeschenLabel;
    }
}