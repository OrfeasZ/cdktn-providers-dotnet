using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelDeployment
{
    [JsiiInterface(nativeType: typeof(IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleConfiguration), fullyQualifiedName: "oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleConfiguration")]
    public interface IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/datascience_model_deployment#metric_namespace DatascienceModelDeployment#metric_namespace}.</summary>
        [JsiiProperty(name: "metricNamespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MetricNamespace
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/datascience_model_deployment#query DatascienceModelDeployment#query}.</summary>
        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Query
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/datascience_model_deployment#target_scaling_configuration_type DatascienceModelDeployment#target_scaling_configuration_type}.</summary>
        [JsiiProperty(name: "targetScalingConfigurationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetScalingConfigurationType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/datascience_model_deployment#threshold DatascienceModelDeployment#threshold}.</summary>
        [JsiiProperty(name: "threshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Threshold
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleConfiguration), fullyQualifiedName: "oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/datascience_model_deployment#metric_namespace DatascienceModelDeployment#metric_namespace}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metricNamespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MetricNamespace
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/datascience_model_deployment#query DatascienceModelDeployment#query}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Query
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/datascience_model_deployment#target_scaling_configuration_type DatascienceModelDeployment#target_scaling_configuration_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetScalingConfigurationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetScalingConfigurationType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/datascience_model_deployment#threshold DatascienceModelDeployment#threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "threshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Threshold
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
