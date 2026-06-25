using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DifStack
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.difStack.DifStackOmk")]
    public class DifStackOmk : oci.DifStack.IDifStackOmk
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/dif_stack#cluster_id DifStack#cluster_id}.</summary>
        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        public string ClusterId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/dif_stack#cluster_namespace_id DifStack#cluster_namespace_id}.</summary>
        [JsiiProperty(name: "clusterNamespaceId", typeJson: "{\"primitive\":\"string\"}")]
        public string ClusterNamespaceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/dif_stack#instance_id DifStack#instance_id}.</summary>
        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}")]
        public string InstanceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/dif_stack#namespace_name DifStack#namespace_name}.</summary>
        [JsiiProperty(name: "namespaceName", typeJson: "{\"primitive\":\"string\"}")]
        public string NamespaceName
        {
            get;
            set;
        }

        private object? _componentValueOverrides;

        /// <summary>component_value_overrides block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/dif_stack#component_value_overrides DifStack#component_value_overrides}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DifStack.IDifStackOmkComponentValueOverrides" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "componentValueOverrides", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.difStack.DifStackOmkComponentValueOverrides\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ComponentValueOverrides
        {
            get => _componentValueOverrides;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DifStack.IDifStackOmkComponentValueOverrides[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DifStack.IDifStackOmkComponentValueOverrides).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _componentValueOverrides = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/dif_stack#manifest_object_storage_path DifStack#manifest_object_storage_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "manifestObjectStoragePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ManifestObjectStoragePath
        {
            get;
            set;
        }

        private object? _secrets;

        /// <summary>secrets block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/dif_stack#secrets DifStack#secrets}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DifStack.IDifStackOmkSecrets" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secrets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.difStack.DifStackOmkSecrets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Secrets
        {
            get => _secrets;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DifStack.IDifStackOmkSecrets[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DifStack.IDifStackOmkSecrets).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _secrets = value;
            }
        }
    }
}
