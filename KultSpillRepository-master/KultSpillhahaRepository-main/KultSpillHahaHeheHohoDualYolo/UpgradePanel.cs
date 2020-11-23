using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        static List<UpgradeDisplayerRectangle> sizeUpgradeRectangles = new List<UpgradeDisplayerRectangle>
        {
            new UpgradeDisplayerRectangle(Color.Transparent, 340, 215),
            new UpgradeDisplayerRectangle(Color.Transparent, 390, 215),
            new UpgradeDisplayerRectangle(Color.Transparent, 440, 215),
            new UpgradeDisplayerRectangle(Color.Transparent, 490, 215),
            new UpgradeDisplayerRectangle(Color.Transparent, 540, 215),
        };
        static List<UpgradeDisplayerRectangle> coinFindUpgradesList = new List<UpgradeDisplayerRectangle>
        {
            new UpgradeDisplayerRectangle(Color.Transparent, 340, 285),
            new UpgradeDisplayerRectangle(Color.Transparent, 390, 285),
            new UpgradeDisplayerRectangle(Color.Transparent, 440, 285),
            new UpgradeDisplayerRectangle(Color.Transparent, 490, 285),
            new UpgradeDisplayerRectangle(Color.Transparent, 540, 285),
        };
        static List<UpgradeDisplayerRectangle> coinValueUpgradeList = new List<UpgradeDisplayerRectangle>
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
            new Buttons(new Point(40,152), 50,25),
        };
        public static Label1 choseYourUpgradesLabel = new Label1(50, 50, "Upgrade time!", Color.Gold, 27);
        public static void CreateUpgradePanel(Form1 formInstance)
        {
            formInstance.BackColor = Color.DodgerBlue;
            choseYourUpgradesLabel.SpawnLabel(formInstance);
            foreach (var rectangle in speedUpgradeRectangles)
            {
                rectangle.SpawnRectangle(formInstance);
            }

            foreach (var rectangle in sizeUpgradeRectangles)
            {
                rectangle.SpawnRectangle(formInstance);
            }

            foreach (var rectangle in coinFindUpgradesList)
            {
                rectangle.SpawnRectangle(formInstance);
            }

            foreach (var rectangle in coinValueUpgradeList)
            {
                rectangle.SpawnRectangle(formInstance);
            }
            foreach (var label in labelList)
            {
                label.SpawnLabel(formInstance);
            }

            foreach (var button in ButtonsList)
            {
                button.SpawnButton(formInstance);
                button.ButtonClick();
            }

        }
    }
}
