namespace MyCalories
{
    partial class Form7
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
            this.closeBtn7 = new MaterialSkin.Controls.MaterialButton();
            this.saveChanges7 = new MaterialSkin.Controls.MaterialButton();
            this.gerichtNameBox = new System.Windows.Forms.TextBox();
            this.gerichtName = new System.Windows.Forms.Label();
            this.kategorieComboBox = new System.Windows.Forms.ComboBox();
            this.gerichtKategorie = new System.Windows.Forms.Label();
            this.gebrMengeLabel = new System.Windows.Forms.Label();
            this.gebrMengeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // closeBtn7
            // 
            this.closeBtn7.AutoSize = false;
            this.closeBtn7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeBtn7.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.closeBtn7.Depth = 0;
            this.closeBtn7.HighEmphasis = true;
            this.closeBtn7.Icon = null;
            this.closeBtn7.Location = new System.Drawing.Point(711, 15);
            this.closeBtn7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.closeBtn7.MouseState = MaterialSkin.MouseState.HOVER;
            this.closeBtn7.Name = "closeBtn7";
            this.closeBtn7.NoAccentTextColor = System.Drawing.Color.Empty;
            this.closeBtn7.Size = new System.Drawing.Size(50, 50);
            this.closeBtn7.TabIndex = 23;
            this.closeBtn7.Text = "X";
            this.closeBtn7.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.closeBtn7.UseAccentColor = false;
            this.closeBtn7.UseVisualStyleBackColor = true;
            this.closeBtn7.Click += new System.EventHandler(this.closeBtn7_Click);
            // 
            // saveChanges7
            // 
            this.saveChanges7.AutoSize = false;
            this.saveChanges7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveChanges7.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.saveChanges7.Depth = 0;
            this.saveChanges7.HighEmphasis = true;
            this.saveChanges7.Icon = null;
            this.saveChanges7.Location = new System.Drawing.Point(661, 609);
            this.saveChanges7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveChanges7.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveChanges7.Name = "saveChanges7";
            this.saveChanges7.NoAccentTextColor = System.Drawing.Color.Empty;
            this.saveChanges7.Size = new System.Drawing.Size(100, 50);
            this.saveChanges7.TabIndex = 28;
            this.saveChanges7.Text = "fertig";
            this.saveChanges7.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveChanges7.UseAccentColor = false;
            this.saveChanges7.UseVisualStyleBackColor = true;
            this.saveChanges7.Click += new System.EventHandler(this.saveChanges7_Click);
            // 
            // gerichtNameBox
            // 
            this.gerichtNameBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerichtNameBox.Location = new System.Drawing.Point(144, 101);
            this.gerichtNameBox.Name = "gerichtNameBox";
            this.gerichtNameBox.Size = new System.Drawing.Size(452, 71);
            this.gerichtNameBox.TabIndex = 30;
            // 
            // gerichtName
            // 
            this.gerichtName.AutoSize = true;
            this.gerichtName.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerichtName.Location = new System.Drawing.Point(170, 34);
            this.gerichtName.Name = "gerichtName";
            this.gerichtName.Size = new System.Drawing.Size(410, 64);
            this.gerichtName.TabIndex = 29;
            this.gerichtName.Text = "Name für das Gericht:";
            // 
            // kategorieComboBox
            // 
            this.kategorieComboBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategorieComboBox.FormattingEnabled = true;
            this.kategorieComboBox.Location = new System.Drawing.Point(225, 496);
            this.kategorieComboBox.Name = "kategorieComboBox";
            this.kategorieComboBox.Size = new System.Drawing.Size(300, 72);
            this.kategorieComboBox.TabIndex = 31;
            // 
            // gerichtKategorie
            // 
            this.gerichtKategorie.AutoSize = true;
            this.gerichtKategorie.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerichtKategorie.Location = new System.Drawing.Point(133, 404);
            this.gerichtKategorie.Name = "gerichtKategorie";
            this.gerichtKategorie.Size = new System.Drawing.Size(479, 64);
            this.gerichtKategorie.TabIndex = 32;
            this.gerichtKategorie.Text = "Kategorie für das Gericht:";
            // 
            // gebrMengeLabel
            // 
            this.gebrMengeLabel.AutoSize = true;
            this.gebrMengeLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gebrMengeLabel.Location = new System.Drawing.Point(156, 198);
            this.gebrMengeLabel.Name = "gebrMengeLabel";
            this.gebrMengeLabel.Size = new System.Drawing.Size(424, 64);
            this.gebrMengeLabel.TabIndex = 33;
            this.gebrMengeLabel.Text = "Menge für das Gericht:";
            // 
            // gebrMengeBox
            // 
            this.gebrMengeBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gebrMengeBox.Location = new System.Drawing.Point(144, 290);
            this.gebrMengeBox.Name = "gebrMengeBox";
            this.gebrMengeBox.Size = new System.Drawing.Size(452, 71);
            this.gebrMengeBox.TabIndex = 34;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 674);
            this.ControlBox = false;
            this.Controls.Add(this.gebrMengeBox);
            this.Controls.Add(this.gebrMengeLabel);
            this.Controls.Add(this.gerichtKategorie);
            this.Controls.Add(this.kategorieComboBox);
            this.Controls.Add(this.gerichtNameBox);
            this.Controls.Add(this.gerichtName);
            this.Controls.Add(this.saveChanges7);
            this.Controls.Add(this.closeBtn7);
            this.DoubleBuffered = true;
            this.Name = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton closeBtn7;
        private MaterialSkin.Controls.MaterialButton saveChanges7;
        private System.Windows.Forms.TextBox gerichtNameBox;
        private System.Windows.Forms.Label gerichtName;
        private System.Windows.Forms.ComboBox kategorieComboBox;
        private System.Windows.Forms.Label gerichtKategorie;
        private System.Windows.Forms.Label gebrMengeLabel;
        private System.Windows.Forms.TextBox gebrMengeBox;
    }
}