namespace CodeFirst_Invoice
{
    using CodeFirst_Invoice.Entity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class InvoiceContext : DbContext
    {


        // Your context has been configured to use a 'InvoiceContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CodeFirst_Invoice.InvoiceContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'InvoiceContext' 
        // connection string in the application configuration file.
        public InvoiceContext()
            : base("name=InvoiceContext")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
  
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }


        public virtual DbSet<City> Cities { get; set; }

        public virtual DbSet<County> Counties{ get; set; }

        public virtual DbSet<Customer> Customers{ get; set; }

        public virtual DbSet<InvoiceDetails> InvoiceDetails { get; set; }

        public virtual DbSet<InvoiceHeader> InvoiceHeaders{ get; set; }

        public virtual DbSet<Product>Products { get; set; }

        public virtual  DbSet<Unit> Units { get; set; }


   }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}