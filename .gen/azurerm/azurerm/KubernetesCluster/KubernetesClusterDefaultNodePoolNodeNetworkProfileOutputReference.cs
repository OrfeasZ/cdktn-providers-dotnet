using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiClass(nativeType: typeof(azurerm.KubernetesCluster.KubernetesClusterDefaultNodePoolNodeNetworkProfileOutputReference), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolNodeNetworkProfileOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KubernetesClusterDefaultNodePoolNodeNetworkProfileOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KubernetesClusterDefaultNodePoolNodeNetworkProfileOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubernetesClusterDefaultNodePoolNodeNetworkProfileOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubernetesClusterDefaultNodePoolNodeNetworkProfileOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolNodeNetworkProfileAllowedHostPorts" />)[]</param>
        [JsiiMethod(name: "putAllowedHostPorts", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolNodeNetworkProfileAllowedHostPorts\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAllowedHostPorts(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolNodeNetworkProfileAllowedHostPorts[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolNodeNetworkProfileAllowedHostPorts).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolNodeNetworkProfileAllowedHostPorts).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAllowedHostPorts")]
        public virtual void ResetAllowedHostPorts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetApplicationSecurityGroupIds")]
        public virtual void ResetApplicationSecurityGroupIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNodePublicIpTags")]
        public virtual void ResetNodePublicIpTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "allowedHostPorts", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolNodeNetworkProfileAllowedHostPortsList\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterDefaultNodePoolNodeNetworkProfileAllowedHostPortsList AllowedHostPorts
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterDefaultNodePoolNodeNetworkProfileAllowedHostPortsList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolNodeNetworkProfileAllowedHostPorts" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowedHostPortsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolNodeNetworkProfileAllowedHostPorts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AllowedHostPortsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationSecurityGroupIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ApplicationSecurityGroupIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodePublicIpTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? NodePublicIpTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "applicationSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ApplicationSecurityGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nodePublicIpTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> NodePublicIpTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolNodeNetworkProfile\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolNodeNetworkProfile? InternalValue
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolNodeNetworkProfile?>();
            set => SetInstanceProperty(value);
        }
    }
}
