using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    [DataContract]
    public class Reply
    {
        string _name;
        string _key;
        DateTime _time;
        [DataMember]
        public string Name
        {
            get { return _name;}
            set { _name = value; }
        }
        [DataMember]
        public string Key
        {
            get { return _key; }
            set { _key = value; }
        }
        [DataMember]
        public DateTime Time
        {
            get { return _time; }
            set { _time = value; }
        }
    }
}
