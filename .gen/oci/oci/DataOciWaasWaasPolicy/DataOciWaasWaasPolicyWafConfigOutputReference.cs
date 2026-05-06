using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciWaasWaasPolicy
{
    [JsiiClass(nativeType: typeof(oci.DataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigOutputReference), fullyQualifiedName: "oci.dataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciWaasWaasPolicyWafConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciWaasWaasPolicyWafConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciWaasWaasPolicyWafConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciWaasWaasPolicyWafConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accessRules", typeJson: "{\"fqn\":\"oci.dataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigAccessRulesList\"}")]
        public virtual oci.DataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigAccessRulesList AccessRules
        {
            get => GetInstanceProperty<oci.DataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigAccessRulesList>()!;
        }

        [JsiiProperty(name: "addressRateLimiting", typeJson: "{\"fqn\":\"oci.dataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigAddressRateLimitingList\"}")]
        public virtual oci.DataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigAddressRateLimitingList AddressRateLimiting
        {
            get => GetInstanceProperty<oci.DataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigAddressRateLimitingList>()!;
        }

        [JsiiProperty(name: "cachingRules", typeJson: "{\"fqn\":\"oci.dataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigCachingRulesList\"}")]
        public virtual oci.DataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigCachingRulesList CachingRules
        {
            get => GetInstanceProperty<oci.DataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigCachingRulesList>()!;
        }

        [JsiiProperty(name: "captchas", typeJson: "{\"fqn\":\"oci.dataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigCaptchasList\"}")]
        public virtual oci.DataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigCaptchasList Captchas
        {
            get => GetInstanceProperty<oci.DataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigCaptchasList>()!;
        }

        [JsiiProperty(name: "customProtectionRules", typeJson: "{\"fqn\":\"oci.dataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigCustomProtectionRulesList\"}")]
        public virtual oci.DataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigCustomProtectionRulesList CustomProtectionRules
        {
            get => GetInstanceProperty<oci.DataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigCustomProtectionRulesList>()!;
        }

        [JsiiProperty(name: "deviceFingerprintChallenge", typeJson: "{\"fqn\":\"oci.dataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigDeviceFingerprintChallengeList\"}")]
        public virtual oci.DataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigDeviceFingerprintChallengeList DeviceFingerprintChallenge
        {
            get => GetInstanceProperty<oci.DataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigDeviceFingerprintChallengeList>()!;
        }

        [JsiiProperty(name: "humanInteractionChallenge", typeJson: "{\"fqn\":\"oci.dataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigHumanInteractionChallengeList\"}")]
        public virtual oci.DataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigHumanInteractionChallengeList HumanInteractionChallenge
        {
            get => GetInstanceProperty<oci.DataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigHumanInteractionChallengeList>()!;
        }

        [JsiiProperty(name: "jsChallenge", typeJson: "{\"fqn\":\"oci.dataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigJsChallengeList\"}")]
        public virtual oci.DataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigJsChallengeList JsChallenge
        {
            get => GetInstanceProperty<oci.DataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigJsChallengeList>()!;
        }

        [JsiiProperty(name: "origin", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Origin
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "originGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] OriginGroups
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "protectionSettings", typeJson: "{\"fqn\":\"oci.dataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigProtectionSettingsList\"}")]
        public virtual oci.DataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigProtectionSettingsList ProtectionSettings
        {
            get => GetInstanceProperty<oci.DataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigProtectionSettingsList>()!;
        }

        [JsiiProperty(name: "whitelists", typeJson: "{\"fqn\":\"oci.dataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigWhitelistsList\"}")]
        public virtual oci.DataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigWhitelistsList Whitelists
        {
            get => GetInstanceProperty<oci.DataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigWhitelistsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfig\"}", isOptional: true)]
        public virtual oci.DataOciWaasWaasPolicy.IDataOciWaasWaasPolicyWafConfig? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciWaasWaasPolicy.IDataOciWaasWaasPolicyWafConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
