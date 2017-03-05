﻿using System;
using Warden.Messages.Commands;

namespace Warden.Messages.Commands.Organizations
{
    public class UpdateOrganization : IAuthenticatedCommand
    {
        public Request Request { get; set; }
        public string UserId { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}