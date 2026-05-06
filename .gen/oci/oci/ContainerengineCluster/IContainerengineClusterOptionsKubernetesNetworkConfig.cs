using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineCluster
{
    [JsiiInterface(nativeType: typeof(IContainerengineClusterOptionsKubernetesNetworkConfig), fullyQualifiedName: "oci.containerengineCluster.ContainerengineClusterOptionsKubernetesNetworkConfig")]
    public interface IContainerengineClusterOptionsKubernetesNetworkConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#pods_cidr ContainerengineCluster#pods_cidr}.</summary>
        [JsiiProperty(name: "podsCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PodsCidr
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#services_cidr ContainerengineCluster#services_cidr}.</summary>
        [JsiiProperty(name: "servicesCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServicesCidr
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerengineClusterOptionsKubernetesNetworkConfig), fullyQualifiedName: "oci.containerengineCluster.ContainerengineClusterOptionsKubernetesNetworkConfig")]
        internal sealed class _Proxy : DeputyBase, oci.ContainerengineCluster.IContainerengineClusterOptionsKubernetesNetworkConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#pods_cidr ContainerengineCluster#pods_cidr}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "podsCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PodsCidr
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#services_cidr ContainerengineCluster#services_cidr}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "servicesCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServicesCidr
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
