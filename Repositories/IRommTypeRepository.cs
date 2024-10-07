using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDR.Models;

namespace FDR.Repositories;

public interface IRommTypeRepository
{
    Task<List<RoomType>> GetAll();
    Task<RoomType> GetById(int id);
}
