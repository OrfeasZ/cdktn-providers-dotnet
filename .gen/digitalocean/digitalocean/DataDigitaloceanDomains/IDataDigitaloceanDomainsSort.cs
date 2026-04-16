using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanDomains
{
    [JsiiInterface(nativeType: typeof(IDataDigitaloceanDomainsSort), fullyQualifiedName: "digitalocean.dataDigitaloceanDomains.DataDigitaloceanDomainsSort")]
    public interface IDataDigitaloceanDomainsSort
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/domains#key DataDigitaloceanDomains#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/domains#direction DataDigitaloceanDomains#direction}.</summary>
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Direction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataDigitaloceanDomainsSort), fullyQualifiedName: "digitalocean.dataDigitaloceanDomains.DataDigitaloceanDomainsSort")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DataDigitaloceanDomains.IDataDigitaloceanDomainsSort
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/domains#key DataDigitaloceanDomains#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/domains#direction DataDigitaloceanDomains#direction}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
