using Master.Entities;
using Master.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master.Repository.Implementation
{
    public class PartnerRepository : IPartnerRepository
    {
        private readonly MasterPolBsvContext _context;

        public PartnerRepository(MasterPolBsvContext context)
        {
            _context = context;
        }

        public async Task AddToDataBaseAsync(Partner partner)
        {
            await _context.AddAsync(partner);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Partner>> GetListPartnerAsync()
        {
            return await _context.Partners.Include(p => p.IdPartnerTypeNavigation).ToListAsync();
        }

        public Task<Partner> GetPartnerByIDAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdatePartnerAsnc(Partner partner)
        {
            var existingPartner = await _context.Partners
        .FirstOrDefaultAsync(p => p.IdPartner == partner.IdPartner);

            if (existingPartner != null)
            { 
                _context.Entry(existingPartner).CurrentValues.SetValues(partner);

                await _context.SaveChangesAsync();
            }
        }
    }
}
