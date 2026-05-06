using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobConfigurationDetails")]
    public class DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobConfigurationDetails : oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobConfigurationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#job_type DatascienceJob#job_type}.</summary>
        [JsiiProperty(name: "jobType", typeJson: "{\"primitive\":\"string\"}")]
        public string JobType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#command_line_arguments DatascienceJob#command_line_arguments}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "commandLineArguments", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CommandLineArguments
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#environment_variables DatascienceJob#environment_variables}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "environmentVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? EnvironmentVariables
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#maximum_runtime_in_minutes DatascienceJob#maximum_runtime_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumRuntimeInMinutes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaximumRuntimeInMinutes
        {
            get;
            set;
        }

        /// <summary>startup_probe_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#startup_probe_details DatascienceJob#startup_probe_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "startupProbeDetails", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobConfigurationDetailsStartupProbeDetails\"}", isOptional: true)]
        public oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobConfigurationDetailsStartupProbeDetails? StartupProbeDetails
        {
            get;
            set;
        }
    }
}
