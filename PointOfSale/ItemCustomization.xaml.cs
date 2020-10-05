using System;
using System.Collections.Generic;
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
        public ItemCustomization()
        {
            InitializeComponent();

            List<string> checkBoxContent = new List<string>();

            checkBoxContent.Add("asdf");
            checkBoxContent.Add("sdfg");
            checkBoxContent.Add("dfgh");

            DisplayCheckbox.Content = checkBoxContent;


        }





    }//class
}
