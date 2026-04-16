using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareLogpushJobs
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareLogpushJobs.DataCloudflareLogpushJobsResultOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareLogpushJobs.DataCloudflareLogpushJobsResultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareLogpushJobsResultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareLogpushJobsResultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataCloudflareLogpushJobsResultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareLogpushJobsResultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "dataset", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Dataset
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "destinationConf", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DestinationConf
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Enabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "errorMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ErrorMessage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "frequency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Frequency
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Id
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Kind
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastComplete", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastComplete
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastError", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastError
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logpullOptions", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogpullOptions
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maxUploadBytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxUploadBytes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxUploadIntervalSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxUploadIntervalSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxUploadRecords", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxUploadRecords
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "outputOptions", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareLogpushJobs.DataCloudflareLogpushJobsResultOutputOptionsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareLogpushJobs.DataCloudflareLogpushJobsResultOutputOptionsOutputReference OutputOptions
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareLogpushJobs.DataCloudflareLogpushJobsResultOutputOptionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareLogpushJobs.DataCloudflareLogpushJobsResult\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareLogpushJobs.IDataCloudflareLogpushJobsResult? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareLogpushJobs.IDataCloudflareLogpushJobsResult?>();
            set => SetInstanceProperty(value);
        }
    }
}
