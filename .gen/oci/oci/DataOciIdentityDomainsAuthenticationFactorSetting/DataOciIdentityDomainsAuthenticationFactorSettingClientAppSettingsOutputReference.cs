using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsAuthenticationFactorSetting
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingClientAppSettingsOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingClientAppSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsAuthenticationFactorSettingClientAppSettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsAuthenticationFactorSettingClientAppSettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsAuthenticationFactorSettingClientAppSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsAuthenticationFactorSettingClientAppSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "deviceProtectionPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeviceProtectionPolicy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "initialLockoutPeriodInSecs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InitialLockoutPeriodInSecs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "keyPairLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double KeyPairLength
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "lockoutEscalationPattern", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LockoutEscalationPattern
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maxFailuresBeforeLockout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxFailuresBeforeLockout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxFailuresBeforeWarning", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxFailuresBeforeWarning
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxLockoutIntervalInSecs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxLockoutIntervalInSecs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minPinLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinPinLength
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "policyUpdateFreqInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PolicyUpdateFreqInDays
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "requestSigningAlgo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestSigningAlgo
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sharedSecretEncoding", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SharedSecretEncoding
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "unlockAppForEachRequestEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable UnlockAppForEachRequestEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "unlockAppIntervalInSecs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UnlockAppIntervalInSecs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "unlockOnAppForegroundEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable UnlockOnAppForegroundEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "unlockOnAppStartEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable UnlockOnAppStartEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAuthenticationFactorSetting.DataOciIdentityDomainsAuthenticationFactorSettingClientAppSettings\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsAuthenticationFactorSetting.IDataOciIdentityDomainsAuthenticationFactorSettingClientAppSettings? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAuthenticationFactorSetting.IDataOciIdentityDomainsAuthenticationFactorSettingClientAppSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
