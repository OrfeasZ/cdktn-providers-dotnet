using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanMicrovmCheckpoints
{
    [JsiiInterface(nativeType: typeof(IDataDigitaloceanMicrovmCheckpointsSort), fullyQualifiedName: "digitalocean.dataDigitaloceanMicrovmCheckpoints.DataDigitaloceanMicrovmCheckpointsSort")]
    public interface IDataDigitaloceanMicrovmCheckpointsSort
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/data-sources/microvm_checkpoints#key DataDigitaloceanMicrovmCheckpoints#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/data-sources/microvm_checkpoints#direction DataDigitaloceanMicrovmCheckpoints#direction}.</summary>
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Direction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataDigitaloceanMicrovmCheckpointsSort), fullyQualifiedName: "digitalocean.dataDigitaloceanMicrovmCheckpoints.DataDigitaloceanMicrovmCheckpointsSort")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DataDigitaloceanMicrovmCheckpoints.IDataDigitaloceanMicrovmCheckpointsSort
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/data-sources/microvm_checkpoints#key DataDigitaloceanMicrovmCheckpoints#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/data-sources/microvm_checkpoints#direction DataDigitaloceanMicrovmCheckpoints#direction}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
