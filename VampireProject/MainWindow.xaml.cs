using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VampireProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Variables
        private int str = 0;
        private int dex = 0;
        private int vit = 0;
        private int chrm = 0;
        private int man = 0;
        private int attr = 0;
        private int perc = 0;
        private int intl = 0;
        private int wit = 0;
        private int[] maxCharacteristics = {7, 5, 3};
        private bool isPhysicalCharacteristics = false;
        #endregion

        /// <summary>
        /// Strength check 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioBtnStr_Checked(object sender, RoutedEventArgs e)
        {
            if(radioBtnStr1.IsChecked == true)
            {
                str = 1;
            }
            else if(radioBtnStr2.IsChecked == true)
            {
                str = 2;
            }
            else if(radioBtnStr3.IsChecked == true)
            {
                str = 3;
            }
            else if(radioBtnStr4.IsChecked == true)
            {
                str = 4;
            }
            else if(radioBtnStr5.IsChecked == true)
            {
                str = 5;
            }
            physicalCharacteristicsCheck(e);
        }
        /// <summary>
        /// Dexterity check
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioBtnDex_Checked(object sender, RoutedEventArgs e)
        {
            if(radioBtnDex1.IsChecked == true)
            {
                dex = 1;
            }
            else if(radioBtnDex2.IsChecked == true)
            {
                dex = 2;
            }
            else if(radioBtnDex3.IsChecked == true)
            {
                dex = 3;
            }
            else if(radioBtnDex4.IsChecked == true)
            {
                dex = 4;
            }
            else if(radioBtnDex5.IsChecked == true)
            {
                dex = 5;
            }
            physicalCharacteristicsCheck(e);
        }
        /// <summary>
        /// Vitality check
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioBtnVit_Checked(object sender, RoutedEventArgs e)
        {
            if(radioBtnVit1.IsChecked == true)
            {
                vit = 1;
            }
            else if(radioBtnVit2.IsChecked == true)
            {
                vit = 2;
            }
            else if(radioBtnVit3.IsChecked == true)
            {
                vit = 3;
            }
            else if(radioBtnVit4.IsChecked == true)
            {
                vit = 4;
            }
            else if(radioBtnVit5.IsChecked == true)
            {
                vit = 5;
            }
            physicalCharacteristicsCheck(e);
        }
        /// <summary>
        /// Charisma check
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioBtnChrm_Checked(object sender, RoutedEventArgs e)
        {
            if(radioBtnChrm1.IsChecked == true)
            {
                chrm = 1;
            }
            else if(radioBtnChrm2.IsChecked == true)
            {
                chrm = 2;
            }
            else if(radioBtnChrm3.IsChecked == true)
            {
                chrm = 3;
            }
            else if(radioBtnChrm4.IsChecked == true)
            {
                chrm = 4;
            }
            else if(radioBtnChrm5.IsChecked == true)
            {
                chrm = 5;
            }
            physicalCharacteristicsCheck(e);
        }
        /// <summary>
        /// Manipulation check
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioBtnMan_Checked(object sender, RoutedEventArgs e)
        {
            if(radioBtnMan1.IsChecked == true)
            {
                man = 1;
            }
            else if(radioBtnMan2.IsChecked == true)
            {
                man = 2;
            }
            else if(radioBtnMan3.IsChecked == true)
            {
                man = 3;
            }
            else if(radioBtnMan4.IsChecked == true)
            {
                man = 4;
            }
            else if(radioBtnMan5.IsChecked == true)
            {
                man = 5;
            }
            physicalCharacteristicsCheck(e);
        }
        /// <summary>
        /// Attribute check
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioBtnAttr_Checked(object sender, RoutedEventArgs e)
        {
            if(radioBtnAttr1.IsChecked == true)
            {
                attr = 1;
            }
            else if(radioBtnAttr2.IsChecked == true)
            {
                attr = 2;
            }
            else if(radioBtnAttr3.IsChecked == true)
            {
                attr = 3;
            }
            else if(radioBtnAttr4.IsChecked == true)
            {
                attr = 4;
            }
            else if(radioBtnAttr5.IsChecked == true)
            {
                attr = 5;
            }
            physicalCharacteristicsCheck(e);
        }
        /// <summary>
        /// Perception check
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioBtnPerc_Checked(object sender, RoutedEventArgs e)
        {
            if(radioBtnPerc1.IsChecked == true)
            {
                perc = 1;
            }
            else if(radioBtnPerc2.IsChecked == true)
            {
                perc = 2;
            }
            else if(radioBtnPerc3.IsChecked == true)
            {
                perc = 3;
            }
            else if(radioBtnPerc4.IsChecked == true)
            {
                perc = 4;
            }
            else if(radioBtnPerc5.IsChecked == true)
            {
                perc = 5;
            }
            physicalCharacteristicsCheck(e);
        }
        /// <summary>
        /// Intelligence check
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioBtnInt_Checked(object sender, RoutedEventArgs e)
        {
            if(radioBtnInt1.IsChecked == true)
            {
                intl = 1;
            }
            else if(radioBtnInt2.IsChecked == true)
            {
                intl = 2;
            }
            else if(radioBtnInt3.IsChecked == true)
            {
                intl = 3;
            }
            else if(radioBtnInt4.IsChecked == true)
            {
                intl = 4;
            }
            else if(radioBtnInt5.IsChecked == true)
            {
                intl = 5;
            }
            physicalCharacteristicsCheck(e);
        }
        /// <summary>
        /// Wit check
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioBtnWit_Checked(object sender, RoutedEventArgs e)
        {
            if(radioBtnWit1.IsChecked == true)
            {
                wit = 1;
            }
            else if(radioBtnWit2.IsChecked == true)
            {
                wit = 2;
            }
            else if(radioBtnWit3.IsChecked == true)
            {
                wit = 3;
            }
            else if(radioBtnWit4.IsChecked == true)
            {
                wit = 4;
            }
            else if(radioBtnWit5.IsChecked == true)
            {
                wit = 5;
            }
            physicalCharacteristicsCheck(e);
        }
        /// <summary>
        /// Physical characteristics check and found needed points for other characteristics
        /// </summary>
        /// <param name="e"></param>
        private void physicalCharacteristicsCheck(RoutedEventArgs e)
        {
            int physicalCharacteristics = str + dex + vit;
            try
            {
                if(physicalCharacteristics <= maxCharacteristics[2])
                {
                    lblPhysicalCount.Content = physicalCharacteristics.ToString() + " / " + maxCharacteristics[2].ToString();
                }
                else if (physicalCharacteristics > maxCharacteristics[2] && physicalCharacteristics <= maxCharacteristics[1])
                {
                    lblPhysicalCount.Content = physicalCharacteristics.ToString() + " / " + maxCharacteristics[1].ToString();
                }
                else
                {
                    lblPhysicalCount.Content = physicalCharacteristics.ToString() + " / " + maxCharacteristics[0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (physicalCharacteristics > maxCharacteristics[0])
            {
                MessageBox.Show("You have exceeded the maximum number of points for physical characteristics");
                isPhysicalCharacteristics = true;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}