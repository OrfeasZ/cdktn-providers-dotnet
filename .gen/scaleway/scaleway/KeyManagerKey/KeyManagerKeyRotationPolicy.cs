using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.KeyManagerKey
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.keyManagerKey.KeyManagerKeyRotationPolicy")]
    public class KeyManagerKeyRotationPolicy : scaleway.KeyManagerKey.IKeyManagerKeyRotationPolicy
    {
        /// <summary>Time interval between two key rotations.</summary>
        /// <remarks>
        /// The minimum duration is 24 hours and the maximum duration is 1 year (876000 hours).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/key_manager_key#rotation_period KeyManagerKey#rotation_period}
        /// </remarks>
        [JsiiProperty(name: "rotationPeriod", typeJson: "{\"primitive\":\"string\"}")]
        public string RotationPeriod
        {
            get;
            set;
        }

        /// <summary>Timestamp indicating the next scheduled rotation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/key_manager_key#next_rotation_at KeyManagerKey#next_rotation_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nextRotationAt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NextRotationAt
        {
            get;
            set;
        }
    }
}
