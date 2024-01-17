using Domain.Master;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces;

public interface IApplicationDbContext 
{ 
    DbSet<AppSettings> AppSettingsEnumerable { get; set; }
}