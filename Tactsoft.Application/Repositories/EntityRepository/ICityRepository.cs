﻿using Tactsoft.Application.Models.Entities;
using Tactsoft.Application.Repository.Base;
using Tactsoft.Domain.Entities;

namespace Tactsoft.Application.Repositories.EntityRepository;

public interface ICityRepository : IBaseRepository<City, CityVM, long>
{
}
