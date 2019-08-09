using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuynSell
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            IList<string> invList = new List<string>() { "Ironsword", "Flamesword", "Bag of rice" };
            for (int i = 0; i < invList.Count; i++)
            {
                Inventory.Items.Add(invList.ElementAt(i));
            }

            IList<string> shopList = new List<string>() { "Herbs", "Gold armor", "Pile of garbage", "Horn" };
            for (int i = 0; i < shopList.Count; i++)
            {
                Shop.Items.Add(shopList.ElementAt(i));
            }
        }
      
        
        public void buyButton_Click(object sender, EventArgs e)
        {
            
            if (Shop.SelectedItem != null)
            {
                while (Shop.SelectedItems.Count > 0)
                {
                    
                    Inventory.Items.Add(Shop.SelectedItem);
                    Shop.Items.Remove(Shop.SelectedItem);
                    gold--;
                    goldBox.Text = gold.ToString();
                }
            }
            else
            {
            }
            
        }

        public void sellButton_Click(object sender, EventArgs e)
        {
            if (Inventory.SelectedItem != null)
            {
                while (Inventory.SelectedItems.Count > 0)
                {
                    Shop.Items.Add(Inventory.SelectedItem);
                    Inventory.Items.Remove(Inventory.SelectedItem);
                    gold++;
                    goldBox.Text = gold.ToString();
                }
            }
            else
            {
            }
            
        }



        public void Shop_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Shop.SelectedIndex >= 0)
                Inventory.SelectedIndex = -1;
        }
        public void Inventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Inventory.SelectedIndex >= 0)
                Shop.SelectedIndex = -1;
        }
        public int gold = 0;

        
    }
}