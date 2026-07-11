using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermMssqlFailoverGroup
{
    [JsiiInterface(nativeType: typeof(IDataAzurermMssqlFailoverGroupTimeouts), fullyQualifiedName: "azurerm.dataAzurermMssqlFailoverGroup.DataAzurermMssqlFailoverGroupTimeouts")]
    public interface IDataAzurermMssqlFailoverGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/data-sources/mssql_failover_group#read DataAzurermMssqlFailoverGroup#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermMssqlFailoverGroupTimeouts), fullyQualifiedName: "azurerm.dataAzurermMssqlFailoverGroup.DataAzurermMssqlFailoverGroupTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermMssqlFailoverGroup.IDataAzurermMssqlFailoverGroupTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/data-sources/mssql_failover_group#read DataAzurermMssqlFailoverGroup#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
