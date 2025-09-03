using DevFreela.Application.ViewModels;
using MediatR;
using System.Collections.Generic;

namespace DevFreela.Application.Queries.GetAllProjects
{
    // Query sem parâmetros
    public class GetAllProjectsQuery : IRequest<List<ProjectViewModel>>
    {
       
    }
}