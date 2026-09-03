using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightHbaseCluster
{
    [JsiiInterface(nativeType: typeof(IHdinsightHbaseClusterComputeIsolation), fullyQualifiedName: "azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterComputeIsolation")]
    public interface IHdinsightHbaseClusterComputeIsolation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_hbase_cluster#compute_isolation_enabled HdinsightHbaseCluster#compute_isolation_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "computeIsolationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ComputeIsolationEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_hbase_cluster#host_sku HdinsightHbaseCluster#host_sku}.</summary>
        [JsiiProperty(name: "hostSku", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HostSku
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IHdinsightHbaseClusterComputeIsolation), fullyQualifiedName: "azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterComputeIsolation")]
        internal sealed class _Proxy : DeputyBase, azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterComputeIsolation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_hbase_cluster#compute_isolation_enabled HdinsightHbaseCluster#compute_isolation_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "computeIsolationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ComputeIsolationEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_hbase_cluster#host_sku HdinsightHbaseCluster#host_sku}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hostSku", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HostSku
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
