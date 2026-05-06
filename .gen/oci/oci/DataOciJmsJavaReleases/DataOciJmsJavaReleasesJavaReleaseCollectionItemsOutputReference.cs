using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciJmsJavaReleases
{
    [JsiiClass(nativeType: typeof(oci.DataOciJmsJavaReleases.DataOciJmsJavaReleasesJavaReleaseCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciJmsJavaReleases.DataOciJmsJavaReleasesJavaReleaseCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciJmsJavaReleasesJavaReleaseCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciJmsJavaReleasesJavaReleaseCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciJmsJavaReleasesJavaReleaseCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciJmsJavaReleasesJavaReleaseCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "artifactContentTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ArtifactContentTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "artifacts", typeJson: "{\"fqn\":\"oci.dataOciJmsJavaReleases.DataOciJmsJavaReleasesJavaReleaseCollectionItemsArtifactsList\"}")]
        public virtual oci.DataOciJmsJavaReleases.DataOciJmsJavaReleasesJavaReleaseCollectionItemsArtifactsList Artifacts
        {
            get => GetInstanceProperty<oci.DataOciJmsJavaReleases.DataOciJmsJavaReleasesJavaReleaseCollectionItemsArtifactsList>()!;
        }

        [JsiiProperty(name: "daysUnderSecurityBaseline", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DaysUnderSecurityBaseline
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "familyDetails", typeJson: "{\"fqn\":\"oci.dataOciJmsJavaReleases.DataOciJmsJavaReleasesJavaReleaseCollectionItemsFamilyDetailsList\"}")]
        public virtual oci.DataOciJmsJavaReleases.DataOciJmsJavaReleasesJavaReleaseCollectionItemsFamilyDetailsList FamilyDetails
        {
            get => GetInstanceProperty<oci.DataOciJmsJavaReleases.DataOciJmsJavaReleasesJavaReleaseCollectionItemsFamilyDetailsList>()!;
        }

        [JsiiProperty(name: "familyVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FamilyVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "licenseDetails", typeJson: "{\"fqn\":\"oci.dataOciJmsJavaReleases.DataOciJmsJavaReleasesJavaReleaseCollectionItemsLicenseDetailsList\"}")]
        public virtual oci.DataOciJmsJavaReleases.DataOciJmsJavaReleasesJavaReleaseCollectionItemsLicenseDetailsList LicenseDetails
        {
            get => GetInstanceProperty<oci.DataOciJmsJavaReleases.DataOciJmsJavaReleasesJavaReleaseCollectionItemsLicenseDetailsList>()!;
        }

        [JsiiProperty(name: "licenseType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LicenseType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mosPatches", typeJson: "{\"fqn\":\"oci.dataOciJmsJavaReleases.DataOciJmsJavaReleasesJavaReleaseCollectionItemsMosPatchesList\"}")]
        public virtual oci.DataOciJmsJavaReleases.DataOciJmsJavaReleasesJavaReleaseCollectionItemsMosPatchesList MosPatches
        {
            get => GetInstanceProperty<oci.DataOciJmsJavaReleases.DataOciJmsJavaReleasesJavaReleaseCollectionItemsMosPatchesList>()!;
        }

        [JsiiProperty(name: "parentReleaseVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentReleaseVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "releaseDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReleaseDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "releaseNotesUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReleaseNotesUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "releaseType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReleaseType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "releaseVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReleaseVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securityStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciJmsJavaReleases.DataOciJmsJavaReleasesJavaReleaseCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciJmsJavaReleases.IDataOciJmsJavaReleasesJavaReleaseCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciJmsJavaReleases.IDataOciJmsJavaReleasesJavaReleaseCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
