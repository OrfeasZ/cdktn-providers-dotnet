using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DemandSignalOccDemandSignal
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.demandSignalOccDemandSignal.DemandSignalOccDemandSignalOccDemandSignalsValues")]
    public class DemandSignalOccDemandSignalOccDemandSignalsValues : oci.DemandSignalOccDemandSignal.IDemandSignalOccDemandSignalOccDemandSignalsValues
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/demand_signal_occ_demand_signal#time_expected DemandSignalOccDemandSignal#time_expected}.</summary>
        [JsiiProperty(name: "timeExpected", typeJson: "{\"primitive\":\"string\"}")]
        public string TimeExpected
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/demand_signal_occ_demand_signal#value DemandSignalOccDemandSignal#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
        public double Value
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/demand_signal_occ_demand_signal#comments DemandSignalOccDemandSignal#comments}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "comments", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Comments
        {
            get;
            set;
        }
    }
}
