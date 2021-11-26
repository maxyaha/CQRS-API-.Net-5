﻿using Microservice.Application.Entities.Errors.v1.Models;

namespace Microservice.Application.Entities.Errors.v1.Maps
{
    using dto = Companion.Entities.Errors.Models;

    public class ErrorMapper : BaseMapper<dto.Error, Error>
    {
    }
}
