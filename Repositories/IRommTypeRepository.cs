using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDR.Models;

namespace FDR.Repositories;

public interface IRommTypeRepository
{
    Task<IEnumerable<RoomType>> GetAll();
    Task<RoomType> GetById(int id);
    Task<bool> CheckExistence(int id);

}
