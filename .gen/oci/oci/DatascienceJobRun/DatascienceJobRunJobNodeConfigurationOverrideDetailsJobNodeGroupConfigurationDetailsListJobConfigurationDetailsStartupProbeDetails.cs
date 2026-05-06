using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceJobRun
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.datascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobConfigurationDetailsStartupProbeDetails")]
    public class DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobConfigurationDetailsStartupProbeDetails : oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobConfigurationDetailsStartupProbeDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#command DatascienceJobRun#command}.</summary>
        [JsiiProperty(name: "command", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Command
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#job_probe_check_type DatascienceJobRun#job_probe_check_type}.</summary>
        [JsiiProperty(name: "jobProbeCheckType", typeJson: "{\"primitive\":\"string\"}")]
        public string JobProbeCheckType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#failure_threshold DatascienceJobRun#failure_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "failureThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FailureThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#initial_delay_in_seconds DatascienceJobRun#initial_delay_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "initialDelayInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InitialDelayInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#period_in_seconds DatascienceJobRun#period_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "periodInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PeriodInSeconds
        {
            get;
            set;
        }
    }
}
