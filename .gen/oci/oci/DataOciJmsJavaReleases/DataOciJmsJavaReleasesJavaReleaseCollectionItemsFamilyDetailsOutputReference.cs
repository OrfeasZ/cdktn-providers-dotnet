using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciJmsJavaReleases
{
    [JsiiClass(nativeType: typeof(oci.DataOciJmsJavaReleases.DataOciJmsJavaReleasesJavaReleaseCollectionItemsFamilyDetailsOutputReference), fullyQualifiedName: "oci.dataOciJmsJavaReleases.DataOciJmsJavaReleasesJavaReleaseCollectionItemsFamilyDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciJmsJavaReleasesJavaReleaseCollectionItemsFamilyDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciJmsJavaReleasesJavaReleaseCollectionItemsFamilyDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciJmsJavaReleasesJavaReleaseCollectionItemsFamilyDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciJmsJavaReleasesJavaReleaseCollectionItemsFamilyDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "docUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DocUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endOfSupportLifeDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndOfSupportLifeDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "familyVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FamilyVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isSupportedVersion", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSupportedVersion
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "latestReleaseArtifacts", typeJson: "{\"fqn\":\"oci.dataOciJmsJavaReleases.DataOciJmsJavaReleasesJavaReleaseCollectionItemsFamilyDetailsLatestReleaseArtifactsList\"}")]
        public virtual oci.DataOciJmsJavaReleases.DataOciJmsJavaReleasesJavaReleaseCollectionItemsFamilyDetailsLatestReleaseArtifactsList LatestReleaseArtifacts
        {
            get => GetInstanceProperty<oci.DataOciJmsJavaReleases.DataOciJmsJavaReleasesJavaReleaseCollectionItemsFamilyDetailsLatestReleaseArtifactsList>()!;
        }

        [JsiiProperty(name: "latestReleaseVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LatestReleaseVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "licenseTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] LicenseTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "releaseDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReleaseDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "supportType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SupportType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciJmsJavaReleases.DataOciJmsJavaReleasesJavaReleaseCollectionItemsFamilyDetails\"}", isOptional: true)]
        public virtual oci.DataOciJmsJavaReleases.IDataOciJmsJavaReleasesJavaReleaseCollectionItemsFamilyDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciJmsJavaReleases.IDataOciJmsJavaReleasesJavaReleaseCollectionItemsFamilyDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
