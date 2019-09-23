using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Api.Core.Entity;

namespace Api.Core.Configurations
{
    // This class contains configuration regarding relationships
    class TestTableConfiguration : IEntityTypeConfiguration<TestTable>
    {
        public void Configure(EntityTypeBuilder<TestTable> builder)
        {
            // builder.HasMany(c => c.TaskAssignments)
            //  .WithOne(e => e.Task)
            //  .HasForeignKey(b => b.TaskId);
        }
    }
}
