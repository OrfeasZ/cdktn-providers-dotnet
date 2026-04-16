using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareHealthchecks
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareHealthchecks.DataCloudflareHealthchecksResultOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareHealthchecks.DataCloudflareHealthchecksResultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareHealthchecksResultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareHealthchecksResultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataCloudflareHealthchecksResultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareHealthchecksResultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Address
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "checkRegions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] CheckRegions
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "consecutiveFails", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConsecutiveFails
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "consecutiveSuccesses", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConsecutiveSuccesses
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "createdOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "failureReason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FailureReason
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "httpConfig", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareHealthchecks.DataCloudflareHealthchecksResultHttpConfigOutputReference\"}")]
        public virtual cloudflare.DataCloudflareHealthchecks.DataCloudflareHealthchecksResultHttpConfigOutputReference HttpConfig
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareHealthchecks.DataCloudflareHealthchecksResultHttpConfigOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Interval
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "retries", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Retries
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "suspended", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Suspended
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "tcpConfig", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareHealthchecks.DataCloudflareHealthchecksResultTcpConfigOutputReference\"}")]
        public virtual cloudflare.DataCloudflareHealthchecks.DataCloudflareHealthchecksResultTcpConfigOutputReference TcpConfig
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareHealthchecks.DataCloudflareHealthchecksResultTcpConfigOutputReference>()!;
        }

        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Timeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareHealthchecks.DataCloudflareHealthchecksResult\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareHealthchecks.IDataCloudflareHealthchecksResult? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareHealthchecks.IDataCloudflareHealthchecksResult?>();
            set => SetInstanceProperty(value);
        }
    }
}
