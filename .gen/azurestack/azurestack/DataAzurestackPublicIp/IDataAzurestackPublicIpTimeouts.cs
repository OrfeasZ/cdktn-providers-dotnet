using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DataAzurestackPublicIp
{
    [JsiiInterface(nativeType: typeof(IDataAzurestackPublicIpTimeouts), fullyQualifiedName: "azurestack.dataAzurestackPublicIp.DataAzurestackPublicIpTimeouts")]
    public interface IDataAzurestackPublicIpTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/public_ip#read DataAzurestackPublicIp#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurestackPublicIpTimeouts), fullyQualifiedName: "azurestack.dataAzurestackPublicIp.DataAzurestackPublicIpTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurestack.DataAzurestackPublicIp.IDataAzurestackPublicIpTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/public_ip#read DataAzurestackPublicIp#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
