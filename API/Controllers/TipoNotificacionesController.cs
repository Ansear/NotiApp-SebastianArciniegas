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
public class TipoNotificacionesController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public TipoNotificacionesController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<TipoNotificacionesDto>>> Get()
    {
        var tipo = await _unitOfWork.TipoNotificaciones.GetAllAsync();
        return _mapper.Map<List<TipoNotificacionesDto>>(tipo);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<TipoNotificacionesDto>> Get(int id)
    {
        var tipo = await _unitOfWork.TipoNotificaciones.GetByIdAsync(id);
        if (tipo == null)
            return NotFound();
        return _mapper.Map<TipoNotificacionesDto>(tipo);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<TipoNotificacionesDto>> Post([FromBody] TipoNotificacionesDto tipoNotificacionesDto)
    {
        var tipo = _mapper.Map<TipoNotificaciones>(tipoNotificacionesDto);
        _unitOfWork.TipoNotificaciones.Add(tipo);
        await _unitOfWork.SaveAsync();
        if (tipo == null)
            return BadRequest();
        tipoNotificacionesDto.Id = tipo.Id;
        return CreatedAtAction(nameof(Post), new { Id = tipoNotificacionesDto.Id }, tipoNotificacionesDto);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<TipoNotificacionesDto>> Put(int id, [FromBody] TipoNotificacionesDto tipoNotificacionesDto)
    {
        if (tipoNotificacionesDto == null)
            return BadRequest();
        if (tipoNotificacionesDto.Id == 0)
            tipoNotificacionesDto.Id = id;
        if (tipoNotificacionesDto.Id != id)
            return NotFound();
        var tipo = _mapper.Map<TipoNotificaciones>(tipoNotificacionesDto);
        _unitOfWork.TipoNotificaciones.Update(tipo);
        await _unitOfWork.SaveAsync();
        return tipoNotificacionesDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var tipo = await _unitOfWork.TipoNotificaciones.GetByIdAsync(id);
        if (tipo == null)
            return NotFound();
        _unitOfWork.TipoNotificaciones.Remove(tipo);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}