using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DataAzurestackResources
{
    [JsiiInterface(nativeType: typeof(IDataAzurestackResourcesTimeouts), fullyQualifiedName: "azurestack.dataAzurestackResources.DataAzurestackResourcesTimeouts")]
    public interface IDataAzurestackResourcesTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/resources#read DataAzurestackResources#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurestackResourcesTimeouts), fullyQualifiedName: "azurestack.dataAzurestackResources.DataAzurestackResourcesTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurestack.DataAzurestackResources.IDataAzurestackResourcesTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/resources#read DataAzurestackResources#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
