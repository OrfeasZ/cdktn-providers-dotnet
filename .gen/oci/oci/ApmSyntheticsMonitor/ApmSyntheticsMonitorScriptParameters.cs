using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmSyntheticsMonitor
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorScriptParameters")]
    public class ApmSyntheticsMonitorScriptParameters : oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorScriptParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#param_name ApmSyntheticsMonitor#param_name}.</summary>
        [JsiiProperty(name: "paramName", typeJson: "{\"primitive\":\"string\"}")]
        public string ParamName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#param_value ApmSyntheticsMonitor#param_value}.</summary>
        [JsiiProperty(name: "paramValue", typeJson: "{\"primitive\":\"string\"}")]
        public string ParamValue
        {
            get;
            set;
        }
    }
}
