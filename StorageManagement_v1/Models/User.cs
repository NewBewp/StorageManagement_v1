﻿using System;
using System.Collections.Generic;

namespace StorageManagement_v1.Models;

public partial class User
{
    public int UsersId { get; set; }

    public string? Name { get; set; }

    public string? Role { get; set; }

    public string? Password { get; set; }

    public string? Email { get; set; }
}
