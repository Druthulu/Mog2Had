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
        //  STORAGE OBJECT FOR PATCH DATA
        public string sourceMD5 { get; set; }
        public List<ObjectData> dataPoints { get; set; }
        public M2HPatch()
        {
            this.sourceMD5 = "";
            this.dataPoints = new List<ObjectData>();
        }
    }

    public class ObjectData
    {
        public int startAddress { get; set; }   //  OB1 source address
        public int length { get; set; } //  OB2 how long to replace/insert, 0 for insert, x for replace
        public string type { get; set; }    //  OB3 "replace", "insert"
        public byte[] data { get; set; }    //  OB4 [0,1,2,3,4...]
        public ObjectData()
        {
            this.startAddress = 0;
            this.length = 0;
            this.type = "";
            this.data = new byte[0];
        }
    }
}
