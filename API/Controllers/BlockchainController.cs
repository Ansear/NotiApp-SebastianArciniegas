using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using API.Dtos;

namespace API.Controllers;
public class BlockchainController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public BlockchainController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<BlockchainDto>>> Get()
    {
        var blockchain = await _unitOfWork.Blockchain.GetAllAsync();
        return _mapper.Map<List<BlockchainDto>>(blockchain);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<BlockchainDto>> Get(int id)
    {
        var blockchain = await _unitOfWork.Blockchain.GetByIdAsync(id);
        if (blockchain == null)
            return NotFound();
        return _mapper.Map<BlockchainDto>(blockchain);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Blockchain>> Post([FromBody] BlockchainDto blockchainDto)
    {
        var blockchain = _mapper.Map<Blockchain>(blockchainDto);
        if (blockchain.FechaCreacion == DateTime.MinValue)
        {
            blockchain.FechaCreacion = DateTime.Now;
            blockchainDto.FechaCreacion = DateTime.Now;
        }
        if (blockchain.FechaModificacion == DateTime.MinValue)
        {
            blockchain.FechaModificacion = DateTime.Now;
            blockchainDto.FechaModificacion = DateTime.Now;
        }
        _unitOfWork.Blockchain.Add(blockchain);
        await _unitOfWork.SaveAsync();
        if (blockchain == null)
        {
            return BadRequest();
        }
        blockchainDto.Id = blockchain.Id;
        return CreatedAtAction(nameof(Post), new { Id = blockchainDto.Id }, blockchainDto);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<BlockchainDto>> Put(int id, [FromBody] BlockchainDto blockchainDto)
    {
        var blockchain = _mapper.Map<Blockchain>(blockchainDto);
        if (blockchainDto == null)
            return BadRequest();
        if (blockchainDto.Id == 0)
            blockchainDto.Id = id;
        if (blockchainDto.Id != id)
            return NotFound();
        if (blockchain.FechaCreacion == DateTime.MinValue)
        {
            blockchain.FechaCreacion = DateTime.Now;
            blockchainDto.FechaCreacion = DateTime.Now;
        }
        if (blockchain.FechaModificacion == DateTime.MinValue)
        {
            blockchain.FechaModificacion = DateTime.Now;
            blockchainDto.FechaModificacion = DateTime.Now;
        }
        _unitOfWork.Blockchain.Add(blockchain);
        await _unitOfWork.SaveAsync();
        return blockchainDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var blockchain = await _unitOfWork.Blockchain.GetByIdAsync(id);
        if (blockchain == null)
            return NotFound();
        _unitOfWork.Blockchain.Remove(blockchain);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}