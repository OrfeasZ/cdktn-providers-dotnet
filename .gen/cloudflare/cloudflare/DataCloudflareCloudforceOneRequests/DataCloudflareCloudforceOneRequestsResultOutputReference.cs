using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareCloudforceOneRequests
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareCloudforceOneRequests.DataCloudflareCloudforceOneRequestsResultOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareCloudforceOneRequests.DataCloudflareCloudforceOneRequestsResultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareCloudforceOneRequestsResultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareCloudforceOneRequestsResultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataCloudflareCloudforceOneRequestsResultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareCloudforceOneRequestsResultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "completed", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Completed
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "created", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Created
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "messageTokens", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MessageTokens
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Priority
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "readableId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReadableId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "request", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Request
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "summary", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Summary
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tlp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tlp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tokens", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Tokens
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "updated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Updated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareCloudforceOneRequests.DataCloudflareCloudforceOneRequestsResult\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareCloudforceOneRequests.IDataCloudflareCloudforceOneRequestsResult? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareCloudforceOneRequests.IDataCloudflareCloudforceOneRequestsResult?>();
            set => SetInstanceProperty(value);
        }
    }
}
