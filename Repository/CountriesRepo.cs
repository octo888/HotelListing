using HotelListing.Contracts;
using HotelListing.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.Repository;

public class CountriesRepo : GenericRepo<Country>, ICountriesRepository
{
    private readonly HotelListingDbContext _ctx;

    public CountriesRepo(HotelListingDbContext ctx) : base(ctx)
    {
        _ctx = ctx;
    }

    public async Task<Country> GetDetails(int id)
    {
        return await _ctx.Countries
            .Include(q => q.Hotels)
            .FirstOrDefaultAsync(q => q.Id == id);
    }
}
