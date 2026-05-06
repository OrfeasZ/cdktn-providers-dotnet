using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciWaasWaasPolicies
{
    [JsiiClass(nativeType: typeof(oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigOutputReference), fullyQualifiedName: "oci.dataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciWaasWaasPoliciesWaasPoliciesWafConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciWaasWaasPoliciesWaasPoliciesWafConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciWaasWaasPoliciesWaasPoliciesWafConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciWaasWaasPoliciesWaasPoliciesWafConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accessRules", typeJson: "{\"fqn\":\"oci.dataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigAccessRulesList\"}")]
        public virtual oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigAccessRulesList AccessRules
        {
            get => GetInstanceProperty<oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigAccessRulesList>()!;
        }

        [JsiiProperty(name: "addressRateLimiting", typeJson: "{\"fqn\":\"oci.dataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigAddressRateLimitingList\"}")]
        public virtual oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigAddressRateLimitingList AddressRateLimiting
        {
            get => GetInstanceProperty<oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigAddressRateLimitingList>()!;
        }

        [JsiiProperty(name: "cachingRules", typeJson: "{\"fqn\":\"oci.dataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigCachingRulesList\"}")]
        public virtual oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigCachingRulesList CachingRules
        {
            get => GetInstanceProperty<oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigCachingRulesList>()!;
        }

        [JsiiProperty(name: "captchas", typeJson: "{\"fqn\":\"oci.dataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigCaptchasList\"}")]
        public virtual oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigCaptchasList Captchas
        {
            get => GetInstanceProperty<oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigCaptchasList>()!;
        }

        [JsiiProperty(name: "customProtectionRules", typeJson: "{\"fqn\":\"oci.dataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigCustomProtectionRulesList\"}")]
        public virtual oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigCustomProtectionRulesList CustomProtectionRules
        {
            get => GetInstanceProperty<oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigCustomProtectionRulesList>()!;
        }

        [JsiiProperty(name: "deviceFingerprintChallenge", typeJson: "{\"fqn\":\"oci.dataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigDeviceFingerprintChallengeList\"}")]
        public virtual oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigDeviceFingerprintChallengeList DeviceFingerprintChallenge
        {
            get => GetInstanceProperty<oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigDeviceFingerprintChallengeList>()!;
        }

        [JsiiProperty(name: "humanInteractionChallenge", typeJson: "{\"fqn\":\"oci.dataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigHumanInteractionChallengeList\"}")]
        public virtual oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigHumanInteractionChallengeList HumanInteractionChallenge
        {
            get => GetInstanceProperty<oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigHumanInteractionChallengeList>()!;
        }

        [JsiiProperty(name: "jsChallenge", typeJson: "{\"fqn\":\"oci.dataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigJsChallengeList\"}")]
        public virtual oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigJsChallengeList JsChallenge
        {
            get => GetInstanceProperty<oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigJsChallengeList>()!;
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

        [JsiiProperty(name: "protectionSettings", typeJson: "{\"fqn\":\"oci.dataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigProtectionSettingsList\"}")]
        public virtual oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigProtectionSettingsList ProtectionSettings
        {
            get => GetInstanceProperty<oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigProtectionSettingsList>()!;
        }

        [JsiiProperty(name: "whitelists", typeJson: "{\"fqn\":\"oci.dataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigWhitelistsList\"}")]
        public virtual oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigWhitelistsList Whitelists
        {
            get => GetInstanceProperty<oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigWhitelistsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfig\"}", isOptional: true)]
        public virtual oci.DataOciWaasWaasPolicies.IDataOciWaasWaasPoliciesWaasPoliciesWafConfig? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciWaasWaasPolicies.IDataOciWaasWaasPoliciesWaasPoliciesWafConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
