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
public class HiloRespuestaNotificacionController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public HiloRespuestaNotificacionController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<HiloRespuestaNotificacionDto>>> Get()
    {
        var response = await _unitOfWork.HiloRespuestaNotificacion.GetAllAsync();
        return _mapper.Map<List<HiloRespuestaNotificacionDto>>(response);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<HiloRespuestaNotificacionDto>> Get(int id)
    {
        var response = await _unitOfWork.HiloRespuestaNotificacion.GetByIdAsync(id);
        if(response == null )
            return NotFound();
        return _mapper.Map<HiloRespuestaNotificacionDto>(response);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<HiloRespuestaNotificacion>> Post([FromBody] HiloRespuestaNotificacionDto hiloDto)
    {
        var hilo = _mapper.Map<HiloRespuestaNotificacion>(hiloDto);
        if (hilo.FechaCreacion == DateTime.MinValue)
        {
            hilo.FechaCreacion = DateTime.Now;
            hiloDto.FechaCreacion = DateTime.Now;
        }
        if (hilo.FechaModificacion == DateTime.MinValue)
        {
            hilo.FechaModificacion = DateTime.Now;
            hiloDto.FechaModificacion = DateTime.Now;
        }
        _unitOfWork.HiloRespuestaNotificacion.Add(hilo);
        await _unitOfWork.SaveAsync();
        if(hilo == null)
            return BadRequest();
        hiloDto.Id = hilo.Id;
        return CreatedAtAction(nameof(Post), new {Id = hiloDto.Id}, hiloDto);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<HiloRespuestaNotificacionDto>> Put(int id, [FromBody] HiloRespuestaNotificacionDto hiloDto)
    {
        var hilo = _mapper.Map<HiloRespuestaNotificacion>(hiloDto);
        if(hiloDto == null)
            return BadRequest();
        if(hiloDto.Id == 0)
            hiloDto.Id = id;
        if(hiloDto.Id != id)
            return NotFound();
        if (hilo.FechaCreacion == DateTime.MinValue)
        {
            hilo.FechaCreacion = DateTime.Now;
            hiloDto.FechaCreacion = DateTime.Now;
        }
        if (hilo.FechaModificacion == DateTime.MinValue)
        {
            hilo.FechaModificacion = DateTime.Now;
            hiloDto.FechaModificacion = DateTime.Now;
        }
        _unitOfWork.HiloRespuestaNotificacion.Update(hilo);
        await _unitOfWork.SaveAsync();
        return hiloDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var hilo = await _unitOfWork.HiloRespuestaNotificacion.GetByIdAsync(id);
        if(hilo == null)
            return NotFound();
        _unitOfWork.HiloRespuestaNotificacion.Remove(hilo);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}