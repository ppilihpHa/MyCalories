namespace MyCalories
{
    partial class Form5
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.closeBtn5 = new MaterialSkin.Controls.MaterialButton();
            this.zutatGewichtBox5 = new System.Windows.Forms.TextBox();
            this.zutatGewicht5 = new System.Windows.Forms.Label();
            this.eiweißZutatBox5 = new System.Windows.Forms.TextBox();
            this.eiweißZutat5 = new System.Windows.Forms.Label();
            this.zutatKalorienBox5 = new System.Windows.Forms.TextBox();
            this.zutatKalorien5 = new System.Windows.Forms.Label();
            this.zutatNameBox5 = new System.Windows.Forms.TextBox();
            this.zutatName5 = new System.Windows.Forms.Label();
            this.saveChanges = new MaterialSkin.Controls.MaterialButton();
            this.rezeptGrid = new System.Windows.Forms.DataGridView();
            this.kategorieComboBox = new System.Windows.Forms.ComboBox();
            this.delButton = new MaterialSkin.Controls.MaterialButton();
            this.zutsBearbeiten = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.rezeptGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // closeBtn5
            // 
            this.closeBtn5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn5.AutoSize = false;
            this.closeBtn5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeBtn5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.closeBtn5.Depth = 0;
            this.closeBtn5.HighEmphasis = true;
            this.closeBtn5.Icon = null;
            this.closeBtn5.Location = new System.Drawing.Point(1211, 15);
            this.closeBtn5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.closeBtn5.MouseState = MaterialSkin.MouseState.HOVER;
            this.closeBtn5.Name = "closeBtn5";
            this.closeBtn5.NoAccentTextColor = System.Drawing.Color.Empty;
            this.closeBtn5.Size = new System.Drawing.Size(50, 50);
            this.closeBtn5.TabIndex = 21;
            this.closeBtn5.Text = "X";
            this.closeBtn5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.closeBtn5.UseAccentColor = false;
            this.closeBtn5.UseVisualStyleBackColor = true;
            this.closeBtn5.Click += new System.EventHandler(this.closeBtn5_Click);
            // 
            // zutatGewichtBox5
            // 
            this.zutatGewichtBox5.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zutatGewichtBox5.Location = new System.Drawing.Point(211, 358);
            this.zutatGewichtBox5.Name = "zutatGewichtBox5";
            this.zutatGewichtBox5.Size = new System.Drawing.Size(392, 71);
            this.zutatGewichtBox5.TabIndex = 20;
            // 
            // zutatGewicht5
            // 
            this.zutatGewicht5.AutoSize = true;
            this.zutatGewicht5.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zutatGewicht5.Location = new System.Drawing.Point(21, 365);
            this.zutatGewicht5.Name = "zutatGewicht5";
            this.zutatGewicht5.Size = new System.Drawing.Size(176, 64);
            this.zutatGewicht5.TabIndex = 19;
            this.zutatGewicht5.Text = "Gewicht:";
            // 
            // eiweißZutatBox5
            // 
            this.eiweißZutatBox5.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eiweißZutatBox5.Location = new System.Drawing.Point(211, 264);
            this.eiweißZutatBox5.Name = "eiweißZutatBox5";
            this.eiweißZutatBox5.Size = new System.Drawing.Size(392, 71);
            this.eiweißZutatBox5.TabIndex = 18;
            // 
            // eiweißZutat5
            // 
            this.eiweißZutat5.AutoSize = true;
            this.eiweißZutat5.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eiweißZutat5.Location = new System.Drawing.Point(21, 271);
            this.eiweißZutat5.Name = "eiweißZutat5";
            this.eiweißZutat5.Size = new System.Drawing.Size(150, 64);
            this.eiweißZutat5.TabIndex = 17;
            this.eiweißZutat5.Text = "Eiweiß:";
            // 
            // zutatKalorienBox5
            // 
            this.zutatKalorienBox5.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zutatKalorienBox5.Location = new System.Drawing.Point(211, 175);
            this.zutatKalorienBox5.Name = "zutatKalorienBox5";
            this.zutatKalorienBox5.Size = new System.Drawing.Size(392, 71);
            this.zutatKalorienBox5.TabIndex = 16;
            // 
            // zutatKalorien5
            // 
            this.zutatKalorien5.AutoSize = true;
            this.zutatKalorien5.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zutatKalorien5.Location = new System.Drawing.Point(21, 182);
            this.zutatKalorien5.Name = "zutatKalorien5";
            this.zutatKalorien5.Size = new System.Drawing.Size(183, 64);
            this.zutatKalorien5.TabIndex = 15;
            this.zutatKalorien5.Text = "Kalorien:";
            // 
            // zutatNameBox5
            // 
            this.zutatNameBox5.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zutatNameBox5.Location = new System.Drawing.Point(211, 85);
            this.zutatNameBox5.Name = "zutatNameBox5";
            this.zutatNameBox5.Size = new System.Drawing.Size(392, 71);
            this.zutatNameBox5.TabIndex = 14;
            // 
            // zutatName5
            // 
            this.zutatName5.AutoSize = true;
            this.zutatName5.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zutatName5.Location = new System.Drawing.Point(21, 92);
            this.zutatName5.Name = "zutatName5";
            this.zutatName5.Size = new System.Drawing.Size(135, 64);
            this.zutatName5.TabIndex = 13;
            this.zutatName5.Text = "Name:";
            // 
            // saveChanges
            // 
            this.saveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveChanges.AutoSize = false;
            this.saveChanges.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveChanges.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.saveChanges.Depth = 0;
            this.saveChanges.HighEmphasis = true;
            this.saveChanges.Icon = null;
            this.saveChanges.Location = new System.Drawing.Point(1111, 509);
            this.saveChanges.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveChanges.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.NoAccentTextColor = System.Drawing.Color.Empty;
            this.saveChanges.Size = new System.Drawing.Size(150, 50);
            this.saveChanges.TabIndex = 12;
            this.saveChanges.Text = "Speichern";
            this.saveChanges.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveChanges.UseAccentColor = false;
            this.saveChanges.UseVisualStyleBackColor = true;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // rezeptGrid
            // 
            this.rezeptGrid.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.rezeptGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rezeptGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.rezeptGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rezeptGrid.EnableHeadersVisualStyles = false;
            this.rezeptGrid.GridColor = System.Drawing.SystemColors.MenuText;
            this.rezeptGrid.Location = new System.Drawing.Point(636, 85);
            this.rezeptGrid.Name = "rezeptGrid";
            this.rezeptGrid.RowHeadersVisible = false;
            this.rezeptGrid.RowHeadersWidth = 82;
            this.rezeptGrid.RowTemplate.Height = 33;
            this.rezeptGrid.Size = new System.Drawing.Size(458, 452);
            this.rezeptGrid.TabIndex = 27;
            // 
            // kategorieComboBox
            // 
            this.kategorieComboBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategorieComboBox.FormattingEnabled = true;
            this.kategorieComboBox.Location = new System.Drawing.Point(303, 465);
            this.kategorieComboBox.Name = "kategorieComboBox";
            this.kategorieComboBox.Size = new System.Drawing.Size(300, 72);
            this.kategorieComboBox.TabIndex = 28;
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
            this.delButton.TabIndex = 33;
            this.delButton.Text = "Löschen";
            this.delButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.delButton.UseAccentColor = false;
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // zutsBearbeiten
            // 
            this.zutsBearbeiten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zutsBearbeiten.AutoSize = false;
            this.zutsBearbeiten.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.zutsBearbeiten.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.zutsBearbeiten.Depth = 0;
            this.zutsBearbeiten.HighEmphasis = true;
            this.zutsBearbeiten.Icon = null;
            this.zutsBearbeiten.Location = new System.Drawing.Point(13, 15);
            this.zutsBearbeiten.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.zutsBearbeiten.MouseState = MaterialSkin.MouseState.HOVER;
            this.zutsBearbeiten.Name = "zutsBearbeiten";
            this.zutsBearbeiten.NoAccentTextColor = System.Drawing.Color.Empty;
            this.zutsBearbeiten.Size = new System.Drawing.Size(200, 50);
            this.zutsBearbeiten.TabIndex = 34;
            this.zutsBearbeiten.Text = "Bearbeiten";
            this.zutsBearbeiten.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.zutsBearbeiten.UseAccentColor = false;
            this.zutsBearbeiten.UseVisualStyleBackColor = true;
            this.zutsBearbeiten.Click += new System.EventHandler(this.zutsBearbeiten_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 574);
            this.ControlBox = false;
            this.Controls.Add(this.zutsBearbeiten);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.kategorieComboBox);
            this.Controls.Add(this.rezeptGrid);
            this.Controls.Add(this.closeBtn5);
            this.Controls.Add(this.zutatGewichtBox5);
            this.Controls.Add(this.zutatGewicht5);
            this.Controls.Add(this.eiweißZutatBox5);
            this.Controls.Add(this.eiweißZutat5);
            this.Controls.Add(this.zutatKalorienBox5);
            this.Controls.Add(this.zutatKalorien5);
            this.Controls.Add(this.zutatNameBox5);
            this.Controls.Add(this.zutatName5);
            this.Controls.Add(this.saveChanges);
            this.DoubleBuffered = true;
            this.Name = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.rezeptGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton closeBtn5;
        private System.Windows.Forms.TextBox zutatGewichtBox5;
        private System.Windows.Forms.Label zutatGewicht5;
        private System.Windows.Forms.TextBox eiweißZutatBox5;
        private System.Windows.Forms.Label eiweißZutat5;
        private System.Windows.Forms.TextBox zutatKalorienBox5;
        private System.Windows.Forms.Label zutatKalorien5;
        private System.Windows.Forms.TextBox zutatNameBox5;
        private System.Windows.Forms.Label zutatName5;
        private MaterialSkin.Controls.MaterialButton saveChanges;
        private System.Windows.Forms.DataGridView rezeptGrid;
        private System.Windows.Forms.ComboBox kategorieComboBox;
        private MaterialSkin.Controls.MaterialButton delButton;
        private MaterialSkin.Controls.MaterialButton zutsBearbeiten;
    }
}