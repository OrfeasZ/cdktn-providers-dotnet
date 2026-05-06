using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreCaptureFilter
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesIcmpOptions")]
    public class CoreCaptureFilterFlowLogCaptureFilterRulesIcmpOptions : oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesIcmpOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#type CoreCaptureFilter#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"number\"}")]
        public double Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#code CoreCaptureFilter#code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Code
        {
            get;
            set;
        }
    }
}
