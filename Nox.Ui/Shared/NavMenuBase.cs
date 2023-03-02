using Microsoft.AspNetCore.Components;
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
    public class NavMenuBase : ComponentBase
    {
        [Parameter]
        public globalDefinition? globalDefinition { get; set; }

        [Parameter]
        public List<navigationDefinition>? navigationDefinitions { get; set; }

        private string? _configurationRead { get; set; } = null;

        private string? configurationRead
        {
            get
            {
                if (_configurationRead == null)
                {
                    _configurationRead = ConfigurationHelper.ReadConfiguration();
                }
                return _configurationRead;
            }
        }

        protected override async Task OnInitializedAsync()
        {
            globalDefinition = Data.GlobalDefinitionHelper.GetGlobalDefinition(configurationRead);
            navigationDefinitions = Data.NavigationDefinitionHelper.GetNavigationDefinitions(configurationRead);

            await base.OnInitializedAsync();
        }
    }
}
