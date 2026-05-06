using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringDiscoveryJob
{
    [JsiiInterface(nativeType: typeof(IStackMonitoringDiscoveryJobDiscoveryDetails), fullyQualifiedName: "oci.stackMonitoringDiscoveryJob.StackMonitoringDiscoveryJobDiscoveryDetails")]
    public interface IStackMonitoringDiscoveryJobDiscoveryDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_discovery_job#agent_id StackMonitoringDiscoveryJob#agent_id}.</summary>
        [JsiiProperty(name: "agentId", typeJson: "{\"primitive\":\"string\"}")]
        string AgentId
        {
            get;
        }

        /// <summary>properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_discovery_job#properties StackMonitoringDiscoveryJob#properties}
        /// </remarks>
        [JsiiProperty(name: "properties", typeJson: "{\"fqn\":\"oci.stackMonitoringDiscoveryJob.StackMonitoringDiscoveryJobDiscoveryDetailsProperties\"}")]
        oci.StackMonitoringDiscoveryJob.IStackMonitoringDiscoveryJobDiscoveryDetailsProperties Properties
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_discovery_job#resource_name StackMonitoringDiscoveryJob#resource_name}.</summary>
        [JsiiProperty(name: "resourceName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_discovery_job#resource_type StackMonitoringDiscoveryJob#resource_type}.</summary>
        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceType
        {
            get;
        }

        /// <summary>credentials block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_discovery_job#credentials StackMonitoringDiscoveryJob#credentials}
        /// </remarks>
        [JsiiProperty(name: "credentials", typeJson: "{\"fqn\":\"oci.stackMonitoringDiscoveryJob.StackMonitoringDiscoveryJobDiscoveryDetailsCredentials\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.StackMonitoringDiscoveryJob.IStackMonitoringDiscoveryJobDiscoveryDetailsCredentials? Credentials
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_discovery_job#license StackMonitoringDiscoveryJob#license}.</summary>
        [JsiiProperty(name: "license", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? License
        {
            get
            {
                return null;
            }
        }

        /// <summary>tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_discovery_job#tags StackMonitoringDiscoveryJob#tags}
        /// </remarks>
        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.stackMonitoringDiscoveryJob.StackMonitoringDiscoveryJobDiscoveryDetailsTags\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.StackMonitoringDiscoveryJob.IStackMonitoringDiscoveryJobDiscoveryDetailsTags? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStackMonitoringDiscoveryJobDiscoveryDetails), fullyQualifiedName: "oci.stackMonitoringDiscoveryJob.StackMonitoringDiscoveryJobDiscoveryDetails")]
        internal sealed class _Proxy : DeputyBase, oci.StackMonitoringDiscoveryJob.IStackMonitoringDiscoveryJobDiscoveryDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_discovery_job#agent_id StackMonitoringDiscoveryJob#agent_id}.</summary>
            [JsiiProperty(name: "agentId", typeJson: "{\"primitive\":\"string\"}")]
            public string AgentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>properties block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_discovery_job#properties StackMonitoringDiscoveryJob#properties}
            /// </remarks>
            [JsiiProperty(name: "properties", typeJson: "{\"fqn\":\"oci.stackMonitoringDiscoveryJob.StackMonitoringDiscoveryJobDiscoveryDetailsProperties\"}")]
            public oci.StackMonitoringDiscoveryJob.IStackMonitoringDiscoveryJobDiscoveryDetailsProperties Properties
            {
                get => GetInstanceProperty<oci.StackMonitoringDiscoveryJob.IStackMonitoringDiscoveryJobDiscoveryDetailsProperties>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_discovery_job#resource_name StackMonitoringDiscoveryJob#resource_name}.</summary>
            [JsiiProperty(name: "resourceName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_discovery_job#resource_type StackMonitoringDiscoveryJob#resource_type}.</summary>
            [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>credentials block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_discovery_job#credentials StackMonitoringDiscoveryJob#credentials}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "credentials", typeJson: "{\"fqn\":\"oci.stackMonitoringDiscoveryJob.StackMonitoringDiscoveryJobDiscoveryDetailsCredentials\"}", isOptional: true)]
            public oci.StackMonitoringDiscoveryJob.IStackMonitoringDiscoveryJobDiscoveryDetailsCredentials? Credentials
            {
                get => GetInstanceProperty<oci.StackMonitoringDiscoveryJob.IStackMonitoringDiscoveryJobDiscoveryDetailsCredentials?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_discovery_job#license StackMonitoringDiscoveryJob#license}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "license", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? License
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_discovery_job#tags StackMonitoringDiscoveryJob#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.stackMonitoringDiscoveryJob.StackMonitoringDiscoveryJobDiscoveryDetailsTags\"}", isOptional: true)]
            public oci.StackMonitoringDiscoveryJob.IStackMonitoringDiscoveryJobDiscoveryDetailsTags? Tags
            {
                get => GetInstanceProperty<oci.StackMonitoringDiscoveryJob.IStackMonitoringDiscoveryJobDiscoveryDetailsTags?>();
            }
        }
    }
}
