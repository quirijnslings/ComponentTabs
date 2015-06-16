using Alchemy4Tridion.Plugins.GUI.Configuration;

namespace ComponentTabs.Config
{
    public class MetaDataSourceTabResourceGroup : ResourceGroup
    {
        public MetaDataSourceTabResourceGroup()
        {
            Dependencies.AddAlchemyCore();
            AddFile(Alchemy4Tridion.Plugins.GUI.Configuration.Elements.FileTypes.Script, "MetaDataSourceTab.js");

            // If you want this resource group to contain the js proxies to call your webservice, call AddWebApiProxy()
            //AddWebApiProxy();
        }
    }
}
