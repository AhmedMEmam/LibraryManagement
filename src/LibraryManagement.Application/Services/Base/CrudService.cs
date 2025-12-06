using AutoMapper;
using LibraryManagement.Application.Interfaces.Persistence;
using LibraryManagement.Application.Interfaces.Services;
using LibraryManagement.Domain.Entities;

namespace LibraryManagement.Application.Services.Base;

public abstract class CrudService<TEntity, TDto, TCreateDto> : ICrudService<TDto, TCreateDto>
    where TEntity : BaseEntity
{
    private readonly IGenericRepository<TEntity> _repository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    protected CrudService(IGenericRepository<TEntity> repository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public virtual async Task<TDto> CreateAsync(TCreateDto dto)
    {
        var entity = _mapper.Map<TEntity>(dto);
        await _repository.AddAsync(entity);
        await _unitOfWork.SaveChangesAsync();
        return _mapper.Map<TDto>(entity);
    }

    public virtual async Task<bool> DeleteAsync(int id)
    {
        var entity = await _repository.GetByIdAsync(id);
        if (entity is null)
        {
            return false;
        }

        _repository.Remove(entity);
        await _unitOfWork.SaveChangesAsync();
        return true;
    }

    public virtual async Task<IEnumerable<TDto>> GetAllAsync()
    {
        var items = await _repository.GetAllAsync();
        return _mapper.Map<IEnumerable<TDto>>(items);
    }

    public virtual async Task<TDto?> GetByIdAsync(int id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity is null ? default : _mapper.Map<TDto>(entity);
    }

    public virtual async Task<bool> UpdateAsync(int id, TCreateDto dto)
    {
        var entity = await _repository.GetByIdAsync(id);
        if (entity is null)
        {
            return false;
        }

        _mapper.Map(dto, entity);
        _repository.Update(entity);
        await _unitOfWork.SaveChangesAsync();
        return true;
    }
}
