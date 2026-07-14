using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNetappBackupPolicy
{
    [JsiiInterface(nativeType: typeof(IDataAzurermNetappBackupPolicyTimeouts), fullyQualifiedName: "azurerm.dataAzurermNetappBackupPolicy.DataAzurermNetappBackupPolicyTimeouts")]
    public interface IDataAzurermNetappBackupPolicyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/data-sources/netapp_backup_policy#read DataAzurermNetappBackupPolicy#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermNetappBackupPolicyTimeouts), fullyQualifiedName: "azurerm.dataAzurermNetappBackupPolicy.DataAzurermNetappBackupPolicyTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermNetappBackupPolicy.IDataAzurermNetappBackupPolicyTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/data-sources/netapp_backup_policy#read DataAzurermNetappBackupPolicy#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
