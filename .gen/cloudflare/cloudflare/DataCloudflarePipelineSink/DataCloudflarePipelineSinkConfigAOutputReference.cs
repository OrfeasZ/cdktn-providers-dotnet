using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflarePipelineSink
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflarePipelineSink.DataCloudflarePipelineSinkConfigAOutputReference), fullyQualifiedName: "cloudflare.dataCloudflarePipelineSink.DataCloudflarePipelineSinkConfigAOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflarePipelineSinkConfigAOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflarePipelineSinkConfigAOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflarePipelineSinkConfigAOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflarePipelineSinkConfigAOutputReference(DeputyProps props): base(props)
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

        [JsiiProperty(name: "fileNaming", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePipelineSink.DataCloudflarePipelineSinkConfigFileNamingOutputReference\"}")]
        public virtual cloudflare.DataCloudflarePipelineSink.DataCloudflarePipelineSinkConfigFileNamingOutputReference FileNaming
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePipelineSink.DataCloudflarePipelineSinkConfigFileNamingOutputReference>()!;
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

        [JsiiProperty(name: "partitioning", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePipelineSink.DataCloudflarePipelineSinkConfigPartitioningOutputReference\"}")]
        public virtual cloudflare.DataCloudflarePipelineSink.DataCloudflarePipelineSinkConfigPartitioningOutputReference Partitioning
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePipelineSink.DataCloudflarePipelineSinkConfigPartitioningOutputReference>()!;
        }

        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Path
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rollingPolicy", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePipelineSink.DataCloudflarePipelineSinkConfigRollingPolicyOutputReference\"}")]
        public virtual cloudflare.DataCloudflarePipelineSink.DataCloudflarePipelineSinkConfigRollingPolicyOutputReference RollingPolicy
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePipelineSink.DataCloudflarePipelineSinkConfigRollingPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TableName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePipelineSink.DataCloudflarePipelineSinkConfigA\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflarePipelineSink.IDataCloudflarePipelineSinkConfigA? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePipelineSink.IDataCloudflarePipelineSinkConfigA?>();
            set => SetInstanceProperty(value);
        }
    }
}
