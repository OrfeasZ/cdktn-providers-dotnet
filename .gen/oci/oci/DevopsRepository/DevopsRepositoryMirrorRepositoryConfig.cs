using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsRepository
{
    [JsiiByValue(fqn: "oci.devopsRepository.DevopsRepositoryMirrorRepositoryConfig")]
    public class DevopsRepositoryMirrorRepositoryConfig : oci.DevopsRepository.IDevopsRepositoryMirrorRepositoryConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_repository#connector_id DevopsRepository#connector_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConnectorId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_repository#repository_url DevopsRepository#repository_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "repositoryUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RepositoryUrl
        {
            get;
            set;
        }

        /// <summary>trigger_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_repository#trigger_schedule DevopsRepository#trigger_schedule}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "triggerSchedule", typeJson: "{\"fqn\":\"oci.devopsRepository.DevopsRepositoryMirrorRepositoryConfigTriggerSchedule\"}", isOptional: true)]
        public oci.DevopsRepository.IDevopsRepositoryMirrorRepositoryConfigTriggerSchedule? TriggerSchedule
        {
            get;
            set;
        }
    }
}
