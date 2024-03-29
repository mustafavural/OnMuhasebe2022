﻿using Microsoft.Extensions.DependencyInjection;

namespace Core.Utilities.Ioc
{
    public interface ICoreModule
    {
        void Load(IServiceCollection services);
    }
}
