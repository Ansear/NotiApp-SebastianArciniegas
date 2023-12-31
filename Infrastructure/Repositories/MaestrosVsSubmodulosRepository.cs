using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories;
public class MaestrosVsSubmodulosRepository : GenericRepository<MaestrosVsSubmodulos>, IMaestrosVsSubmodulos
{
    private readonly NotiAppContext _context;

    public MaestrosVsSubmodulosRepository(NotiAppContext context) : base(context)
    {
        _context = context;
    }
}