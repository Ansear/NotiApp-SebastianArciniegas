using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
public class FormatosController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public FormatosController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<FormatosDto>>> Get()
    {
        var formato = await _unitOfWork.Formatos.GetAllAsync();
        return _mapper.Map<List<FormatosDto>>(formato);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<FormatosDto>> Get(int id)
    {
        var formato = await _unitOfWork.Formatos.GetByIdAsync(id);
        if(formato == null)
            return NotFound();
        return _mapper.Map<FormatosDto>(formato);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Formatos>> Post([FromBody] FormatosDto formatosDto)
    {
        var formato = _mapper.Map<Formatos>(formatosDto);
        if (formato.FechaCreacion == DateTime.MinValue)
        {
            formato.FechaCreacion = DateTime.Now;
            formatosDto.FechaCreacion = DateTime.Now;
        }
        if (formato.FechaModificacion == DateTime.MinValue)
        {
            formato.FechaModificacion = DateTime.Now;
            formatosDto.FechaModificacion = DateTime.Now;
        }
        _unitOfWork.Formatos.Add(formato);
        await _unitOfWork.SaveAsync();
        if(formato == null)
            return BadRequest();
        formatosDto.Id = formato.Id;
        return CreatedAtAction(nameof(Post), new {Id = formatosDto.Id}, formatosDto);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<FormatosDto>> Put(int id, [FromBody] FormatosDto formatosDto)
    {
        var formato = _mapper.Map<Formatos>(formatosDto);
        if(formatosDto == null)
            return BadRequest();
        if(formatosDto.Id == 0)
            formatosDto.Id = id;
        if(formatosDto.Id != id)
            return NotFound();
        if (formato.FechaCreacion == DateTime.MinValue)
        {
            formato.FechaCreacion = DateTime.Now;
            formatosDto.FechaCreacion = DateTime.Now;
        }
        if (formato.FechaModificacion == DateTime.MinValue)
        {
            formato.FechaModificacion = DateTime.Now;
            formatosDto.FechaModificacion = DateTime.Now;
        }
        _unitOfWork.Formatos.Update(formato);
        await _unitOfWork.SaveAsync();
        return formatosDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var formato = await _unitOfWork.Formatos.GetByIdAsync(id);
        if(formato == null)
            return NotFound();
        _unitOfWork.Formatos.Remove(formato);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}