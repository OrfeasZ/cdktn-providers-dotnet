using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsDeployment
{
    [JsiiByValue(fqn: "oci.devopsDeployment.DevopsDeploymentDeployArtifactOverrideArgumentsItems")]
    public class DevopsDeploymentDeployArtifactOverrideArgumentsItems : oci.DevopsDeployment.IDevopsDeploymentDeployArtifactOverrideArgumentsItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#deploy_artifact_id DevopsDeployment#deploy_artifact_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deployArtifactId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeployArtifactId
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
