using HealthifyApp.Services.Data.Interfaces;

namespace CinemaApp.Services.Data
{
    public class BaseService : IBaseService
    {
        public bool IsGuidIdValid(string? id, ref Guid parsedGuidId)
        {
            // Non-existing parameter in the URL
            if (string.IsNullOrEmpty(id))
            {
                return false;
            }

            // Invalid parameter in the URL
            bool isGuidValid = Guid.TryParse(id, out parsedGuidId);
            if (!isGuidValid)
            {
                return false;
            }

            return true;
        }
    }
}
