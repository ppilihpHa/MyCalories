namespace MyCalories
{
    partial class Form8
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
            this.sollZutatFinal = new MaterialSkin.Controls.MaterialButton();
            this.sollKalorienBox = new System.Windows.Forms.TextBox();
            this.sollKalorien = new System.Windows.Forms.Label();
            this.zielEiweißBox = new System.Windows.Forms.TextBox();
            this.zielEiweißLabel = new System.Windows.Forms.Label();
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
            this.closeBtn.Location = new System.Drawing.Point(711, 15);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.closeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.closeBtn.Size = new System.Drawing.Size(50, 50);
            this.closeBtn.TabIndex = 13;
            this.closeBtn.Text = "X";
            this.closeBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.closeBtn.UseAccentColor = false;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // sollZutatFinal
            // 
            this.sollZutatFinal.AutoSize = false;
            this.sollZutatFinal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sollZutatFinal.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.sollZutatFinal.Depth = 0;
            this.sollZutatFinal.HighEmphasis = true;
            this.sollZutatFinal.Icon = null;
            this.sollZutatFinal.Location = new System.Drawing.Point(661, 509);
            this.sollZutatFinal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.sollZutatFinal.MouseState = MaterialSkin.MouseState.HOVER;
            this.sollZutatFinal.Name = "sollZutatFinal";
            this.sollZutatFinal.NoAccentTextColor = System.Drawing.Color.Empty;
            this.sollZutatFinal.Size = new System.Drawing.Size(100, 50);
            this.sollZutatFinal.TabIndex = 12;
            this.sollZutatFinal.Text = "Fertig";
            this.sollZutatFinal.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.sollZutatFinal.UseAccentColor = false;
            this.sollZutatFinal.UseVisualStyleBackColor = true;
            this.sollZutatFinal.Click += new System.EventHandler(this.sollZutatFinal_Click);
            // 
            // sollKalorienBox
            // 
            this.sollKalorienBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sollKalorienBox.Location = new System.Drawing.Point(208, 181);
            this.sollKalorienBox.Name = "sollKalorienBox";
            this.sollKalorienBox.Size = new System.Drawing.Size(300, 71);
            this.sollKalorienBox.TabIndex = 15;
            // 
            // sollKalorien
            // 
            this.sollKalorien.AutoSize = true;
            this.sollKalorien.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sollKalorien.Location = new System.Drawing.Point(180, 99);
            this.sollKalorien.Name = "sollKalorien";
            this.sollKalorien.Size = new System.Drawing.Size(365, 64);
            this.sollKalorien.TabIndex = 14;
            this.sollKalorien.Text = "Maximale Kalorien:";
            // 
            // zielEiweißBox
            // 
            this.zielEiweißBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zielEiweißBox.Location = new System.Drawing.Point(208, 354);
            this.zielEiweißBox.Name = "zielEiweißBox";
            this.zielEiweißBox.Size = new System.Drawing.Size(300, 71);
            this.zielEiweißBox.TabIndex = 17;
            // 
            // zielEiweißLabel
            // 
            this.zielEiweißLabel.AutoSize = true;
            this.zielEiweißLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zielEiweißLabel.Location = new System.Drawing.Point(162, 272);
            this.zielEiweißLabel.Name = "zielEiweißLabel";
            this.zielEiweißLabel.Size = new System.Drawing.Size(393, 64);
            this.zielEiweißLabel.TabIndex = 16;
            this.zielEiweißLabel.Text = "Gewünschtes Eiweiß:";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 574);
            this.ControlBox = false;
            this.Controls.Add(this.zielEiweißBox);
            this.Controls.Add(this.zielEiweißLabel);
            this.Controls.Add(this.sollKalorienBox);
            this.Controls.Add(this.sollKalorien);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.sollZutatFinal);
            this.Name = "Form8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton closeBtn;
        private MaterialSkin.Controls.MaterialButton sollZutatFinal;
        private System.Windows.Forms.TextBox sollKalorienBox;
        private System.Windows.Forms.Label sollKalorien;
        private System.Windows.Forms.TextBox zielEiweißBox;
        private System.Windows.Forms.Label zielEiweißLabel;
    }
}