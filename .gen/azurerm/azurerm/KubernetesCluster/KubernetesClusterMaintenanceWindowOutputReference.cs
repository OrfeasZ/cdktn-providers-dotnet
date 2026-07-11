using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiClass(nativeType: typeof(azurerm.KubernetesCluster.KubernetesClusterMaintenanceWindowOutputReference), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindowOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KubernetesClusterMaintenanceWindowOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KubernetesClusterMaintenanceWindowOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected KubernetesClusterMaintenanceWindowOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubernetesClusterMaintenanceWindowOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowAllowed" />)[]</param>
        [JsiiMethod(name: "putAllowed", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindowAllowed\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAllowed(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowAllowed[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowAllowed).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowAllowed).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowNotAllowed" />)[]</param>
        [JsiiMethod(name: "putNotAllowed", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindowNotAllowed\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNotAllowed(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowNotAllowed[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowNotAllowed).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowNotAllowed).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAllowed")]
        public virtual void ResetAllowed()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNotAllowed")]
        public virtual void ResetNotAllowed()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "allowed", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindowAllowedList\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterMaintenanceWindowAllowedList Allowed
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterMaintenanceWindowAllowedList>()!;
        }

        [JsiiProperty(name: "notAllowed", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindowNotAllowedList\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterMaintenanceWindowNotAllowedList NotAllowed
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterMaintenanceWindowNotAllowedList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowAllowed" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowedInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindowAllowed\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AllowedInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowNotAllowed" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "notAllowedInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindowNotAllowed\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NotAllowedInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindow\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindow? InternalValue
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindow?>();
            set => SetInstanceProperty(value);
        }
    }
}
