using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstance
{
    [JsiiByValue(fqn: "oci.bdsBdsInstance.BdsBdsInstanceStartClusterShapeConfigs")]
    public class BdsBdsInstanceStartClusterShapeConfigs : oci.BdsBdsInstance.IBdsBdsInstanceStartClusterShapeConfigs
    {
        private object? _nodeTypeShapeConfigs;

        /// <summary>node_type_shape_configs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance#node_type_shape_configs BdsBdsInstance#node_type_shape_configs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nodeTypeShapeConfigs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceStartClusterShapeConfigsNodeTypeShapeConfigs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NodeTypeShapeConfigs
        {
            get => _nodeTypeShapeConfigs;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.BdsBdsInstance.IBdsBdsInstanceStartClusterShapeConfigsNodeTypeShapeConfigs[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.BdsBdsInstance.IBdsBdsInstanceStartClusterShapeConfigsNodeTypeShapeConfigs).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _nodeTypeShapeConfigs = value;
            }
        }
    }
}
