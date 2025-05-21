using Master.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master.Repository.Interface
{
    public interface IPartnerRepository
    {
        Task<List<Partner>> GetListPartnerAsync();
        Task<Partner> GetPartnerByIDAsync(int id);
        Task UpdatePartnerAsnc(Partner partner);

        Task AddToDataBaseAsync(Partner partner);
    }
}
