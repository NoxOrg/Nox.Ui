﻿using Microsoft.AspNetCore.Components;
using Nox.Ui.Models;
using Nox.Ui.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Nox.Ui
{
    // Not testable by UT
    [ExcludeFromCodeCoverage]
    public class ControlStringBase : ComponentBase
    {
        [Parameter]
        public entityAttributeDefinition? entityAttributeDefinition { get; set; }        
    }
}
