using ArgeProject.Application.Abstractions.Repositories;
using ArgeProject.Domain.Entities;
using ArgeProject.Persistence.Data;

namespace ArgeProject.Persistence.Repositories
{
    public class SampleRepository : ISampleRepository
    {
        private readonly ArgeDbContext _context;
        //private readonly IRepository<TempTable> _repository;

        public SampleRepository(ArgeDbContext context)
        {
            _context = context;
            //_repository = repository;
        }

        public async Task InsertSampleDataAsync()
        {
            await _context.TempTable.AddAsync(new TempTable
            {
                Tarih = DateTime.Now,
            });

            _context.SaveChanges();
        }
    }
}
