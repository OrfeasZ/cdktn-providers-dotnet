using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WaasWaasPolicy
{
    [JsiiClass(nativeType: typeof(oci.WaasWaasPolicy.WaasWaasPolicyWafConfigDeviceFingerprintChallengeChallengeSettingsOutputReference), fullyQualifiedName: "oci.waasWaasPolicy.WaasWaasPolicyWafConfigDeviceFingerprintChallengeChallengeSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class WaasWaasPolicyWafConfigDeviceFingerprintChallengeChallengeSettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public WaasWaasPolicyWafConfigDeviceFingerprintChallengeChallengeSettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected WaasWaasPolicyWafConfigDeviceFingerprintChallengeChallengeSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WaasWaasPolicyWafConfigDeviceFingerprintChallengeChallengeSettingsOutputReference(DeputyProps props): base(props)
        {
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

        [JsiiMethod(name: "resetCaptchaFooter")]
        public virtual void ResetCaptchaFooter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCaptchaHeader")]
        public virtual void ResetCaptchaHeader()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCaptchaSubmitLabel")]
        public virtual void ResetCaptchaSubmitLabel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCaptchaTitle")]
        public virtual void ResetCaptchaTitle()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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
        [JsiiProperty(name: "captchaFooterInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CaptchaFooterInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "captchaHeaderInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CaptchaHeaderInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "captchaSubmitLabelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CaptchaSubmitLabelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "captchaTitleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CaptchaTitleInput
        {
            get => GetInstanceProperty<string?>();
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

        [JsiiProperty(name: "captchaFooter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CaptchaFooter
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "captchaHeader", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CaptchaHeader
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "captchaSubmitLabel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CaptchaSubmitLabel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "captchaTitle", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CaptchaTitle
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigDeviceFingerprintChallengeChallengeSettings\"}", isOptional: true)]
        public virtual oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigDeviceFingerprintChallengeChallengeSettings? InternalValue
        {
            get => GetInstanceProperty<oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigDeviceFingerprintChallengeChallengeSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
