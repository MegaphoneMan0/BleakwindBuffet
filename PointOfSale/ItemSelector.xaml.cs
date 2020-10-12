using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
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
        BindingList<IOrderItem> orderList;

        //all menu item objects
        
        


        public ItemSelector()
        {
            InitializeComponent();

            orderList = new BindingList<IOrderItem>();

            userOrder.ItemsSource = orderList;



        }


        public ItemSelected buttonPressed = ItemSelected.Default;
        
       


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
            BriarheartBurger menuItem = new BriarheartBurger();
            ItemCustomization ic = new ItemCustomization(menuItem, orderList);
            buildANewWindowAndShow(ic);
            
            
        }

        private void DoubleDraugrButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.DD;
            DoubleDraugr menuItem = new DoubleDraugr();
            ItemCustomization ic = new ItemCustomization(menuItem, orderList); 
            buildANewWindowAndShow(ic);


        }

        private void ThalmorTripleButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.TT;
            ThalmorTriple menuItem = new ThalmorTriple();
            ItemCustomization ic = new ItemCustomization(menuItem, orderList); 
            buildANewWindowAndShow(ic);

        }

        private void SmokehouseSkeletonButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.SS;
            SmokehouseSkeleton menuItem = new SmokehouseSkeleton();
            ItemCustomization ic = new ItemCustomization(menuItem, orderList);

            buildANewWindowAndShow(ic);

        }

        private void GardenOrcOmeletteButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.GOO;
            GardenOrcOmelette menuItem = new GardenOrcOmelette();
            ItemCustomization ic = new ItemCustomization(menuItem, orderList);
            buildANewWindowAndShow(ic);

        }

        private void ThugsTBoneButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.TTB;
            ThugsTBone menuItem = new ThugsTBone();
            ItemCustomization ic = new ItemCustomization(menuItem, orderList);
            buildANewWindowAndShow(ic);

        }

        private void SailorSodaButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.SaSo;
            SailorSoda menuItem = new SailorSoda();
            ItemCustomization ic = new ItemCustomization(menuItem, orderList);
            buildANewWindowAndShow(ic);

        }

        private void MarkarthMilkButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.MM;
            MarkarthMilk menuItem = new MarkarthMilk();
            ItemCustomization ic = new ItemCustomization(menuItem, orderList);
            buildANewWindowAndShow(ic);

        }

        private void AretinoAppleJuiceButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.AAJ;
            AretinoAppleJuice menuItem = new AretinoAppleJuice();
            ItemCustomization ic = new ItemCustomization(menuItem, orderList);
            buildANewWindowAndShow(ic);

        }

        private void CandlehearthCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.CC;
            CandlehearthCoffee menuItem = new CandlehearthCoffee();
            ItemCustomization ic = new ItemCustomization(menuItem, orderList);
            buildANewWindowAndShow(ic);

        }

        private void WarriorWaterButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.WW;
            WarriorWater menuItem = new WarriorWater();
            ItemCustomization ic = new ItemCustomization(menuItem, orderList);
            buildANewWindowAndShow(ic);

        }

        private void VokunSaladButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.VS;
            VokunSalad menuItem = new VokunSalad();
            ItemCustomization ic = new ItemCustomization(menuItem, orderList);
            buildANewWindowAndShow(ic);

        }

        private void FriedMiraakButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.FM;
            FriedMiraak menuItem = new FriedMiraak();
            ItemCustomization ic = new ItemCustomization(menuItem, orderList);
            buildANewWindowAndShow(ic);

        }

        private void MadOtarGritsButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.MOG;
            MadOtarGrits menuItem = new MadOtarGrits();
            ItemCustomization ic = new ItemCustomization(menuItem, orderList);
            buildANewWindowAndShow(ic);

        }

        private void DragonbornWaffleFriesButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.DWF;
            DragonbornWaffleFries menuItem = new DragonbornWaffleFries();
            ItemCustomization ic = new ItemCustomization(menuItem, orderList);
            buildANewWindowAndShow(ic);

        }


    }//class
}//namespace
