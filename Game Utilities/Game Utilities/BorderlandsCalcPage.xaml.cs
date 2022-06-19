using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UtilitiesLib;

namespace Game_Utilities
{
    /// <summary>
    /// Interaction logic for BorderlandsCalcPage.xaml
    /// </summary>
    public partial class BorderlandsCalcPage : Page
    {
        public BorderlandsCalcPage()
        {
            InitializeComponent();
        }

        private void CalcBtnClick(object sender, RoutedEventArgs e)
        {
            float damagePerShot1 = float.Parse(DamageTxtBox1.Text) * float.Parse(NumProjectilesTxtBox1.Text);
            float damagePerShot2 = float.Parse(DamageTxtBox2.Text) * float.Parse(NumProjectilesTxtBox2.Text);

            float dps1 = UMath.CalcDPS(damagePerShot1, float.Parse(FireRateTxtBox1.Text));
            float dps2 = UMath.CalcDPS(damagePerShot1, float.Parse(FireRateTxtBox2.Text));

            SetResultLblColors(damagePerShot1, damagePerShot2, dps1, dps2);
            SetResultLblValues(damagePerShot1, damagePerShot2, dps1, dps2);
        }

        private void SetResultLblColors(float damage1, float damage2, float dps1, float dps2)
        {
            if (damage1 > damage2)
            {
                DamagePerShotLbl1.Foreground = Brushes.Green;
                DamagePerShotLbl2.Foreground = Brushes.Red;
            }
            else if (damage1 < damage2)
            {
                DamagePerShotLbl2.Foreground = Brushes.Green;
                DamagePerShotLbl1.Foreground = Brushes.Red;
            }
            else
            {
                DamagePerShotLbl1.Foreground = Brushes.Yellow;
                DamagePerShotLbl2.Foreground = Brushes.Yellow;
            }

            if (dps1 > dps2)
            {
                DamagePerSecondLbl1.Foreground = Brushes.Green;
                DamagePerSecondLbl2.Foreground = Brushes.Red;
            }
            else if (dps1 < dps2)
            {
                DamagePerSecondLbl2.Foreground = Brushes.Green;
                DamagePerSecondLbl1.Foreground = Brushes.Red;
            }
            else
            {
                DamagePerSecondLbl1.Foreground = Brushes.Yellow;
                DamagePerSecondLbl2.Foreground = Brushes.Yellow;
            }
        }

        private void SetResultLblValues(float damage1, float damage2, float dps1, float dps2)
        {
            DamagePerShotLbl1.Content = damage1.ToString();
            DamagePerShotLbl2.Content = damage2.ToString();
            DamagePerSecondLbl1.Content = dps1.ToString();
            DamagePerSecondLbl2.Content = dps2.ToString();
        }
    }
}
