using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.Foundation;
using System.IO;
using System.Text.RegularExpressions;

namespace SentenceLearner
{
    class MyStorage
    {
        StorageFolder InstallationFolder;
        const string StorageFileName = @"Assets\MyStorage\EnglishTexts.csv";
        private string TextStorage { get; set; }

        public MyStorage()
        {
            InstallationFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;
        }

        public async void Load(List<TextSet> model)
        {
            await LoadData(model);
        }

        private async Task LoadData(List<TextSet> model)
        {
            var file = await InstallationFolder.GetFileAsync(StorageFileName);
            var contents = await file.OpenStreamForReadAsync();

            //var assetsFolder = await InstallationFolder.GetFolderAsync(@"Assets\MyStorage");
            //foreach (var file in await assetsFolder.GetFilesAsync())
            //{
            //    int debug = 1;
            //}

            using (StreamReader streamReader = new StreamReader(contents))
            {
                TextStorage = streamReader.ReadToEnd();

                //var lines = TextStorage.Split('\n');
                var lines = Regex.Split(TextStorage, "\r\n|\r|\n");
                foreach (var line in lines)
                {
                    var feilds = ReadLine(line);
                    MakeModel(model, feilds);
                }
            }
            
        }

        private void MakeModel(List<TextSet> model, List<string> stringList)
        {
            if(stringList.Count == 2)
            {
                model.Add(new TextSet { English = stringList[0], Japanese = stringList[1] });
            }
        }

        private List<string> ReadLine(string line)
        {
            var record = new List<string>();
            var field = new StringBuilder();
            var isQuotedField = false;

            foreach(var character in line)
            {
                switch(isQuotedField) {
                    case true :
                        switch(character)
                        {
                            case '"':
                                isQuotedField = false;
                                break;
                            default:
                                field.Append(character);
                                break;
                        }
                        break;
                    case false:
                        switch(character)
                        {
                            case '"':
                                isQuotedField = true;
                                break;
                            case ',':
                                record.Add(field.ToString());
                                field.Clear();
                                break;
                            default:
                                field.Append(character);
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
            record.Add(field.ToString());

            return record;
        }
    }
}
