using AutoMapper;
using Barbie.Data;
using Barbie.Dtos;
using Barbie.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Barbie.Services;

public class RecordService : IRecordService
{
    private readonly DataContext _dataContext;
    private readonly IMapper _mapper;

    public RecordService(DataContext dataContext, IMapper mapper)
    {
        _dataContext = dataContext;
        _mapper = mapper;
    }

    public async Task<List<RecordDto>> GetAll()
    {
        var records = await _dataContext.Records.ToListAsync();
        
        if (records == null)
        {
            throw new Exception("No records");
        }

        var recordsDto = records.Select(rec => _mapper.Map<RecordDto>(rec)).ToList();
        
        return recordsDto;
    }
}