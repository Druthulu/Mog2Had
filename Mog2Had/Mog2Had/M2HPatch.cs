using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Mog2Had
{
    public class M2HPatch
    {
        //  STORAGE CONTAINER FOR ALL PATCH DATA
        public string m2H = "M2H";
        public string sourceMD5 { get; set; }
        public List<ObjectData> dataPoints { get; set; }
        public M2HPatch(string sourceMD5)
        {
            this.sourceMD5 = sourceMD5;
            this.dataPoints = new List<ObjectData>();
        }
    }

    public class ObjectData
    {
        //  STORAGE FOR EACH PATCH
        public int startAddress { get; set; }   //  OB1 source address
        public int length { get; set; } //  OB2 how long to replace/insert, 0 for insert, x for replace
        public string type { get; set; }    //  OB3 "replace", "insert"
        public byte[] data { get; set; }    //  OB4 [0,1,2,3,4...]
        public ObjectData(int startAddress, int length, string type, byte[] data)
        {
            this.startAddress = startAddress;
            this.length = length;
            this.type = type;
            this.data = data;
        }
    }
}
