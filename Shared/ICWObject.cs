using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public interface IIDTitle<t>
    {
        t ID { get; set; }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        string Title { get; set; }
    }
    public interface IIDTitleObject : IIDTitle<object>
    {

    }

    /// <summary>
    /// Internal CustomWare.NET Object Interface. All Object MUST Implement it.
    /// </summary>
    /// 
    [ProtoContract]
    public interface ICWObject //: IIDTitleObject
    {
        public string SomeValue { get; set; }

        // bool IsDirty { get; }
        //void SetUpdated();
        //void SetUpdated(bool value);
        // bool WasRemoved { get; }
    }
}
