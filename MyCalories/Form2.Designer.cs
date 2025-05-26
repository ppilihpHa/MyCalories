namespace MyCalories
{
    partial class Form2
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
            this.AddZutatFinal = new MaterialSkin.Controls.MaterialButton();
            this.zutatName = new System.Windows.Forms.Label();
            this.zutatNameBox = new System.Windows.Forms.TextBox();
            this.zutatKalorienBox = new System.Windows.Forms.TextBox();
            this.zutatKalorien = new System.Windows.Forms.Label();
            this.eiweißZutatBox = new System.Windows.Forms.TextBox();
            this.eiweißZutat = new System.Windows.Forms.Label();
            this.zutatGewichtBox = new System.Windows.Forms.TextBox();
            this.zutatGewicht = new System.Windows.Forms.Label();
            this.closeBtn = new MaterialSkin.Controls.MaterialButton();
            this.kategorieComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // AddZutatFinal
            // 
            this.AddZutatFinal.AutoSize = false;
            this.AddZutatFinal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddZutatFinal.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddZutatFinal.Depth = 0;
            this.AddZutatFinal.HighEmphasis = true;
            this.AddZutatFinal.Icon = null;
            this.AddZutatFinal.Location = new System.Drawing.Point(761, 509);
            this.AddZutatFinal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddZutatFinal.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddZutatFinal.Name = "AddZutatFinal";
            this.AddZutatFinal.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddZutatFinal.Size = new System.Drawing.Size(200, 50);
            this.AddZutatFinal.TabIndex = 1;
            this.AddZutatFinal.Text = "hinzufügen";
            this.AddZutatFinal.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddZutatFinal.UseAccentColor = false;
            this.AddZutatFinal.UseVisualStyleBackColor = true;
            this.AddZutatFinal.Click += new System.EventHandler(this.AddZutatFinal_Click);
            // 
            // zutatName
            // 
            this.zutatName.AutoSize = true;
            this.zutatName.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zutatName.Location = new System.Drawing.Point(61, 44);
            this.zutatName.Name = "zutatName";
            this.zutatName.Size = new System.Drawing.Size(135, 64);
            this.zutatName.TabIndex = 3;
            this.zutatName.Text = "Name:";
            // 
            // zutatNameBox
            // 
            this.zutatNameBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zutatNameBox.Location = new System.Drawing.Point(272, 37);
            this.zutatNameBox.Name = "zutatNameBox";
            this.zutatNameBox.Size = new System.Drawing.Size(516, 71);
            this.zutatNameBox.TabIndex = 1;
            // 
            // zutatKalorienBox
            // 
            this.zutatKalorienBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zutatKalorienBox.Location = new System.Drawing.Point(272, 127);
            this.zutatKalorienBox.Name = "zutatKalorienBox";
            this.zutatKalorienBox.Size = new System.Drawing.Size(516, 71);
            this.zutatKalorienBox.TabIndex = 6;
            this.zutatKalorienBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.zutatKalorienBox_KeyDown);
            // 
            // zutatKalorien
            // 
            this.zutatKalorien.AutoSize = true;
            this.zutatKalorien.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zutatKalorien.Location = new System.Drawing.Point(61, 134);
            this.zutatKalorien.Name = "zutatKalorien";
            this.zutatKalorien.Size = new System.Drawing.Size(183, 64);
            this.zutatKalorien.TabIndex = 5;
            this.zutatKalorien.Text = "Kalorien:";
            // 
            // eiweißZutatBox
            // 
            this.eiweißZutatBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eiweißZutatBox.Location = new System.Drawing.Point(272, 216);
            this.eiweißZutatBox.Name = "eiweißZutatBox";
            this.eiweißZutatBox.Size = new System.Drawing.Size(516, 71);
            this.eiweißZutatBox.TabIndex = 8;
            this.eiweißZutatBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eiweißZutatBox_KeyDown);
            // 
            // eiweißZutat
            // 
            this.eiweißZutat.AutoSize = true;
            this.eiweißZutat.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eiweißZutat.Location = new System.Drawing.Point(61, 223);
            this.eiweißZutat.Name = "eiweißZutat";
            this.eiweißZutat.Size = new System.Drawing.Size(150, 64);
            this.eiweißZutat.TabIndex = 7;
            this.eiweißZutat.Text = "Eiweiß:";
            // 
            // zutatGewichtBox
            // 
            this.zutatGewichtBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zutatGewichtBox.Location = new System.Drawing.Point(272, 310);
            this.zutatGewichtBox.Name = "zutatGewichtBox";
            this.zutatGewichtBox.Size = new System.Drawing.Size(516, 71);
            this.zutatGewichtBox.TabIndex = 10;
            this.zutatGewichtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.zutatGewichtBox_KeyDown);
            // 
            // zutatGewicht
            // 
            this.zutatGewicht.AutoSize = true;
            this.zutatGewicht.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zutatGewicht.Location = new System.Drawing.Point(61, 317);
            this.zutatGewicht.Name = "zutatGewicht";
            this.zutatGewicht.Size = new System.Drawing.Size(176, 64);
            this.zutatGewicht.TabIndex = 9;
            this.zutatGewicht.Text = "Gewicht:";
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSize = false;
            this.closeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.closeBtn.Depth = 0;
            this.closeBtn.HighEmphasis = true;
            this.closeBtn.Icon = null;
            this.closeBtn.Location = new System.Drawing.Point(861, 15);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.closeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.closeBtn.Size = new System.Drawing.Size(100, 50);
            this.closeBtn.TabIndex = 11;
            this.closeBtn.Text = "X";
            this.closeBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.closeBtn.UseAccentColor = false;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // kategorieComboBox
            // 
            this.kategorieComboBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategorieComboBox.FormattingEnabled = true;
            this.kategorieComboBox.Location = new System.Drawing.Point(272, 407);
            this.kategorieComboBox.Name = "kategorieComboBox";
            this.kategorieComboBox.Size = new System.Drawing.Size(411, 72);
            this.kategorieComboBox.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(974, 574);
            this.ControlBox = false;
            this.Controls.Add(this.kategorieComboBox);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.zutatGewichtBox);
            this.Controls.Add(this.zutatGewicht);
            this.Controls.Add(this.eiweißZutatBox);
            this.Controls.Add(this.eiweißZutat);
            this.Controls.Add(this.zutatKalorienBox);
            this.Controls.Add(this.zutatKalorien);
            this.Controls.Add(this.zutatNameBox);
            this.Controls.Add(this.zutatName);
            this.Controls.Add(this.AddZutatFinal);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton AddZutatFinal;
        private System.Windows.Forms.Label zutatName;
        private System.Windows.Forms.TextBox zutatNameBox;
        private System.Windows.Forms.TextBox zutatKalorienBox;
        private System.Windows.Forms.Label zutatKalorien;
        private System.Windows.Forms.TextBox eiweißZutatBox;
        private System.Windows.Forms.Label eiweißZutat;
        private System.Windows.Forms.TextBox zutatGewichtBox;
        private System.Windows.Forms.Label zutatGewicht;
        private MaterialSkin.Controls.MaterialButton closeBtn;
        private System.Windows.Forms.ComboBox kategorieComboBox;
    }
}