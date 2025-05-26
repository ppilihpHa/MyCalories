namespace MyCalories
{
    partial class Form9
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
            this.delButton = new MaterialSkin.Controls.MaterialButton();
            this.closeBtn5 = new MaterialSkin.Controls.MaterialButton();
            this.saveChanges = new MaterialSkin.Controls.MaterialButton();
            this.neueMengeBox = new System.Windows.Forms.TextBox();
            this.neueMenge = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // delButton
            // 
            this.delButton.AutoSize = false;
            this.delButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.delButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.delButton.Depth = 0;
            this.delButton.HighEmphasis = true;
            this.delButton.Icon = null;
            this.delButton.Location = new System.Drawing.Point(13, 509);
            this.delButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.delButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.delButton.Name = "delButton";
            this.delButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.delButton.Size = new System.Drawing.Size(200, 50);
            this.delButton.TabIndex = 34;
            this.delButton.Text = "Löschen";
            this.delButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.delButton.UseAccentColor = false;
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // closeBtn5
            // 
            this.closeBtn5.AutoSize = false;
            this.closeBtn5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeBtn5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.closeBtn5.Depth = 0;
            this.closeBtn5.HighEmphasis = true;
            this.closeBtn5.Icon = null;
            this.closeBtn5.Location = new System.Drawing.Point(711, 15);
            this.closeBtn5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.closeBtn5.MouseState = MaterialSkin.MouseState.HOVER;
            this.closeBtn5.Name = "closeBtn5";
            this.closeBtn5.NoAccentTextColor = System.Drawing.Color.Empty;
            this.closeBtn5.Size = new System.Drawing.Size(50, 50);
            this.closeBtn5.TabIndex = 35;
            this.closeBtn5.Text = "X";
            this.closeBtn5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.closeBtn5.UseAccentColor = false;
            this.closeBtn5.UseVisualStyleBackColor = true;
            this.closeBtn5.Click += new System.EventHandler(this.closeBtn5_Click);
            // 
            // saveChanges
            // 
            this.saveChanges.AutoSize = false;
            this.saveChanges.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveChanges.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.saveChanges.Depth = 0;
            this.saveChanges.HighEmphasis = true;
            this.saveChanges.Icon = null;
            this.saveChanges.Location = new System.Drawing.Point(611, 509);
            this.saveChanges.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveChanges.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.NoAccentTextColor = System.Drawing.Color.Empty;
            this.saveChanges.Size = new System.Drawing.Size(150, 50);
            this.saveChanges.TabIndex = 36;
            this.saveChanges.Text = "Speichern";
            this.saveChanges.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveChanges.UseAccentColor = false;
            this.saveChanges.UseVisualStyleBackColor = true;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // neueMengeBox
            // 
            this.neueMengeBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neueMengeBox.Location = new System.Drawing.Point(356, 221);
            this.neueMengeBox.Name = "neueMengeBox";
            this.neueMengeBox.Size = new System.Drawing.Size(392, 71);
            this.neueMengeBox.TabIndex = 38;
            this.neueMengeBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.neueMengeBox_KeyDown);
            // 
            // neueMenge
            // 
            this.neueMenge.AutoSize = true;
            this.neueMenge.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neueMenge.Location = new System.Drawing.Point(42, 228);
            this.neueMenge.Name = "neueMenge";
            this.neueMenge.Size = new System.Drawing.Size(245, 64);
            this.neueMenge.TabIndex = 37;
            this.neueMenge.Text = "neue Menge:";
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 574);
            this.ControlBox = false;
            this.Controls.Add(this.neueMengeBox);
            this.Controls.Add(this.neueMenge);
            this.Controls.Add(this.saveChanges);
            this.Controls.Add(this.closeBtn5);
            this.Controls.Add(this.delButton);
            this.Name = "Form9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton delButton;
        private MaterialSkin.Controls.MaterialButton closeBtn5;
        private MaterialSkin.Controls.MaterialButton saveChanges;
        private System.Windows.Forms.TextBox neueMengeBox;
        private System.Windows.Forms.Label neueMenge;
    }
}