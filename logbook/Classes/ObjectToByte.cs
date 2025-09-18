using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Classes
{
    public class ObjectToByte
    {
        public static void ObjectToByteArray(object obj)
        {
            if (obj != null)
            {
                BinaryFormatter bf = new BinaryFormatter();
                using (MemoryStream ms = new MemoryStream())
                {
                    bf.Serialize(ms, obj);
                    Model.Accounts.image_bytes = ms.ToArray();
                }
            }
        }
    }
}
