using CarRentalManagement.Server.Data;
using CarRentalManagement.Server.IRepository;
using CarRentalManagement.Server.Models;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace CarRentalManagement.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Make> _makes;
        private IGenericRepository<Model> _models;
        private IGenericRepository<Colour> _colours;
        private IGenericRepository<Booking> _bokkings;
        private IGenericRepository<Customer> _customers;
        private IGenericRepository<Vehicle> _vehicles;

        private Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IGenericRepository<Make> Makes => _makes ??= new GenericRepository<Make>(_context);

        public IGenericRepository<Model> Models => throw new NotImplementedException();

        public IGenericRepository<Vehicle> Vehicles => throw new NotImplementedException();
       
        public IGenericRepository<Colour> Colours => throw new NotImplementedException();

        public IGenericRepository<Booking> Bookings => throw new NotImplementedException();

        public IGenericRepository<Customer> Customers => throw new NotImplementedException();

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this); // es para que mate en la memoria estas unidades de trabajo, cerrar conexiones
        }

        public async Task Save(HttpContext httpContext)
        {
            ////var user = httpContext.User.Identity.Name;
            var userId = httpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var user = await _userManager.FindByIdAsync(userId);

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == Microsoft.EntityFrameworkCore.EntityState.Modified ||
                q.State == Microsoft.EntityFrameworkCore.EntityState.Added );
            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).UpdatedDate = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdatedBy = user.UserName;
                if (entry.State == Microsoft.EntityFrameworkCore.EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).CreatedDate = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = user.UserName;
                }
            }
            await _context.SaveChangesAsync();
        }

    }
}
