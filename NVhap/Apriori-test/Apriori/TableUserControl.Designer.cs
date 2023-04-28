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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ItemSetsDataGridView = new System.Windows.Forms.DataGridView();
            this.ItemSet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemSetLabel = new System.Windows.Forms.Label();
            this.RulesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Support = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupportComboBox = new System.Windows.Forms.ComboBox();
            this.ConfidanceComboBox = new System.Windows.Forms.ComboBox();
            this.SupportLabel = new System.Windows.Forms.Label();
            this.ConfidentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItemSetsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RulesDataGridView)).BeginInit();
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemSetsDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.ItemSetsDataGridView.Location = new System.Drawing.Point(15, 39);
            this.ItemSetsDataGridView.Name = "ItemSetsDataGridView";
            this.ItemSetsDataGridView.ReadOnly = true;
            this.ItemSetsDataGridView.RowHeadersVisible = false;
            this.ItemSetsDataGridView.RowHeadersWidth = 51;
            this.ItemSetsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemSetsDataGridView.Size = new System.Drawing.Size(298, 243);
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RulesDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.RulesDataGridView.Location = new System.Drawing.Point(331, 39);
            this.RulesDataGridView.Name = "RulesDataGridView";
            this.RulesDataGridView.ReadOnly = true;
            this.RulesDataGridView.RowHeadersVisible = false;
            this.RulesDataGridView.RowHeadersWidth = 51;
            this.RulesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RulesDataGridView.Size = new System.Drawing.Size(298, 243);
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
            // SupportComboBox
            // 
            this.SupportComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SupportComboBox.FormattingEnabled = true;
            this.SupportComboBox.Location = new System.Drawing.Point(503, 6);
            this.SupportComboBox.Name = "SupportComboBox";
            this.SupportComboBox.Size = new System.Drawing.Size(126, 27);
            this.SupportComboBox.Sorted = true;
            this.SupportComboBox.TabIndex = 10;
            this.SupportComboBox.SelectedIndexChanged += new System.EventHandler(this.SupportComboBox_SelectedIndexChanged);
            // 
            // ConfidanceComboBox
            // 
            this.ConfidanceComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ConfidanceComboBox.FormattingEnabled = true;
            this.ConfidanceComboBox.Location = new System.Drawing.Point(307, 6);
            this.ConfidanceComboBox.Name = "ConfidanceComboBox";
            this.ConfidanceComboBox.Size = new System.Drawing.Size(126, 27);
            this.ConfidanceComboBox.Sorted = true;
            this.ConfidanceComboBox.TabIndex = 11;
            this.ConfidanceComboBox.SelectedIndexChanged += new System.EventHandler(this.ConfidanceComboBox_SelectedIndexChanged);
            // 
            // SupportLabel
            // 
            this.SupportLabel.AutoSize = true;
            this.SupportLabel.Location = new System.Drawing.Point(439, 9);
            this.SupportLabel.Name = "SupportLabel";
            this.SupportLabel.Size = new System.Drawing.Size(58, 19);
            this.SupportLabel.TabIndex = 12;
            this.SupportLabel.Text = "Support";
            // 
            // ConfidentLabel
            // 
            this.ConfidentLabel.AutoSize = true;
            this.ConfidentLabel.Location = new System.Drawing.Point(224, 9);
            this.ConfidentLabel.Name = "ConfidentLabel";
            this.ConfidentLabel.Size = new System.Drawing.Size(77, 19);
            this.ConfidentLabel.TabIndex = 13;
            this.ConfidentLabel.Text = "Confidance";
            // 
            // TableUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ConfidentLabel);
            this.Controls.Add(this.SupportLabel);
            this.Controls.Add(this.ConfidanceComboBox);
            this.Controls.Add(this.SupportComboBox);
            this.Controls.Add(this.RulesDataGridView);
            this.Controls.Add(this.ItemSetLabel);
            this.Controls.Add(this.ItemSetsDataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TableUserControl";
            this.Size = new System.Drawing.Size(642, 293);
            ((System.ComponentModel.ISupportInitialize)(this.ItemSetsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RulesDataGridView)).EndInit();
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
        private System.Windows.Forms.ComboBox SupportComboBox;
        private System.Windows.Forms.ComboBox ConfidanceComboBox;
        private System.Windows.Forms.Label SupportLabel;
        private System.Windows.Forms.Label ConfidentLabel;
    }
}
