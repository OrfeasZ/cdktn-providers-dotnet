using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeMaskingPolicyReferentialRelations
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeMaskingPolicyReferentialRelations.DataOciDataSafeMaskingPolicyReferentialRelationsMaskingPolicyReferentialRelationCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDataSafeMaskingPolicyReferentialRelations.DataOciDataSafeMaskingPolicyReferentialRelationsMaskingPolicyReferentialRelationCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataSafeMaskingPolicyReferentialRelationsMaskingPolicyReferentialRelationCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataSafeMaskingPolicyReferentialRelationsMaskingPolicyReferentialRelationCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataSafeMaskingPolicyReferentialRelationsMaskingPolicyReferentialRelationCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeMaskingPolicyReferentialRelationsMaskingPolicyReferentialRelationCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "child", typeJson: "{\"fqn\":\"oci.dataOciDataSafeMaskingPolicyReferentialRelations.DataOciDataSafeMaskingPolicyReferentialRelationsMaskingPolicyReferentialRelationCollectionItemsChildList\"}")]
        public virtual oci.DataOciDataSafeMaskingPolicyReferentialRelations.DataOciDataSafeMaskingPolicyReferentialRelationsMaskingPolicyReferentialRelationCollectionItemsChildList Child
        {
            get => GetInstanceProperty<oci.DataOciDataSafeMaskingPolicyReferentialRelations.DataOciDataSafeMaskingPolicyReferentialRelationsMaskingPolicyReferentialRelationCollectionItemsChildList>()!;
        }

        [JsiiProperty(name: "maskingFormat", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] MaskingFormat
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "maskingPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaskingPolicyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parent", typeJson: "{\"fqn\":\"oci.dataOciDataSafeMaskingPolicyReferentialRelations.DataOciDataSafeMaskingPolicyReferentialRelationsMaskingPolicyReferentialRelationCollectionItemsParentList\"}")]
        public virtual oci.DataOciDataSafeMaskingPolicyReferentialRelations.DataOciDataSafeMaskingPolicyReferentialRelationsMaskingPolicyReferentialRelationCollectionItemsParentList Parent
        {
            get => GetInstanceProperty<oci.DataOciDataSafeMaskingPolicyReferentialRelations.DataOciDataSafeMaskingPolicyReferentialRelationsMaskingPolicyReferentialRelationCollectionItemsParentList>()!;
        }

        [JsiiProperty(name: "relationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RelationType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataSafeMaskingPolicyReferentialRelations.DataOciDataSafeMaskingPolicyReferentialRelationsMaskingPolicyReferentialRelationCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDataSafeMaskingPolicyReferentialRelations.IDataOciDataSafeMaskingPolicyReferentialRelationsMaskingPolicyReferentialRelationCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataSafeMaskingPolicyReferentialRelations.IDataOciDataSafeMaskingPolicyReferentialRelationsMaskingPolicyReferentialRelationCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
