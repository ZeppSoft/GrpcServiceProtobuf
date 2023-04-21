using Google.Protobuf.WellKnownTypes;
using ProtoBuf.Grpc;
using ProtoBuf.Meta;
using Shared;
using Any = Shared.Any;

namespace GrpcServiceProtobuf.Services
{
    public class LoanManager : ILoanManager
    {
        public  Task<Shared.HelloReply> SayHelloAsync(Shared.HelloRequest request, CallContext context = default)
        {
            return Task.FromResult(new Shared.HelloReply
            {
                Message = "Hello LoanManager"
            }) ;
        }

        public Task<Shared.HelloReply> Test(ObjectWrapper request, CallContext context = default)
        {
            return Task.FromResult(new Shared.HelloReply
            {
                Message = "Hello LoanManager"
            });
        }

        public Task<Shared.HelloReply> TestContainer(Container request, CallContext context = default)
        {

            return Task.FromResult(new Shared.HelloReply
            {
                Message = "Hello LoanManager"
            });
        }

        public Task<Shared.HelloReply> TestTuple(TupleWrapper request, CallContext context = default)
        {
            return Task.FromResult(new Shared.HelloReply
            {
                Message = "Hello LoanManager"
            });
        }

        public Task<Shared.HelloReply> TestTupleSingleContainer(TupleSingleWrapper request, CallContext context = default)
        {
            return Task.FromResult(new Shared.HelloReply
            {
                Message = "Hello LoanManager"
            });
        }
    }
}
