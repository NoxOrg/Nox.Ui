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
    public class MainDynamicBodyBase : ComponentBase
    {
        private string? _pageId { get; set; }

        [Parameter]
        public string? pageId
        {
            get
            {
                return _pageId;
            }
            set
            {
                _pageId = value;
                GetCurrentPageDefinitions();
            }
        }

        [Parameter]
        public globalDefinition? globalDefinition { get; set; } = null;

        [Parameter]
        public List<pageDefinition>? pageDefinitions { get; set; } = null;

        [Parameter]
        public entityDefinition? entityDefinition { get; set; } = null;

        [Parameter]
        public pageDefinition? currentPageDefinition { get; set; } = null;

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

        private string? _entityConfigurationRead { get; set; } = null;

        private string? entityConfigurationRead
        {
            get
            {
                if (_entityConfigurationRead == null)
                {
                    _entityConfigurationRead = ConfigurationHelper.ReadEntityConfiguration();
                }
                return _entityConfigurationRead;
            }
        }

        protected override async Task OnInitializedAsync()
        {
            globalDefinition = GlobalDefinitionHelper.GetGlobalDefinition(configurationRead);
            pageDefinitions = PageDefinitionHelper.GetPageDefinitions(configurationRead);
            GetCurrentPageDefinitions();
            entityDefinition = EntityDefinitionHelper.GetEntityDefinition(entityConfigurationRead);

            await base.OnInitializedAsync();
        }

        private void GetCurrentPageDefinitions()
        {
            currentPageDefinition = PageDefinitionHelper.GetSpecificPageDefinition(configurationRead, pageId);
        }

    }
}
