using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesFluxConfiguration
{
    [JsiiClass(nativeType: typeof(azurerm.KubernetesFluxConfiguration.KubernetesFluxConfigurationKustomizationsPostBuildOutputReference), fullyQualifiedName: "azurerm.kubernetesFluxConfiguration.KubernetesFluxConfigurationKustomizationsPostBuildOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KubernetesFluxConfigurationKustomizationsPostBuildOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KubernetesFluxConfigurationKustomizationsPostBuildOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected KubernetesFluxConfigurationKustomizationsPostBuildOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubernetesFluxConfigurationKustomizationsPostBuildOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.KubernetesFluxConfiguration.IKubernetesFluxConfigurationKustomizationsPostBuildSubstituteFrom" />)[]</param>
        [JsiiMethod(name: "putSubstituteFrom", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.kubernetesFluxConfiguration.KubernetesFluxConfigurationKustomizationsPostBuildSubstituteFrom\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSubstituteFrom(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.KubernetesFluxConfiguration.IKubernetesFluxConfigurationKustomizationsPostBuildSubstituteFrom[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.KubernetesFluxConfiguration.IKubernetesFluxConfigurationKustomizationsPostBuildSubstituteFrom).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.KubernetesFluxConfiguration.IKubernetesFluxConfigurationKustomizationsPostBuildSubstituteFrom).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetSubstitute")]
        public virtual void ResetSubstitute()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubstituteFrom")]
        public virtual void ResetSubstituteFrom()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "substituteFrom", typeJson: "{\"fqn\":\"azurerm.kubernetesFluxConfiguration.KubernetesFluxConfigurationKustomizationsPostBuildSubstituteFromList\"}")]
        public virtual azurerm.KubernetesFluxConfiguration.KubernetesFluxConfigurationKustomizationsPostBuildSubstituteFromList SubstituteFrom
        {
            get => GetInstanceProperty<azurerm.KubernetesFluxConfiguration.KubernetesFluxConfigurationKustomizationsPostBuildSubstituteFromList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.KubernetesFluxConfiguration.IKubernetesFluxConfigurationKustomizationsPostBuildSubstituteFrom" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "substituteFromInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.kubernetesFluxConfiguration.KubernetesFluxConfigurationKustomizationsPostBuildSubstituteFrom\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SubstituteFromInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "substituteInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? SubstituteInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "substitute", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Substitute
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.kubernetesFluxConfiguration.KubernetesFluxConfigurationKustomizationsPostBuild\"}", isOptional: true)]
        public virtual azurerm.KubernetesFluxConfiguration.IKubernetesFluxConfigurationKustomizationsPostBuild? InternalValue
        {
            get => GetInstanceProperty<azurerm.KubernetesFluxConfiguration.IKubernetesFluxConfigurationKustomizationsPostBuild?>();
            set => SetInstanceProperty(value);
        }
    }
}
