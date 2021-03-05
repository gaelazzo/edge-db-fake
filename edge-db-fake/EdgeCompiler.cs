using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace edge_db_fake {
    public class EdgeCompiler {
        public Func<object, Task<object>> CompileFunc(IDictionary<string, object> parameters) { 
            return (o) => { return Task.FromResult((object) null); };
        }
    }
}
