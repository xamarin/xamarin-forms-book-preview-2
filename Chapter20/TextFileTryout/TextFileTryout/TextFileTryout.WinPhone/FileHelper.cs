using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using Xamarin.Forms;

[assembly: Dependency(typeof(TextFileTryout.WinPhone.FileHelper))]

namespace TextFileTryout.WinPhone
{
    class FileHelper : IFileHelper
    {
        public bool Exists(string filename)
        {
            bool exists = false;

            using (IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForApplication())
            {
                exists = storage.FileExists(filename);
            }
            return exists;
        }

        public void WriteText(string filename, string text)
        {
            using (IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForApplication())
            {

                using (IsolatedStorageFileStream stream = storage.CreateFile(filename))
                {
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        writer.Write(text);
                    }
                }
            }
        }

        public string ReadText(string filename)
        {
            string contents = null;

            using (IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForApplication())
            {
                using (IsolatedStorageFileStream stream = storage.OpenFile(filename, FileMode.Open))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        contents = reader.ReadToEnd();
                    }
                }
            }
            return contents;
        }

        public IEnumerable<string> GetFiles()
        {
            IEnumerable<string> files = null;

            using (IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForApplication())
            {
                files = storage.GetFileNames();
            }
            return files;
        }

        public void Delete(string filename)
        {
            using (IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForApplication())
            {
                storage.DeleteFile(filename);
            }
        }
    }
}
