using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciWaasWaasPolicies
{
    [JsiiClass(nativeType: typeof(oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigHumanInteractionChallengeOutputReference), fullyQualifiedName: "oci.dataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigHumanInteractionChallengeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciWaasWaasPoliciesWaasPoliciesWafConfigHumanInteractionChallengeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciWaasWaasPoliciesWaasPoliciesWafConfigHumanInteractionChallengeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciWaasWaasPoliciesWaasPoliciesWafConfigHumanInteractionChallengeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciWaasWaasPoliciesWaasPoliciesWafConfigHumanInteractionChallengeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Action
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "actionExpirationInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ActionExpirationInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "challengeSettings", typeJson: "{\"fqn\":\"oci.dataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigHumanInteractionChallengeChallengeSettingsList\"}")]
        public virtual oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigHumanInteractionChallengeChallengeSettingsList ChallengeSettings
        {
            get => GetInstanceProperty<oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigHumanInteractionChallengeChallengeSettingsList>()!;
        }

        [JsiiProperty(name: "failureThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FailureThreshold
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "failureThresholdExpirationInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FailureThresholdExpirationInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "interactionThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InteractionThreshold
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "isEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isNatEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsNatEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "recordingPeriodInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RecordingPeriodInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "setHttpHeader", typeJson: "{\"fqn\":\"oci.dataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigHumanInteractionChallengeSetHttpHeaderList\"}")]
        public virtual oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigHumanInteractionChallengeSetHttpHeaderList SetHttpHeader
        {
            get => GetInstanceProperty<oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigHumanInteractionChallengeSetHttpHeaderList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigHumanInteractionChallenge\"}", isOptional: true)]
        public virtual oci.DataOciWaasWaasPolicies.IDataOciWaasWaasPoliciesWaasPoliciesWafConfigHumanInteractionChallenge? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciWaasWaasPolicies.IDataOciWaasWaasPoliciesWaasPoliciesWafConfigHumanInteractionChallenge?>();
            set => SetInstanceProperty(value);
        }
    }
}
