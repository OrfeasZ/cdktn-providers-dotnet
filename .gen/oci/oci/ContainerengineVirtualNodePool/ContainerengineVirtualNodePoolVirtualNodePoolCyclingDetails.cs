using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineVirtualNodePool
{
    [JsiiByValue(fqn: "oci.containerengineVirtualNodePool.ContainerengineVirtualNodePoolVirtualNodePoolCyclingDetails")]
    public class ContainerengineVirtualNodePoolVirtualNodePoolCyclingDetails : oci.ContainerengineVirtualNodePool.IContainerengineVirtualNodePoolVirtualNodePoolCyclingDetails
    {
        private object? _isVirtualNodeCyclingEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/containerengine_virtual_node_pool#is_virtual_node_cycling_enabled ContainerengineVirtualNodePool#is_virtual_node_cycling_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isVirtualNodeCyclingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsVirtualNodeCyclingEnabled
        {
            get => _isVirtualNodeCyclingEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isVirtualNodeCyclingEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/containerengine_virtual_node_pool#maximum_surge ContainerengineVirtualNodePool#maximum_surge}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumSurge", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaximumSurge
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/containerengine_virtual_node_pool#maximum_unavailable ContainerengineVirtualNodePool#maximum_unavailable}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumUnavailable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaximumUnavailable
        {
            get;
            set;
        }
    }
}
