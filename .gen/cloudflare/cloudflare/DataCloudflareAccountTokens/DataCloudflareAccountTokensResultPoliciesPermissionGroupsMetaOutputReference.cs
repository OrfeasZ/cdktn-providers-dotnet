using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAccountTokens
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareAccountTokens.DataCloudflareAccountTokensResultPoliciesPermissionGroupsMetaOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareAccountTokens.DataCloudflareAccountTokensResultPoliciesPermissionGroupsMetaOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareAccountTokensResultPoliciesPermissionGroupsMetaOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareAccountTokensResultPoliciesPermissionGroupsMetaOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareAccountTokensResultPoliciesPermissionGroupsMetaOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareAccountTokensResultPoliciesPermissionGroupsMetaOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Category
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deprecated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Deprecated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "editable", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Editable
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "eolAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EolAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Label
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scopes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Scopes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "visibility", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Visibility
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountTokens.DataCloudflareAccountTokensResultPoliciesPermissionGroupsMeta\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareAccountTokens.IDataCloudflareAccountTokensResultPoliciesPermissionGroupsMeta? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountTokens.IDataCloudflareAccountTokensResultPoliciesPermissionGroupsMeta?>();
            set => SetInstanceProperty(value);
        }
    }
}
