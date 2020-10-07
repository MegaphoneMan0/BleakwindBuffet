using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interfaces;
using BleakwindBuffet.Data.Sides;
using PointOfSale;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ItemSelector.xaml
    /// </summary>
    public partial class ItemSelector : UserControl
    {

        Window newWindow = new Window();
        BindingList<string> orderList = new BindingList<string>();


        public ItemSelector()
        {
            InitializeComponent();
            
            
        }
    
        
        public ItemSelected buttonPressed = ItemSelected.Default;
        
        
        public void fillContent(IOrderItem foo, ItemCustomization ic)
        {

            List<string> propList = new List<string>();
            List<CheckBox> checkArray = new List<CheckBox>();

            foreach (var prop in foo.GetType().GetProperties())
            {
                //look at prop type
                //path will be the name of the prop for data binding
                //props in controls are "dependancy properties"
                string propString = prop.Name;
                CheckBox propCheckbox = new CheckBox();

                //filters out unwanted properties
                if (propString.Equals("SpecialInstructions")) { }

                else if (propString.Equals("Price")) { }


                else if (propString.Equals("Calories")) { }

                else if (propString.Equals("Size"))
                {
                    propCheckbox.Content = "Small";
                    checkArray.Add(propCheckbox);

                    propCheckbox = new CheckBox();
                    propCheckbox.Content = "Medium";
                    checkArray.Add(propCheckbox);

                    propCheckbox = new CheckBox();
                    propCheckbox.Content = "Large";
                    checkArray.Add(propCheckbox);

                }

                else if (propString.Equals("Flavor"))
                {
                    propCheckbox.Content = "Blackberry";
                    checkArray.Add(propCheckbox);

                    propCheckbox = new CheckBox();
                    propCheckbox.Content = "Cherry";
                    checkArray.Add(propCheckbox);

                    propCheckbox = new CheckBox();
                    propCheckbox.Content = "Grapefruit";
                    checkArray.Add(propCheckbox);


                    propCheckbox = new CheckBox();
                    propCheckbox.Content = "Lemon";
                    checkArray.Add(propCheckbox);

                    propCheckbox = new CheckBox();
                    propCheckbox.Content = "Peach";
                    checkArray.Add(propCheckbox);

                    propCheckbox = new CheckBox();
                    propCheckbox.Content = "Watermelon";
                    checkArray.Add(propCheckbox);

                }

                else
                {
                    propCheckbox.Content = propString;

                    checkArray.Add(propCheckbox);
                }

            }//foreach

            ic.DisplayBox.ItemsSource = checkArray;

            buildANewWindowAndShow(ic);



        }//fillcontent


        private void buildANewWindowAndShow(ItemCustomization ic)
        {
            newWindow = new Window();
            newWindow.Content = ic;
            newWindow.Height = 600;
            newWindow.Width = 600;
            newWindow.Show();
        }


        private void BriarheartBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.BB;
            BriarheartBurger newMenuItem = new BriarheartBurger();
            ItemCustomization ic = new ItemCustomization();
            fillContent(newMenuItem, ic);

            
        }

        private void DoubleDraugrButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.DD;

            DoubleDraugr newMenuItem = new DoubleDraugr();
            ItemCustomization ic = new ItemCustomization();
            fillContent(newMenuItem, ic);


        }

        private void ThalmorTripleButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.TT;
            ThalmorTriple newMenuItem = new ThalmorTriple();
            ItemCustomization ic = new ItemCustomization();
            fillContent(newMenuItem, ic);

        }

        private void SmokehouseSkeletonButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.SS;
            SmokehouseSkeleton newMenuItem = new SmokehouseSkeleton();
            ItemCustomization ic = new ItemCustomization();
            fillContent(newMenuItem, ic);

        }

        private void GardenOrcOmletteButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.GOO;
            GardenOrcOmelette newMenuItem = new GardenOrcOmelette();
            ItemCustomization ic = new ItemCustomization();
            fillContent(newMenuItem, ic);

        }

        private void ThugsTBoneButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.TTB;
            ThugsTBone newMenuItem = new ThugsTBone();
            ItemCustomization ic = new ItemCustomization();
            fillContent(newMenuItem, ic);

        }

        private void SailorSodaButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.SaSo;
            SailorSoda newMenuItem = new SailorSoda();
            ItemCustomization ic = new ItemCustomization();
            fillContent(newMenuItem, ic);

        }

        private void MarkarthMilkButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.MM;
            MarkarthMilk newMenuItem = new MarkarthMilk();
            ItemCustomization ic = new ItemCustomization();
            fillContent(newMenuItem, ic);

        }

        private void AretinoAppleJuiceButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.AAJ;
            AretinoAppleJuice newMenuItem = new AretinoAppleJuice();
            ItemCustomization ic = new ItemCustomization();
            fillContent(newMenuItem, ic);

        }

        private void CandlehearthCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.CC;
            CandlehearthCoffee newMenuItem = new CandlehearthCoffee();
            ItemCustomization ic = new ItemCustomization();
            fillContent(newMenuItem, ic);

        }

        private void WarriorWaterButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.WW;
            WarriorWater newMenuItem = new WarriorWater();
            ItemCustomization ic = new ItemCustomization();
            fillContent(newMenuItem, ic);

        }

        private void VokunSaladButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.VS;
            VokunSalad newMenuItem = new VokunSalad();
            ItemCustomization ic = new ItemCustomization();
            fillContent(newMenuItem, ic);

        }

        private void FriedMiraakButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.FM;
            FriedMiraak newMenuItem = new FriedMiraak();
            ItemCustomization ic = new ItemCustomization();
            fillContent(newMenuItem, ic);

        }

        private void MadOtarGritsButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.MOG;
            MadOtarGrits newMenuItem = new MadOtarGrits();
            ItemCustomization ic = new ItemCustomization();
            fillContent(newMenuItem, ic);

        }

        private void DragonbornWaffleFriesButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.DWF;
            DragonbornWaffleFries newMenuItem = new DragonbornWaffleFries();
            ItemCustomization ic = new ItemCustomization();
            fillContent(newMenuItem, ic);

        }


    }//class
}//namespace
