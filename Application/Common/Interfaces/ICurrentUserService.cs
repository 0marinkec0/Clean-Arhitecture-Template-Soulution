﻿namespace Application.Common.Interfaces
{
    public interface ICurrentUserService
    {
        int UserId { get; }
        string Email { get; }
    }
}
