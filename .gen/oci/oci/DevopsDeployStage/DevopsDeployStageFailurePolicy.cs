using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsDeployStage
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.devopsDeployStage.DevopsDeployStageFailurePolicy")]
    public class DevopsDeployStageFailurePolicy : oci.DevopsDeployStage.IDevopsDeployStageFailurePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#policy_type DevopsDeployStage#policy_type}.</summary>
        [JsiiProperty(name: "policyType", typeJson: "{\"primitive\":\"string\"}")]
        public string PolicyType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#failure_count DevopsDeployStage#failure_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "failureCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FailureCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#failure_percentage DevopsDeployStage#failure_percentage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "failurePercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FailurePercentage
        {
            get;
            set;
        }
    }
}
