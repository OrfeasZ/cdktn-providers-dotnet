using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNetappBackupPolicy
{
    [JsiiByValue(fqn: "azurerm.dataAzurermNetappBackupPolicy.DataAzurermNetappBackupPolicyTimeouts")]
    public class DataAzurermNetappBackupPolicyTimeouts : azurerm.DataAzurermNetappBackupPolicy.IDataAzurermNetappBackupPolicyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/data-sources/netapp_backup_policy#read DataAzurermNetappBackupPolicy#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
