using EzSale.Infrastructure;
using Microsoft.Practices.Unity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeModule.Views;

namespace EmployeeModule
{
    public class EmployeesMod : ModuleBase
    {
        public EmployeesMod(IUnityContainer container, IRegionManager regionManager) : base(container, regionManager)
        {

        }

        protected override void InitializeModule()
        {

            IRegion region = RegionManager.Regions[RegionNames.ToolbarRegion];

            region.Add(Container.Resolve<EmployeesComboBox>());
        }

        protected override void RegisterTypes()
        {
          
        }
    }
}
