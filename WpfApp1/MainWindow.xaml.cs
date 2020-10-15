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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"the description is {this.Descriptiontext.Text}");
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            this.WeldCheckbox.IsChecked = this.assemblyCheckbox.IsChecked = this.plasmaCheckbox.IsChecked = this.laserdCheckbox.IsChecked = this.purchaseCheckbox.IsChecked = this.latheCheckbox.IsChecked = this.drillCheckbox.IsChecked = this.foldCheckbox.IsChecked = this.rollCheckbox.IsChecked = this.sawCheckbox.IsChecked = false;
        }

        private void Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            this.LengthText.Text += ((CheckBox)sender).Content;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.noteText == null)
                return;

            //this.noteText.Text = (string)((ComboBoxItem)((ComboBox)sender).SelectedValue).Content;
        }
    }
}










//1. What does &lt;Grid&gt; and &lt;Stackpanel&gt; do and what is the difference between them? if you want your Program to be listed rather than divided use StackPanel and vice versa.

//2. In the following code, what percent of each column will each container take up? 50/25/25 since the first one takes up half.

//&lt;ColumnDefinition Width = “2*”/&gt; = x%
//&lt;ColumnDefinition Width = “*”/&gt; = x%
//&lt;ColumnDefinition Width = “*”/&gt; = x%

//3. What is the code to create a padding of “5” from the text to the border? Padding="*"

//4. What is the code to make the font Bold? FontWeight="Bold"

//5. What is the code to create a dropdown box? <ComboBox></ComboBox>

//6. What is the code to create checkbox that is pre-checked?  Checked="Checkbox_Checked"

//. What is the code to convert a value to a string?  Convert.ToString

//8. What does the keyword “this” mean in C#?  It allows you to access the different properties. 