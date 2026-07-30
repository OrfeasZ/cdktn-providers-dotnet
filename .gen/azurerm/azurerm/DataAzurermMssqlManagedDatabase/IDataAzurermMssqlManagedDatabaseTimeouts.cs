using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermMssqlManagedDatabase
{
    [JsiiInterface(nativeType: typeof(IDataAzurermMssqlManagedDatabaseTimeouts), fullyQualifiedName: "azurerm.dataAzurermMssqlManagedDatabase.DataAzurermMssqlManagedDatabaseTimeouts")]
    public interface IDataAzurermMssqlManagedDatabaseTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/data-sources/mssql_managed_database#read DataAzurermMssqlManagedDatabase#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermMssqlManagedDatabaseTimeouts), fullyQualifiedName: "azurerm.dataAzurermMssqlManagedDatabase.DataAzurermMssqlManagedDatabaseTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermMssqlManagedDatabase.IDataAzurermMssqlManagedDatabaseTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/data-sources/mssql_managed_database#read DataAzurermMssqlManagedDatabase#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
