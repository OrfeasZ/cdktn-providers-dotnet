using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareOrganizations
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareOrganizations.DataCloudflareOrganizationsResultMetaTenantFlagsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareOrganizations.DataCloudflareOrganizationsResultMetaTenantFlagsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareOrganizationsResultMetaTenantFlagsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareOrganizationsResultMetaTenantFlagsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareOrganizationsResultMetaTenantFlagsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareOrganizationsResultMetaTenantFlagsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accountCreation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountCreation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "accountDeletion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountDeletion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "accountMigration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountMigration
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "accountMobility", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountMobility
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enterpriseCapability", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnterpriseCapability
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "memberManagement", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MemberManagement
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subOrgCreation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubOrgCreation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareOrganizations.DataCloudflareOrganizationsResultMetaTenantFlags\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareOrganizations.IDataCloudflareOrganizationsResultMetaTenantFlags? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareOrganizations.IDataCloudflareOrganizationsResultMetaTenantFlags?>();
            set => SetInstanceProperty(value);
        }
    }
}
