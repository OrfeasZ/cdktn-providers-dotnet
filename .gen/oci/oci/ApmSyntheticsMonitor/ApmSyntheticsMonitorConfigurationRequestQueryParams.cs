using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmSyntheticsMonitor
{
    [JsiiByValue(fqn: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationRequestQueryParams")]
    public class ApmSyntheticsMonitorConfigurationRequestQueryParams : oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationRequestQueryParams
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#param_name ApmSyntheticsMonitor#param_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "paramName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ParamName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#param_value ApmSyntheticsMonitor#param_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "paramValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ParamValue
        {
            get;
            set;
        }
    }
}
