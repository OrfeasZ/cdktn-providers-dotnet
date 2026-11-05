using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataProtectionBackupInstanceCosmosdbAccount
{
    [JsiiInterface(nativeType: typeof(IDataProtectionBackupInstanceCosmosdbAccountTimeouts), fullyQualifiedName: "azurerm.dataProtectionBackupInstanceCosmosdbAccount.DataProtectionBackupInstanceCosmosdbAccountTimeouts")]
    public interface IDataProtectionBackupInstanceCosmosdbAccountTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.13.0/docs/resources/data_protection_backup_instance_cosmosdb_account#create DataProtectionBackupInstanceCosmosdbAccount#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.13.0/docs/resources/data_protection_backup_instance_cosmosdb_account#delete DataProtectionBackupInstanceCosmosdbAccount#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.13.0/docs/resources/data_protection_backup_instance_cosmosdb_account#read DataProtectionBackupInstanceCosmosdbAccount#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.13.0/docs/resources/data_protection_backup_instance_cosmosdb_account#update DataProtectionBackupInstanceCosmosdbAccount#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataProtectionBackupInstanceCosmosdbAccountTimeouts), fullyQualifiedName: "azurerm.dataProtectionBackupInstanceCosmosdbAccount.DataProtectionBackupInstanceCosmosdbAccountTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataProtectionBackupInstanceCosmosdbAccount.IDataProtectionBackupInstanceCosmosdbAccountTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.13.0/docs/resources/data_protection_backup_instance_cosmosdb_account#create DataProtectionBackupInstanceCosmosdbAccount#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.13.0/docs/resources/data_protection_backup_instance_cosmosdb_account#delete DataProtectionBackupInstanceCosmosdbAccount#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.13.0/docs/resources/data_protection_backup_instance_cosmosdb_account#read DataProtectionBackupInstanceCosmosdbAccount#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.13.0/docs/resources/data_protection_backup_instance_cosmosdb_account#update DataProtectionBackupInstanceCosmosdbAccount#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
