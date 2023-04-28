using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;

namespace Apriori
{
    public partial class TableUserControl : UserControl
    {
        ItemSet itemSet = new ItemSet();
        List<AssociationRule> rules = new List<AssociationRule>();
        public TableUserControl(ItemSet itemSet, List<AssociationRule> rules)
        {
            InitializeComponent();
            this.itemSet = itemSet;
            this.rules = rules;
            ItemSetLabel.Text = itemSet.Label;
            Console.WriteLine(itemSet.Label);
            List<string> items = new List<string>();
            foreach (var item in itemSet)
            {
                ItemSetsDataGridView.Rows.Add(item.Key.ToDisplay(), item.Value);
                if (item.Value < itemSet.Support)
                    ItemSetsDataGridView.Rows[ItemSetsDataGridView.Rows.Count - 1].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            }
            if (rules.Count == 0)
            {
                RulesDataGridView.Hide();
            }
            else
            {
                foreach (var item in rules)
                {
                    RulesDataGridView.Rows.Add(item.Label, item.Confidance.ToPercentString(), item.Support.ToPercentString());
                    ConfidanceComboBox.Items.Add(item.Confidance.ToPercentString());
                    SupportComboBox.Items.Add(item.Support.ToPercentString());
                }
            }
        }

        public TableUserControl(List<string> Values)
        {
            InitializeComponent();
            ItemSetLabel.Text = "Input";
            for (int i = 0; i < Values.Count; i++)
            {
                ItemSetsDataGridView.Rows.Add(i, Values[i]);
            }
            ConfidentLabel.Hide();
            ConfidanceComboBox.Hide();
            SupportComboBox.Hide();
            SupportLabel.Hide();
            RulesDataGridView.Hide();
            this.Size = new System.Drawing.Size(330,293);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            ItemSetsDataGridView.ClearSelection();
        }

        private void ConfidanceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RulesDataGridView.Rows.Clear();
            SupportComboBox.SelectedItem = -1;
            string sCombobox = ConfidanceComboBox.SelectedItem.ToString();
            sCombobox = sCombobox.Replace('%', ' ');
            double number = double.Parse(sCombobox);

            //number = Convert.ToDouble(ConfidanceComboBox.SelectedValue);

            foreach (var item in rules)
            {
                if (item.Confidance >= number)
                {
                    RulesDataGridView.Rows.Add(item.Label, item.Confidance.ToPercentString(), item.Support.ToPercentString());
                }
            }
        }

        private void SupportComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RulesDataGridView.Rows.Clear();
            ConfidanceComboBox.SelectedItem = -1;
            string sCombobox = SupportComboBox.SelectedItem.ToString();
            sCombobox = sCombobox.Replace('%', ' ');
            Double number = Double.Parse(sCombobox);

            foreach (var item in rules)
            {
                if (item.Support >= number)
                {
                    RulesDataGridView.Rows.Add(item.Label, item.Confidance.ToPercentString(), item.Support.ToPercentString());
                    //RulesDataGridView.Rows.Clear();
                }
            }
        }
    }
}
