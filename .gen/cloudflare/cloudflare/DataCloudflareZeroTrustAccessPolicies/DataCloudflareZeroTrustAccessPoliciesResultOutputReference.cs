using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessPolicies
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareZeroTrustAccessPoliciesResultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareZeroTrustAccessPoliciesResultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataCloudflareZeroTrustAccessPoliciesResultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustAccessPoliciesResultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "appCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AppCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "approvalGroups", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultApprovalGroupsList\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultApprovalGroupsList ApprovalGroups
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultApprovalGroupsList>()!;
        }

        [JsiiProperty(name: "approvalRequired", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ApprovalRequired
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "connectionRules", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultConnectionRulesOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultConnectionRulesOutputReference ConnectionRules
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultConnectionRulesOutputReference>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "decision", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Decision
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "exclude", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultExcludeList\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultExcludeList Exclude
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultExcludeList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "include", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultIncludeList\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultIncludeList Include
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultIncludeList>()!;
        }

        [JsiiProperty(name: "isolationRequired", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsolationRequired
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "mfaConfig", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultMfaConfigOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultMfaConfigOutputReference MfaConfig
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultMfaConfigOutputReference>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "purposeJustificationPrompt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PurposeJustificationPrompt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "purposeJustificationRequired", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable PurposeJustificationRequired
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "require", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireList\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireList Require
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireList>()!;
        }

        [JsiiProperty(name: "reusable", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Reusable
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "sessionDuration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SessionDuration
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResult\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicies.IDataCloudflareZeroTrustAccessPoliciesResult? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicies.IDataCloudflareZeroTrustAccessPoliciesResult?>();
            set => SetInstanceProperty(value);
        }
    }
}
