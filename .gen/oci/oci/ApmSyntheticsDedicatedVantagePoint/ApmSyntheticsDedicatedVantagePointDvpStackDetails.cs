using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmSyntheticsDedicatedVantagePoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.apmSyntheticsDedicatedVantagePoint.ApmSyntheticsDedicatedVantagePointDvpStackDetails")]
    public class ApmSyntheticsDedicatedVantagePointDvpStackDetails : oci.ApmSyntheticsDedicatedVantagePoint.IApmSyntheticsDedicatedVantagePointDvpStackDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_dedicated_vantage_point#dvp_stack_id ApmSyntheticsDedicatedVantagePoint#dvp_stack_id}.</summary>
        [JsiiProperty(name: "dvpStackId", typeJson: "{\"primitive\":\"string\"}")]
        public string DvpStackId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_dedicated_vantage_point#dvp_stack_type ApmSyntheticsDedicatedVantagePoint#dvp_stack_type}.</summary>
        [JsiiProperty(name: "dvpStackType", typeJson: "{\"primitive\":\"string\"}")]
        public string DvpStackType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_dedicated_vantage_point#dvp_stream_id ApmSyntheticsDedicatedVantagePoint#dvp_stream_id}.</summary>
        [JsiiProperty(name: "dvpStreamId", typeJson: "{\"primitive\":\"string\"}")]
        public string DvpStreamId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_dedicated_vantage_point#dvp_version ApmSyntheticsDedicatedVantagePoint#dvp_version}.</summary>
        [JsiiProperty(name: "dvpVersion", typeJson: "{\"primitive\":\"string\"}")]
        public string DvpVersion
        {
            get;
            set;
        }
    }
}
