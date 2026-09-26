using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareHyperdriveConfig
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareHyperdriveConfig.DataCloudflareHyperdriveConfigIntegrationOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareHyperdriveConfig.DataCloudflareHyperdriveConfigIntegrationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareHyperdriveConfigIntegrationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareHyperdriveConfigIntegrationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareHyperdriveConfigIntegrationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareHyperdriveConfigIntegrationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "customDatabaseName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomDatabaseName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseBranchName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseBranchName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "integration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Integration
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "organizationName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OrganizationName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheme", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Scheme
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareHyperdriveConfig.DataCloudflareHyperdriveConfigIntegration\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareHyperdriveConfig.IDataCloudflareHyperdriveConfigIntegration? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareHyperdriveConfig.IDataCloudflareHyperdriveConfigIntegration?>();
            set => SetInstanceProperty(value);
        }
    }
}
