using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicNetworkMonitoringConfiguration
{
    [JsiiInterface(nativeType: typeof(IMagicNetworkMonitoringConfigurationWarpDevices), fullyQualifiedName: "cloudflare.magicNetworkMonitoringConfiguration.MagicNetworkMonitoringConfigurationWarpDevices")]
    public interface IMagicNetworkMonitoringConfigurationWarpDevices
    {
        /// <summary>Unique identifier for the warp device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_network_monitoring_configuration#id MagicNetworkMonitoringConfiguration#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        string Id
        {
            get;
        }

        /// <summary>Name of the warp device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_network_monitoring_configuration#name MagicNetworkMonitoringConfiguration#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>IPv4 CIDR of the router sourcing flow data associated with this warp device. Only /32 addresses are currently supported.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_network_monitoring_configuration#router_ip MagicNetworkMonitoringConfiguration#router_ip}
        /// </remarks>
        [JsiiProperty(name: "routerIp", typeJson: "{\"primitive\":\"string\"}")]
        string RouterIp
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMagicNetworkMonitoringConfigurationWarpDevices), fullyQualifiedName: "cloudflare.magicNetworkMonitoringConfiguration.MagicNetworkMonitoringConfigurationWarpDevices")]
        internal sealed class _Proxy : DeputyBase, cloudflare.MagicNetworkMonitoringConfiguration.IMagicNetworkMonitoringConfigurationWarpDevices
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Unique identifier for the warp device.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_network_monitoring_configuration#id MagicNetworkMonitoringConfiguration#id}
            ///
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
            public string Id
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Name of the warp device.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_network_monitoring_configuration#name MagicNetworkMonitoringConfiguration#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>IPv4 CIDR of the router sourcing flow data associated with this warp device. Only /32 addresses are currently supported.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_network_monitoring_configuration#router_ip MagicNetworkMonitoringConfiguration#router_ip}
            /// </remarks>
            [JsiiProperty(name: "routerIp", typeJson: "{\"primitive\":\"string\"}")]
            public string RouterIp
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
