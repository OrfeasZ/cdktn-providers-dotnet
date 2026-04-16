using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanSpacesBuckets
{
    [JsiiInterface(nativeType: typeof(IDataDigitaloceanSpacesBucketsSort), fullyQualifiedName: "digitalocean.dataDigitaloceanSpacesBuckets.DataDigitaloceanSpacesBucketsSort")]
    public interface IDataDigitaloceanSpacesBucketsSort
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/spaces_buckets#key DataDigitaloceanSpacesBuckets#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/spaces_buckets#direction DataDigitaloceanSpacesBuckets#direction}.</summary>
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Direction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataDigitaloceanSpacesBucketsSort), fullyQualifiedName: "digitalocean.dataDigitaloceanSpacesBuckets.DataDigitaloceanSpacesBucketsSort")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DataDigitaloceanSpacesBuckets.IDataDigitaloceanSpacesBucketsSort
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/spaces_buckets#key DataDigitaloceanSpacesBuckets#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/spaces_buckets#direction DataDigitaloceanSpacesBuckets#direction}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
