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
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interfaces;
using PointOfSale;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ItemSelector.xaml
    /// </summary>
    public partial class ItemSelector : UserControl
    {
        
       


        public ItemSelector()
        {
            InitializeComponent();

            
        }
    
        
        public ItemSelected buttonPressed = ItemSelected.Default;
        
        
        public void fillContent(IOrderItem foo)
        {

            foreach (var prop in foo.GetType().GetProperties())
            {
                
            }

        }


        private void BriarheartBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.BB;
            BriarheartBurger briarheartBurger = new BriarheartBurger();
            fillContent(briarheartBurger);
        }

        private void DoubleDraugrButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.DD;

        }

        private void ThalmoreTripleButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.TT;

        }

        private void SmokehouseSkeletonButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.SS;

        }

        private void GardenOrcOmletteButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.GOO;

        }

        private void ThugsTBoneButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.TTB;

        }

        private void SailorSodaButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.SaSo;

        }

        private void MarkarthMilkButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.MM;

        }

        private void AretinoAppleJuiceButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.AAJ;

        }

        private void CandlehearthCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.CC;

        }

        private void WarriorWaterButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.WW;

        }

        private void VokunSaladButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.VS;

        }

        private void FriedMiraakButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.FM;

        }

        private void MadOtarGritsButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.MOG;

        }

        private void DragonbornWaffleFriesButton_Click(object sender, RoutedEventArgs e)
        {
            buttonPressed = ItemSelected.DWF;

        }


    }//class
}//namespace
