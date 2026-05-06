using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstance
{
    [JsiiInterface(nativeType: typeof(IBdsBdsInstanceStartClusterShapeConfigs), fullyQualifiedName: "oci.bdsBdsInstance.BdsBdsInstanceStartClusterShapeConfigs")]
    public interface IBdsBdsInstanceStartClusterShapeConfigs
    {
        /// <summary>node_type_shape_configs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance#node_type_shape_configs BdsBdsInstance#node_type_shape_configs}
        /// </remarks>
        [JsiiProperty(name: "nodeTypeShapeConfigs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceStartClusterShapeConfigsNodeTypeShapeConfigs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NodeTypeShapeConfigs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBdsBdsInstanceStartClusterShapeConfigs), fullyQualifiedName: "oci.bdsBdsInstance.BdsBdsInstanceStartClusterShapeConfigs")]
        internal sealed class _Proxy : DeputyBase, oci.BdsBdsInstance.IBdsBdsInstanceStartClusterShapeConfigs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>node_type_shape_configs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance#node_type_shape_configs BdsBdsInstance#node_type_shape_configs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nodeTypeShapeConfigs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceStartClusterShapeConfigsNodeTypeShapeConfigs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NodeTypeShapeConfigs
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
