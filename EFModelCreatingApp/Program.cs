using EFModelCreatingApp;

//List<Country> countries = new()
//{
//    new Country{ Name = "Russia" },
//    new Country{ Name = "Usa" },
//    new Country{ Name = "China" }
//};

//List<Company> companies = new()
//{
//    new Company{ Name = "Yandex", Country = countries[0] },
//    new Company{ Name = "Google", Country = countries[1] },
//    new Company{ Name = "Huawai", Country = countries[2] },
//    new Company{ Name = "Amazon", Country = countries[1] },
//    new Company{ Name = "Avito", Country = countries[0] }
//};

//List<Position> positions = new()
//{
//    new Position{ Name = "Manager" },
//    new Position{ Name = "Developer" },
//    new Position{ Name = "Buhgalter" }
//};

using (EmployeeAppContext context = new())
{
    context.Database.EnsureDeleted();
    context.Database.EnsureCreated();
}

//using (EmployeeAppContext context = new())
//{
//    context.Employees.Add(new Employee() { PassportSeries = "XI78", 
//                                            PassportNumber = 123456, 
//                                            Name = "Bobby", 
//                                            Age = 26 });
//    context.Employees.Add(new Employee() { PassportSeries = "UP21", 
//                                            PassportNumber = 123456, 
//                                            Name = "Tommy", 
//                                            Age = 31 });
//    context.SaveChanges();
//}

//using (EmployeeAppContext context = new())
//{
//    foreach (var item in countries)
//        context.Countries.Add(item);
//    foreach (var item in positions)
//        context.Positions.Add(item);
//    foreach (var item in companies)
//        context.Companies.Add(item);

//    context.SaveChanges();
//}

//using (EmployeeAppContext context = new())
//{
//    var positions_dbset = context.Positions.ToList();
//    foreach(var p in positions_dbset)
//        Console.WriteLine(p.Name);
//}

//using (EmployeeAppContext context = new())
//{
//    context.Employees.Add(new() { Name = "Bobby", Age = 28 });
//    context.SaveChanges();
//}