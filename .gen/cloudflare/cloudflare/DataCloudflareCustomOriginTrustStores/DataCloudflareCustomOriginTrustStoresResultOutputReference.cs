using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareCustomOriginTrustStores
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareCustomOriginTrustStores.DataCloudflareCustomOriginTrustStoresResultOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareCustomOriginTrustStores.DataCloudflareCustomOriginTrustStoresResultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareCustomOriginTrustStoresResultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareCustomOriginTrustStoresResultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataCloudflareCustomOriginTrustStoresResultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareCustomOriginTrustStoresResultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Certificate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "expiresOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExpiresOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Issuer
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "signature", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Signature
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "uploadedOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UploadedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareCustomOriginTrustStores.DataCloudflareCustomOriginTrustStoresResult\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareCustomOriginTrustStores.IDataCloudflareCustomOriginTrustStoresResult? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareCustomOriginTrustStores.IDataCloudflareCustomOriginTrustStoresResult?>();
            set => SetInstanceProperty(value);
        }
    }
}
