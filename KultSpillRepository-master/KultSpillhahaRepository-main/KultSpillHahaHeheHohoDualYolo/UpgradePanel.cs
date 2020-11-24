using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KultSpillHahaHeheHohoDualYolo
{
    class UpgradePanel
    {
        public static List<UpgradeDisplayerRectangle> speedUpgradeRectangles = new List<UpgradeDisplayerRectangle>
        {
            //new Rectangle1("kake", 5, 5, Color.Gold, 50, 50, true),
            new UpgradeDisplayerRectangle(Color.Transparent,/* Color.Green,*/  340, 145),
            new UpgradeDisplayerRectangle(Color.Transparent,/* Color.Green,*/  390, 145),
            new UpgradeDisplayerRectangle(Color.Transparent,/* Color.Green,*/  440, 145),
            new UpgradeDisplayerRectangle(Color.Transparent,/* Color.Green,*/  490, 145),
            new UpgradeDisplayerRectangle(Color.Transparent,/* Color.Green,*/  540, 145),
        };
        public static List<UpgradeDisplayerRectangle> sizeUpgradeRectangles = new List<UpgradeDisplayerRectangle>
        {
            new UpgradeDisplayerRectangle(Color.Transparent, 340, 215),
            new UpgradeDisplayerRectangle(Color.Transparent, 390, 215),
            new UpgradeDisplayerRectangle(Color.Transparent, 440, 215),
            new UpgradeDisplayerRectangle(Color.Transparent, 490, 215),
            new UpgradeDisplayerRectangle(Color.Transparent, 540, 215),
        };
        public static List<UpgradeDisplayerRectangle> coinFindUpgradesRectangles = new List<UpgradeDisplayerRectangle>
        {
            new UpgradeDisplayerRectangle(Color.Transparent, 340, 285),
            new UpgradeDisplayerRectangle(Color.Transparent, 390, 285),
            new UpgradeDisplayerRectangle(Color.Transparent, 440, 285),
            new UpgradeDisplayerRectangle(Color.Transparent, 490, 285),
            new UpgradeDisplayerRectangle(Color.Transparent, 540, 285),
        };
        public static List<UpgradeDisplayerRectangle> coinValueUpgradeRectangles = new List<UpgradeDisplayerRectangle>
        {
            new UpgradeDisplayerRectangle(Color.Transparent, 340, 355),
            new UpgradeDisplayerRectangle(Color.Transparent, 390, 355),
            new UpgradeDisplayerRectangle(Color.Transparent, 440, 355),
            new UpgradeDisplayerRectangle(Color.Transparent, 490, 355),
            new UpgradeDisplayerRectangle(Color.Transparent, 540, 355),
        };

        static List<Label1> labelList = new List<Label1>
        {
            new Label1(120, 150, "Speed:", Color.Transparent, 19),
            new Label1(120, 220, "Size:", Color.Transparent, 19),
            new Label1(120, 290, "Coin find:", Color.Transparent, 19),
            new Label1(120, 360, "Coin value:", Color.Transparent, 19),
        };
        static List<Buttons> ButtonsList = new List<Buttons>
        {
            new Buttons(new Point(40,157), 50,25, "BUY", new Font("times new roman", 9)),
            new Buttons(new Point(40,227), 50,25, "BUY",new Font("times new roman", 9)),
            new Buttons(new Point(40,297), 50,25, "BUY",new Font("times new roman", 9)),
            new Buttons(new Point(40,367), 50,25, "BUY",new Font("times new roman", 9)),
            new Buttons(new Point(1185,610), 150,100, "Go to next level",new Font("times new roman", 19)),
        };
        public static List<Label1> priceLabel = new List<Label1>
        {
            new Label1(230, 150, $"{Buttons._speedUpgradePrice}", Color.Gold, 20),
            new Label1(230, 220, $"{Buttons._sizeUpgradePrice}", Color.Gold, 20),
            new Label1(230, 150, $"{Buttons._coinFindUpgradePrice}", Color.Gold, 20),
            new Label1(230, 150, $"{Buttons._coinValueUpgradePrice}", Color.Gold, 20),
        };
        // buttonlist må gjøres om til en metode som tar form1 som parameter, som kalles fra form1 med this som parameter
        public static Label1 choseYourUpgradesLabel = new Label1(50, 50, "Upgrade time!", Color.Gold, 27);
        public static void CreateUpgradePanel( )
        {
            Form1.form1.BackColor = Color.MediumSlateBlue;
            choseYourUpgradesLabel.SpawnLabel();
            foreach (var rectangle in speedUpgradeRectangles)
            {
                rectangle.SpawnRectangle();
            }

            foreach (var rectangle in sizeUpgradeRectangles)
            {
                rectangle.SpawnRectangle();
            }

            foreach (var rectangle in coinFindUpgradesRectangles)
            {
                rectangle.SpawnRectangle();
            }

            foreach (var rectangle in coinValueUpgradeRectangles)
            {
                rectangle.SpawnRectangle();
            }
            foreach (var label in labelList)
            {
                label.SpawnLabel();
            }

            foreach (var button in ButtonsList)
            {
                button.SpawnButton();
                //button.SpeedUpgradeOnClick();
            }
            foreach (var label in priceLabel) label.SpawnLabel();
            addButtonFunctionality();
        }

        public static void DespawnUpgradePanel()
        {
            Form1.form1.BackColor = Color.PowderBlue;
            choseYourUpgradesLabel.DespawnLabel();
            foreach (var rectangle in speedUpgradeRectangles)
            {
                rectangle.DespawnRectangle();
            }

            foreach (var rectangle in sizeUpgradeRectangles)
            {
                rectangle.DespawnRectangle();
            }

            foreach (var rectangle in coinFindUpgradesRectangles)
            {
                rectangle.DespawnRectangle();
            }

            foreach (var rectangle in coinValueUpgradeRectangles)
            {
                rectangle.DespawnRectangle();
            }
            foreach (var label in labelList)
            {
                label.DespawnLabel();
            }

            foreach (var button in ButtonsList)
            {
                button.DespawnButton();
                //button.SpeedUpgradeOnClick();
            }
            foreach (var label in priceLabel) label.DespawnLabel();
        }
        private static void addButtonFunctionality()
        {
            ButtonsList[0].SpeedUpgradeOnClick();
            ButtonsList[1].sizeUpgradeUpgradeOnClick();
            ButtonsList[2].CoinFindUpgradeOnClick();
            ButtonsList[3].CoinValueUpgradeOnClick();
            ButtonsList[4].NextLevelButtonOnClick();
        }
    }
}
