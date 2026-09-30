using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeSubsettingReportSubsettedObjects
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeSubsettingReportSubsettedObjects.DataOciDataSafeSubsettingReportSubsettedObjectsSubsettedObjectCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDataSafeSubsettingReportSubsettedObjects.DataOciDataSafeSubsettingReportSubsettedObjectsSubsettedObjectCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataSafeSubsettingReportSubsettedObjectsSubsettedObjectCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataSafeSubsettingReportSubsettedObjectsSubsettedObjectCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataSafeSubsettingReportSubsettedObjectsSubsettedObjectCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeSubsettingReportSubsettedObjectsSubsettedObjectCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Object
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "objectType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rowCountAfterSubsetting", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RowCountAfterSubsetting
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rowCountBeforeSubsetting", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RowCountBeforeSubsetting
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "schemaName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SchemaName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sizeAfterSubsettingInKbs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SizeAfterSubsettingInKbs
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sizeBeforeSubsettingInKbs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SizeBeforeSubsettingInKbs
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSubsettingReportSubsettedObjects.DataOciDataSafeSubsettingReportSubsettedObjectsSubsettedObjectCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDataSafeSubsettingReportSubsettedObjects.IDataOciDataSafeSubsettingReportSubsettedObjectsSubsettedObjectCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSubsettingReportSubsettedObjects.IDataOciDataSafeSubsettingReportSubsettedObjectsSubsettedObjectCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
