using ProtoBuf;
using ProtoBuf.Grpc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    [ServiceContract]
    public interface ITestService
    {
        [OperationContract]
        TestReply TestLoadObject(TestRequest request,
           CallContext context = default);

        [OperationContract]
        TestObjectReply Test2LoadObject(Container request,
          CallContext context = default);

        [OperationContract]
        Container Test3LoadObject(Container request,
         CallContext context = default);


    }

    [ProtoContract]
    public class TestReply
    {
        [ProtoMember(1)]
        public string Reply { get; set; }
    }

    [DataContract]
    public class TestObjectReply
    {
        [DataMember(Order = 1, Name = nameof(Value))]
        public Any.Container Any { get => new Any.Container(Value); set => Value = value.Value; }
        /// <summary>Object</summary>
        public object? Value;
    }

    [DataContract]
    public class TestObjectReply2
    {
        [DataMember(Order = 1, Name = nameof(Value))]
        public Any.Container Any { get => new Any.Container(Value); set => Value = value.Value; }
        /// <summary>Object</summary>
        public object? Value;
    }

    [ProtoContract]
    public class TestRequest
    {
        [ProtoMember(1)]
        public string Request { get; set; }
    }



    public class MyObject : ICWObject 
    {
        public string SomeValue { get; set; }
    }
}
