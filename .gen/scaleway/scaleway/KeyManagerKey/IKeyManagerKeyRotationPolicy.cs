using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.KeyManagerKey
{
    [JsiiInterface(nativeType: typeof(IKeyManagerKeyRotationPolicy), fullyQualifiedName: "scaleway.keyManagerKey.KeyManagerKeyRotationPolicy")]
    public interface IKeyManagerKeyRotationPolicy
    {
        /// <summary>Time interval between two key rotations.</summary>
        /// <remarks>
        /// The minimum duration is 24 hours and the maximum duration is 1 year (876000 hours).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/key_manager_key#rotation_period KeyManagerKey#rotation_period}
        /// </remarks>
        [JsiiProperty(name: "rotationPeriod", typeJson: "{\"primitive\":\"string\"}")]
        string RotationPeriod
        {
            get;
        }

        /// <summary>Timestamp indicating the next scheduled rotation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/key_manager_key#next_rotation_at KeyManagerKey#next_rotation_at}
        /// </remarks>
        [JsiiProperty(name: "nextRotationAt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NextRotationAt
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKeyManagerKeyRotationPolicy), fullyQualifiedName: "scaleway.keyManagerKey.KeyManagerKeyRotationPolicy")]
        internal sealed class _Proxy : DeputyBase, scaleway.KeyManagerKey.IKeyManagerKeyRotationPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Time interval between two key rotations.</summary>
            /// <remarks>
            /// The minimum duration is 24 hours and the maximum duration is 1 year (876000 hours).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/key_manager_key#rotation_period KeyManagerKey#rotation_period}
            /// </remarks>
            [JsiiProperty(name: "rotationPeriod", typeJson: "{\"primitive\":\"string\"}")]
            public string RotationPeriod
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Timestamp indicating the next scheduled rotation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/key_manager_key#next_rotation_at KeyManagerKey#next_rotation_at}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nextRotationAt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NextRotationAt
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
