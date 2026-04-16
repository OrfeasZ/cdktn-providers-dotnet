using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanSshKeys
{
    [JsiiInterface(nativeType: typeof(IDataDigitaloceanSshKeysSort), fullyQualifiedName: "digitalocean.dataDigitaloceanSshKeys.DataDigitaloceanSshKeysSort")]
    public interface IDataDigitaloceanSshKeysSort
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/ssh_keys#key DataDigitaloceanSshKeys#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/ssh_keys#direction DataDigitaloceanSshKeys#direction}.</summary>
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Direction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataDigitaloceanSshKeysSort), fullyQualifiedName: "digitalocean.dataDigitaloceanSshKeys.DataDigitaloceanSshKeysSort")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DataDigitaloceanSshKeys.IDataDigitaloceanSshKeysSort
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/ssh_keys#key DataDigitaloceanSshKeys#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/ssh_keys#direction DataDigitaloceanSshKeys#direction}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
