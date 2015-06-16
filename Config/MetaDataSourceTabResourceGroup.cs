using Alchemy4Tridion.Plugins.GUI.Configuration;

namespace ComponentTabs.Config
{
    public class MetaDataSourceTabResourceGroup : ResourceGroup
    {
        public MetaDataSourceTabResourceGroup()
        {

            // When adding files you only need to specify the filename and not full path
            AddFile("MetaDataSourceTab.js");
            //AddFile("GetApiVersionCommand.js");
            //AddFile("HelloWorldCommand.js");

            //AddFile("Hello.css");

            // When referencing commandsets you can just use the generic AddFile with your CommandSet as the type.
            //AddFile<HelloCommandSet>();

            // The above is just a convinient way of doing the following...
            // AddFile(FileTypes.Reference, "Alchemy.Plugins.HelloWorld.Commands.HelloCommandSet");

            // If you want this resource group to contain the js proxies to call your webservice, call AddWebApiProxy()
            //AddWebApiProxy();
        }
    }
}
