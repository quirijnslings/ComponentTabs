using Alchemy4Tridion.Plugins.GUI.Configuration;

namespace ComponentTabs.Config
{
    public class MetaDataSourceTab : TabPageExtension
    {
        public MetaDataSourceTab()
        {
            AssignId = "MetaDataSourceTab";
            Control = "MetaDataSourceTab.ascx";
            Name = "Metadata Source";
            PageType = "MetaDataSourceTab";
            Dependencies.Add<MetaDataSourceTabResourceGroup>();

            InsertBefore = "BundleTab";
            
            
            
            Apply.ToView("ComponentView", "MasterTabControl");
        }
    }
}

