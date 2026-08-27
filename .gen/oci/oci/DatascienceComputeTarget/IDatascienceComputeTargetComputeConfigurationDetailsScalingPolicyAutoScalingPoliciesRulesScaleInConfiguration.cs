using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceComputeTarget
{
    [JsiiInterface(nativeType: typeof(IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleInConfiguration), fullyQualifiedName: "oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleInConfiguration")]
    public interface IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleInConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/datascience_compute_target#instance_count_adjustment DatascienceComputeTarget#instance_count_adjustment}.</summary>
        [JsiiProperty(name: "instanceCountAdjustment", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? InstanceCountAdjustment
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/datascience_compute_target#pending_duration DatascienceComputeTarget#pending_duration}.</summary>
        [JsiiProperty(name: "pendingDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PendingDuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/datascience_compute_target#query DatascienceComputeTarget#query}.</summary>
        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Query
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/datascience_compute_target#scaling_configuration_type DatascienceComputeTarget#scaling_configuration_type}.</summary>
        [JsiiProperty(name: "scalingConfigurationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScalingConfigurationType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/datascience_compute_target#threshold DatascienceComputeTarget#threshold}.</summary>
        [JsiiProperty(name: "threshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Threshold
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleInConfiguration), fullyQualifiedName: "oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleInConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleInConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/datascience_compute_target#instance_count_adjustment DatascienceComputeTarget#instance_count_adjustment}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceCountAdjustment", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? InstanceCountAdjustment
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/datascience_compute_target#pending_duration DatascienceComputeTarget#pending_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pendingDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PendingDuration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/datascience_compute_target#query DatascienceComputeTarget#query}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Query
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/datascience_compute_target#scaling_configuration_type DatascienceComputeTarget#scaling_configuration_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scalingConfigurationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScalingConfigurationType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/datascience_compute_target#threshold DatascienceComputeTarget#threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "threshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Threshold
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
