using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineCluster
{
    [JsiiInterface(nativeType: typeof(IContainerengineClusterClusterPodNetworkOptions), fullyQualifiedName: "oci.containerengineCluster.ContainerengineClusterClusterPodNetworkOptions")]
    public interface IContainerengineClusterClusterPodNetworkOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#cni_type ContainerengineCluster#cni_type}.</summary>
        [JsiiProperty(name: "cniType", typeJson: "{\"primitive\":\"string\"}")]
        string CniType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerengineClusterClusterPodNetworkOptions), fullyQualifiedName: "oci.containerengineCluster.ContainerengineClusterClusterPodNetworkOptions")]
        internal sealed class _Proxy : DeputyBase, oci.ContainerengineCluster.IContainerengineClusterClusterPodNetworkOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#cni_type ContainerengineCluster#cni_type}.</summary>
            [JsiiProperty(name: "cniType", typeJson: "{\"primitive\":\"string\"}")]
            public string CniType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
