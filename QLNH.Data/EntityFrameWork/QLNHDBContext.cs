using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.Data.EntityFrameWork
{
    public class QLNHDBContext : DbContext
    {
        public QLNHDBContext(DbContextOptions options) : base(options)
        {
           
        }
        
    }
}
