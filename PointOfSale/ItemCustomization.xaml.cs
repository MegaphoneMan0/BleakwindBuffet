using BleakwindBuffet.Data.Interfaces;
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
        BindingList<IOrderItem> fullOrder;

        IOrderItem itemToCustomize;

        List<CheckBox> checkArray;

        BindingList<String> selectedItemsList;

        public ItemCustomization()
        {
            InitializeComponent();


        }
        

        public ItemCustomization(IOrderItem menuItem , BindingList<IOrderItem> theList)
        {
            InitializeComponent();
            itemToCustomize = menuItem;
            DataContext = menuItem;
            fullOrder = theList;
            selectedItemsList = new BindingList<string>();

            fillContent(itemToCustomize);

            
        }




        public void fillContent(IOrderItem foo)
        {

            List<string> propList = new List<string>();
            checkArray = new List<CheckBox>();

            foreach (var prop in foo.GetType().GetProperties())
            {
                //look at prop type
                //path will be the name of the prop for data binding
                //props in controls are "dependancy properties"
                string propString = prop.Name;

                //filters out unwanted properties
                if (propString.Equals("SpecialInstructions")) { }

                else if (propString.Equals("Price")) { }


                else if (propString.Equals("Calories")) { }

                else if (propString.Equals("Size"))
                {
                    addToCheckArrayNormal("Small", prop);
                    addToCheckArrayNormal("Medium", prop);
                    addToCheckArrayNormal("Large", prop);

                }

                else if (propString.Equals("Flavor"))
                {

                    addToCheckArrayNormal("Blackberry", prop);


                    addToCheckArrayNormal("Cherry", prop);


                    addToCheckArrayNormal("Grapefruit", prop);


                    addToCheckArrayNormal("Lemon", prop);


                    addToCheckArrayNormal("Peach", prop);


                    addToCheckArrayNormal("Watermelon",prop);

                    

                }

                else
                {

                    addToCheckArrayNormal(propString, prop);

                }

            }//foreach

            DisplayBox.ItemsSource = checkArray;

            
            


        }//fillcontent
        


        private void addToCheckArrayNormal(string name, object prop)
        {
            CheckBox propCheckbox = new CheckBox();


            var myBinding = new Binding(name)
            {
                Source = prop
            };

            propCheckbox.Content = name;
            checkArray.Add(propCheckbox);

            //also adding to the binding list

            

        }







        private void Done_Click(object sender, RoutedEventArgs e)
        {
            //get all of the custom ingredients in a binding list
            //Array selectedItems = Array.Empty<string>();

            //DisplayBox.SelectedItems.CopyTo(selectedItems,0);

            //selectedItemsList = new BindingList<string>();

            foreach(CheckBox cb in checkArray)
            {

                if ((bool)cb.IsChecked)
                {
                    selectedItemsList.Add(cb.Content.ToString());
                }

            }


            itemToCustomize.setIngredients(selectedItemsList);


            fullOrder.Add(itemToCustomize);

            


            //this closes the window

            Window.GetWindow(this).Close();

        }
    }//class
}
