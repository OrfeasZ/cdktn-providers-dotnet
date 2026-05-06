using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceJob
{
    [JsiiInterface(nativeType: typeof(IDatascienceJobJobConfigurationDetails), fullyQualifiedName: "oci.datascienceJob.DatascienceJobJobConfigurationDetails")]
    public interface IDatascienceJobJobConfigurationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#job_type DatascienceJob#job_type}.</summary>
        [JsiiProperty(name: "jobType", typeJson: "{\"primitive\":\"string\"}")]
        string JobType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#command_line_arguments DatascienceJob#command_line_arguments}.</summary>
        [JsiiProperty(name: "commandLineArguments", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CommandLineArguments
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#environment_variables DatascienceJob#environment_variables}.</summary>
        [JsiiProperty(name: "environmentVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? EnvironmentVariables
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#maximum_runtime_in_minutes DatascienceJob#maximum_runtime_in_minutes}.</summary>
        [JsiiProperty(name: "maximumRuntimeInMinutes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaximumRuntimeInMinutes
        {
            get
            {
                return null;
            }
        }

        /// <summary>startup_probe_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#startup_probe_details DatascienceJob#startup_probe_details}
        /// </remarks>
        [JsiiProperty(name: "startupProbeDetails", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobConfigurationDetailsStartupProbeDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceJob.IDatascienceJobJobConfigurationDetailsStartupProbeDetails? StartupProbeDetails
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceJobJobConfigurationDetails), fullyQualifiedName: "oci.datascienceJob.DatascienceJobJobConfigurationDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceJob.IDatascienceJobJobConfigurationDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#job_type DatascienceJob#job_type}.</summary>
            [JsiiProperty(name: "jobType", typeJson: "{\"primitive\":\"string\"}")]
            public string JobType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#command_line_arguments DatascienceJob#command_line_arguments}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "commandLineArguments", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CommandLineArguments
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#environment_variables DatascienceJob#environment_variables}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "environmentVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? EnvironmentVariables
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#maximum_runtime_in_minutes DatascienceJob#maximum_runtime_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumRuntimeInMinutes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaximumRuntimeInMinutes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>startup_probe_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#startup_probe_details DatascienceJob#startup_probe_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "startupProbeDetails", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobConfigurationDetailsStartupProbeDetails\"}", isOptional: true)]
            public oci.DatascienceJob.IDatascienceJobJobConfigurationDetailsStartupProbeDetails? StartupProbeDetails
            {
                get => GetInstanceProperty<oci.DatascienceJob.IDatascienceJobJobConfigurationDetailsStartupProbeDetails?>();
            }
        }
    }
}
