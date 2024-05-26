using Barbie.Dtos;

namespace Barbie.Interfaces;

public interface IRecordService
{
    Task<List<RecordDto>> GetAll();
}