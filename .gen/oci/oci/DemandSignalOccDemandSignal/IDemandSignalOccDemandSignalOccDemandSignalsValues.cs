using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DemandSignalOccDemandSignal
{
    [JsiiInterface(nativeType: typeof(IDemandSignalOccDemandSignalOccDemandSignalsValues), fullyQualifiedName: "oci.demandSignalOccDemandSignal.DemandSignalOccDemandSignalOccDemandSignalsValues")]
    public interface IDemandSignalOccDemandSignalOccDemandSignalsValues
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/demand_signal_occ_demand_signal#time_expected DemandSignalOccDemandSignal#time_expected}.</summary>
        [JsiiProperty(name: "timeExpected", typeJson: "{\"primitive\":\"string\"}")]
        string TimeExpected
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/demand_signal_occ_demand_signal#value DemandSignalOccDemandSignal#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
        double Value
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/demand_signal_occ_demand_signal#comments DemandSignalOccDemandSignal#comments}.</summary>
        [JsiiProperty(name: "comments", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Comments
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDemandSignalOccDemandSignalOccDemandSignalsValues), fullyQualifiedName: "oci.demandSignalOccDemandSignal.DemandSignalOccDemandSignalOccDemandSignalsValues")]
        internal sealed class _Proxy : DeputyBase, oci.DemandSignalOccDemandSignal.IDemandSignalOccDemandSignalOccDemandSignalsValues
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/demand_signal_occ_demand_signal#time_expected DemandSignalOccDemandSignal#time_expected}.</summary>
            [JsiiProperty(name: "timeExpected", typeJson: "{\"primitive\":\"string\"}")]
            public string TimeExpected
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/demand_signal_occ_demand_signal#value DemandSignalOccDemandSignal#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
            public double Value
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/demand_signal_occ_demand_signal#comments DemandSignalOccDemandSignal#comments}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "comments", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Comments
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
