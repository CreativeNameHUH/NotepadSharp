using System;
using System.Windows;
using System.Windows.Controls;

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
            _textHandler.SaveFile("notepad.txt");
        }
        
        public MainWindow()
        {
            InitializeComponent();
            
            _textHandler = TextHandler.GetTextHandler();

            if (_textHandler is null)
                throw new NullReferenceException();
        }

        private void NotepadTextBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            _textHandler.Text = NotepadTextBox.Text;
        }
    }
}