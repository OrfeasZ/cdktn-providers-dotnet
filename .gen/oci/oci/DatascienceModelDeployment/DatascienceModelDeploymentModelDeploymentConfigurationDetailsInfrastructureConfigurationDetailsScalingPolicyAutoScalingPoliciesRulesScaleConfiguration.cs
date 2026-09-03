using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelDeployment
{
    [JsiiByValue(fqn: "oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleConfiguration")]
    public class DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleConfiguration : oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/datascience_model_deployment#metric_namespace DatascienceModelDeployment#metric_namespace}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metricNamespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MetricNamespace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/datascience_model_deployment#query DatascienceModelDeployment#query}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Query
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/datascience_model_deployment#target_scaling_configuration_type DatascienceModelDeployment#target_scaling_configuration_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetScalingConfigurationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetScalingConfigurationType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/datascience_model_deployment#threshold DatascienceModelDeployment#threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "threshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Threshold
        {
            get;
            set;
        }
    }
}
