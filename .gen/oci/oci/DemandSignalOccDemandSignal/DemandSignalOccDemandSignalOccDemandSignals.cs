using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DemandSignalOccDemandSignal
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.demandSignalOccDemandSignal.DemandSignalOccDemandSignalOccDemandSignals")]
    public class DemandSignalOccDemandSignalOccDemandSignals : oci.DemandSignalOccDemandSignal.IDemandSignalOccDemandSignalOccDemandSignals
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/demand_signal_occ_demand_signal#resource_type DemandSignalOccDemandSignal#resource_type}.</summary>
        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/demand_signal_occ_demand_signal#units DemandSignalOccDemandSignal#units}.</summary>
        [JsiiProperty(name: "units", typeJson: "{\"primitive\":\"string\"}")]
        public string Units
        {
            get;
            set;
        }

        private object _values;

        /// <summary>values block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/demand_signal_occ_demand_signal#values DemandSignalOccDemandSignal#values}
        /// </remarks>
        [JsiiProperty(name: "values", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.demandSignalOccDemandSignal.DemandSignalOccDemandSignalOccDemandSignalsValues\"},\"kind\":\"array\"}}]}}")]
        public object Values
        {
            get => _values;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DemandSignalOccDemandSignal.IDemandSignalOccDemandSignalOccDemandSignalsValues[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DemandSignalOccDemandSignal.IDemandSignalOccDemandSignalOccDemandSignalsValues).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DemandSignalOccDemandSignal.IDemandSignalOccDemandSignalOccDemandSignalsValues).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _values = value;
            }
        }
    }
}
