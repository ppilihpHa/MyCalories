namespace MyCalories
{
    partial class Form6
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.closeBtn6 = new MaterialSkin.Controls.MaterialButton();
            this.menuBoard2 = new System.Windows.Forms.DataGridView();
            this.suchLabel2 = new System.Windows.Forms.Label();
            this.sucheBox2 = new System.Windows.Forms.TextBox();
            this.rezeptGrid = new System.Windows.Forms.DataGridView();
            this.saveChanges6 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.menuBoard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezeptGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // closeBtn6
            // 
            this.closeBtn6.AutoSize = false;
            this.closeBtn6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeBtn6.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.closeBtn6.Depth = 0;
            this.closeBtn6.HighEmphasis = true;
            this.closeBtn6.Icon = null;
            this.closeBtn6.Location = new System.Drawing.Point(1611, 15);
            this.closeBtn6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.closeBtn6.MouseState = MaterialSkin.MouseState.HOVER;
            this.closeBtn6.Name = "closeBtn6";
            this.closeBtn6.NoAccentTextColor = System.Drawing.Color.Empty;
            this.closeBtn6.Size = new System.Drawing.Size(50, 50);
            this.closeBtn6.TabIndex = 22;
            this.closeBtn6.Text = "X";
            this.closeBtn6.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.closeBtn6.UseAccentColor = false;
            this.closeBtn6.UseVisualStyleBackColor = true;
            this.closeBtn6.Click += new System.EventHandler(this.closeBtn5_Click);
            // 
            // menuBoard2
            // 
            this.menuBoard2.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.menuBoard2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.menuBoard2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.menuBoard2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuBoard2.EnableHeadersVisualStyles = false;
            this.menuBoard2.GridColor = System.Drawing.SystemColors.MenuText;
            this.menuBoard2.Location = new System.Drawing.Point(22, 185);
            this.menuBoard2.Name = "menuBoard2";
            this.menuBoard2.RowHeadersVisible = false;
            this.menuBoard2.RowHeadersWidth = 82;
            this.menuBoard2.RowTemplate.Height = 33;
            this.menuBoard2.Size = new System.Drawing.Size(922, 901);
            this.menuBoard2.TabIndex = 23;
            this.menuBoard2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.menuBoard2_CellClick);
            // 
            // suchLabel2
            // 
            this.suchLabel2.AutoSize = true;
            this.suchLabel2.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suchLabel2.Location = new System.Drawing.Point(12, 60);
            this.suchLabel2.Name = "suchLabel2";
            this.suchLabel2.Size = new System.Drawing.Size(130, 58);
            this.suchLabel2.TabIndex = 25;
            this.suchLabel2.Text = "Suche:";
            // 
            // sucheBox2
            // 
            this.sucheBox2.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sucheBox2.Location = new System.Drawing.Point(251, 69);
            this.sucheBox2.Name = "sucheBox2";
            this.sucheBox2.Size = new System.Drawing.Size(468, 71);
            this.sucheBox2.TabIndex = 24;
            this.sucheBox2.TextChanged += new System.EventHandler(this.sucheBox2_TextChanged);
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
            this.rezeptGrid.Location = new System.Drawing.Point(1014, 185);
            this.rezeptGrid.Name = "rezeptGrid";
            this.rezeptGrid.RowHeadersVisible = false;
            this.rezeptGrid.RowHeadersWidth = 82;
            this.rezeptGrid.RowTemplate.Height = 33;
            this.rezeptGrid.Size = new System.Drawing.Size(608, 901);
            this.rezeptGrid.TabIndex = 26;
            this.rezeptGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.rezeptGrid_CellMouseClick);
            // 
            // saveChanges6
            // 
            this.saveChanges6.AutoSize = false;
            this.saveChanges6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveChanges6.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.saveChanges6.Depth = 0;
            this.saveChanges6.HighEmphasis = true;
            this.saveChanges6.Icon = null;
            this.saveChanges6.Location = new System.Drawing.Point(1511, 1118);
            this.saveChanges6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveChanges6.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveChanges6.Name = "saveChanges6";
            this.saveChanges6.NoAccentTextColor = System.Drawing.Color.Empty;
            this.saveChanges6.Size = new System.Drawing.Size(150, 50);
            this.saveChanges6.TabIndex = 27;
            this.saveChanges6.Text = "fertig";
            this.saveChanges6.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveChanges6.UseAccentColor = false;
            this.saveChanges6.UseVisualStyleBackColor = true;
            this.saveChanges6.Click += new System.EventHandler(this.saveChanges6_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1674, 1174);
            this.ControlBox = false;
            this.Controls.Add(this.saveChanges6);
            this.Controls.Add(this.rezeptGrid);
            this.Controls.Add(this.suchLabel2);
            this.Controls.Add(this.sucheBox2);
            this.Controls.Add(this.menuBoard2);
            this.Controls.Add(this.closeBtn6);
            this.DoubleBuffered = true;
            this.Name = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.menuBoard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezeptGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton closeBtn6;
        private System.Windows.Forms.DataGridView menuBoard2;
        private System.Windows.Forms.Label suchLabel2;
        private System.Windows.Forms.TextBox sucheBox2;
        private System.Windows.Forms.DataGridView rezeptGrid;
        private MaterialSkin.Controls.MaterialButton saveChanges6;
    }
}