using AirPort_PRO_NuGet_Logger.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AirPort_PRO_NuGet_Logger.Contracts
{
    /// <summary>
    /// Интерфейс IAirPortStorage определяет контракт для хранилища самолетов
    /// </summary>
    public interface IAirPortStorage
    {
        Task<IReadOnlyCollection<Plane>> GetAllAsync();
        Task<Plane> AddAsync(Plane Plane);
        Task EditAsync(Plane Plane);
        Task<bool> DeleteAsync(Guid id);
    }
}
