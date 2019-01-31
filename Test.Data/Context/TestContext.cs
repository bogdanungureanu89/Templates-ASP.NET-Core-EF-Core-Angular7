namespace Test.Data.Context
{
    using Microsoft.EntityFrameworkCore;

    public class TestContext : DbContext
    {


        public TestContext()
        {

        }

        public TestContext(DbContextOptions<TestContext> options) : base(options)
        {

        }

        //define DbSets here
        //define modelBuilder here: OnModelCreating
    }
}
