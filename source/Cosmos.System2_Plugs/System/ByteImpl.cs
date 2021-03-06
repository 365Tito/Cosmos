using Cosmos.Common;
using Cosmos.IL2CPU.API;
using Cosmos.IL2CPU.API.Attribs;

namespace Cosmos.System_Plugs.System
{
    [Plug(Target = typeof(byte))]
    public static class ByteImpl
    {
        public static string ToString(ref byte aThis)
        {
            return StringHelper.GetNumberString(aThis);
        }
    }
}
