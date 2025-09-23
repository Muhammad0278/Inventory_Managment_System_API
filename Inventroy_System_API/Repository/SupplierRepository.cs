using AutoMapper;
using Inventroy_System_API.Data;
using Inventroy_System_API.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Inventroy_System_API.Repository
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly AppDBContext _context;
        private readonly IMapper _mapper;

        public SupplierRepository(AppDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<SupplierModel>> GetAllSuppliers()
        {
            var suppliers = await _context.tbl_Supplier.ToListAsync();
            return _mapper.Map<List<SupplierModel>>(suppliers);
        }

        public async Task<SupplierModel> GetSupplierById(int supplierId)
        {
            var supplier = await _context.tbl_Supplier.FindAsync(supplierId);
            return _mapper.Map<SupplierModel>(supplier);
        }

        public async Task<int> AddSupplier(SupplierModel supplierModel)
        {
            var supplier = _mapper.Map<Supplier>(supplierModel);
            _context.tbl_Supplier.Add(supplier);
            await _context.SaveChangesAsync();
            return supplier.SupplierId;
        }

        public async Task UpdateSupplier(int supplierId, SupplierModel supplierModel)
        {
            var supplier = await _context.tbl_Supplier.FindAsync(supplierId);
            if (supplier != null)
            {

                _mapper.Map(supplierModel, supplier); // Maps only the updated fields
                await _context.SaveChangesAsync();

            }
        }
        public async Task DeleteSupplier(int supplierId)
        {
            var supplier = new Supplier { SupplierId = supplierId };
            _context.tbl_Supplier.Remove(supplier);
            await _context.SaveChangesAsync();
        }
    }
}
