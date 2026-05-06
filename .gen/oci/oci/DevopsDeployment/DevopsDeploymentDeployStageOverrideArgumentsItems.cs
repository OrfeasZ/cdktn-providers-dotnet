using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsDeployment
{
    [JsiiByValue(fqn: "oci.devopsDeployment.DevopsDeploymentDeployStageOverrideArgumentsItems")]
    public class DevopsDeploymentDeployStageOverrideArgumentsItems : oci.DevopsDeployment.IDevopsDeploymentDeployStageOverrideArgumentsItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#deploy_stage_id DevopsDeployment#deploy_stage_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deployStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeployStageId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#name DevopsDeployment#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#value DevopsDeployment#value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
