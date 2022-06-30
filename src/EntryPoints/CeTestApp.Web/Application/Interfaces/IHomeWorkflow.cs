using CeTestApp.Web.Models;

namespace CeTestApp.Web.Application.Interfaces;

public interface IHomeWorkflow
{
    Task<Home> GetResultOfAllOperationsAsync();
}