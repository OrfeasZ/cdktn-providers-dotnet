using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WaasWaasPolicy
{
    [JsiiClass(nativeType: typeof(oci.WaasWaasPolicy.WaasWaasPolicyWafConfigProtectionSettingsOutputReference), fullyQualifiedName: "oci.waasWaasPolicy.WaasWaasPolicyWafConfigProtectionSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class WaasWaasPolicyWafConfigProtectionSettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public WaasWaasPolicyWafConfigProtectionSettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected WaasWaasPolicyWafConfigProtectionSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WaasWaasPolicyWafConfigProtectionSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAllowedHttpMethods")]
        public virtual void ResetAllowedHttpMethods()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBlockAction")]
        public virtual void ResetBlockAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBlockErrorPageCode")]
        public virtual void ResetBlockErrorPageCode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBlockErrorPageDescription")]
        public virtual void ResetBlockErrorPageDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBlockErrorPageMessage")]
        public virtual void ResetBlockErrorPageMessage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBlockResponseCode")]
        public virtual void ResetBlockResponseCode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsResponseInspected")]
        public virtual void ResetIsResponseInspected()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxArgumentCount")]
        public virtual void ResetMaxArgumentCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxNameLengthPerArgument")]
        public virtual void ResetMaxNameLengthPerArgument()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxResponseSizeInKiB")]
        public virtual void ResetMaxResponseSizeInKiB()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxTotalNameLengthOfArguments")]
        public virtual void ResetMaxTotalNameLengthOfArguments()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMediaTypes")]
        public virtual void ResetMediaTypes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRecommendationsPeriodInDays")]
        public virtual void ResetRecommendationsPeriodInDays()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowedHttpMethodsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AllowedHttpMethodsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "blockActionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BlockActionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "blockErrorPageCodeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BlockErrorPageCodeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "blockErrorPageDescriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BlockErrorPageDescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "blockErrorPageMessageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BlockErrorPageMessageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "blockResponseCodeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BlockResponseCodeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isResponseInspectedInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsResponseInspectedInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxArgumentCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxArgumentCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxNameLengthPerArgumentInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxNameLengthPerArgumentInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxResponseSizeInKiBInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxResponseSizeInKiBInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxTotalNameLengthOfArgumentsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxTotalNameLengthOfArgumentsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mediaTypesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? MediaTypesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recommendationsPeriodInDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RecommendationsPeriodInDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "allowedHttpMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedHttpMethods
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "blockAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BlockAction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "blockErrorPageCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BlockErrorPageCode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "blockErrorPageDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BlockErrorPageDescription
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "blockErrorPageMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BlockErrorPageMessage
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "blockResponseCode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BlockResponseCode
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isResponseInspected", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsResponseInspected
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

        [JsiiProperty(name: "maxArgumentCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxArgumentCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxNameLengthPerArgument", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxNameLengthPerArgument
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxResponseSizeInKiB", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxResponseSizeInKiB
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxTotalNameLengthOfArguments", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxTotalNameLengthOfArguments
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mediaTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] MediaTypes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "recommendationsPeriodInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RecommendationsPeriodInDays
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigProtectionSettings\"}", isOptional: true)]
        public virtual oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigProtectionSettings? InternalValue
        {
            get => GetInstanceProperty<oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigProtectionSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
