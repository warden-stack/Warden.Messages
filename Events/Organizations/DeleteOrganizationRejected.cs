using System;
using Warden.Messages.Events;

namespace Warden.Messages.Events.Organizations
{
    public class DeleteOrganizationRejected : IRejectedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public string Code { get; }
        public string Reason { get; }
        public Guid OrganizationId { get; }

        protected DeleteOrganizationRejected()
        {
        }

        public DeleteOrganizationRejected(Guid requestId,
            string userId, string code,
            string reason, Guid organizationId)
        {
            RequestId = requestId;
            UserId = userId;
            Code = code;
            Reason = reason;
            OrganizationId = organizationId;
        }
    }
}