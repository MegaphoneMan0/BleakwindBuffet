using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BleakwindBuffet.Data
{
    class Menu
    {

        static IEnumerable<IOrderItem> Entrees()
        {
            BriarheartBurger BB = new BriarheartBurger();
            DoubleDraugr DD = new DoubleDraugr();
            GardenOrcOmelette GOO = new GardenOrcOmelette();
            PhillyPoacher PP = new PhillyPoacher();
            SmokehouseSkeleton SS = new SmokehouseSkeleton();
            ThalmorTriple TT = new ThalmorTriple();
            ThugsTBone TTB = new ThugsTBone();

            IEnumerable<IOrderItem> entrees = Enumerable.Empty<IOrderItem>();
            entrees.Append(BB);
            entrees.Append(DD);
            entrees.Append(GOO);
            entrees.Append(PP);
            entrees.Append(SS);
            entrees.Append(TT);
            entrees.Append(TTB);

            return entrees;

        }

        static IEnumerable<IOrderItem> Sides()
        {
            IEnumerable<IOrderItem> sides = Enumerable.Empty<IOrderItem>();

            DragonbornWaffleFries DWFsmall = new DragonbornWaffleFries();
            DWFsmall.Size = Enums.Size.Small;
            DragonbornWaffleFries DWFmedium = new DragonbornWaffleFries();
            DWFmedium.Size = Enums.Size.Medium;
            DragonbornWaffleFries DWFlarge = new DragonbornWaffleFries();
            DWFlarge.Size = Enums.Size.Large;


            FriedMiraak FMsmall = new FriedMiraak();
            FMsmall.Size = Enums.Size.Small;
            FriedMiraak FMmedium = new FriedMiraak();
            FMmedium.Size = Enums.Size.Medium;
            FriedMiraak FMlarge = new FriedMiraak();
            FMlarge.Size = Enums.Size.Large;

            MadOtarGrits MOGsmall = new MadOtarGrits();
            MOGsmall.Size = Enums.Size.Small;
            MadOtarGrits MOGmedium = new MadOtarGrits();
            MOGmedium.Size = Enums.Size.Medium;
            MadOtarGrits MOGlarge = new MadOtarGrits();
            MOGlarge.Size = Enums.Size.Large;

            VokunSalad VSsmall = new VokunSalad();
            VSsmall.Size = Enums.Size.Small;
            VokunSalad VSmedium = new VokunSalad();
            VSmedium.Size = Enums.Size.Medium;
            VokunSalad VSlarge = new VokunSalad();
            VSlarge.Size = Enums.Size.Large;

            sides.Append(DWFsmall);
            sides.Append(DWFmedium);
            sides.Append(DWFlarge);

            sides.Append(FMsmall);
            sides.Append(FMmedium);
            sides.Append(FMlarge);

            sides.Append(MOGsmall);
            sides.Append(MOGmedium);
            sides.Append(MOGlarge);

            sides.Append(VSsmall);
            sides.Append(VSmedium);
            sides.Append(VSlarge);


            return sides;

        }


        static IEnumerable<IOrderItem> Drinks()
        {
            IEnumerable<IOrderItem> drinks = Enumerable.Empty<IOrderItem>();




        }









    }
}
