using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace ConvertBlockOfTextToStrings
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

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //take input from input box
            var inputText = inputTextBox.Text;
            //do stuff to it
            var stuffToSend = AddStuff(inputText);
            //print stuff to output box
            outputTextBox.Text = stuffToSend;
        }

        private string AddStuff(string inputText)
        {
            var output = new List<string>();
            using (StringReader reader = new StringReader(inputText))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    output.Add("\"" + line + "\", ");
                }
            }

            return string.Join("\r", output.ToArray());
        }
    }
}
