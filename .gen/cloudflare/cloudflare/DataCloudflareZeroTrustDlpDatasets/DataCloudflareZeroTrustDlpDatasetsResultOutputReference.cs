using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustDlpDatasets
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustDlpDatasets.DataCloudflareZeroTrustDlpDatasetsResultOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustDlpDatasets.DataCloudflareZeroTrustDlpDatasetsResultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareZeroTrustDlpDatasetsResultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareZeroTrustDlpDatasetsResultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataCloudflareZeroTrustDlpDatasetsResultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustDlpDatasetsResultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "caseSensitive", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable CaseSensitive
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "columns", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDlpDatasets.DataCloudflareZeroTrustDlpDatasetsResultColumnsList\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustDlpDatasets.DataCloudflareZeroTrustDlpDatasetsResultColumnsList Columns
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDlpDatasets.DataCloudflareZeroTrustDlpDatasetsResultColumnsList>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "encodingVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EncodingVersion
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "numCells", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumCells
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Secret
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
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

        [JsiiProperty(name: "uploads", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDlpDatasets.DataCloudflareZeroTrustDlpDatasetsResultUploadsList\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustDlpDatasets.DataCloudflareZeroTrustDlpDatasetsResultUploadsList Uploads
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDlpDatasets.DataCloudflareZeroTrustDlpDatasetsResultUploadsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDlpDatasets.DataCloudflareZeroTrustDlpDatasetsResult\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustDlpDatasets.IDataCloudflareZeroTrustDlpDatasetsResult? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDlpDatasets.IDataCloudflareZeroTrustDlpDatasetsResult?>();
            set => SetInstanceProperty(value);
        }
    }
}
