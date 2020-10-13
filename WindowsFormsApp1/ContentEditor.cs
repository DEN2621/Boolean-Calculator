using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class ContentEditor
    {
        private DataGridView table = new DataGridView();
        private TextBox textBox = new TextBox();
        public ContentEditor(TextBox textbox, DataGridView dataGridView)
        {
            textBox = textbox;
            table = dataGridView;
        }
        public void PrintSDNF(string sdnf)
        {
            textBox.Clear();
            textBox.Text += $"СДНФ: {sdnf}";
        }
        public void PrintSKNF(string sknf)
        {
            textBox.Text += Environment.NewLine;
            textBox.Text += $"СКНФ: {sknf}";
        }
        public void PrintTruthTable(List<string> title, List<List<bool>> data)
        {
            MakeTitle(title);
            MakeData(data);
        }
        private void MakeTitle(List<string> title)
        {
            table.SelectAll();
            table.ClearSelection();
            table.Columns.Clear();
            for (int i = 0; i < title.Count; i++)
            {
                table.Columns.Add(i.ToString(), title[i]);
            }
        }
        private void MakeData(List<List<bool>> data)
        {
            for (int i = 0; i < data[0].Count; i++)
            {
                table.Rows.Add();
                for (int j = 0; j < data.Count; j++)
                {
                    table.Rows[i].Cells[j].Value = data[j][i] ? "1" : "0";
                }
            }
        }
    }
}
