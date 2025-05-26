namespace MyCalories
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.addZutat = new MaterialSkin.Controls.MaterialButton();
            this.menuBoard = new System.Windows.Forms.DataGridView();
            this.gesamtLabel = new System.Windows.Forms.Label();
            this.addMahlzeit = new MaterialSkin.Controls.MaterialButton();
            this.sucheBox = new System.Windows.Forms.TextBox();
            this.suchLabel = new System.Windows.Forms.Label();
            this.tagRechner = new System.Windows.Forms.DataGridView();
            this.gesamtLabel2 = new System.Windows.Forms.Label();
            this.datumMinus = new MaterialSkin.Controls.MaterialButton();
            this.datumPlus = new MaterialSkin.Controls.MaterialButton();
            this.datumLabel = new System.Windows.Forms.Label();
            this.kategorieComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.isFilteredCheckBox = new System.Windows.Forms.CheckBox();
            this.sollBtn = new MaterialSkin.Controls.MaterialButton();
            this.progressBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.zielLabel = new System.Windows.Forms.Label();
            this.zielEiwLabel = new System.Windows.Forms.Label();
            this.progressBarEiw = new MaterialSkin.Controls.MaterialProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.menuBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagRechner)).BeginInit();
            this.SuspendLayout();
            // 
            // addZutat
            // 
            this.addZutat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addZutat.AutoSize = false;
            this.addZutat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addZutat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addZutat.Depth = 0;
            this.addZutat.HighEmphasis = true;
            this.addZutat.Icon = null;
            this.addZutat.Location = new System.Drawing.Point(25, 687);
            this.addZutat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addZutat.MouseState = MaterialSkin.MouseState.HOVER;
            this.addZutat.Name = "addZutat";
            this.addZutat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addZutat.Size = new System.Drawing.Size(100, 100);
            this.addZutat.TabIndex = 0;
            this.addZutat.Text = "Zutat hinzufügen";
            this.addZutat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addZutat.UseAccentColor = false;
            this.addZutat.UseVisualStyleBackColor = true;
            this.addZutat.Click += new System.EventHandler(this.addZutat_Click);
            // 
            // menuBoard
            // 
            this.menuBoard.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.menuBoard.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.menuBoard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.menuBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuBoard.EnableHeadersVisualStyles = false;
            this.menuBoard.GridColor = System.Drawing.SystemColors.MenuText;
            this.menuBoard.Location = new System.Drawing.Point(25, 125);
            this.menuBoard.Name = "menuBoard";
            this.menuBoard.RowHeadersVisible = false;
            this.menuBoard.RowHeadersWidth = 82;
            this.menuBoard.RowTemplate.Height = 33;
            this.menuBoard.Size = new System.Drawing.Size(684, 485);
            this.menuBoard.TabIndex = 2;
            this.menuBoard.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.menuBoard_CellMouseClick);
            this.menuBoard.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.menuBoard_ColumnHeaderMouseClick);
            // 
            // gesamtLabel
            // 
            this.gesamtLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gesamtLabel.AutoSize = true;
            this.gesamtLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gesamtLabel.Location = new System.Drawing.Point(726, 653);
            this.gesamtLabel.Name = "gesamtLabel";
            this.gesamtLabel.Size = new System.Drawing.Size(240, 58);
            this.gesamtLabel.TabIndex = 4;
            this.gesamtLabel.Text = "kCal-Gesamt:";
            // 
            // addMahlzeit
            // 
            this.addMahlzeit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addMahlzeit.AutoSize = false;
            this.addMahlzeit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addMahlzeit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addMahlzeit.Depth = 0;
            this.addMahlzeit.HighEmphasis = true;
            this.addMahlzeit.Icon = null;
            this.addMahlzeit.Location = new System.Drawing.Point(133, 687);
            this.addMahlzeit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addMahlzeit.MouseState = MaterialSkin.MouseState.HOVER;
            this.addMahlzeit.Name = "addMahlzeit";
            this.addMahlzeit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addMahlzeit.Size = new System.Drawing.Size(100, 100);
            this.addMahlzeit.TabIndex = 5;
            this.addMahlzeit.Text = "Gericht hinzufügen";
            this.addMahlzeit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addMahlzeit.UseAccentColor = false;
            this.addMahlzeit.UseVisualStyleBackColor = true;
            this.addMahlzeit.Click += new System.EventHandler(this.addMahlzeit_Click);
            // 
            // sucheBox
            // 
            this.sucheBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sucheBox.Location = new System.Drawing.Point(387, 71);
            this.sucheBox.Name = "sucheBox";
            this.sucheBox.Size = new System.Drawing.Size(322, 71);
            this.sucheBox.TabIndex = 6;
            this.sucheBox.Click += new System.EventHandler(this.sucheBox_Click);
            this.sucheBox.TextChanged += new System.EventHandler(this.sucheBox_TextChanged);
            // 
            // suchLabel
            // 
            this.suchLabel.AutoSize = true;
            this.suchLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suchLabel.Location = new System.Drawing.Point(240, 71);
            this.suchLabel.Name = "suchLabel";
            this.suchLabel.Size = new System.Drawing.Size(130, 58);
            this.suchLabel.TabIndex = 7;
            this.suchLabel.Text = "Suche:";
            // 
            // tagRechner
            // 
            this.tagRechner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tagRechner.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.tagRechner.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tagRechner.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tagRechner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tagRechner.EnableHeadersVisualStyles = false;
            this.tagRechner.GridColor = System.Drawing.SystemColors.MenuText;
            this.tagRechner.Location = new System.Drawing.Point(736, 125);
            this.tagRechner.Name = "tagRechner";
            this.tagRechner.RowHeadersVisible = false;
            this.tagRechner.RowHeadersWidth = 82;
            this.tagRechner.RowTemplate.Height = 33;
            this.tagRechner.Size = new System.Drawing.Size(661, 525);
            this.tagRechner.TabIndex = 8;
            this.tagRechner.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tagRechner_CellMouseClick);
            // 
            // gesamtLabel2
            // 
            this.gesamtLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gesamtLabel2.AutoSize = true;
            this.gesamtLabel2.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gesamtLabel2.Location = new System.Drawing.Point(1042, 653);
            this.gesamtLabel2.Name = "gesamtLabel2";
            this.gesamtLabel2.Size = new System.Drawing.Size(274, 58);
            this.gesamtLabel2.TabIndex = 9;
            this.gesamtLabel2.Text = "Eiweiß-Gesamt:";
            // 
            // datumMinus
            // 
            this.datumMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datumMinus.AutoSize = false;
            this.datumMinus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.datumMinus.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.datumMinus.Depth = 0;
            this.datumMinus.HighEmphasis = true;
            this.datumMinus.Icon = null;
            this.datumMinus.Location = new System.Drawing.Point(1089, 71);
            this.datumMinus.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.datumMinus.MouseState = MaterialSkin.MouseState.HOVER;
            this.datumMinus.Name = "datumMinus";
            this.datumMinus.NoAccentTextColor = System.Drawing.Color.Empty;
            this.datumMinus.Size = new System.Drawing.Size(150, 45);
            this.datumMinus.TabIndex = 10;
            this.datumMinus.Text = "Datum minus";
            this.datumMinus.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.datumMinus.UseAccentColor = false;
            this.datumMinus.UseVisualStyleBackColor = true;
            this.datumMinus.Click += new System.EventHandler(this.datumMinus_Click);
            // 
            // datumPlus
            // 
            this.datumPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datumPlus.AutoSize = false;
            this.datumPlus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.datumPlus.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.datumPlus.Depth = 0;
            this.datumPlus.HighEmphasis = true;
            this.datumPlus.Icon = null;
            this.datumPlus.Location = new System.Drawing.Point(1247, 71);
            this.datumPlus.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.datumPlus.MouseState = MaterialSkin.MouseState.HOVER;
            this.datumPlus.Name = "datumPlus";
            this.datumPlus.NoAccentTextColor = System.Drawing.Color.Empty;
            this.datumPlus.Size = new System.Drawing.Size(150, 45);
            this.datumPlus.TabIndex = 11;
            this.datumPlus.Text = "Datum plus";
            this.datumPlus.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.datumPlus.UseAccentColor = false;
            this.datumPlus.UseVisualStyleBackColor = true;
            this.datumPlus.Click += new System.EventHandler(this.datumPlus_Click);
            // 
            // datumLabel
            // 
            this.datumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datumLabel.AutoSize = true;
            this.datumLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datumLabel.Location = new System.Drawing.Point(726, 71);
            this.datumLabel.Name = "datumLabel";
            this.datumLabel.Size = new System.Drawing.Size(137, 58);
            this.datumLabel.TabIndex = 12;
            this.datumLabel.Text = "Datum:";
            // 
            // kategorieComboBox
            // 
            this.kategorieComboBox.AutoResize = false;
            this.kategorieComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kategorieComboBox.Depth = 0;
            this.kategorieComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.kategorieComboBox.DropDownHeight = 862;
            this.kategorieComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kategorieComboBox.DropDownWidth = 121;
            this.kategorieComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.kategorieComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kategorieComboBox.FormattingEnabled = true;
            this.kategorieComboBox.IntegralHeight = false;
            this.kategorieComboBox.ItemHeight = 43;
            this.kategorieComboBox.Location = new System.Drawing.Point(351, 626);
            this.kategorieComboBox.MaxDropDownItems = 20;
            this.kategorieComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.kategorieComboBox.Name = "kategorieComboBox";
            this.kategorieComboBox.Size = new System.Drawing.Size(285, 49);
            this.kategorieComboBox.StartIndex = 0;
            this.kategorieComboBox.TabIndex = 16;
            this.kategorieComboBox.SelectedIndexChanged += new System.EventHandler(this.kategorieComboBox_SelectedIndexChanged);
            // 
            // isFilteredCheckBox
            // 
            this.isFilteredCheckBox.Location = new System.Drawing.Point(112, 626);
            this.isFilteredCheckBox.Name = "isFilteredCheckBox";
            this.isFilteredCheckBox.Size = new System.Drawing.Size(233, 49);
            this.isFilteredCheckBox.TabIndex = 17;
            this.isFilteredCheckBox.Text = "Kategorie filtern";
            this.isFilteredCheckBox.UseVisualStyleBackColor = true;
            this.isFilteredCheckBox.CheckedChanged += new System.EventHandler(this.isFilteredCheckBox_CheckedChanged);
            // 
            // sollBtn
            // 
            this.sollBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sollBtn.AutoSize = false;
            this.sollBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sollBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.sollBtn.Depth = 0;
            this.sollBtn.HighEmphasis = true;
            this.sollBtn.Icon = null;
            this.sollBtn.Location = new System.Drawing.Point(241, 687);
            this.sollBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.sollBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.sollBtn.Name = "sollBtn";
            this.sollBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.sollBtn.Size = new System.Drawing.Size(100, 100);
            this.sollBtn.TabIndex = 19;
            this.sollBtn.Text = "Max ändern";
            this.sollBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.sollBtn.UseAccentColor = false;
            this.sollBtn.UseVisualStyleBackColor = true;
            this.sollBtn.Click += new System.EventHandler(this.sollBtn_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Depth = 0;
            this.progressBar.Location = new System.Drawing.Point(736, 714);
            this.progressBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(661, 5);
            this.progressBar.TabIndex = 20;
            // 
            // zielLabel
            // 
            this.zielLabel.AutoSize = true;
            this.zielLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zielLabel.Location = new System.Drawing.Point(551, 682);
            this.zielLabel.Name = "zielLabel";
            this.zielLabel.Size = new System.Drawing.Size(160, 58);
            this.zielLabel.TabIndex = 21;
            this.zielLabel.Text = "Max Kal:";
            // 
            // zielEiwLabel
            // 
            this.zielEiwLabel.AutoSize = true;
            this.zielEiwLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zielEiwLabel.Location = new System.Drawing.Point(551, 740);
            this.zielEiwLabel.Name = "zielEiwLabel";
            this.zielEiwLabel.Size = new System.Drawing.Size(85, 58);
            this.zielEiwLabel.TabIndex = 22;
            this.zielEiwLabel.Text = "Eiw:";
            // 
            // progressBarEiw
            // 
            this.progressBarEiw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarEiw.Depth = 0;
            this.progressBarEiw.Location = new System.Drawing.Point(736, 766);
            this.progressBarEiw.MouseState = MaterialSkin.MouseState.HOVER;
            this.progressBarEiw.Name = "progressBarEiw";
            this.progressBarEiw.Size = new System.Drawing.Size(661, 5);
            this.progressBarEiw.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1424, 800);
            this.Controls.Add(this.progressBarEiw);
            this.Controls.Add(this.zielEiwLabel);
            this.Controls.Add(this.zielLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.sollBtn);
            this.Controls.Add(this.isFilteredCheckBox);
            this.Controls.Add(this.kategorieComboBox);
            this.Controls.Add(this.datumLabel);
            this.Controls.Add(this.datumPlus);
            this.Controls.Add(this.datumMinus);
            this.Controls.Add(this.gesamtLabel2);
            this.Controls.Add(this.tagRechner);
            this.Controls.Add(this.suchLabel);
            this.Controls.Add(this.sucheBox);
            this.Controls.Add(this.addMahlzeit);
            this.Controls.Add(this.gesamtLabel);
            this.Controls.Add(this.menuBoard);
            this.Controls.Add(this.addZutat);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyCalories";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.menuBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagRechner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton addZutat;
        private System.Windows.Forms.DataGridView menuBoard;
        private System.Windows.Forms.Label gesamtLabel;
        private MaterialSkin.Controls.MaterialButton addMahlzeit;
        private System.Windows.Forms.TextBox sucheBox;
        private System.Windows.Forms.Label suchLabel;
        private System.Windows.Forms.DataGridView tagRechner;
        private System.Windows.Forms.Label gesamtLabel2;
        private MaterialSkin.Controls.MaterialButton datumMinus;
        private MaterialSkin.Controls.MaterialButton datumPlus;
        private System.Windows.Forms.Label datumLabel;
        private MaterialSkin.Controls.MaterialComboBox kategorieComboBox;
        private System.Windows.Forms.CheckBox isFilteredCheckBox;
        private MaterialSkin.Controls.MaterialButton sollBtn;
        private MaterialSkin.Controls.MaterialProgressBar progressBar;
        private System.Windows.Forms.Label zielLabel;
        private System.Windows.Forms.Label zielEiwLabel;
        private MaterialSkin.Controls.MaterialProgressBar progressBarEiw;
    }
}

