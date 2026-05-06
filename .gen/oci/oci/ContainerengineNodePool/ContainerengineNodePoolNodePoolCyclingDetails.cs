using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineNodePool
{
    [JsiiByValue(fqn: "oci.containerengineNodePool.ContainerengineNodePoolNodePoolCyclingDetails")]
    public class ContainerengineNodePoolNodePoolCyclingDetails : oci.ContainerengineNodePool.IContainerengineNodePoolNodePoolCyclingDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#cycle_modes ContainerengineNodePool#cycle_modes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cycleModes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? CycleModes
        {
            get;
            set;
        }

        private object? _isNodeCyclingEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#is_node_cycling_enabled ContainerengineNodePool#is_node_cycling_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isNodeCyclingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsNodeCyclingEnabled
        {
            get => _isNodeCyclingEnabled;
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
                _isNodeCyclingEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#maximum_surge ContainerengineNodePool#maximum_surge}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumSurge", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaximumSurge
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#maximum_unavailable ContainerengineNodePool#maximum_unavailable}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumUnavailable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaximumUnavailable
        {
            get;
            set;
        }
    }
}
