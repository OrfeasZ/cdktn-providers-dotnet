using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelDeployment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyAutoScalingPoliciesRules")]
    public class DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyAutoScalingPoliciesRules : oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyAutoScalingPoliciesRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#metric_expression_rule_type DatascienceModelDeployment#metric_expression_rule_type}.</summary>
        [JsiiProperty(name: "metricExpressionRuleType", typeJson: "{\"primitive\":\"string\"}")]
        public string MetricExpressionRuleType
        {
            get;
            set;
        }

        /// <summary>scale_in_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#scale_in_configuration DatascienceModelDeployment#scale_in_configuration}
        /// </remarks>
        [JsiiProperty(name: "scaleInConfiguration", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleInConfiguration\"}")]
        public oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleInConfiguration ScaleInConfiguration
        {
            get;
            set;
        }

        /// <summary>scale_out_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#scale_out_configuration DatascienceModelDeployment#scale_out_configuration}
        /// </remarks>
        [JsiiProperty(name: "scaleOutConfiguration", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleOutConfiguration\"}")]
        public oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleOutConfiguration ScaleOutConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#metric_type DatascienceModelDeployment#metric_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metricType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MetricType
        {
            get;
            set;
        }
    }
}
