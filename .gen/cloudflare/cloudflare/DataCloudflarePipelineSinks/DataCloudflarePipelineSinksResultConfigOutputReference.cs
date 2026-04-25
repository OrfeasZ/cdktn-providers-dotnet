using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflarePipelineSinks
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflarePipelineSinks.DataCloudflarePipelineSinksResultConfigOutputReference), fullyQualifiedName: "cloudflare.dataCloudflarePipelineSinks.DataCloudflarePipelineSinksResultConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflarePipelineSinksResultConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflarePipelineSinksResultConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflarePipelineSinksResultConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflarePipelineSinksResultConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bucket
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fileNaming", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePipelineSinks.DataCloudflarePipelineSinksResultConfigFileNamingOutputReference\"}")]
        public virtual cloudflare.DataCloudflarePipelineSinks.DataCloudflarePipelineSinksResultConfigFileNamingOutputReference FileNaming
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePipelineSinks.DataCloudflarePipelineSinksResultConfigFileNamingOutputReference>()!;
        }

        [JsiiProperty(name: "jurisdiction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Jurisdiction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Namespace
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "partitioning", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePipelineSinks.DataCloudflarePipelineSinksResultConfigPartitioningOutputReference\"}")]
        public virtual cloudflare.DataCloudflarePipelineSinks.DataCloudflarePipelineSinksResultConfigPartitioningOutputReference Partitioning
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePipelineSinks.DataCloudflarePipelineSinksResultConfigPartitioningOutputReference>()!;
        }

        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Path
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rollingPolicy", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePipelineSinks.DataCloudflarePipelineSinksResultConfigRollingPolicyOutputReference\"}")]
        public virtual cloudflare.DataCloudflarePipelineSinks.DataCloudflarePipelineSinksResultConfigRollingPolicyOutputReference RollingPolicy
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePipelineSinks.DataCloudflarePipelineSinksResultConfigRollingPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TableName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePipelineSinks.DataCloudflarePipelineSinksResultConfig\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflarePipelineSinks.IDataCloudflarePipelineSinksResultConfig? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePipelineSinks.IDataCloudflarePipelineSinksResultConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
