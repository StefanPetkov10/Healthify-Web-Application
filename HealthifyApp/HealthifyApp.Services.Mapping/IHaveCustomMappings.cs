using AutoMapper;

namespace HealthifyApp.Services.Mapping
{
    public interface IHaveCustomMappings
    {
        void CreateMappings(IProfileExpression configurate);
    }
}
