using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsDeployStage
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.devopsDeployStage.DevopsDeployStageWaitCriteria")]
    public class DevopsDeployStageWaitCriteria : oci.DevopsDeployStage.IDevopsDeployStageWaitCriteria
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#wait_duration DevopsDeployStage#wait_duration}.</summary>
        [JsiiProperty(name: "waitDuration", typeJson: "{\"primitive\":\"string\"}")]
        public string WaitDuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#wait_type DevopsDeployStage#wait_type}.</summary>
        [JsiiProperty(name: "waitType", typeJson: "{\"primitive\":\"string\"}")]
        public string WaitType
        {
            get;
            set;
        }
    }
}
