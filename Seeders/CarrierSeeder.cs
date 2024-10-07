    public static void Seed(ModelBuilder modelBuilder)
    {
        var brands = GenerateBrands(100);
        modelBuilder.Entity<Brand>().HasData(brands);
    }

    public static IEnumerable<Brand> GenerateBrands(int count)
    {
        int id = 1; 
        
        var faker = new Faker<Brand>()
            .RuleFor(b => b.Brand_id, f => id++) 
            .RuleFor(b => b.Brand_name, f => f.Company.CompanyName()) 
            .RuleFor(b => b.Brand_description, f => f.Lorem.Sentence(10));

        return faker.Generate(count);
    }