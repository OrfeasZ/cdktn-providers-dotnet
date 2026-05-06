using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsDeployStage
{
    [JsiiByValue(fqn: "oci.devopsDeployStage.DevopsDeployStageRolloutPolicy")]
    public class DevopsDeployStageRolloutPolicy : oci.DevopsDeployStage.IDevopsDeployStageRolloutPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#batch_count DevopsDeployStage#batch_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "batchCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BatchCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#batch_delay_in_seconds DevopsDeployStage#batch_delay_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "batchDelayInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BatchDelayInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#batch_percentage DevopsDeployStage#batch_percentage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "batchPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BatchPercentage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#policy_type DevopsDeployStage#policy_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "policyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PolicyType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#ramp_limit_percent DevopsDeployStage#ramp_limit_percent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rampLimitPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RampLimitPercent
        {
            get;
            set;
        }
    }
}
