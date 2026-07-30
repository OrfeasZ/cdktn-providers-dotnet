using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermOracleCloudVmCluster
{
    [JsiiInterface(nativeType: typeof(IDataAzurermOracleCloudVmClusterTimeouts), fullyQualifiedName: "azurerm.dataAzurermOracleCloudVmCluster.DataAzurermOracleCloudVmClusterTimeouts")]
    public interface IDataAzurermOracleCloudVmClusterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/data-sources/oracle_cloud_vm_cluster#read DataAzurermOracleCloudVmCluster#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermOracleCloudVmClusterTimeouts), fullyQualifiedName: "azurerm.dataAzurermOracleCloudVmCluster.DataAzurermOracleCloudVmClusterTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermOracleCloudVmCluster.IDataAzurermOracleCloudVmClusterTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/data-sources/oracle_cloud_vm_cluster#read DataAzurermOracleCloudVmCluster#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
