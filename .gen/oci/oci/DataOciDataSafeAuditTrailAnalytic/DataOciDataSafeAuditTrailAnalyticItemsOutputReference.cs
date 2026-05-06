using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeAuditTrailAnalytic
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeAuditTrailAnalytic.DataOciDataSafeAuditTrailAnalyticItemsOutputReference), fullyQualifiedName: "oci.dataOciDataSafeAuditTrailAnalytic.DataOciDataSafeAuditTrailAnalyticItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataSafeAuditTrailAnalyticItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataSafeAuditTrailAnalyticItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataSafeAuditTrailAnalyticItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeAuditTrailAnalyticItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Count
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dimensions", typeJson: "{\"fqn\":\"oci.dataOciDataSafeAuditTrailAnalytic.DataOciDataSafeAuditTrailAnalyticItemsDimensionsList\"}")]
        public virtual oci.DataOciDataSafeAuditTrailAnalytic.DataOciDataSafeAuditTrailAnalyticItemsDimensionsList Dimensions
        {
            get => GetInstanceProperty<oci.DataOciDataSafeAuditTrailAnalytic.DataOciDataSafeAuditTrailAnalyticItemsDimensionsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataSafeAuditTrailAnalytic.DataOciDataSafeAuditTrailAnalyticItems\"}", isOptional: true)]
        public virtual oci.DataOciDataSafeAuditTrailAnalytic.IDataOciDataSafeAuditTrailAnalyticItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataSafeAuditTrailAnalytic.IDataOciDataSafeAuditTrailAnalyticItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
