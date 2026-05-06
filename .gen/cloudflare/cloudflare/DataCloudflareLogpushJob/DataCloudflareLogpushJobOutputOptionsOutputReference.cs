using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareLogpushJob
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareLogpushJob.DataCloudflareLogpushJobOutputOptionsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareLogpushJob.DataCloudflareLogpushJobOutputOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareLogpushJobOutputOptionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareLogpushJobOutputOptionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareLogpushJobOutputOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareLogpushJobOutputOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "batchPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BatchPrefix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "batchSuffix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BatchSuffix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cve202144228", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Cve202144228
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "fieldDelimiter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FieldDelimiter
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fieldNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] FieldNames
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "outputType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutputType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "recordDelimiter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RecordDelimiter
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "recordPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RecordPrefix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "recordSuffix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RecordSuffix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "recordTemplate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RecordTemplate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sampleRate", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SampleRate
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "timestampFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimestampFormat
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareLogpushJob.DataCloudflareLogpushJobOutputOptions\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareLogpushJob.IDataCloudflareLogpushJobOutputOptions? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareLogpushJob.IDataCloudflareLogpushJobOutputOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
