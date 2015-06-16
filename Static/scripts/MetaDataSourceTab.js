/**
 * Creates an anguilla command using a wrapper shorthand. The command will communicate with the web service
 * to return a message.
 *
 * Note the ${PluginName} will get replaced by the actual plugin name.
 */

if (Tridion.UI.UserSettings.getJsonUserSettings(true).User.Data.Privileges != "1") {
    $display.getView().properties.controls.TabControl.disableItem('SourceTab');
    $display.getView().properties.controls.TabControl.disableItem('MetaDataSourceTab');
}
Alchemy.command("${PluginName}", "MetaDataSourceTab", {
    /**
     * Whether or not the command is enabled for the user (will usually have extensions displayed but disabled).
     * @returns {boolean}
     */
    isEnabled: function () {
        return true;
    },

    /**
     * Whether or not the command is available to the user.
     * @returns {boolean}
     */
    isAvailable: function () {
        return Tridion.UI.UserSettings.getJsonUserSettings(true).User.Data.Privileges == "1";
    },

    /**
     * Executes your command. You can use _execute or execute as the property name.
     */
    execute: function () {

    }
});