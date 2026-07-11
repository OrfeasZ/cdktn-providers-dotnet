using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DataAzurestackImage
{
    [JsiiInterface(nativeType: typeof(IDataAzurestackImageTimeouts), fullyQualifiedName: "azurestack.dataAzurestackImage.DataAzurestackImageTimeouts")]
    public interface IDataAzurestackImageTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/image#read DataAzurestackImage#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurestackImageTimeouts), fullyQualifiedName: "azurestack.dataAzurestackImage.DataAzurestackImageTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurestack.DataAzurestackImage.IDataAzurestackImageTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/image#read DataAzurestackImage#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
