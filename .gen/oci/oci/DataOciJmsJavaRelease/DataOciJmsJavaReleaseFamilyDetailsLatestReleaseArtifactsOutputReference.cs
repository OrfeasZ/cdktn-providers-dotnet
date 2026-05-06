using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciJmsJavaRelease
{
    [JsiiClass(nativeType: typeof(oci.DataOciJmsJavaRelease.DataOciJmsJavaReleaseFamilyDetailsLatestReleaseArtifactsOutputReference), fullyQualifiedName: "oci.dataOciJmsJavaRelease.DataOciJmsJavaReleaseFamilyDetailsLatestReleaseArtifactsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciJmsJavaReleaseFamilyDetailsLatestReleaseArtifactsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciJmsJavaReleaseFamilyDetailsLatestReleaseArtifactsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciJmsJavaReleaseFamilyDetailsLatestReleaseArtifactsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciJmsJavaReleaseFamilyDetailsLatestReleaseArtifactsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "approximateFileSizeInBytes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApproximateFileSizeInBytes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "architecture", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Architecture
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "artifactContentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArtifactContentType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "artifactDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArtifactDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "artifactFileName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArtifactFileName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "artifactId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArtifactId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "downloadUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DownloadUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "osFamily", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OsFamily
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "packageType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "packageTypeDetail", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageTypeDetail
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scriptChecksumUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScriptChecksumUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scriptDownloadUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScriptDownloadUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sha256", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Sha256
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciJmsJavaRelease.DataOciJmsJavaReleaseFamilyDetailsLatestReleaseArtifacts\"}", isOptional: true)]
        public virtual oci.DataOciJmsJavaRelease.IDataOciJmsJavaReleaseFamilyDetailsLatestReleaseArtifacts? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciJmsJavaRelease.IDataOciJmsJavaReleaseFamilyDetailsLatestReleaseArtifacts?>();
            set => SetInstanceProperty(value);
        }
    }
}
