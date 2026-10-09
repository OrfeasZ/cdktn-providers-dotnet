using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.Microvm
{
    [JsiiInterface(nativeType: typeof(IMicrovmSource), fullyQualifiedName: "digitalocean.microvm.MicrovmSource")]
    public interface IMicrovmSource
    {
        /// <summary>Checkpoint UUID to restore.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/microvm#checkpoint_id Microvm#checkpoint_id}
        /// </remarks>
        [JsiiProperty(name: "checkpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CheckpointId
        {
            get
            {
                return null;
            }
        }

        /// <summary>OCI reference for the workload container.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/microvm#oci_ref Microvm#oci_ref}
        /// </remarks>
        [JsiiProperty(name: "ociRef", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OciRef
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMicrovmSource), fullyQualifiedName: "digitalocean.microvm.MicrovmSource")]
        internal sealed class _Proxy : DeputyBase, digitalocean.Microvm.IMicrovmSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Checkpoint UUID to restore.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/microvm#checkpoint_id Microvm#checkpoint_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "checkpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CheckpointId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>OCI reference for the workload container.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/microvm#oci_ref Microvm#oci_ref}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ociRef", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OciRef
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
