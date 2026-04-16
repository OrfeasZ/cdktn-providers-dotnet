using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDlpDataset
{
    [JsiiClass(nativeType: typeof(cloudflare.ZeroTrustDlpDataset.ZeroTrustDlpDatasetDatasetOutputReference), fullyQualifiedName: "cloudflare.zeroTrustDlpDataset.ZeroTrustDlpDatasetDatasetOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ZeroTrustDlpDatasetDatasetOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ZeroTrustDlpDatasetDatasetOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ZeroTrustDlpDatasetDatasetOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ZeroTrustDlpDatasetDatasetOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "caseSensitive", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable CaseSensitive
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "columns", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDlpDataset.ZeroTrustDlpDatasetDatasetColumnsList\"}")]
        public virtual cloudflare.ZeroTrustDlpDataset.ZeroTrustDlpDatasetDatasetColumnsList Columns
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustDlpDataset.ZeroTrustDlpDatasetDatasetColumnsList>()!;
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

        [JsiiProperty(name: "uploads", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDlpDataset.ZeroTrustDlpDatasetDatasetUploadsList\"}")]
        public virtual cloudflare.ZeroTrustDlpDataset.ZeroTrustDlpDatasetDatasetUploadsList Uploads
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustDlpDataset.ZeroTrustDlpDatasetDatasetUploadsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDlpDataset.ZeroTrustDlpDatasetDataset\"}", isOptional: true)]
        public virtual cloudflare.ZeroTrustDlpDataset.IZeroTrustDlpDatasetDataset? InternalValue
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustDlpDataset.IZeroTrustDlpDatasetDataset?>();
            set => SetInstanceProperty(value);
        }
    }
}
