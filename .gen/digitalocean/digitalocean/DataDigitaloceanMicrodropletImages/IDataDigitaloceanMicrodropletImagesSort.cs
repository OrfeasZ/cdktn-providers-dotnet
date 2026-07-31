using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanMicrodropletImages
{
    [JsiiInterface(nativeType: typeof(IDataDigitaloceanMicrodropletImagesSort), fullyQualifiedName: "digitalocean.dataDigitaloceanMicrodropletImages.DataDigitaloceanMicrodropletImagesSort")]
    public interface IDataDigitaloceanMicrodropletImagesSort
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/data-sources/microdroplet_images#key DataDigitaloceanMicrodropletImages#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/data-sources/microdroplet_images#direction DataDigitaloceanMicrodropletImages#direction}.</summary>
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Direction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataDigitaloceanMicrodropletImagesSort), fullyQualifiedName: "digitalocean.dataDigitaloceanMicrodropletImages.DataDigitaloceanMicrodropletImagesSort")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DataDigitaloceanMicrodropletImages.IDataDigitaloceanMicrodropletImagesSort
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/data-sources/microdroplet_images#key DataDigitaloceanMicrodropletImages#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/data-sources/microdroplet_images#direction DataDigitaloceanMicrodropletImages#direction}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
