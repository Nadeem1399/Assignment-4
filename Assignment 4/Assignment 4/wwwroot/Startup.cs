services.AddDbContext<NorthwindContext>(options =>
    options.UseSqlServer(Configuration.GetConnectionString("NorthwindConnection")));

