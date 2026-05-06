using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.datascienceJob.DatascienceJobJobConfigurationDetailsStartupProbeDetails")]
    public class DatascienceJobJobConfigurationDetailsStartupProbeDetails : oci.DatascienceJob.IDatascienceJobJobConfigurationDetailsStartupProbeDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#command DatascienceJob#command}.</summary>
        [JsiiProperty(name: "command", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Command
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#job_probe_check_type DatascienceJob#job_probe_check_type}.</summary>
        [JsiiProperty(name: "jobProbeCheckType", typeJson: "{\"primitive\":\"string\"}")]
        public string JobProbeCheckType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#failure_threshold DatascienceJob#failure_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "failureThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FailureThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#initial_delay_in_seconds DatascienceJob#initial_delay_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "initialDelayInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InitialDelayInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#period_in_seconds DatascienceJob#period_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "periodInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PeriodInSeconds
        {
            get;
            set;
        }
    }
}
