using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAccountTokens
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareAccountTokens.DataCloudflareAccountTokensResultOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareAccountTokens.DataCloudflareAccountTokensResultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareAccountTokensResultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareAccountTokensResultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataCloudflareAccountTokensResultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareAccountTokensResultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountTokens.DataCloudflareAccountTokensResultConditionOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountTokens.DataCloudflareAccountTokensResultConditionOutputReference Condition
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountTokens.DataCloudflareAccountTokensResultConditionOutputReference>()!;
        }

        [JsiiProperty(name: "expiresOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExpiresOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "issuedOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IssuedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastUsedOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastUsedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modifiedOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModifiedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "notBefore", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NotBefore
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "policies", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountTokens.DataCloudflareAccountTokensResultPoliciesList\"}")]
        public virtual cloudflare.DataCloudflareAccountTokens.DataCloudflareAccountTokensResultPoliciesList Policies
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountTokens.DataCloudflareAccountTokensResultPoliciesList>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountTokens.DataCloudflareAccountTokensResult\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareAccountTokens.IDataCloudflareAccountTokensResult? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountTokens.IDataCloudflareAccountTokensResult?>();
            set => SetInstanceProperty(value);
        }
    }
}
