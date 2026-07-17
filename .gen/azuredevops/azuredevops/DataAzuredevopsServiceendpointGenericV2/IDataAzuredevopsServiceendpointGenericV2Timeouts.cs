using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsServiceendpointGenericV2
{
    [JsiiInterface(nativeType: typeof(IDataAzuredevopsServiceendpointGenericV2Timeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsServiceendpointGenericV2.DataAzuredevopsServiceendpointGenericV2Timeouts")]
    public interface IDataAzuredevopsServiceendpointGenericV2Timeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/serviceendpoint_generic_v2#read DataAzuredevopsServiceendpointGenericV2#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzuredevopsServiceendpointGenericV2Timeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsServiceendpointGenericV2.DataAzuredevopsServiceendpointGenericV2Timeouts")]
        internal sealed class _Proxy : DeputyBase, azuredevops.DataAzuredevopsServiceendpointGenericV2.IDataAzuredevopsServiceendpointGenericV2Timeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/serviceendpoint_generic_v2#read DataAzuredevopsServiceendpointGenericV2#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
