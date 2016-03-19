using SmartModel.Entities;
using System.Data.Entity;

namespace SmartDAL
{
    public class SmartContext : DbContext
    {
        public DbSet<Trial> Trials { get; set; }     
        public SmartContext()
            : base("SmartContext")
        {

        }
    }
}
