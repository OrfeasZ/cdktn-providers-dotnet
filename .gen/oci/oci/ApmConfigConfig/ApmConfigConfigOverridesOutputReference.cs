using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmConfigConfig
{
    [JsiiClass(nativeType: typeof(oci.ApmConfigConfig.ApmConfigConfigOverridesOutputReference), fullyQualifiedName: "oci.apmConfigConfig.ApmConfigConfigOverridesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApmConfigConfigOverridesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApmConfigConfigOverridesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApmConfigConfigOverridesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApmConfigConfigOverridesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putOverrideList", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apmConfigConfig.ApmConfigConfigOverridesOverrideListStruct\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutOverrideList(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.ApmConfigConfig.IApmConfigConfigOverridesOverrideListStruct[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ApmConfigConfig.IApmConfigConfigOverridesOverrideListStruct).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ApmConfigConfig.IApmConfigConfigOverridesOverrideListStruct).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetOverrideList")]
        public virtual void ResetOverrideList()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "overrideList", typeJson: "{\"fqn\":\"oci.apmConfigConfig.ApmConfigConfigOverridesOverrideListStructList\"}")]
        public virtual oci.ApmConfigConfig.ApmConfigConfigOverridesOverrideListStructList OverrideList
        {
            get => GetInstanceProperty<oci.ApmConfigConfig.ApmConfigConfigOverridesOverrideListStructList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "overrideListInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apmConfigConfig.ApmConfigConfigOverridesOverrideListStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? OverrideListInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.apmConfigConfig.ApmConfigConfigOverrides\"}", isOptional: true)]
        public virtual oci.ApmConfigConfig.IApmConfigConfigOverrides? InternalValue
        {
            get => GetInstanceProperty<oci.ApmConfigConfig.IApmConfigConfigOverrides?>();
            set => SetInstanceProperty(value);
        }
    }
}
