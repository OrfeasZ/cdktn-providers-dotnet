using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNetappVolumeBucket
{
    [JsiiInterface(nativeType: typeof(IDataAzurermNetappVolumeBucketTimeouts), fullyQualifiedName: "azurerm.dataAzurermNetappVolumeBucket.DataAzurermNetappVolumeBucketTimeouts")]
    public interface IDataAzurermNetappVolumeBucketTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/data-sources/netapp_volume_bucket#read DataAzurermNetappVolumeBucket#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermNetappVolumeBucketTimeouts), fullyQualifiedName: "azurerm.dataAzurermNetappVolumeBucket.DataAzurermNetappVolumeBucketTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermNetappVolumeBucket.IDataAzurermNetappVolumeBucketTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/data-sources/netapp_volume_bucket#read DataAzurermNetappVolumeBucket#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
