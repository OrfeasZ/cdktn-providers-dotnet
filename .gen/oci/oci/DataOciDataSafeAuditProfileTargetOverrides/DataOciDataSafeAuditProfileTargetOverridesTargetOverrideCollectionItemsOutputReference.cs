using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeAuditProfileTargetOverrides
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeAuditProfileTargetOverrides.DataOciDataSafeAuditProfileTargetOverridesTargetOverrideCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDataSafeAuditProfileTargetOverrides.DataOciDataSafeAuditProfileTargetOverridesTargetOverrideCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataSafeAuditProfileTargetOverridesTargetOverrideCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataSafeAuditProfileTargetOverridesTargetOverrideCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataSafeAuditProfileTargetOverridesTargetOverrideCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeAuditProfileTargetOverridesTargetOverrideCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "isPaidUsageEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsPaidUsageEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "offlineMonths", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OfflineMonths
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "offlineMonthsSource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OfflineMonthsSource
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "onlineMonths", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OnlineMonths
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "onlineMonthsSource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OnlineMonthsSource
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "paidUsageSource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PaidUsageSource
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "targetDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetDatabaseId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataSafeAuditProfileTargetOverrides.DataOciDataSafeAuditProfileTargetOverridesTargetOverrideCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDataSafeAuditProfileTargetOverrides.IDataOciDataSafeAuditProfileTargetOverridesTargetOverrideCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataSafeAuditProfileTargetOverrides.IDataOciDataSafeAuditProfileTargetOverridesTargetOverrideCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
