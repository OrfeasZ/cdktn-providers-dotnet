using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreCaptureFilter
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesUdpOptionsDestinationPortRange")]
    public class CoreCaptureFilterVtapCaptureFilterRulesUdpOptionsDestinationPortRange : oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesUdpOptionsDestinationPortRange
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#max CoreCaptureFilter#max}.</summary>
        [JsiiProperty(name: "max", typeJson: "{\"primitive\":\"number\"}")]
        public double Max
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#min CoreCaptureFilter#min}.</summary>
        [JsiiProperty(name: "min", typeJson: "{\"primitive\":\"number\"}")]
        public double Min
        {
            get;
            set;
        }
    }
}
