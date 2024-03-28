using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Reflection;
using System.Text;

using System.Windows.Forms;

namespace AngelLayout
{
    public partial class Levis : Form
    {
        public Levis()
        {
            InitializeComponent();
           
            propertyGrid1.SelectedObject = listView1;
            listView1.View = View.Tile;
            var properInfo = listView1.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            properInfo.SetValue(listView1, true, null);

            for (int i = 0; i < 1920/2 ; i++)
            {

                var header = new ColumnHeader();
                header.Text = i.ToString();
                header.Width = 2 + 14 + 2;

                listView1.Columns.Add(header);
                var item = new ListViewItem();
                item.Text = i.ToString();
                
                listView1.Items.Add(item);

                //for (int t = 0; t < 1920  ; t++)
                //{
                //    var subItem = new ListViewItem.ListViewSubItem();
                ////    subItem.BackColor = Color.FromArgb()
                //    subItem.Text = t.ToString();
                //    listView1.Items[i].SubItems.Add(subItem);
                //}

            }

        }

        private void Levis_Load(object sender, EventArgs e)
        {

        }
    }
}
