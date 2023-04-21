using Grpc.Net.Client;
using ProtoBuf.Grpc.Client;
using ProtoBuf.Meta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public interface ICwnetServiceWrpapper
    {
        T LoadObject<T>(object id) where T : class, ICWObject;
    }
    public class CwnetServiceWrpapper : ICwnetServiceWrpapper
    {
        GrpcChannel channel;
        ILoanManager loanManager;
        ICwnetService cwnetService;
        ITestService testService;
        public CwnetServiceWrpapper()
        {
            channel = GrpcChannel.ForAddress("https://localhost:7140");
            loanManager = channel.CreateGrpcService<ILoanManager>();
            cwnetService = channel.CreateGrpcService<ICwnetService>();
            testService = channel.CreateGrpcService<ITestService>();

            RuntimeTypeModel.Default.Add(typeof(Any.Container), false).SetSurrogate(typeof(Any));

        }
         T ICwnetServiceWrpapper.LoadObject<T>(object id)
        {
            //var resp =  testService.TestLoadObject(new TestRequest { Request = id.ToString() });

            // var res = resp.Reply;

            // //Type type = typeof(T);

            // return res as T;


            //var resp = testService.Test3LoadObject(new Container {Value = id, Type = typeof(T)});

            var resp = testService.Test2LoadObject(new Container { Value = id, Type = typeof(T) });

            var t = resp.Any;

            return resp.Value as T;

        }
    }
}
