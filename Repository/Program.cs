using Microsoft.EntityFrameworkCore;
using Repository;

var host = "localhost";
var username = "pi-user";
var password = "pi-password";

var options = new DbContextOptionsBuilder<PersonContext>()
    .UseNpgsql($"Host={host};Username={username};Password={password}")
    .UseSnakeCaseNamingConvention()
    .Options;

var context = new PersonContext(options);