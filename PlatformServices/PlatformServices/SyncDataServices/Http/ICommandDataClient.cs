using PlatformServices.Dtos;
using System.Threading.Tasks;

namespace PlatformServices.SyncDataServices.Http
{
    public interface ICommandDataClient
    {
        Task SendPlatformToCommand(PlatformReadDto plat);
    }
}
