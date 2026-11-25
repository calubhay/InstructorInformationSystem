using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using InstructorSystem;
using InstructorSystem.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") 
    ?? "Data Source=instructor-information.db";

if (connectionString.StartsWith("Data Source=", StringComparison.OrdinalIgnoreCase))
{
    var dataSource = connectionString.Substring("Data Source=".Length).Trim();
    if (!Path.IsPathRooted(dataSource))
    {
        dataSource = Path.Combine(builder.Environment.ContentRootPath, dataSource);
        connectionString = $"Data Source={dataSource}";
    }
}

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(connectionString));
builder.Services.AddScoped<IPasswordHasher<UserAccount>, PasswordHasher<UserAccount>>();

builder.Services
    .AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Account/Login";
        options.AccessDeniedPath = "/Account/Login";
        options.SlidingExpiration = true;
        options.Cookie.HttpOnly = true;
        options.Cookie.SameSite = SameSiteMode.Lax;
    });

builder.Services.AddAuthorization();

var app = builder.Build();

// Create or migrate the SQLite schema on startup.
using (var scope = app.Services.CreateScope())
{
    var database = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    database.Database.EnsureCreated();

    try
    {
        using var connection = database.Database.GetDbConnection();
        connection.Open();

        using var checkCmd = connection.CreateCommand();
        checkCmd.CommandText = "PRAGMA table_info(Instructors);";
        var hasDesignation = false;
        var hasDepartment = false;
        var hasAge = false;
        var hasBachelorDegree = false;
        var hasMajorship = false;
        var idType = "TEXT";

        using (var reader = checkCmd.ExecuteReader())
        {
            while (reader.Read())
            {
                var colName = reader["name"]?.ToString();
                var colType = reader["type"]?.ToString();
                if (string.Equals(colName, "InstructorId", StringComparison.OrdinalIgnoreCase))
                {
                    idType = colType ?? "TEXT";
                }
                if (string.Equals(colName, "Designation", StringComparison.OrdinalIgnoreCase))
                {
                    hasDesignation = true;
                }
                if (string.Equals(colName, "Department", StringComparison.OrdinalIgnoreCase))
                {
                    hasDepartment = true;
                }
                if (string.Equals(colName, "Age", StringComparison.OrdinalIgnoreCase))
                {
                    hasAge = true;
                }
                if (string.Equals(colName, "BachelorDegree", StringComparison.OrdinalIgnoreCase))
                {
                    hasBachelorDegree = true;
                }
                if (string.Equals(colName, "Majorship", StringComparison.OrdinalIgnoreCase))
                {
                    hasMajorship = true;
                }
            }
        }

        if (hasDesignation || idType.Contains("INT", StringComparison.OrdinalIgnoreCase))
        {
            using var rebuildCmd = connection.CreateCommand();
            rebuildCmd.CommandText = @"
                CREATE TABLE IF NOT EXISTS Instructors_New (
                    InstructorId TEXT NOT NULL PRIMARY KEY,
                    FullName TEXT NOT NULL,
                    Department TEXT NOT NULL DEFAULT 'Institute of Education (IED)',
                    Age TEXT NOT NULL DEFAULT 'N/A',
                    BachelorDegree TEXT NOT NULL DEFAULT 'N/A',
                    Majorship TEXT NOT NULL DEFAULT 'N/A',
                    Address TEXT NOT NULL,
                    Gender TEXT NOT NULL,
                    EmailAddress TEXT NOT NULL
                );
                INSERT INTO Instructors_New (InstructorId, FullName, Department, Age, BachelorDegree, Majorship, Address, Gender, EmailAddress)
                SELECT 
                    CAST(InstructorId AS TEXT), 
                    FullName, 
                    COALESCE(Department, 'Institute of Education (IED)'), 
                    'N/A', 
                    'N/A', 
                    'N/A', 
                    Address, 
                    Gender, 
                    EmailAddress 
                FROM Instructors;
                DROP TABLE Instructors;
                ALTER TABLE Instructors_New RENAME TO Instructors;
                CREATE UNIQUE INDEX IF NOT EXISTS IX_Instructors_EmailAddress ON Instructors (EmailAddress);
            ";
            rebuildCmd.ExecuteNonQuery();
        }
        else
        {
            if (!hasDepartment)
            {
                using var alterCmd = connection.CreateCommand();
                alterCmd.CommandText = "ALTER TABLE Instructors ADD COLUMN Department TEXT NOT NULL DEFAULT 'Institute of Education (IED)';";
                alterCmd.ExecuteNonQuery();
            }

            if (!hasAge)
            {
                using var alterCmd = connection.CreateCommand();
                alterCmd.CommandText = "ALTER TABLE Instructors ADD COLUMN Age TEXT NOT NULL DEFAULT 'N/A';";
                alterCmd.ExecuteNonQuery();
            }

            if (!hasBachelorDegree)
            {
                using var alterCmd = connection.CreateCommand();
                alterCmd.CommandText = "ALTER TABLE Instructors ADD COLUMN BachelorDegree TEXT NOT NULL DEFAULT 'N/A';";
                alterCmd.ExecuteNonQuery();
            }

            if (!hasMajorship)
            {
                using var alterCmd = connection.CreateCommand();
                alterCmd.CommandText = "ALTER TABLE Instructors ADD COLUMN Majorship TEXT NOT NULL DEFAULT 'N/A';";
                alterCmd.ExecuteNonQuery();
            }

            using var updateDefaultsCmd = connection.CreateCommand();
            updateDefaultsCmd.CommandText = @"
                UPDATE Instructors SET Age = 'N/A' WHERE Age IS NULL OR Age = '';
                UPDATE Instructors SET BachelorDegree = 'N/A' WHERE BachelorDegree IS NULL OR BachelorDegree = '';
                UPDATE Instructors SET Majorship = 'N/A' WHERE Majorship IS NULL OR Majorship = '';
            ";
            updateDefaultsCmd.ExecuteNonQuery();
        }
    }
    catch
    {
        // Safety fallback
    }

    DbInitializer.Seed(database);
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");

app.Run();
