using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.MODEL;

namespace TMS.DATA.Context
{
    public class TMS_Context : DbContext
    {
        public TMS_Context(DbContextOptions<TMS_Context> options) : base(options)
        {
        }

        public virtual DbSet<Users> Users { get; set; } = null!;
    }
}
