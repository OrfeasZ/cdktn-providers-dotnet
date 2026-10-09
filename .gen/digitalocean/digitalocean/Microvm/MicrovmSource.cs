using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.Microvm
{
    [JsiiByValue(fqn: "digitalocean.microvm.MicrovmSource")]
    public class MicrovmSource : digitalocean.Microvm.IMicrovmSource
    {
        /// <summary>Checkpoint UUID to restore.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/microvm#checkpoint_id Microvm#checkpoint_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "checkpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CheckpointId
        {
            get;
            set;
        }

        /// <summary>OCI reference for the workload container.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/microvm#oci_ref Microvm#oci_ref}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ociRef", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OciRef
        {
            get;
            set;
        }
    }
}
