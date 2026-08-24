using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareOrganizations
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareOrganizations.DataCloudflareOrganizationsResultMetaOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareOrganizations.DataCloudflareOrganizationsResultMetaOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareOrganizationsResultMetaOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareOrganizationsResultMetaOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareOrganizationsResultMetaOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareOrganizationsResultMetaOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "hierarchyTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] HierarchyTags
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "managedBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tenantFlags", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareOrganizations.DataCloudflareOrganizationsResultMetaTenantFlagsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareOrganizations.DataCloudflareOrganizationsResultMetaTenantFlagsOutputReference TenantFlags
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareOrganizations.DataCloudflareOrganizationsResultMetaTenantFlagsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareOrganizations.DataCloudflareOrganizationsResultMeta\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareOrganizations.IDataCloudflareOrganizationsResultMeta? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareOrganizations.IDataCloudflareOrganizationsResultMeta?>();
            set => SetInstanceProperty(value);
        }
    }
}
