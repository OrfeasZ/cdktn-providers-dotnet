using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciJmsJavaDownloadsJavaDownloadTokens
{
    [JsiiClass(nativeType: typeof(oci.DataOciJmsJavaDownloadsJavaDownloadTokens.DataOciJmsJavaDownloadsJavaDownloadTokensJavaDownloadTokenCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciJmsJavaDownloadsJavaDownloadTokens.DataOciJmsJavaDownloadsJavaDownloadTokensJavaDownloadTokenCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciJmsJavaDownloadsJavaDownloadTokensJavaDownloadTokenCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciJmsJavaDownloadsJavaDownloadTokensJavaDownloadTokenCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciJmsJavaDownloadsJavaDownloadTokensJavaDownloadTokenCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciJmsJavaDownloadsJavaDownloadTokensJavaDownloadTokenCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdBy", typeJson: "{\"fqn\":\"oci.dataOciJmsJavaDownloadsJavaDownloadTokens.DataOciJmsJavaDownloadsJavaDownloadTokensJavaDownloadTokenCollectionItemsCreatedByList\"}")]
        public virtual oci.DataOciJmsJavaDownloadsJavaDownloadTokens.DataOciJmsJavaDownloadsJavaDownloadTokensJavaDownloadTokenCollectionItemsCreatedByList CreatedBy
        {
            get => GetInstanceProperty<oci.DataOciJmsJavaDownloadsJavaDownloadTokens.DataOciJmsJavaDownloadsJavaDownloadTokensJavaDownloadTokenCollectionItemsCreatedByList>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isDefault", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDefault
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "javaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JavaVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastUpdatedBy", typeJson: "{\"fqn\":\"oci.dataOciJmsJavaDownloadsJavaDownloadTokens.DataOciJmsJavaDownloadsJavaDownloadTokensJavaDownloadTokenCollectionItemsLastUpdatedByList\"}")]
        public virtual oci.DataOciJmsJavaDownloadsJavaDownloadTokens.DataOciJmsJavaDownloadsJavaDownloadTokensJavaDownloadTokenCollectionItemsLastUpdatedByList LastUpdatedBy
        {
            get => GetInstanceProperty<oci.DataOciJmsJavaDownloadsJavaDownloadTokens.DataOciJmsJavaDownloadsJavaDownloadTokensJavaDownloadTokenCollectionItemsLastUpdatedByList>()!;
        }

        [JsiiProperty(name: "licenseType", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] LicenseType
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeExpires", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeExpires
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastUsed", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastUsed
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Value
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciJmsJavaDownloadsJavaDownloadTokens.DataOciJmsJavaDownloadsJavaDownloadTokensJavaDownloadTokenCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciJmsJavaDownloadsJavaDownloadTokens.IDataOciJmsJavaDownloadsJavaDownloadTokensJavaDownloadTokenCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciJmsJavaDownloadsJavaDownloadTokens.IDataOciJmsJavaDownloadsJavaDownloadTokensJavaDownloadTokenCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
