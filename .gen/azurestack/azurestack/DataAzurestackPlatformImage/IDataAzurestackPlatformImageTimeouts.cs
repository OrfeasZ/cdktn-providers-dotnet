using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DataAzurestackPlatformImage
{
    [JsiiInterface(nativeType: typeof(IDataAzurestackPlatformImageTimeouts), fullyQualifiedName: "azurestack.dataAzurestackPlatformImage.DataAzurestackPlatformImageTimeouts")]
    public interface IDataAzurestackPlatformImageTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/platform_image#read DataAzurestackPlatformImage#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurestackPlatformImageTimeouts), fullyQualifiedName: "azurestack.dataAzurestackPlatformImage.DataAzurestackPlatformImageTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurestack.DataAzurestackPlatformImage.IDataAzurestackPlatformImageTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/platform_image#read DataAzurestackPlatformImage#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
