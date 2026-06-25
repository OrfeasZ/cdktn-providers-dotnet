using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceComputeTarget
{
    [JsiiInterface(nativeType: typeof(IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRules), fullyQualifiedName: "oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRules")]
    public interface IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/datascience_compute_target#metric_expression_rule_type DatascienceComputeTarget#metric_expression_rule_type}.</summary>
        [JsiiProperty(name: "metricExpressionRuleType", typeJson: "{\"primitive\":\"string\"}")]
        string MetricExpressionRuleType
        {
            get;
        }

        /// <summary>scale_in_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/datascience_compute_target#scale_in_configuration DatascienceComputeTarget#scale_in_configuration}
        /// </remarks>
        [JsiiProperty(name: "scaleInConfiguration", typeJson: "{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleInConfiguration\"}")]
        oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleInConfiguration ScaleInConfiguration
        {
            get;
        }

        /// <summary>scale_out_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/datascience_compute_target#scale_out_configuration DatascienceComputeTarget#scale_out_configuration}
        /// </remarks>
        [JsiiProperty(name: "scaleOutConfiguration", typeJson: "{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleOutConfiguration\"}")]
        oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleOutConfiguration ScaleOutConfiguration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/datascience_compute_target#metric_type DatascienceComputeTarget#metric_type}.</summary>
        [JsiiProperty(name: "metricType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MetricType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRules), fullyQualifiedName: "oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRules")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/datascience_compute_target#metric_expression_rule_type DatascienceComputeTarget#metric_expression_rule_type}.</summary>
            [JsiiProperty(name: "metricExpressionRuleType", typeJson: "{\"primitive\":\"string\"}")]
            public string MetricExpressionRuleType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>scale_in_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/datascience_compute_target#scale_in_configuration DatascienceComputeTarget#scale_in_configuration}
            /// </remarks>
            [JsiiProperty(name: "scaleInConfiguration", typeJson: "{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleInConfiguration\"}")]
            public oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleInConfiguration ScaleInConfiguration
            {
                get => GetInstanceProperty<oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleInConfiguration>()!;
            }

            /// <summary>scale_out_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/datascience_compute_target#scale_out_configuration DatascienceComputeTarget#scale_out_configuration}
            /// </remarks>
            [JsiiProperty(name: "scaleOutConfiguration", typeJson: "{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleOutConfiguration\"}")]
            public oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleOutConfiguration ScaleOutConfiguration
            {
                get => GetInstanceProperty<oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleOutConfiguration>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/datascience_compute_target#metric_type DatascienceComputeTarget#metric_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metricType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MetricType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
