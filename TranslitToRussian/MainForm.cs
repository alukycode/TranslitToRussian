using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TranslitToRussian
{
    public partial class MainForm : Form
    {
        // transliteration rules are described here: https://ru.wikipedia.org/wiki/Транслитерация_русского_алфавита_латиницей
        private static List<DictionaryEntry> _dictionary;
        private static string[] _filePaths;
        private static string[] _decodedFilenames;

        public MainForm()
        {
            InitializeComponent();

            InitDictionary();
        }

        private void InitDictionary()
        {
            var dictionaryLines = File.ReadAllLines("Dictionary.txt");

            _dictionary = TranslitDecoder.ParseDictionary(dictionaryLines);
        }

        private void ReloadDictionaryButton_Click(object sender, System.EventArgs e)
        {
            InitDictionary();
            RefreshFilesList();
        }

        private void ChooseFilesButton_Click(object sender, System.EventArgs e)
        {
            // https://www.c-sharpcorner.com/UploadFile/mahesh/openfiledialog-in-C-Sharp/
            var openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _filePaths = openFileDialog.FileNames;
                _decodedFilenames = new string[_filePaths.Length];
                RefreshFilesList();
            }
        }

        private void RefreshFilesList()
        {
            if (_filePaths == null || _decodedFilenames == null)
            {
                return;
            };

            FilesListBox.Items.Clear();
            for (var i = 0; i < _filePaths.Length; i++)
            {
                var filePath = _filePaths[i];
                var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);
                var fileNameDecoded = TranslitDecoder.Decode(fileNameWithoutExtension, _dictionary);
                _decodedFilenames[i] = fileNameDecoded;
                FilesListBox.Items.Add(fileNameWithoutExtension + " -> " + fileNameDecoded);
            }
        }


        private void SelectAllButton_Click(object sender, System.EventArgs e)
        {
            for (int i = 0; i < FilesListBox.Items.Count; i++)
            {
                FilesListBox.SetItemChecked(i, true);
            }
        }

        private void DeselectAllButton_Click(object sender, System.EventArgs e)
        {
            for (int i = 0; i < FilesListBox.Items.Count; i++)
            {
                FilesListBox.SetItemChecked(i, false);
            }
        }

        private void RenameSelectedButton_Click(object sender, System.EventArgs e)
        {
            for (var i = 0; i < _filePaths.Length; i++)
            {
                if (FilesListBox.GetItemCheckState(i) == CheckState.Checked)
                {
                    var oldFilePath = _filePaths[i];
                    var fileInfo = new FileInfo(oldFilePath);
                    var newFilePath = Path.Combine(fileInfo.Directory.FullName, _decodedFilenames[i]) + fileInfo.Extension;
                    if (oldFilePath != newFilePath)
                    {
                        File.Move(oldFilePath, newFilePath);
                    }
                }
            }

            MessageBox.Show("Successfully renamed!");

            Application.Exit();
        }
    }
}
