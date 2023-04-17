﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ticketsonline.Models;

namespace ticketsonline.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllAsync();

        Task<Actor> GetByIdAsync(int id);
        Task AddAsync(Actor actor);
        Task<Actor> UpdateAsync(int id, Actor newActor);
        void Dalete(int id);
    }
}
