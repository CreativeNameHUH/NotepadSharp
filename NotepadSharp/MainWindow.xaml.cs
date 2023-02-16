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
using System.IO;

namespace NotepadSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        private readonly TextHandler _textHandler;
        
        private void OnButtonPressed(object sender, RoutedEventArgs e)
        {
            string data = NotepadTextBox.Text;            
            File.WriteAllText("notepad.txt", data);
            MessageBox.Show("File saved successfully.");
        }
        public MainWindow()
        {
            
            
            InitializeComponent();
            
            _textHandler = TextHandler.GetTextHandler();
        }

        private void NotepadTextBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            _textHandler.Text = NotepadTextBox.Text;
        }
    }
}