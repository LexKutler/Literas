﻿using LiterasDataTransfer.DTO;
using LiterasModels.System;
using MediatR;

namespace LiterasCQS.Commands.Users;

public class PatchUserCommand : IRequest<int>
{
    public UserDTO User { get; set; }
    public List<PatchModel> PatchList { get; set; }
}