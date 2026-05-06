using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciWaasWaasPolicy
{
    [JsiiClass(nativeType: typeof(oci.DataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigAccessRulesOutputReference), fullyQualifiedName: "oci.dataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigAccessRulesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciWaasWaasPolicyWafConfigAccessRulesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciWaasWaasPolicyWafConfigAccessRulesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciWaasWaasPolicyWafConfigAccessRulesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciWaasWaasPolicyWafConfigAccessRulesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Action
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "blockAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BlockAction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "blockErrorPageCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BlockErrorPageCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "blockErrorPageDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BlockErrorPageDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "blockErrorPageMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BlockErrorPageMessage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "blockResponseCode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BlockResponseCode
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "bypassChallenges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] BypassChallenges
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "captchaFooter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CaptchaFooter
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "captchaHeader", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CaptchaHeader
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "captchaSubmitLabel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CaptchaSubmitLabel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "captchaTitle", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CaptchaTitle
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "criteria", typeJson: "{\"fqn\":\"oci.dataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigAccessRulesCriteriaList\"}")]
        public virtual oci.DataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigAccessRulesCriteriaList Criteria
        {
            get => GetInstanceProperty<oci.DataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigAccessRulesCriteriaList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "redirectResponseCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RedirectResponseCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "redirectUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RedirectUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "responseHeaderManipulation", typeJson: "{\"fqn\":\"oci.dataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigAccessRulesResponseHeaderManipulationList\"}")]
        public virtual oci.DataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigAccessRulesResponseHeaderManipulationList ResponseHeaderManipulation
        {
            get => GetInstanceProperty<oci.DataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigAccessRulesResponseHeaderManipulationList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigAccessRules\"}", isOptional: true)]
        public virtual oci.DataOciWaasWaasPolicy.IDataOciWaasWaasPolicyWafConfigAccessRules? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciWaasWaasPolicy.IDataOciWaasWaasPolicyWafConfigAccessRules?>();
            set => SetInstanceProperty(value);
        }
    }
}
