﻿using MediatR;

namespace Infrastructure.Query.Interfaces
{
    public interface IQuery<TResponse> : IRequest<TResponse>
    {

    }
}
