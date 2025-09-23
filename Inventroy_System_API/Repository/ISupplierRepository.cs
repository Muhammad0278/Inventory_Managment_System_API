using Inventroy_System_API.Models;

namespace Inventroy_System_API.Repository
{
    public interface ISupplierRepository
    {
        Task<List<SupplierModel>> GetAllSuppliers();
        Task<SupplierModel> GetSupplierById(int supplierId);
        Task<int> AddSupplier(SupplierModel supplierModel);
        Task UpdateSupplier(int supplierId, SupplierModel supplierModel);
        Task DeleteSupplier(int supplierId);
    }
}
