﻿using HealthifyApp.Data.Models;
using HealthifyApp.Data.Repository.Interfaces;
using HealthifyApp.Services.Data.Interfaces;

namespace HealthifyApp.Services.Data
{
    public class BaseService : IBaseService
    {
        private readonly IRepository<UserProfile, Guid> userProfileRepository;

        public BaseService(IRepository<UserProfile, Guid> userProfileRepository)
        {
            this.userProfileRepository = userProfileRepository;
        }

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

        public async Task<UserProfile> GetUserProfileAsync(Guid userId)
        {
            return await userProfileRepository
                            .FirstOrDefaultAsync(up =>
                                up.IsActiveProfile == true &&
                                up.ApplicationUserProfiles.Any(a => a.ApplicationUserId == userId));
        }

        public async Task<bool> IsUserProfileValid(string? userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                return false;
            }

            var userProfile = await userProfileRepository.FirstOrDefaultAsync(up =>
                up.IsActiveProfile &&
                up.ApplicationUserProfiles.Any(a => a.ApplicationUserId.ToString() == userId));

            return userProfile != null;
        }
    }
}
