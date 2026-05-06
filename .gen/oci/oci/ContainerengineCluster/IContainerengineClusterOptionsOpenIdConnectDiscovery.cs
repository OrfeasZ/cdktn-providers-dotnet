using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineCluster
{
    [JsiiInterface(nativeType: typeof(IContainerengineClusterOptionsOpenIdConnectDiscovery), fullyQualifiedName: "oci.containerengineCluster.ContainerengineClusterOptionsOpenIdConnectDiscovery")]
    public interface IContainerengineClusterOptionsOpenIdConnectDiscovery
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#is_open_id_connect_discovery_enabled ContainerengineCluster#is_open_id_connect_discovery_enabled}.</summary>
        [JsiiProperty(name: "isOpenIdConnectDiscoveryEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsOpenIdConnectDiscoveryEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerengineClusterOptionsOpenIdConnectDiscovery), fullyQualifiedName: "oci.containerengineCluster.ContainerengineClusterOptionsOpenIdConnectDiscovery")]
        internal sealed class _Proxy : DeputyBase, oci.ContainerengineCluster.IContainerengineClusterOptionsOpenIdConnectDiscovery
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#is_open_id_connect_discovery_enabled ContainerengineCluster#is_open_id_connect_discovery_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isOpenIdConnectDiscoveryEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsOpenIdConnectDiscoveryEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
