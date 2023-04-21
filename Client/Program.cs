using Grpc.Net.Client;
using ProtoBuf.Grpc.Client;
using ProtoBuf.Meta;
using Shared;

namespace Client
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            Thread.Sleep(4000);
            //using var channel = GrpcChannel.ForAddress("https://localhost:7140");

            ICwnetServiceWrpapper serviceWrapper = new CwnetServiceWrpapper();

            int objectIntId = 43;
            string objectStringId = "123";

          var res =  serviceWrapper.LoadObject<CWObject>(objectStringId);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();


            //var client = channel.CreateGrpcService<ILoanManager>();
            //var cwnetService = channel.CreateGrpcService<ICwnetService>();
            //var testService = channel.CreateGrpcService<ITestService>();



            ////var reply = await client.SayHelloAsync(
            ////    new HelloRequest { Name = "GreeterClient" });


            ////RuntimeTypeModel.Default.Add(typeof(System.Object), false).SetSurrogate(typeof(Any));

            //var obj = new object();
            //Type type = typeof(ILoanManager);

            ////var reply = await client.Test(
            ////    new ObjectWrapper { Type = type, Obj = obj });
            //var tl =  new List<Tuple<string, Type, object>>();

            //var t = Tuple.Create("Hello", type, new object());
            //tl.Add(t);

            //var o = new CWObject();


            //var reply = await cwnetService.LoadObject("");



            //var r2 = testService.LoadObject("");






            ////var reply = await client.TestTupleSingleContainer(
            ////    new TupleSingleWrapper {Value = t });

            ///*
            //RuntimeTypeModel.Default.Add(typeof(Any.Container), false).SetSurrogate(typeof(Any));

            //var reply = await client.TestContainer(
            //    new Container { Value = "Hello world" , Type = typeof(string) });

            //*/

            //// Console.WriteLine($"Greeting: {reply.Message}");







        }
    }
}