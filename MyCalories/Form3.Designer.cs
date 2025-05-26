namespace MyCalories
{
    partial class Form3
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
            this.saveBtn = new MaterialSkin.Controls.MaterialButton();
            this.zutatDelNameBox = new System.Windows.Forms.TextBox();
            this.zutatName = new System.Windows.Forms.Label();
            this.closeBtn = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
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
            this.saveBtn.TabIndex = 20;
            this.saveBtn.Text = "Fertig";
            this.saveBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveBtn.UseAccentColor = false;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // zutatDelNameBox
            // 
            this.zutatDelNameBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zutatDelNameBox.Location = new System.Drawing.Point(226, 231);
            this.zutatDelNameBox.Name = "zutatDelNameBox";
            this.zutatDelNameBox.Size = new System.Drawing.Size(300, 71);
            this.zutatDelNameBox.TabIndex = 13;
            // 
            // zutatName
            // 
            this.zutatName.AutoSize = true;
            this.zutatName.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zutatName.Location = new System.Drawing.Point(103, 164);
            this.zutatName.Name = "zutatName";
            this.zutatName.Size = new System.Drawing.Size(571, 64);
            this.zutatName.TabIndex = 12;
            this.zutatName.Text = "Name der zu löschenden Zutat:";
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
            this.closeBtn.TabIndex = 21;
            this.closeBtn.Text = "X";
            this.closeBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.closeBtn.UseAccentColor = false;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click_1);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 529);
            this.ControlBox = false;
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.zutatDelNameBox);
            this.Controls.Add(this.zutatName);
            this.DoubleBuffered = true;
            this.Name = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton saveBtn;
        private System.Windows.Forms.TextBox zutatDelNameBox;
        private System.Windows.Forms.Label zutatName;
        private MaterialSkin.Controls.MaterialButton closeBtn;
    }
}