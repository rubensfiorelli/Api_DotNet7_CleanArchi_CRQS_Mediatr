﻿using MediatR;

namespace Infrastructure.Query.Interfaces
{
    public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, TResponse> where TQuery : IQuery<TResponse>
    {

    }
}
