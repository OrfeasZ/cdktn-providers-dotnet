using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsAuthenticationFactorSetting
{
    [JsiiClass(nativeType: typeof(oci.IdentityDomainsAuthenticationFactorSetting.IdentityDomainsAuthenticationFactorSettingTotpSettingsOutputReference), fullyQualifiedName: "oci.identityDomainsAuthenticationFactorSetting.IdentityDomainsAuthenticationFactorSettingTotpSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IdentityDomainsAuthenticationFactorSettingTotpSettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IdentityDomainsAuthenticationFactorSettingTotpSettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected IdentityDomainsAuthenticationFactorSettingTotpSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentityDomainsAuthenticationFactorSettingTotpSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailOtpValidityDurationInMinsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? EmailOtpValidityDurationInMinsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailPasscodeLengthInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? EmailPasscodeLengthInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hashingAlgorithmInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HashingAlgorithmInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jwtValidityDurationInSecsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? JwtValidityDurationInSecsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyRefreshIntervalInDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? KeyRefreshIntervalInDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "passcodeLengthInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PasscodeLengthInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "smsOtpValidityDurationInMinsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SmsOtpValidityDurationInMinsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "smsPasscodeLengthInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SmsPasscodeLengthInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeStepInSecsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TimeStepInSecsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeStepToleranceInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TimeStepToleranceInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "emailOtpValidityDurationInMins", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EmailOtpValidityDurationInMins
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "emailPasscodeLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EmailPasscodeLength
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hashingAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HashingAlgorithm
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "jwtValidityDurationInSecs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double JwtValidityDurationInSecs
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "keyRefreshIntervalInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double KeyRefreshIntervalInDays
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "passcodeLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PasscodeLength
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "smsOtpValidityDurationInMins", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SmsOtpValidityDurationInMins
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "smsPasscodeLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SmsPasscodeLength
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeStepInSecs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TimeStepInSecs
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeStepTolerance", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TimeStepTolerance
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.identityDomainsAuthenticationFactorSetting.IdentityDomainsAuthenticationFactorSettingTotpSettings\"}", isOptional: true)]
        public virtual oci.IdentityDomainsAuthenticationFactorSetting.IIdentityDomainsAuthenticationFactorSettingTotpSettings? InternalValue
        {
            get => GetInstanceProperty<oci.IdentityDomainsAuthenticationFactorSetting.IIdentityDomainsAuthenticationFactorSettingTotpSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
