using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortApp
{
	public partial class Form1 : Form
	{
		private string[] m_StringList = { "B", "C", "T", "M" };
		private int[] m_NumberList = { 5, 3, 1, 7, 9 };
		private string[] m_SortedStringList;
		private int[] m_SortedNumberList;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			lsSort1.DataSource = m_StringList;//old
			lsSort2.DataSource = m_NumberList;//old

			//m_SortedStringList = new string[m_StringList.Length];

			//m_StringList.CopyTo(m_SortedStringList, 0);

			//Array.Sort(m_SortedStringList);

		}

		private void ckSort1_CheckedChanged(object sender, EventArgs e)
		{
            if (ckSort1.Checked)
                lsSort1.DataSource = m_StringList.OrderBy(n => n).ToArray();
            else
                lsSort1.DataSource = m_StringList;

            // f(x) = x
            // x => x

            // f(x, y) = x + y
            // (x, y) => x + y

		}

		private void ckSort2_CheckedChanged(object sender, EventArgs e)
		{
            var query = from n in m_NumberList
                        orderby n
                        select n;

            if (ckSort2.Checked)
                lsSort2.DataSource = query.ToArray();
            else
                lsSort2.DataSource = m_NumberList;
		}
	}
}
