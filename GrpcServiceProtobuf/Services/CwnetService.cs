using Shared;

namespace GrpcServiceProtobuf.Services

{
    public class CwnetService : ICwnetService
    {
        public ValueTask<CWObject> LoadObject(string id)
        {
            var obj = new CWObject();

            return new ValueTask<CWObject>(obj);
        }
    }
}
