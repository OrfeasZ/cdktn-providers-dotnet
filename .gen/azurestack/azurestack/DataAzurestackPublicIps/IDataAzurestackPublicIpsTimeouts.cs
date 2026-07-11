using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DataAzurestackPublicIps
{
    [JsiiInterface(nativeType: typeof(IDataAzurestackPublicIpsTimeouts), fullyQualifiedName: "azurestack.dataAzurestackPublicIps.DataAzurestackPublicIpsTimeouts")]
    public interface IDataAzurestackPublicIpsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/public_ips#read DataAzurestackPublicIps#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurestackPublicIpsTimeouts), fullyQualifiedName: "azurestack.dataAzurestackPublicIps.DataAzurestackPublicIpsTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurestack.DataAzurestackPublicIps.IDataAzurestackPublicIpsTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/public_ips#read DataAzurestackPublicIps#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
