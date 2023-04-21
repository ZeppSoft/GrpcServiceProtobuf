using ProtoBuf;
using ProtoBuf.Grpc.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{

    [SubService]
    interface ISomeCommonBehavior<T3>
    {
        void Foo3(T3 request);
    }
    [Service]
    interface ISomeService : ISomeCommonBehavior<SomeValidDataContract>
    { }


    public class SomeValidDataContract : ISomeService
    {
        public void Foo3(SomeValidDataContract request)
        {
            throw new NotImplementedException();
        }
    }


    [SubService]
    public interface ICustomWareNET<T> where T :class, ICWObject
    {
        //void Foo3(T request);
        // public ValueTask<T2> LoadObject<T2>(string id);
        public ValueTask<T> LoadObject(string id);
    }


    [Service]
   public interface ICwnetService : ICustomWareNET<CWObject>
    {
    }


    [DataContract]
    public class CWObject : ICWObject
    {
        //[ProtoMember(1)]
        //public bool IsDirty { get; }

        //[ProtoMember(2)]
        //public bool WasRemoved { get; }
        [DataMember(Order = 1, Name = nameof(SomeValue))]
        public string SomeValue { get; set ; }
    }

    // T LoadObject<T>(object id) where T : class, ICWObject;



    //[SubService] // naming is hard
    //public interface IVehicleReloader<T> where T : IVehicle
    //{
    //    public ValueTask<T> ReloadInstance(ReloadInstanceRequest path);
    //}

    //[Service]
    //public interface ICarService : IVehicleReloader<Car>
    //{
    //}

    ////[Service]
    ////public interface IMotorbike : IVehicleReloader<Motorbike>
    ////{
    ////}

    //public class Car : ICarService
    //{
    //    public ValueTask<Car> ReloadInstance(ReloadInstanceRequest path)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}


    //public class ReloadInstanceRequest
    //{

    //}
}
