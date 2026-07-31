using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanMicrodroplets
{
    [JsiiInterface(nativeType: typeof(IDataDigitaloceanMicrodropletsSort), fullyQualifiedName: "digitalocean.dataDigitaloceanMicrodroplets.DataDigitaloceanMicrodropletsSort")]
    public interface IDataDigitaloceanMicrodropletsSort
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/data-sources/microdroplets#key DataDigitaloceanMicrodroplets#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/data-sources/microdroplets#direction DataDigitaloceanMicrodroplets#direction}.</summary>
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Direction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataDigitaloceanMicrodropletsSort), fullyQualifiedName: "digitalocean.dataDigitaloceanMicrodroplets.DataDigitaloceanMicrodropletsSort")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DataDigitaloceanMicrodroplets.IDataDigitaloceanMicrodropletsSort
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/data-sources/microdroplets#key DataDigitaloceanMicrodroplets#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/data-sources/microdroplets#direction DataDigitaloceanMicrodroplets#direction}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
