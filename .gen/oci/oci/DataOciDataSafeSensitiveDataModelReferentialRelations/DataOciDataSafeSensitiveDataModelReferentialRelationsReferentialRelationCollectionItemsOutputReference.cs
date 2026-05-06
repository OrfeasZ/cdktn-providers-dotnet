using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeSensitiveDataModelReferentialRelations
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeSensitiveDataModelReferentialRelations.DataOciDataSafeSensitiveDataModelReferentialRelationsReferentialRelationCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDataSafeSensitiveDataModelReferentialRelations.DataOciDataSafeSensitiveDataModelReferentialRelationsReferentialRelationCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataSafeSensitiveDataModelReferentialRelationsReferentialRelationCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataSafeSensitiveDataModelReferentialRelationsReferentialRelationCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataSafeSensitiveDataModelReferentialRelationsReferentialRelationCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeSensitiveDataModelReferentialRelationsReferentialRelationCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "child", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSensitiveDataModelReferentialRelations.DataOciDataSafeSensitiveDataModelReferentialRelationsReferentialRelationCollectionItemsChildList\"}")]
        public virtual oci.DataOciDataSafeSensitiveDataModelReferentialRelations.DataOciDataSafeSensitiveDataModelReferentialRelationsReferentialRelationCollectionItemsChildList Child
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSensitiveDataModelReferentialRelations.DataOciDataSafeSensitiveDataModelReferentialRelationsReferentialRelationCollectionItemsChildList>()!;
        }

        [JsiiProperty(name: "isSensitive", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSensitive
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parent", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSensitiveDataModelReferentialRelations.DataOciDataSafeSensitiveDataModelReferentialRelationsReferentialRelationCollectionItemsParentList\"}")]
        public virtual oci.DataOciDataSafeSensitiveDataModelReferentialRelations.DataOciDataSafeSensitiveDataModelReferentialRelationsReferentialRelationCollectionItemsParentList Parent
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSensitiveDataModelReferentialRelations.DataOciDataSafeSensitiveDataModelReferentialRelationsReferentialRelationCollectionItemsParentList>()!;
        }

        [JsiiProperty(name: "relationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RelationType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sensitiveDataModelId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SensitiveDataModelId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSensitiveDataModelReferentialRelations.DataOciDataSafeSensitiveDataModelReferentialRelationsReferentialRelationCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDataSafeSensitiveDataModelReferentialRelations.IDataOciDataSafeSensitiveDataModelReferentialRelationsReferentialRelationCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSensitiveDataModelReferentialRelations.IDataOciDataSafeSensitiveDataModelReferentialRelationsReferentialRelationCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
