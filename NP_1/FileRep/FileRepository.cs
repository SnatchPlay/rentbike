using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP_1.FileRep
{
    public abstract class FileRepository<T>:IRepository<T>
    {
        protected string filePath;
        public List<T> Data { get; } = new List<T>();
        public void Add(T item)
        {
            Data.Add(item);
            Writetofile();
        }
        public void Remove(short ind)
        {
            Data.RemoveAt(ind);
            Writetofile();
        }
        public void Writetofile() {
            if (!File.Exists(filePath))
            {
                throw new Exception($"Error: File({filePath}) not found");
            }
            using (StreamWriter sw = new StreamWriter(filePath, false))
            {
                 WriteObj(sw);
            }

        }
        public void ReadFromFile()
        {
            if (!File.Exists(filePath))
            {
                throw new Exception($"Error: File({filePath}) not found");
            }
            List<String> filelines = new List<string>();
            string Line;
            
            StreamReader streamReader = new StreamReader(filePath);

            while ((Line = streamReader.ReadLine()) != null)
            {
                filelines.Add(Line);
            }
            streamReader.Close();
            ConvertToObject(filelines);
            }
        
        protected abstract void ConvertToObject(List<string> strObjItems);
        protected abstract void WriteObj(StreamWriter sw);



    }
}

//namespace CarDealer.FileRepositories
//{
//    public static class Constants
//    {
//        public static int MaxSize = 10;
//    }

//    public abstract class FileRepository<T> : IRepository<T>
//    {
        
//        readonly string filePath;
//        readonly char delim;
//        bool dataFetched;

//        public FileRepository()
//        {
//            filePath = @"C:\Users\ihor.borachok\Desktop\csharp\CarDealer\CarDealer\Data\Cars.txt";
//            dataFetched = false;
//            delim = ',';
//            SafetyReadItemsFromFile();
//        }

//        public void Add(T newItem)
//        {
//            items[++current] = newItem;
//            //write to file
//        }

//        public void Remove(T itemToBeRemoved)
//        {
//            throw new NotImplementedException();
//            //delete from file: 1. get items ; 2. delete item from items; 3. write all items to file
//        }

//        public T[] GetAll()
//        {
//            SafetyReadItemsFromFile();
//            return items;
//        }

//        private void Clear()
//        {
//            if (current == -1 || items == null)
//                return;

//            for (int i = 0; i <= current; i++)
//            {
//                items[i] = default;
//            }
//        }

//        private void Init()
//        {
//            items = new T[Constants.MaxSize];
//            current = -1;
//        }

//        private void SafetyReadItemsFromFile()
//        {
//            try
//            {
//                if (dataFetched)
//                    return;

//                Clear();
//                ReadItemsFromFile();

//                dataFetched = true;
//            }
//            catch (Exception ex)
//            {
//                throw new Exception($"Error during read file: {ex.Message}");
//            }
//        }

//        private void ReadItemsFromFile()
//        {
//            using (var streamReader = new StreamReader(filePath))
//            {
//                ReadItemsFromStream(streamReader);
//            }
//        }

//        private void ReadItemsFromStream(StreamReader streamReader)
//        {
//            string fileLine;

//            //string maxSizeStr = streamReader.ReadLine();
//            //int maxSize = Convert.ToInt32(maxSizeStr);

//            Init();

//            while ((fileLine = streamReader.ReadLine()) != null)
//            {
//                string[] strObjItems = fileLine.Split(delim);
//                items[++current] = ConvertToObject(strObjItems);
//            }
//        }

//        protected abstract T ConvertToObject(string[] strObjItems);
//    }
//}