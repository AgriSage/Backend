﻿using AgriSage.API.IAM.Domain.Model.Commands;
using AgriSage.API.IAM.Interfaces.REST.Resources;

namespace AgriSage.API.IAM.Interfaces.REST.Transform;

public static class SignUpCommandFromResourceAssembler
{
    public static SignUpCommand ToCommandFromResource(SignUpResource resource)
    {
        return new SignUpCommand(resource.Username, resource.Password);
    }
}