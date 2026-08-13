using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNetappVolumeBucketWithServer
{
    [JsiiInterface(nativeType: typeof(IDataAzurermNetappVolumeBucketWithServerTimeouts), fullyQualifiedName: "azurerm.dataAzurermNetappVolumeBucketWithServer.DataAzurermNetappVolumeBucketWithServerTimeouts")]
    public interface IDataAzurermNetappVolumeBucketWithServerTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/data-sources/netapp_volume_bucket_with_server#read DataAzurermNetappVolumeBucketWithServer#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermNetappVolumeBucketWithServerTimeouts), fullyQualifiedName: "azurerm.dataAzurermNetappVolumeBucketWithServer.DataAzurermNetappVolumeBucketWithServerTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermNetappVolumeBucketWithServer.IDataAzurermNetappVolumeBucketWithServerTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/data-sources/netapp_volume_bucket_with_server#read DataAzurermNetappVolumeBucketWithServer#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
