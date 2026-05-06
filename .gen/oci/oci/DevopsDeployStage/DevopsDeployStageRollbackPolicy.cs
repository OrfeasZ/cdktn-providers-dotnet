using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsDeployStage
{
    [JsiiByValue(fqn: "oci.devopsDeployStage.DevopsDeployStageRollbackPolicy")]
    public class DevopsDeployStageRollbackPolicy : oci.DevopsDeployStage.IDevopsDeployStageRollbackPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#policy_type DevopsDeployStage#policy_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "policyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PolicyType
        {
            get;
            set;
        }
    }
}
