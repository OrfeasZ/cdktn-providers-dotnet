using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceComputeTarget
{
    [JsiiInterface(nativeType: typeof(IDatascienceComputeTargetComputeConfigurationDetails), fullyQualifiedName: "oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetails")]
    public interface IDatascienceComputeTargetComputeConfigurationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datascience_compute_target#compute_type DatascienceComputeTarget#compute_type}.</summary>
        [JsiiProperty(name: "computeType", typeJson: "{\"primitive\":\"string\"}")]
        string ComputeType
        {
            get;
        }

        /// <summary>instance_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datascience_compute_target#instance_configuration DatascienceComputeTarget#instance_configuration}
        /// </remarks>
        [JsiiProperty(name: "instanceConfiguration", typeJson: "{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsInstanceConfiguration\"}")]
        oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsInstanceConfiguration InstanceConfiguration
        {
            get;
        }

        /// <summary>scaling_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datascience_compute_target#scaling_policy DatascienceComputeTarget#scaling_policy}
        /// </remarks>
        [JsiiProperty(name: "scalingPolicy", typeJson: "{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicy? ScalingPolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceComputeTargetComputeConfigurationDetails), fullyQualifiedName: "oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datascience_compute_target#compute_type DatascienceComputeTarget#compute_type}.</summary>
            [JsiiProperty(name: "computeType", typeJson: "{\"primitive\":\"string\"}")]
            public string ComputeType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>instance_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datascience_compute_target#instance_configuration DatascienceComputeTarget#instance_configuration}
            /// </remarks>
            [JsiiProperty(name: "instanceConfiguration", typeJson: "{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsInstanceConfiguration\"}")]
            public oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsInstanceConfiguration InstanceConfiguration
            {
                get => GetInstanceProperty<oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsInstanceConfiguration>()!;
            }

            /// <summary>scaling_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datascience_compute_target#scaling_policy DatascienceComputeTarget#scaling_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scalingPolicy", typeJson: "{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicy\"}", isOptional: true)]
            public oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicy? ScalingPolicy
            {
                get => GetInstanceProperty<oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicy?>();
            }
        }
    }
}
