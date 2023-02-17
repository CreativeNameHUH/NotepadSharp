using System.Windows;
using System.IO;

namespace NotepadSharp
{
    public class TextHandler
    {
        private static TextHandler _instance;

        public string Text { get; set; } = string.Empty;
        
        
        public static TextHandler GetTextHandler()
        {
            if (_instance == null)
                _instance = new TextHandler();

            return _instance;
        }

        public TextHandler()
        {
            
        }

        public void SaveFile(in string pathToFile)
        {
            File.WriteAllText(pathToFile, Text);
            MessageBox.Show("File saved successfully.");
        }
    }
}
