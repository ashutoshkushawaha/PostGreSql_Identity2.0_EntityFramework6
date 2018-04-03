# PostGreSql_Identity2.0_EntityFramework6
Asp.net mvc 5 with implemention of Identity 2.0 PostGreSQL and Entityframwork 6.

 postgresql setup in mvc project
 
 1.in webconfig add this 
  <connectionStrings>
    <add name="Conn" providerName="Npgsql" connectionString="Server=localhost;Database=Test;User Id=postgres;Password=sa;port=5432;Search Path=public;CommandTimeout=180" />
  </connectionStrings>
  <system.data>
    <DbProviderFactories>
      <remove invariant="Npgsql" />
      <add name="Npgsql Data Provider" invariant="Npgsql" support="FF" description=".Net Framework Data Provider for Postgresql" type="Npgsql.NpgsqlFactory, Npgsql" />
    </DbProviderFactories>
  </system.data>
  <entityFramework>
  <defaultConnectionFactory type="Npgsql.NpgsqlFactory, Npgsql" />
  <providers>
    <provider invariantName="Npgsql" type="Npgsql.NpgsqlServices, Npgsql.EntityFramework" />
  </providers>
</entityFramework>

  2. EntityFramework6.Npgsql PostgreSQL provider for Entity Framework. install it from nuget.
  3. Npgsql Npgsql is the open source .NET data provider for PostgreSQL. install it from nuget.
 

4. Asp.identity 2.0 in postgresql

 public class SampleDbContext: IdentityDbContext<ApplicationUser>
    {
        public SampleDbContext() : base("Conn")
        {
            Database.SetInitializer<SampleDbContext>(null);
        }
        public virtual DbSet<sys_user> SYS_USER { get; set; }
        public virtual DbSet<company> Company { get; set; }
        public static SampleDbContext Create()
        {
            return new SampleDbContext();
        }
    }
	
	5. enable-migration to add migration folder 
	6. add-migration "meaningfull name" to add migration 
	7. update-database -verbose
	
	
