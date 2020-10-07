using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ItemCustomization.xaml
    /// </summary>
    public partial class ItemCustomization : UserControl
    {
        BindingList<string> customOptions;

        public ItemCustomization()
        {
            InitializeComponent();


        }

        public ItemCustomization(BindingList<string> vs)
        {
            InitializeComponent();
            customOptions = vs;

        }


        private void Done_Click(object sender, RoutedEventArgs e)
        {
            //get all of the custom ingredients in a binding list
            Array selectedItems = Array.Empty<string>();

            DisplayBox.SelectedItems.CopyTo(selectedItems,0);

            BindingList<string> selectedItemsList = new BindingList<string>();

            foreach(string s in selectedItems)
            {
                selectedItemsList.Add(s);
            }


            //now we have to figure out how to give this to the order container.... huh

            


            //this closes the window

            Window.GetWindow(this).Close();

        }
    }//class
}
