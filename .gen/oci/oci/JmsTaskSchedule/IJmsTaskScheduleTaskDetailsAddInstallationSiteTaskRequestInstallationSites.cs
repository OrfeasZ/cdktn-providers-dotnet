using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsTaskSchedule
{
    [JsiiInterface(nativeType: typeof(IJmsTaskScheduleTaskDetailsAddInstallationSiteTaskRequestInstallationSites), fullyQualifiedName: "oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsAddInstallationSiteTaskRequestInstallationSites")]
    public interface IJmsTaskScheduleTaskDetailsAddInstallationSiteTaskRequestInstallationSites
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#artifact_content_type JmsTaskSchedule#artifact_content_type}.</summary>
        [JsiiProperty(name: "artifactContentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ArtifactContentType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#force_install JmsTaskSchedule#force_install}.</summary>
        [JsiiProperty(name: "forceInstall", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ForceInstall
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#headless_mode JmsTaskSchedule#headless_mode}.</summary>
        [JsiiProperty(name: "headlessMode", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HeadlessMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#installation_path JmsTaskSchedule#installation_path}.</summary>
        [JsiiProperty(name: "installationPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstallationPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#managed_instance_id JmsTaskSchedule#managed_instance_id}.</summary>
        [JsiiProperty(name: "managedInstanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ManagedInstanceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#release_version JmsTaskSchedule#release_version}.</summary>
        [JsiiProperty(name: "releaseVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReleaseVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IJmsTaskScheduleTaskDetailsAddInstallationSiteTaskRequestInstallationSites), fullyQualifiedName: "oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsAddInstallationSiteTaskRequestInstallationSites")]
        internal sealed class _Proxy : DeputyBase, oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsAddInstallationSiteTaskRequestInstallationSites
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#artifact_content_type JmsTaskSchedule#artifact_content_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "artifactContentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ArtifactContentType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#force_install JmsTaskSchedule#force_install}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "forceInstall", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ForceInstall
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#headless_mode JmsTaskSchedule#headless_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "headlessMode", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? HeadlessMode
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#installation_path JmsTaskSchedule#installation_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "installationPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstallationPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#managed_instance_id JmsTaskSchedule#managed_instance_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "managedInstanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ManagedInstanceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#release_version JmsTaskSchedule#release_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "releaseVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReleaseVersion
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
