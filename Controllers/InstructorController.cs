using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InstructorSystem.Models;

namespace InstructorSystem.Controllers;

[Authorize]
public class InstructorController : Controller
{
    private readonly ApplicationDbContext _context;

    public InstructorController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var instructors = await _context.Instructors
            .AsNoTracking()
            .OrderBy(instructor => instructor.Department)
            .ThenBy(instructor => instructor.FullName)
            .ToListAsync();

        return View(instructors);
    }

    [HttpGet]
    public IActionResult Create() => View(new Instructor { InstructorId = string.Empty, Age = "N/A", BachelorDegree = "N/A", Majorship = "N/A" });

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(
        [Bind("InstructorId,FullName,Department,Age,Address,Gender,EmailAddress,BachelorDegree,Majorship")] Instructor instructor)
    {
        instructor.InstructorId = (instructor.InstructorId ?? string.Empty).Trim();
        if (string.IsNullOrWhiteSpace(instructor.InstructorId))
        {
            ModelState.AddModelError(nameof(instructor.InstructorId), "Instructor ID is required.");
        }
        else if (await _context.Instructors.AnyAsync(item => item.InstructorId.ToLower() == instructor.InstructorId.ToLower()))
        {
            ModelState.AddModelError(nameof(instructor.InstructorId), "An instructor with this ID already exists.");
        }

        if (ModelState.IsValid)
        {
            var email = instructor.EmailAddress.Trim().ToLowerInvariant();
            var duplicateEmail = await _context.Instructors
                .AnyAsync(item => item.EmailAddress.ToLower() == email);

            if (duplicateEmail)
            {
                ModelState.AddModelError(nameof(instructor.EmailAddress), "An instructor with this e-mail address already exists.");
            }
            else
            {
                instructor.FullName = instructor.FullName.Trim();
                instructor.Department = instructor.Department.Trim();
                instructor.Age = string.IsNullOrWhiteSpace(instructor.Age) ? "N/A" : instructor.Age.Trim();
                instructor.Address = instructor.Address.Trim();
                instructor.EmailAddress = email;
                instructor.BachelorDegree = string.IsNullOrWhiteSpace(instructor.BachelorDegree) ? "N/A" : instructor.BachelorDegree.Trim();
                instructor.Majorship = string.IsNullOrWhiteSpace(instructor.Majorship) ? "N/A" : instructor.Majorship.Trim();
                _context.Instructors.Add(instructor);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Instructor record created successfully.";
                return RedirectToAction(nameof(Index));
            }
        }

        return View(instructor);
    }

    [HttpGet]
    public async Task<IActionResult> Details(string? id)
    {
        if (string.IsNullOrWhiteSpace(id))
        {
            return NotFound();
        }

        var instructor = await _context.Instructors
            .AsNoTracking()
            .FirstOrDefaultAsync(item => item.InstructorId == id);

        return instructor is null ? NotFound() : View(instructor);
    }

    [HttpGet]
    public async Task<IActionResult> Edit(string? id)
    {
        if (string.IsNullOrWhiteSpace(id))
        {
            return NotFound();
        }

        var instructor = await _context.Instructors.FindAsync(id);
        return instructor is null ? NotFound() : View(instructor);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(
        string id,
        [Bind("InstructorId,FullName,Department,Age,Address,Gender,EmailAddress,BachelorDegree,Majorship")] Instructor instructor)
    {
        if (string.IsNullOrWhiteSpace(id))
        {
            return NotFound();
        }

        var existingInstructor = await _context.Instructors
            .AsNoTracking()
            .FirstOrDefaultAsync(item => item.InstructorId == id);

        if (existingInstructor is null)
        {
            return NotFound();
        }

        instructor.InstructorId = (instructor.InstructorId ?? string.Empty).Trim();
        if (string.IsNullOrWhiteSpace(instructor.InstructorId))
        {
            ModelState.AddModelError(nameof(instructor.InstructorId), "Instructor ID is required.");
        }
        else if (!string.Equals(id, instructor.InstructorId, StringComparison.OrdinalIgnoreCase))
        {
            var duplicateId = await _context.Instructors
                .AnyAsync(item => item.InstructorId.ToLower() == instructor.InstructorId.ToLower());

            if (duplicateId)
            {
                ModelState.AddModelError(nameof(instructor.InstructorId), "Another instructor already has this ID.");
            }
        }

        if (ModelState.IsValid)
        {
            var email = instructor.EmailAddress.Trim().ToLowerInvariant();
            var duplicateEmail = await _context.Instructors
                .AnyAsync(item => item.InstructorId != id && item.EmailAddress.ToLower() == email);

            if (duplicateEmail)
            {
                ModelState.AddModelError(nameof(instructor.EmailAddress), "Another instructor is already using this e-mail address.");
            }
            else
            {
                var fullName = instructor.FullName.Trim();
                var department = instructor.Department.Trim();
                var age = string.IsNullOrWhiteSpace(instructor.Age) ? "N/A" : instructor.Age.Trim();
                var address = instructor.Address.Trim();
                var gender = instructor.Gender.Trim();
                var bachelorDegree = string.IsNullOrWhiteSpace(instructor.BachelorDegree) ? "N/A" : instructor.BachelorDegree.Trim();
                var majorship = string.IsNullOrWhiteSpace(instructor.Majorship) ? "N/A" : instructor.Majorship.Trim();

                await _context.Database.ExecuteSqlInterpolatedAsync($@"
                    UPDATE Instructors 
                    SET InstructorId = {instructor.InstructorId},
                        FullName = {fullName},
                        Department = {department},
                        Age = {age},
                        Address = {address},
                        Gender = {gender},
                        EmailAddress = {email},
                        BachelorDegree = {bachelorDegree},
                        Majorship = {majorship}
                    WHERE InstructorId = {id};
                ");

                TempData["SuccessMessage"] = "Instructor record updated successfully.";
                return RedirectToAction(nameof(Index));
            }
        }

        return View(instructor);
    }

    [HttpGet]
    public async Task<IActionResult> Delete(string? id)
    {
        if (string.IsNullOrWhiteSpace(id))
        {
            return NotFound();
        }

        var instructor = await _context.Instructors
            .AsNoTracking()
            .FirstOrDefaultAsync(item => item.InstructorId == id);

        return instructor is null ? NotFound() : View(instructor);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        var instructor = await _context.Instructors.FindAsync(id);
        if (instructor is null)
        {
            return NotFound();
        }

        _context.Instructors.Remove(instructor);
        await _context.SaveChangesAsync();
        TempData["SuccessMessage"] = "Instructor record deleted successfully.";
        return RedirectToAction(nameof(Index));
    }
}
