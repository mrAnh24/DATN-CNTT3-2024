namespace Apriori
{
    partial class TableUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ItemSetsDataGridView = new System.Windows.Forms.DataGridView();
            this.ItemSet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemSetLabel = new System.Windows.Forms.Label();
            this.RulesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Support = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComboBoxDataGridView = new System.Windows.Forms.DataGridView();
            this.SupportComboBox = new System.Windows.Forms.ComboBox();
            this.ConfidanceComboBox = new System.Windows.Forms.ComboBox();
            this.ConfidanceButton = new System.Windows.Forms.Button();
            this.SupportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ItemSetsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RulesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemSetsDataGridView
            // 
            this.ItemSetsDataGridView.AllowUserToAddRows = false;
            this.ItemSetsDataGridView.AllowUserToDeleteRows = false;
            this.ItemSetsDataGridView.AllowUserToResizeColumns = false;
            this.ItemSetsDataGridView.AllowUserToResizeRows = false;
            this.ItemSetsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ItemSetsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ItemSetsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemSetsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemSet,
            this.Count});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemSetsDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.ItemSetsDataGridView.Location = new System.Drawing.Point(15, 34);
            this.ItemSetsDataGridView.Name = "ItemSetsDataGridView";
            this.ItemSetsDataGridView.ReadOnly = true;
            this.ItemSetsDataGridView.RowHeadersVisible = false;
            this.ItemSetsDataGridView.RowHeadersWidth = 51;
            this.ItemSetsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemSetsDataGridView.Size = new System.Drawing.Size(298, 234);
            this.ItemSetsDataGridView.TabIndex = 0;
            this.ItemSetsDataGridView.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // ItemSet
            // 
            this.ItemSet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemSet.HeaderText = "Item Set";
            this.ItemSet.MinimumWidth = 6;
            this.ItemSet.Name = "ItemSet";
            this.ItemSet.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Count.HeaderText = "Count";
            this.Count.MinimumWidth = 6;
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // ItemSetLabel
            // 
            this.ItemSetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemSetLabel.AutoSize = true;
            this.ItemSetLabel.Font = new System.Drawing.Font("Segoe UI", 13.25F, System.Drawing.FontStyle.Bold);
            this.ItemSetLabel.Location = new System.Drawing.Point(11, 0);
            this.ItemSetLabel.Name = "ItemSetLabel";
            this.ItemSetLabel.Size = new System.Drawing.Size(103, 31);
            this.ItemSetLabel.TabIndex = 1;
            this.ItemSetLabel.Text = "{{Label}}";
            // 
            // RulesDataGridView
            // 
            this.RulesDataGridView.AllowUserToAddRows = false;
            this.RulesDataGridView.AllowUserToDeleteRows = false;
            this.RulesDataGridView.AllowUserToResizeColumns = false;
            this.RulesDataGridView.AllowUserToResizeRows = false;
            this.RulesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.RulesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.RulesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RulesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Support});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RulesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.RulesDataGridView.Location = new System.Drawing.Point(330, 34);
            this.RulesDataGridView.Name = "RulesDataGridView";
            this.RulesDataGridView.ReadOnly = true;
            this.RulesDataGridView.RowHeadersVisible = false;
            this.RulesDataGridView.RowHeadersWidth = 51;
            this.RulesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RulesDataGridView.Size = new System.Drawing.Size(298, 234);
            this.RulesDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Rule";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Confidance";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Support
            // 
            this.Support.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Support.HeaderText = "Support";
            this.Support.MinimumWidth = 6;
            this.Support.Name = "Support";
            this.Support.ReadOnly = true;
            // 
            // ComboBoxDataGridView
            // 
            this.ComboBoxDataGridView.AllowUserToAddRows = false;
            this.ComboBoxDataGridView.AllowUserToDeleteRows = false;
            this.ComboBoxDataGridView.AllowUserToResizeColumns = false;
            this.ComboBoxDataGridView.AllowUserToResizeRows = false;
            this.ComboBoxDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ComboBoxDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ComboBoxDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComboBoxDataGridView.Location = new System.Drawing.Point(643, 34);
            this.ComboBoxDataGridView.Name = "ComboBoxDataGridView";
            this.ComboBoxDataGridView.RowHeadersWidth = 51;
            this.ComboBoxDataGridView.RowTemplate.Height = 24;
            this.ComboBoxDataGridView.Size = new System.Drawing.Size(298, 234);
            this.ComboBoxDataGridView.TabIndex = 9;
            // 
            // SupportComboBox
            // 
            this.SupportComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SupportComboBox.FormattingEnabled = true;
            this.SupportComboBox.Location = new System.Drawing.Point(803, 112);
            this.SupportComboBox.Name = "SupportComboBox";
            this.SupportComboBox.Size = new System.Drawing.Size(121, 27);
            this.SupportComboBox.TabIndex = 10;
            // 
            // ConfidanceComboBox
            // 
            this.ConfidanceComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ConfidanceComboBox.FormattingEnabled = true;
            this.ConfidanceComboBox.Location = new System.Drawing.Point(803, 50);
            this.ConfidanceComboBox.Name = "ConfidanceComboBox";
            this.ConfidanceComboBox.Size = new System.Drawing.Size(121, 27);
            this.ConfidanceComboBox.TabIndex = 11;
            // 
            // ConfidanceButton
            // 
            this.ConfidanceButton.Location = new System.Drawing.Point(710, 51);
            this.ConfidanceButton.Name = "ConfidanceButton";
            this.ConfidanceButton.Size = new System.Drawing.Size(87, 26);
            this.ConfidanceButton.TabIndex = 14;
            this.ConfidanceButton.Text = "Confidance";
            this.ConfidanceButton.UseVisualStyleBackColor = true;
            this.ConfidanceButton.Click += new System.EventHandler(this.ConfidanceButton_Click);
            // 
            // SupportButton
            // 
            this.SupportButton.Location = new System.Drawing.Point(710, 112);
            this.SupportButton.Name = "SupportButton";
            this.SupportButton.Size = new System.Drawing.Size(87, 27);
            this.SupportButton.TabIndex = 15;
            this.SupportButton.Text = "Support";
            this.SupportButton.UseVisualStyleBackColor = true;
            this.SupportButton.Click += new System.EventHandler(this.SupportButton_Click);
            // 
            // TableUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.SupportButton);
            this.Controls.Add(this.ConfidanceButton);
            this.Controls.Add(this.ConfidanceComboBox);
            this.Controls.Add(this.SupportComboBox);
            this.Controls.Add(this.ComboBoxDataGridView);
            this.Controls.Add(this.RulesDataGridView);
            this.Controls.Add(this.ItemSetLabel);
            this.Controls.Add(this.ItemSetsDataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TableUserControl";
            this.Size = new System.Drawing.Size(954, 284);
            ((System.ComponentModel.ISupportInitialize)(this.ItemSetsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RulesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ItemSetsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.Label ItemSetLabel;
        private System.Windows.Forms.DataGridView RulesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Support;
        private System.Windows.Forms.DataGridView ComboBoxDataGridView;
        private System.Windows.Forms.ComboBox SupportComboBox;
        private System.Windows.Forms.ComboBox ConfidanceComboBox;
        private System.Windows.Forms.Button ConfidanceButton;
        private System.Windows.Forms.Button SupportButton;
    }
}
