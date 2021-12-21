using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    [ServiceContract]
    public interface IContract
    {
        [OperationContract]
        string Encrypt(string input, int[] key);
        [OperationContract]
        string Decrypt(string input, int[] key);
        [OperationContract]
        int wordCount(string input);
        [OperationContract]
        string Upper(string input);
        [OperationContract]
        [FaultContract(typeof(FaultException))]
        void SaveData(string inputName, string inputKey, int[] key);
        [OperationContract]
        string GetReply(Reply reply);
        [OperationContract]
        void SaveOperations(int operations);
        [OperationContract]
        int GetOperations(string inputName);
    }
}
