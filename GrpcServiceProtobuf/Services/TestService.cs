using ProtoBuf.Grpc;
using ProtoBuf.Meta;
using Shared;

namespace GrpcServiceProtobuf.Services
{
    public class TestService : ITestService
    {
        public TestObjectReply Test2LoadObject(Container request, CallContext context = default)
        {
            Type type = request.Type;

           var t = new CWObject {SomeValue ="Hello, world!" };


            //return new TestObjectReply { Value = Activator.CreateInstance(request.Type) };
            return new TestObjectReply { Value = t };

        }

        public Container Test3LoadObject(Container request, CallContext context = default)
        {
            Type type = request.Type;

             //var t = new CWObject {SomeValue = "Hello, Test" };//Activator.CreateInstance(request.Type);
            var t = Activator.CreateInstance(request.Type);

            // return new TestObjectReply {Reply = new CWObject {Value = "Response" }  };

            var container = new Container { Value = t };

            return container;
        }

        public TestReply TestLoadObject(TestRequest request, CallContext context = default)
        {
            //return Task.FromResult(new Shared.TestReply
            //{
            //    Reply = "Hello TestLoadObject"
            //});

            return new Shared.TestReply
            {
                Reply = "Hello TestLoadObject"
            };
        }


        //TupleSingleWrapper
    }
}
