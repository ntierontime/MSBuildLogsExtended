using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Resources
{
    public static class ResourceFileFactory
    {
        public static Framework.Resources.UIStringResource GetUIStringResourceInstance()
        {
            return new Framework.Resources.UIStringResource();
        }
        public static Framework.Resources.UIImageResource GetUIImageResource()
        {
            return new Framework.Resources.UIImageResource();
        }
    }
}
