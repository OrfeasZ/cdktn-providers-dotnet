using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OcvpSddc
{
    [JsiiInterface(nativeType: typeof(IOcvpSddcInitialConfiguration), fullyQualifiedName: "oci.ocvpSddc.OcvpSddcInitialConfiguration")]
    public interface IOcvpSddcInitialConfiguration
    {
        /// <summary>initial_cluster_configurations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_sddc#initial_cluster_configurations OcvpSddc#initial_cluster_configurations}
        /// </remarks>
        [JsiiProperty(name: "initialClusterConfigurations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.ocvpSddc.OcvpSddcInitialConfigurationInitialClusterConfigurations\"},\"kind\":\"array\"}}]}}")]
        object InitialClusterConfigurations
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOcvpSddcInitialConfiguration), fullyQualifiedName: "oci.ocvpSddc.OcvpSddcInitialConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.OcvpSddc.IOcvpSddcInitialConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>initial_cluster_configurations block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_sddc#initial_cluster_configurations OcvpSddc#initial_cluster_configurations}
            /// </remarks>
            [JsiiProperty(name: "initialClusterConfigurations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.ocvpSddc.OcvpSddcInitialConfigurationInitialClusterConfigurations\"},\"kind\":\"array\"}}]}}")]
            public object InitialClusterConfigurations
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
