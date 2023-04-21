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
    public interface ILoanManager
    {
        [OperationContract]
        Task<HelloReply> SayHelloAsync(HelloRequest request,
            CallContext context = default);

        [OperationContract]
        Task<HelloReply> Test(ObjectWrapper request,
            CallContext context = default);

        [OperationContract]
        Task<HelloReply> TestTuple(TupleWrapper request,
            CallContext context = default);

        [OperationContract]
        Task<HelloReply> TestContainer(Container request,
           CallContext context = default);

        [OperationContract]
        Task<HelloReply> TestTupleSingleContainer(TupleSingleWrapper request,
          CallContext context = default);
    }
    [ProtoContract]
    public class TupleWrapper
    {
        [ProtoMember(1)]
        public List<Tuple<string, Type, object>> Lst { get; set; }
    }

    [ProtoContract]
    public class TupleSingleWrapper
    {
        [ProtoMember(1)]
        public Tuple<Type, object> Value { get; set; }
    }

    [DataContract]
    public class ObjectWrapper
    {
        [DataMember(Order = 1)]
        public object Obj { get; set; }

        [DataMember(Order = 2)]
        public Type Type { get; set; }
    }

    [DataContract]
    public class HelloReply
    {
        [DataMember(Order = 1)]
        public string Message { get; set; }
    }

    [DataContract]
    public class HelloRequest
    {
        [DataMember(Order = 1)]
        public string Name { get; set; }
    }
}
