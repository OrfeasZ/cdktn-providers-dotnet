using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineNodePool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.containerengineNodePool.ContainerengineNodePoolNodeConfigDetails")]
    public class ContainerengineNodePoolNodeConfigDetails : oci.ContainerengineNodePool.IContainerengineNodePoolNodeConfigDetails
    {
        private object _placementConfigs;

        /// <summary>placement_configs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#placement_configs ContainerengineNodePool#placement_configs}
        /// </remarks>
        [JsiiProperty(name: "placementConfigs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.containerengineNodePool.ContainerengineNodePoolNodeConfigDetailsPlacementConfigs\"},\"kind\":\"array\"}}]}}")]
        public object PlacementConfigs
        {
            get => _placementConfigs;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.ContainerengineNodePool.IContainerengineNodePoolNodeConfigDetailsPlacementConfigs[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ContainerengineNodePool.IContainerengineNodePoolNodeConfigDetailsPlacementConfigs).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ContainerengineNodePool.IContainerengineNodePoolNodeConfigDetailsPlacementConfigs).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _placementConfigs = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#size ContainerengineNodePool#size}.</summary>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        public double Size
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#defined_tags ContainerengineNodePool#defined_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#freeform_tags ContainerengineNodePool#freeform_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get;
            set;
        }

        private object? _isPvEncryptionInTransitEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#is_pv_encryption_in_transit_enabled ContainerengineNodePool#is_pv_encryption_in_transit_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isPvEncryptionInTransitEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsPvEncryptionInTransitEnabled
        {
            get => _isPvEncryptionInTransitEnabled;
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
                _isPvEncryptionInTransitEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#kms_key_id ContainerengineNodePool#kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyId
        {
            get;
            set;
        }

        /// <summary>node_pool_pod_network_option_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#node_pool_pod_network_option_details ContainerengineNodePool#node_pool_pod_network_option_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nodePoolPodNetworkOptionDetails", typeJson: "{\"fqn\":\"oci.containerengineNodePool.ContainerengineNodePoolNodeConfigDetailsNodePoolPodNetworkOptionDetails\"}", isOptional: true)]
        public oci.ContainerengineNodePool.IContainerengineNodePoolNodeConfigDetailsNodePoolPodNetworkOptionDetails? NodePoolPodNetworkOptionDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#nsg_ids ContainerengineNodePool#nsg_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NsgIds
        {
            get;
            set;
        }
    }
}
