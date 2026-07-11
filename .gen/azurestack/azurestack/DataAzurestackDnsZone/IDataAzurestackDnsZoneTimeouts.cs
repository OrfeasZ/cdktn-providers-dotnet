using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DataAzurestackDnsZone
{
    [JsiiInterface(nativeType: typeof(IDataAzurestackDnsZoneTimeouts), fullyQualifiedName: "azurestack.dataAzurestackDnsZone.DataAzurestackDnsZoneTimeouts")]
    public interface IDataAzurestackDnsZoneTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/dns_zone#read DataAzurestackDnsZone#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurestackDnsZoneTimeouts), fullyQualifiedName: "azurestack.dataAzurestackDnsZone.DataAzurestackDnsZoneTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurestack.DataAzurestackDnsZone.IDataAzurestackDnsZoneTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/dns_zone#read DataAzurestackDnsZone#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
