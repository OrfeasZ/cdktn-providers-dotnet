using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsAuthenticationFactorSetting
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingTotpSettingsOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingTotpSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsAuthenticationFactorSettingTotpSettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsAuthenticationFactorSettingTotpSettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsAuthenticationFactorSettingTotpSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsAuthenticationFactorSettingTotpSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "emailOtpValidityDurationInMins", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EmailOtpValidityDurationInMins
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "emailPasscodeLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EmailPasscodeLength
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "hashingAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HashingAlgorithm
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jwtValidityDurationInSecs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double JwtValidityDurationInSecs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "keyRefreshIntervalInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double KeyRefreshIntervalInDays
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "passcodeLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PasscodeLength
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "smsOtpValidityDurationInMins", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SmsOtpValidityDurationInMins
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "smsPasscodeLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SmsPasscodeLength
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "timeStepInSecs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TimeStepInSecs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "timeStepTolerance", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TimeStepTolerance
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingTotpSettings\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsAuthenticationFactorSetting.IDataOciIdentityDomainsAuthenticationFactorSettingTotpSettings? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAuthenticationFactorSetting.IDataOciIdentityDomainsAuthenticationFactorSettingTotpSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
