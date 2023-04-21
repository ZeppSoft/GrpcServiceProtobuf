using ProtoBuf.Grpc.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    [SubService]
    public interface IBaseService<T> where T : ICWObject
    {
        //void Foo3(T request);
        // public ValueTask<T2> LoadObject<T2>(string id);
         T LoadObject(string id);
    }


    //[Service]
    //public interface ITestService : IBaseService<CWObject>
    //{
    //}

    //public class MyObject : CWObject { }
}
