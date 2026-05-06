using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsRepository
{
    [JsiiInterface(nativeType: typeof(IDevopsRepositoryMirrorRepositoryConfig), fullyQualifiedName: "oci.devopsRepository.DevopsRepositoryMirrorRepositoryConfig")]
    public interface IDevopsRepositoryMirrorRepositoryConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_repository#connector_id DevopsRepository#connector_id}.</summary>
        [JsiiProperty(name: "connectorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConnectorId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_repository#repository_url DevopsRepository#repository_url}.</summary>
        [JsiiProperty(name: "repositoryUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RepositoryUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>trigger_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_repository#trigger_schedule DevopsRepository#trigger_schedule}
        /// </remarks>
        [JsiiProperty(name: "triggerSchedule", typeJson: "{\"fqn\":\"oci.devopsRepository.DevopsRepositoryMirrorRepositoryConfigTriggerSchedule\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DevopsRepository.IDevopsRepositoryMirrorRepositoryConfigTriggerSchedule? TriggerSchedule
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsRepositoryMirrorRepositoryConfig), fullyQualifiedName: "oci.devopsRepository.DevopsRepositoryMirrorRepositoryConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsRepository.IDevopsRepositoryMirrorRepositoryConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_repository#connector_id DevopsRepository#connector_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "connectorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConnectorId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_repository#repository_url DevopsRepository#repository_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "repositoryUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RepositoryUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>trigger_schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_repository#trigger_schedule DevopsRepository#trigger_schedule}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "triggerSchedule", typeJson: "{\"fqn\":\"oci.devopsRepository.DevopsRepositoryMirrorRepositoryConfigTriggerSchedule\"}", isOptional: true)]
            public oci.DevopsRepository.IDevopsRepositoryMirrorRepositoryConfigTriggerSchedule? TriggerSchedule
            {
                get => GetInstanceProperty<oci.DevopsRepository.IDevopsRepositoryMirrorRepositoryConfigTriggerSchedule?>();
            }
        }
    }
}
