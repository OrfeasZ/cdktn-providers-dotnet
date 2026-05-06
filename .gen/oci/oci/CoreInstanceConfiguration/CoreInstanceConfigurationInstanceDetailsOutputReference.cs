using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstanceConfiguration
{
    [JsiiClass(nativeType: typeof(oci.CoreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsOutputReference), fullyQualifiedName: "oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CoreInstanceConfigurationInstanceDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CoreInstanceConfigurationInstanceDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CoreInstanceConfigurationInstanceDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreInstanceConfigurationInstanceDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBlockVolumes", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsBlockVolumes\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutBlockVolumes(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsBlockVolumes[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsBlockVolumes).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsBlockVolumes).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLaunchDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetails\"}}]")]
        public virtual void PutLaunchDetails(oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsOptions\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutOptions(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsOptions[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsOptions).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsOptions).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSecondaryVnics", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsSecondaryVnics\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSecondaryVnics(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsSecondaryVnics[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsSecondaryVnics).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsSecondaryVnics).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBlockVolumes")]
        public virtual void ResetBlockVolumes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLaunchDetails")]
        public virtual void ResetLaunchDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOptions")]
        public virtual void ResetOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecondaryVnics")]
        public virtual void ResetSecondaryVnics()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "blockVolumes", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsBlockVolumesList\"}")]
        public virtual oci.CoreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsBlockVolumesList BlockVolumes
        {
            get => GetInstanceProperty<oci.CoreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsBlockVolumesList>()!;
        }

        [JsiiProperty(name: "launchDetails", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsOutputReference\"}")]
        public virtual oci.CoreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsOutputReference LaunchDetails
        {
            get => GetInstanceProperty<oci.CoreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "options", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsOptionsList\"}")]
        public virtual oci.CoreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsOptionsList Options
        {
            get => GetInstanceProperty<oci.CoreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsOptionsList>()!;
        }

        [JsiiProperty(name: "secondaryVnics", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsSecondaryVnicsList\"}")]
        public virtual oci.CoreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsSecondaryVnicsList SecondaryVnics
        {
            get => GetInstanceProperty<oci.CoreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsSecondaryVnicsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "blockVolumesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsBlockVolumes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? BlockVolumesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "launchDetailsInput", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetails\"}", isOptional: true)]
        public virtual oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetails? LaunchDetailsInput
        {
            get => GetInstanceProperty<oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "optionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? OptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secondaryVnicsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsSecondaryVnics\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SecondaryVnicsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetails\"}", isOptional: true)]
        public virtual oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetails? InternalValue
        {
            get => GetInstanceProperty<oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
