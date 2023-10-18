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
public class GenericosVsSubmodulosController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GenericosVsSubmodulosController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<GenericosVsSubmodulosDto>>> Get()
    {
        var genericos = await _unitOfWork.GenericosVsSubmodulos.GetAllAsync();
        return _mapper.Map<List<GenericosVsSubmodulosDto>>(genericos);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<GenericosVsSubmodulosDto>> Get(int id)
    {
        var genericos = await _unitOfWork.GenericosVsSubmodulos.GetByIdAsync(id);
        if(genericos ==null)
            return NotFound();
        return _mapper.Map<GenericosVsSubmodulosDto>(genericos);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<GenericosVsSubmodulos>> Post([FromBody] GenericosVsSubmodulosDto genericosDto)
    {
        var genericos = _mapper.Map<GenericosVsSubmodulos>(genericosDto);
        _unitOfWork.GenericosVsSubmodulos.Add(genericos);
        await _unitOfWork.SaveAsync();
        if(genericosDto == null)
            return BadRequest();
        genericosDto.Id = genericos.Id;
        return CreatedAtAction(nameof(Post), new {Id = genericosDto.Id}, genericosDto);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<GenericosVsSubmodulosDto>> Put(int id, [FromBody] GenericosVsSubmodulosDto genericosDto)
    {
        if(genericosDto == null)
            return BadRequest();
        if(genericosDto.Id == 0)
            genericosDto.Id = id;
        if(genericosDto.Id != id)
            return BadRequest();
        var genericos = _mapper.Map<GenericosVsSubmodulos>(genericosDto);
        _unitOfWork.GenericosVsSubmodulos.Update(genericos);
        await _unitOfWork.SaveAsync();
        return genericosDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var genericos = await _unitOfWork.GenericosVsSubmodulos.GetByIdAsync(id);
        if(genericos == null)
            return BadRequest();
        _unitOfWork.GenericosVsSubmodulos.Remove(genericos);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}