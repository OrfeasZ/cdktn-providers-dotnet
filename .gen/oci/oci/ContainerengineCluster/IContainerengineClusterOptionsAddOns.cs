using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineCluster
{
    [JsiiInterface(nativeType: typeof(IContainerengineClusterOptionsAddOns), fullyQualifiedName: "oci.containerengineCluster.ContainerengineClusterOptionsAddOns")]
    public interface IContainerengineClusterOptionsAddOns
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#is_kubernetes_dashboard_enabled ContainerengineCluster#is_kubernetes_dashboard_enabled}.</summary>
        [JsiiProperty(name: "isKubernetesDashboardEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsKubernetesDashboardEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#is_tiller_enabled ContainerengineCluster#is_tiller_enabled}.</summary>
        [JsiiProperty(name: "isTillerEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsTillerEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerengineClusterOptionsAddOns), fullyQualifiedName: "oci.containerengineCluster.ContainerengineClusterOptionsAddOns")]
        internal sealed class _Proxy : DeputyBase, oci.ContainerengineCluster.IContainerengineClusterOptionsAddOns
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#is_kubernetes_dashboard_enabled ContainerengineCluster#is_kubernetes_dashboard_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isKubernetesDashboardEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsKubernetesDashboardEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#is_tiller_enabled ContainerengineCluster#is_tiller_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isTillerEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsTillerEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
