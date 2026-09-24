using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFunctionsFunctions
{
    [JsiiClass(nativeType: typeof(oci.DataOciFunctionsFunctions.DataOciFunctionsFunctionsFunctionsSourceDetailsOutputReference), fullyQualifiedName: "oci.dataOciFunctionsFunctions.DataOciFunctionsFunctionsFunctionsSourceDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciFunctionsFunctionsFunctionsSourceDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciFunctionsFunctionsFunctionsSourceDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciFunctionsFunctionsFunctionsSourceDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFunctionsFunctionsFunctionsSourceDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "archiveSourceDetails", typeJson: "{\"fqn\":\"oci.dataOciFunctionsFunctions.DataOciFunctionsFunctionsFunctionsSourceDetailsArchiveSourceDetailsList\"}")]
        public virtual oci.DataOciFunctionsFunctions.DataOciFunctionsFunctionsFunctionsSourceDetailsArchiveSourceDetailsList ArchiveSourceDetails
        {
            get => GetInstanceProperty<oci.DataOciFunctionsFunctions.DataOciFunctionsFunctionsFunctionsSourceDetailsArchiveSourceDetailsList>()!;
        }

        [JsiiProperty(name: "handler", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Handler
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Image
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "imageDigest", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageDigest
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pbfListingId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PbfListingId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "runtimeConfig", typeJson: "{\"fqn\":\"oci.dataOciFunctionsFunctions.DataOciFunctionsFunctionsFunctionsSourceDetailsRuntimeConfigList\"}")]
        public virtual oci.DataOciFunctionsFunctions.DataOciFunctionsFunctionsFunctionsSourceDetailsRuntimeConfigList RuntimeConfig
        {
            get => GetInstanceProperty<oci.DataOciFunctionsFunctions.DataOciFunctionsFunctionsFunctionsSourceDetailsRuntimeConfigList>()!;
        }

        [JsiiProperty(name: "sourceCodeSha256", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceCodeSha256
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciFunctionsFunctions.DataOciFunctionsFunctionsFunctionsSourceDetails\"}", isOptional: true)]
        public virtual oci.DataOciFunctionsFunctions.IDataOciFunctionsFunctionsFunctionsSourceDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciFunctionsFunctions.IDataOciFunctionsFunctionsFunctionsSourceDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
