using BAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Apriori
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        string FileName = string.Empty;
        BAL.ItemSet newItemSet = new BAL.ItemSet();
        List<AssociationRule> RuleSets = new List<AssociationRule>();
        private void LoadFromFile_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Filter = "Text|*.csv";
            if (dialog.ShowDialog() != DialogResult.OK) return;
            FileName = dialog.FileName;
            textBox1.Text = dialog.FileName;
            TableRowDataThread();
        }

    private void DoThings()
        {
            int Support = 0;
            BAL.Apriori apriori = new BAL.Apriori(FileName);
            int k = 1;
            List<BAL.ItemSet> ItemSets = new List<BAL.ItemSet>();
            bool next;
            if (numericUpDown1.InvokeRequired)
                numericUpDown1.Invoke(new MethodInvoker(delegate
                {
                    Support = Convert.ToInt32(numericUpDown1.Value);
                    numericUpDown1.Enabled = false;
                }
                ));
            if (SupportButton.InvokeRequired)
                SupportButton.Invoke(new MethodInvoker(delegate
                {
                    SupportButton.Enabled = false;
                }
                ));
            do
            {
                next = false;
                var L = apriori.GetItemSet(k, Support, IsFirstItemList: k == 1);
                if (L.Count > 0)
                {
                    List<AssociationRule> rules = new List<AssociationRule>();
                    if (k != 1)
                        rules = apriori.GetRules(L);                 
                    next = true;
                    k++;
                    RuleSets.AddRange(rules);

                    foreach (var item in L)
                    {
                        newItemSet.Add(item.Key, item.Value);
                    }

                    ItemSets.Add(L);

                    if(k == 1)
                    {
                        newItemSet.Support = L.Support;                        
                    }
                }
            } while (next);
            if (numericUpDown1.InvokeRequired)
                numericUpDown1.Invoke(new MethodInvoker(delegate
                {
                    numericUpDown1.Enabled = true;
                }
                ));
            if (SupportButton.InvokeRequired)
                SupportButton.Invoke(new MethodInvoker(delegate
                {
                    SupportButton.Enabled = true;
                }
                ));
            newItemSet.Label = "Result";
            TableUserControl tableLResult = new TableUserControl(newItemSet, RuleSets);
            if (flowLayoutPanel1.InvokeRequired)
                flowLayoutPanel1.Invoke(new MethodInvoker(delegate
                {
                    flowLayoutPanel1.Controls.Add(tableLResult);
                    flowLayoutPanel1.VerticalScroll.Value = flowLayoutPanel1.VerticalScroll.Maximum;
                }
                ));
        }
        List<Thread> threads = new List<Thread>();

        private void TableRowDataThread()
        {
            Thread t = new Thread(delegate ()
            {
                if (flowLayoutPanel1.InvokeRequired)
                    flowLayoutPanel1.Invoke(new MethodInvoker(delegate
                    {
                        flowLayoutPanel1.Controls.Clear();
                        List<string> list = File.ReadAllLines(FileName).ToList();
                        List<string> listHeader = list[0].Split(',').ToList();
                        list.RemoveAt(0);
                        for (var k = 0; k < list.Count; k++)
                        {
                            var row = list[k].Split(',');           
                            for (var j = 0; j < row.Length; j++)            
                            {
                                if (row[j].Equals("TRUE"))
                                {
                                    row[j] = listHeader[j];
                                }
                                else
                                {
                                    row[j] = "";
                                }
                            }
                            list[k] = String.Join(" ", row);
                        }
                        for (var i = 0; i < list.Count; i++)
                        {
                            List<string> newList = list[i].Replace(',', ' ').Split(' ').ToList();
                            for (var j = newList.Count - 1; j >= 0; j--)
                            {
                                string item = newList[j];
                                if (string.IsNullOrEmpty(item))
                                {
                                    newList.RemoveAt(j);
                                }
                            }

                            list[i] = string.Join(",", newList).Trim();
                        }
                        flowLayoutPanel1.Controls.Add(new TableUserControl(list));
                    }
                    ));
            })
            { Name = "CheckData" };
            t.Start();
        }

        private void DoThingThread()
        {
            TableRowDataThread();
            Thread t = new Thread(delegate ()
            {              
                DoThings();               
            })
            { Name = "DoThings" };
            threads.Add(t);
            t.Start();
        }

        private void SupportButton_Click(object sender, EventArgs e)
        {
            int Support = Convert.ToInt32(numericUpDown1.Value);
            if (Support < 1)
            {
                MessageBox.Show("Require support < 0");
                return;
            }
            DoThingThread();
        }
    }
}