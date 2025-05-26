namespace MyCalories
{
    partial class Form4
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
            this.closeBtn = new MaterialSkin.Controls.MaterialButton();
            this.form4Ueberschrift1 = new System.Windows.Forms.Label();
            this.form4Ueberschrift2 = new System.Windows.Forms.Label();
            this.wieVielBox = new System.Windows.Forms.TextBox();
            this.welcheZutatBox = new System.Windows.Forms.TextBox();
            this.addMahlBttn = new MaterialSkin.Controls.MaterialButton();
            this.wannBox = new System.Windows.Forms.TextBox();
            this.wannLabel = new System.Windows.Forms.Label();
            this.subTag = new MaterialSkin.Controls.MaterialButton();
            this.addTag = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSize = false;
            this.closeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.closeBtn.Depth = 0;
            this.closeBtn.HighEmphasis = true;
            this.closeBtn.Icon = null;
            this.closeBtn.Location = new System.Drawing.Point(911, 15);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.closeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.closeBtn.Size = new System.Drawing.Size(50, 50);
            this.closeBtn.TabIndex = 21;
            this.closeBtn.Text = "X";
            this.closeBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.closeBtn.UseAccentColor = false;
            this.closeBtn.UseCompatibleTextRendering = true;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click_1);
            // 
            // form4Ueberschrift1
            // 
            this.form4Ueberschrift1.AutoSize = true;
            this.form4Ueberschrift1.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form4Ueberschrift1.Location = new System.Drawing.Point(115, 15);
            this.form4Ueberschrift1.Name = "form4Ueberschrift1";
            this.form4Ueberschrift1.Size = new System.Drawing.Size(263, 64);
            this.form4Ueberschrift1.TabIndex = 23;
            this.form4Ueberschrift1.Text = "welche Zutat:";
            // 
            // form4Ueberschrift2
            // 
            this.form4Ueberschrift2.AutoSize = true;
            this.form4Ueberschrift2.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form4Ueberschrift2.Location = new System.Drawing.Point(115, 188);
            this.form4Ueberschrift2.Name = "form4Ueberschrift2";
            this.form4Ueberschrift2.Size = new System.Drawing.Size(174, 64);
            this.form4Ueberschrift2.TabIndex = 24;
            this.form4Ueberschrift2.Text = "wie viel:";
            // 
            // wieVielBox
            // 
            this.wieVielBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wieVielBox.Location = new System.Drawing.Point(111, 278);
            this.wieVielBox.Name = "wieVielBox";
            this.wieVielBox.Size = new System.Drawing.Size(300, 71);
            this.wieVielBox.TabIndex = 1;
            this.wieVielBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.wieVielBox_KeyDown);
            // 
            // welcheZutatBox
            // 
            this.welcheZutatBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcheZutatBox.Location = new System.Drawing.Point(111, 97);
            this.welcheZutatBox.Name = "welcheZutatBox";
            this.welcheZutatBox.Size = new System.Drawing.Size(525, 71);
            this.welcheZutatBox.TabIndex = 26;
            this.welcheZutatBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.welcheZutatBox_KeyDown);
            // 
            // addMahlBttn
            // 
            this.addMahlBttn.AutoSize = false;
            this.addMahlBttn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addMahlBttn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addMahlBttn.Depth = 0;
            this.addMahlBttn.HighEmphasis = true;
            this.addMahlBttn.Icon = null;
            this.addMahlBttn.Location = new System.Drawing.Point(811, 509);
            this.addMahlBttn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addMahlBttn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addMahlBttn.Name = "addMahlBttn";
            this.addMahlBttn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addMahlBttn.Size = new System.Drawing.Size(150, 50);
            this.addMahlBttn.TabIndex = 2;
            this.addMahlBttn.Text = "&Speichern";
            this.addMahlBttn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addMahlBttn.UseAccentColor = false;
            this.addMahlBttn.UseVisualStyleBackColor = true;
            this.addMahlBttn.Click += new System.EventHandler(this.addMahlBttn_Click);
            // 
            // wannBox
            // 
            this.wannBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wannBox.Location = new System.Drawing.Point(111, 464);
            this.wannBox.Name = "wannBox";
            this.wannBox.ReadOnly = true;
            this.wannBox.Size = new System.Drawing.Size(300, 71);
            this.wannBox.TabIndex = 29;
            // 
            // wannLabel
            // 
            this.wannLabel.AutoSize = true;
            this.wannLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wannLabel.Location = new System.Drawing.Point(115, 374);
            this.wannLabel.Name = "wannLabel";
            this.wannLabel.Size = new System.Drawing.Size(132, 64);
            this.wannLabel.TabIndex = 28;
            this.wannLabel.Text = "wann:";
            // 
            // subTag
            // 
            this.subTag.AutoSize = false;
            this.subTag.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.subTag.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.subTag.Depth = 0;
            this.subTag.HighEmphasis = true;
            this.subTag.Icon = null;
            this.subTag.Location = new System.Drawing.Point(54, 485);
            this.subTag.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.subTag.MouseState = MaterialSkin.MouseState.HOVER;
            this.subTag.Name = "subTag";
            this.subTag.NoAccentTextColor = System.Drawing.Color.Empty;
            this.subTag.Size = new System.Drawing.Size(50, 50);
            this.subTag.TabIndex = 30;
            this.subTag.Text = "-";
            this.subTag.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.subTag.UseAccentColor = false;
            this.subTag.UseVisualStyleBackColor = true;
            this.subTag.Click += new System.EventHandler(this.subTag_Click);
            this.subTag.KeyDown += new System.Windows.Forms.KeyEventHandler(this.subTag_KeyDown);
            // 
            // addTag
            // 
            this.addTag.AutoSize = false;
            this.addTag.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addTag.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addTag.Depth = 0;
            this.addTag.HighEmphasis = true;
            this.addTag.Icon = null;
            this.addTag.Location = new System.Drawing.Point(429, 485);
            this.addTag.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addTag.MouseState = MaterialSkin.MouseState.HOVER;
            this.addTag.Name = "addTag";
            this.addTag.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addTag.Size = new System.Drawing.Size(50, 50);
            this.addTag.TabIndex = 31;
            this.addTag.Text = "+";
            this.addTag.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addTag.UseAccentColor = false;
            this.addTag.UseVisualStyleBackColor = true;
            this.addTag.Click += new System.EventHandler(this.addTag_Click);
            this.addTag.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addTag_KeyDown);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 574);
            this.ControlBox = false;
            this.Controls.Add(this.addTag);
            this.Controls.Add(this.subTag);
            this.Controls.Add(this.wannBox);
            this.Controls.Add(this.wannLabel);
            this.Controls.Add(this.addMahlBttn);
            this.Controls.Add(this.welcheZutatBox);
            this.Controls.Add(this.wieVielBox);
            this.Controls.Add(this.form4Ueberschrift2);
            this.Controls.Add(this.form4Ueberschrift1);
            this.Controls.Add(this.closeBtn);
            this.DoubleBuffered = true;
            this.Name = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton closeBtn;
        private System.Windows.Forms.Label form4Ueberschrift1;
        private System.Windows.Forms.Label form4Ueberschrift2;
        private System.Windows.Forms.TextBox wieVielBox;
        public System.Windows.Forms.TextBox welcheZutatBox;
        private MaterialSkin.Controls.MaterialButton addMahlBttn;
        private System.Windows.Forms.TextBox wannBox;
        private System.Windows.Forms.Label wannLabel;
        private MaterialSkin.Controls.MaterialButton subTag;
        private MaterialSkin.Controls.MaterialButton addTag;
    }
}