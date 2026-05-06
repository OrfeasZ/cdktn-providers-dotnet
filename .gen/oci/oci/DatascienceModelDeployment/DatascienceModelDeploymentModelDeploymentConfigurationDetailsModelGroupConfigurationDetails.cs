using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelDeployment
{
    [JsiiByValue(fqn: "oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelGroupConfigurationDetails")]
    public class DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelGroupConfigurationDetails : oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelGroupConfigurationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#model_group_id DatascienceModelDeployment#model_group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "modelGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ModelGroupId
        {
            get;
            set;
        }
    }
}
