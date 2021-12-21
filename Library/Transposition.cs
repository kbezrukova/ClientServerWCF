using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Transposition : IContract
    {
        public string Encrypt(string input, int[] key)
        {
            //if (key.Length!=4)
            //    throw new FaultException("Ключ введен неверно! Проверьте длину ключа или правильность разделения пробелами.");
            for (int i = 0; i < input.Length % key.Length; i++)
                input += input[i];

            string result = "";

            //for (int i = 0; i < key.Length; i++)
            //{
            //    if (key[i] < 1 || key[i] > 4)
            //        throw new FaultException("Ключ введен неверно! Цифры должны быть в диапазоне от 1 до 4.");
            //    else
            //        for (int j=0; j< key.Length; j++)
            //            if (key[i]==key[j] && i!=j)
            //                throw new FaultException("Ключ введен неверно! Цифры не должны повторяться.");
            //}

            for (int i = 0; i < input.Length; i += key.Length)
            {
                char[] transposition = new char[key.Length];

                for (int j = 0; j < key.Length; j++)
                    transposition[key[j] - 1] = input[i + j];

                for (int j = 0; j < key.Length; j++)
                    result += transposition[j];
            }

            return result;
        }
        public string Decrypt(string input, int[] key)
        {
            //if (key.Length != 4)
            //    throw new FaultException("Ключ введен неверно! Проверьте длину ключа или правильность разделения пробелами.");
            string result = "";

            //for (int i = 0; i < key.Length; i++)
            //    if (key[i] < 1 || key[i] > 4)
            //        throw new FaultException("Ключ введен неверно! Цифры должны быть в диапазоне от 1 до 4.");
            //    else
            //        for (int j = 0; j < key.Length; j++)
            //            if (key[i] == key[j] && i != j)
            //                throw new FaultException("Ключ введен неверно! Цифры не должны повторяться.");

            for (int i = 0; i < input.Length; i += key.Length)
            {
                
                char[] transposition = new char[key.Length];

                for (int j = 0; j < key.Length; j++)
                    transposition[j] = input[i + key[j] - 1];

                for (int j = 0; j < key.Length; j++)
                    result += transposition[j];
            }

            return result;
        }

        public int wordCount(string input)
        {
            string[] textMass;
            textMass = input.Split(' ');
            return textMass.Length;
        }

        public string Upper(string input)
        {
            return input.ToUpper();
        }

        const string connectionString = "Server=LAPTOP-0AFOURN8\\SQLEXPRESS;Database=User;Trusted_Connection=True;";
        DataContext db = new DataContext(connectionString);
        public void SaveData(string inputName, string inputKey, int[] key)
        {
            if (key.Length != 4)
                throw new FaultException("Ключ введен неверно! Проверьте длину ключа или правильность разделения пробелами.");
            for (int i = 0; i < key.Length; i++)
            {
                if (key[i] < 1 || key[i] > 4)
                    throw new FaultException("Ключ введен неверно! Цифры должны быть в диапазоне от 1 до 4.");
                else
                    for (int j = 0; j < key.Length; j++)
                        if (key[i] == key[j] && i != j)
                            throw new FaultException("Ключ введен неверно! Цифры не должны повторяться.");
            }
            if (inputName == "" || inputKey == "")
                throw new FaultException("Вы не заполнили поле с именем или ключем! Проверьте поля еще раз.");
            Table<Users> users = db.GetTable<Users>();
            Users newUser = new Users();
            if (CheckData(inputName))
                throw new FaultException("Пользователь с таким именем уже существует");

            newUser.Name = inputName;
            newUser.Key1 = inputKey;
            users.InsertOnSubmit(newUser);
            db.SubmitChanges();
                
        }
        public void SaveOperations(int operations)
        {
            Table<Users> users = db.GetTable<Users>();
            Users newUser = new Users();
            newUser.Operations = operations;
            users.InsertOnSubmit(newUser);
            db.SubmitChanges();
        }
        public int GetOperations(string inputName)
        {
            Table<Users> users = db.GetTable<Users>();
            int s = 0;
            foreach (var user in users)
            {
                if (user.Name == inputName)
                    s = user.Operations;
            }
            return s;
        }
        public bool CheckData(string inputName)
        {
            Table<Users> users = db.GetTable<Users>();
            foreach (var user in users)
            {
                if (user.Name == inputName)
                    return true;
            }
            return false;
        }
       
       
        public string GetReply(Reply reply)
        {          
            return String.Format("Имя '{0}' и ключ '{1}' были успешно сохранены {2}", reply.Name, reply.Key, reply.Time);
        }
    }
}
