using System;
using MagicVilla.API.Data;
using MagicVilla.API.Models;
using MagicVilla.API.Repositories.Interfaces;

namespace MagicVilla.API.Repositories
{
    public class VillaRepository : BaseRepository<Villa>, IVillaRepository
    {
        public VillaRepository(ApplicationDbContext applicationDb) : base(applicationDb)
        {
        }

    }
}

