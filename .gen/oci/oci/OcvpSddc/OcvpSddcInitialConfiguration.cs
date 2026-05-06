using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OcvpSddc
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.ocvpSddc.OcvpSddcInitialConfiguration")]
    public class OcvpSddcInitialConfiguration : oci.OcvpSddc.IOcvpSddcInitialConfiguration
    {
        private object _initialClusterConfigurations;

        /// <summary>initial_cluster_configurations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_sddc#initial_cluster_configurations OcvpSddc#initial_cluster_configurations}
        /// </remarks>
        [JsiiProperty(name: "initialClusterConfigurations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.ocvpSddc.OcvpSddcInitialConfigurationInitialClusterConfigurations\"},\"kind\":\"array\"}}]}}")]
        public object InitialClusterConfigurations
        {
            get => _initialClusterConfigurations;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.OcvpSddc.IOcvpSddcInitialConfigurationInitialClusterConfigurations[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OcvpSddc.IOcvpSddcInitialConfigurationInitialClusterConfigurations).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OcvpSddc.IOcvpSddcInitialConfigurationInitialClusterConfigurations).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _initialClusterConfigurations = value;
            }
        }
    }
}
