using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineNodePool
{
    [JsiiByValue(fqn: "oci.containerengineNodePool.ContainerengineNodePoolNodeEvictionNodePoolSettings")]
    public class ContainerengineNodePoolNodeEvictionNodePoolSettings : oci.ContainerengineNodePool.IContainerengineNodePoolNodeEvictionNodePoolSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#eviction_grace_duration ContainerengineNodePool#eviction_grace_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "evictionGraceDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EvictionGraceDuration
        {
            get;
            set;
        }

        private object? _isForceActionAfterGraceDuration;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#is_force_action_after_grace_duration ContainerengineNodePool#is_force_action_after_grace_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isForceActionAfterGraceDuration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsForceActionAfterGraceDuration
        {
            get => _isForceActionAfterGraceDuration;
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
                _isForceActionAfterGraceDuration = value;
            }
        }

        private object? _isForceDeleteAfterGraceDuration;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#is_force_delete_after_grace_duration ContainerengineNodePool#is_force_delete_after_grace_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isForceDeleteAfterGraceDuration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsForceDeleteAfterGraceDuration
        {
            get => _isForceDeleteAfterGraceDuration;
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
                _isForceDeleteAfterGraceDuration = value;
            }
        }
    }
}
