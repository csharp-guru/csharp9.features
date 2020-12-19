using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharo9.Features.TargetTypedNewExpressions
{
    public class ExampleObject
    {
        public string PropertyString { get; set; }
        public Dictionary<string, string> Dictionary { get; set; }

        // initializing readonly or static types
        private readonly static object s_syncObj = new();

        // creating object's type is already known
        public static ExampleObject InitExampleObject() => new();
    }
}
