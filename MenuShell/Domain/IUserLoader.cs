﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell.Domain
{
    interface IUserLoader
    {
        List<User> LoadUsers();
    }
}
