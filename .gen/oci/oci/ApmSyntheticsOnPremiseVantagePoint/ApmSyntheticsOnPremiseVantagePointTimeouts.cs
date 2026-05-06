using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmSyntheticsOnPremiseVantagePoint
{
    [JsiiByValue(fqn: "oci.apmSyntheticsOnPremiseVantagePoint.ApmSyntheticsOnPremiseVantagePointTimeouts")]
    public class ApmSyntheticsOnPremiseVantagePointTimeouts : oci.ApmSyntheticsOnPremiseVantagePoint.IApmSyntheticsOnPremiseVantagePointTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_on_premise_vantage_point#create ApmSyntheticsOnPremiseVantagePoint#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_on_premise_vantage_point#delete ApmSyntheticsOnPremiseVantagePoint#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_on_premise_vantage_point#update ApmSyntheticsOnPremiseVantagePoint#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
