extern alias LinqKitEF;
extern alias LinqKitEFCore;

using LinqKitControversy.Console;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppNetCore
{
    // see https://stackoverflow.com/questions/35899657/how-to-extern-alias-an-assembly-with-net-core
    class Program
    {
        static void Main(string[] args)
        {
            var ef6Ctx = new Ef6Context();
            var fooSet = ef6Ctx.FooSet;

            var resultEF = LinqKitEF::LinqKit.Extensions.AsExpandable(fooSet).ToListAsync().Result;
            

            var coreCtx = new CoreContext();
            var barSet = coreCtx.BarSet;

            var resultEFCore = LinqKitEFCore::LinqKit.Extensions.AsExpandable(barSet).ToListAsync().Result;
        }
    }
}