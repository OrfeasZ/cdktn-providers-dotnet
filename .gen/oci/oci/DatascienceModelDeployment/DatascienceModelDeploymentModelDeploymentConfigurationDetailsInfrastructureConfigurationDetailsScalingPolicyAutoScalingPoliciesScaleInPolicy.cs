using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelDeployment
{
    [JsiiByValue(fqn: "oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesScaleInPolicy")]
    public class DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesScaleInPolicy : oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesScaleInPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/datascience_model_deployment#cool_down_in_seconds DatascienceModelDeployment#cool_down_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "coolDownInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CoolDownInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/datascience_model_deployment#instance_count_adjustment DatascienceModelDeployment#instance_count_adjustment}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceCountAdjustment", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InstanceCountAdjustment
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/datascience_model_deployment#pending_duration DatascienceModelDeployment#pending_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pendingDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PendingDuration
        {
            get;
            set;
        }
    }
}
