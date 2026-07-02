using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiProject
{
    [JsiiClass(nativeType: typeof(oci.GenerativeAiProject.GenerativeAiProjectShortTermMemoryOptimizationConfigOutputReference), fullyQualifiedName: "oci.generativeAiProject.GenerativeAiProjectShortTermMemoryOptimizationConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GenerativeAiProjectShortTermMemoryOptimizationConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GenerativeAiProjectShortTermMemoryOptimizationConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GenerativeAiProjectShortTermMemoryOptimizationConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GenerativeAiProjectShortTermMemoryOptimizationConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCondenserConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.generativeAiProject.GenerativeAiProjectShortTermMemoryOptimizationConfigCondenserConfig\"}}]")]
        public virtual void PutCondenserConfig(oci.GenerativeAiProject.IGenerativeAiProjectShortTermMemoryOptimizationConfigCondenserConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GenerativeAiProject.IGenerativeAiProjectShortTermMemoryOptimizationConfigCondenserConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCondenserConfig")]
        public virtual void ResetCondenserConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "condenserConfig", typeJson: "{\"fqn\":\"oci.generativeAiProject.GenerativeAiProjectShortTermMemoryOptimizationConfigCondenserConfigOutputReference\"}")]
        public virtual oci.GenerativeAiProject.GenerativeAiProjectShortTermMemoryOptimizationConfigCondenserConfigOutputReference CondenserConfig
        {
            get => GetInstanceProperty<oci.GenerativeAiProject.GenerativeAiProjectShortTermMemoryOptimizationConfigCondenserConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "condenserConfigInput", typeJson: "{\"fqn\":\"oci.generativeAiProject.GenerativeAiProjectShortTermMemoryOptimizationConfigCondenserConfig\"}", isOptional: true)]
        public virtual oci.GenerativeAiProject.IGenerativeAiProjectShortTermMemoryOptimizationConfigCondenserConfig? CondenserConfigInput
        {
            get => GetInstanceProperty<oci.GenerativeAiProject.IGenerativeAiProjectShortTermMemoryOptimizationConfigCondenserConfig?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsEnabled
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.generativeAiProject.GenerativeAiProjectShortTermMemoryOptimizationConfig\"}", isOptional: true)]
        public virtual oci.GenerativeAiProject.IGenerativeAiProjectShortTermMemoryOptimizationConfig? InternalValue
        {
            get => GetInstanceProperty<oci.GenerativeAiProject.IGenerativeAiProjectShortTermMemoryOptimizationConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
