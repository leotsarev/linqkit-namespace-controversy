using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using LinqKit;

namespace LinqKitControversy.Console
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var ef6Ctx = new Ef6Context();
            var foo = await ef6Ctx.FooSet.AsExpandable().ToListAsync();

            var coreCtx = new CoreContext();
            var bar = await coreCtx.BarSet.AsExpandable().ToListAsync();

        }
    }
}
