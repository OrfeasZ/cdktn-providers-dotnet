using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WafWebAppFirewallPolicy
{
    [JsiiClass(nativeType: typeof(oci.WafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitySettingsOutputReference), fullyQualifiedName: "oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitySettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class WafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitySettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public WafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitySettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected WafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitySettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitySettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAllowedHttpMethods")]
        public virtual void ResetAllowedHttpMethods()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxHttpRequestHeaderLength")]
        public virtual void ResetMaxHttpRequestHeaderLength()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxHttpRequestHeaders")]
        public virtual void ResetMaxHttpRequestHeaders()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxNumberOfArguments")]
        public virtual void ResetMaxNumberOfArguments()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxSingleArgumentLength")]
        public virtual void ResetMaxSingleArgumentLength()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxTotalArgumentLength")]
        public virtual void ResetMaxTotalArgumentLength()
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
        [JsiiProperty(name: "maxHttpRequestHeaderLengthInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxHttpRequestHeaderLengthInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxHttpRequestHeadersInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxHttpRequestHeadersInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxNumberOfArgumentsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxNumberOfArgumentsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxSingleArgumentLengthInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxSingleArgumentLengthInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxTotalArgumentLengthInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxTotalArgumentLengthInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "allowedHttpMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedHttpMethods
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxHttpRequestHeaderLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxHttpRequestHeaderLength
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxHttpRequestHeaders", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxHttpRequestHeaders
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxNumberOfArguments", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxNumberOfArguments
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxSingleArgumentLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxSingleArgumentLength
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxTotalArgumentLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxTotalArgumentLength
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitySettings\"}", isOptional: true)]
        public virtual oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitySettings? InternalValue
        {
            get => GetInstanceProperty<oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitySettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
