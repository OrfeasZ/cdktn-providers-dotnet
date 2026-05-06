using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsGroup
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsDefinedTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsDefinedTagsList DefinedTags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsDefinedTagsList>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsFreeformTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsFreeformTagsList FreeformTags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsFreeformTagsList>()!;
        }

        [JsiiProperty(name: "tagSlug", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TagSlug
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTags\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsGroup.IDataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTags? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsGroup.IDataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTags?>();
            set => SetInstanceProperty(value);
        }
    }
}
