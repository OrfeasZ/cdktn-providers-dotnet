using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciJmsListJreUsage
{
    [JsiiClass(nativeType: typeof(oci.DataOciJmsListJreUsage.DataOciJmsListJreUsageItemsOutputReference), fullyQualifiedName: "oci.dataOciJmsListJreUsage.DataOciJmsListJreUsageItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciJmsListJreUsageItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciJmsListJreUsageItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciJmsListJreUsageItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciJmsListJreUsageItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "approximateApplicationCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ApproximateApplicationCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "approximateInstallationCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ApproximateInstallationCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "approximateManagedInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ApproximateManagedInstanceCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "approximatePendingWorkRequestCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ApproximatePendingWorkRequestCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "daysUnderSecurityBaseline", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DaysUnderSecurityBaseline
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "distribution", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Distribution
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endOfSupportLifeDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndOfSupportLifeDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fleetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FleetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managedInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedInstanceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "operatingSystems", typeJson: "{\"fqn\":\"oci.dataOciJmsListJreUsage.DataOciJmsListJreUsageItemsOperatingSystemsList\"}")]
        public virtual oci.DataOciJmsListJreUsage.DataOciJmsListJreUsageItemsOperatingSystemsList OperatingSystems
        {
            get => GetInstanceProperty<oci.DataOciJmsListJreUsage.DataOciJmsListJreUsageItemsOperatingSystemsList>()!;
        }

        [JsiiProperty(name: "releaseDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReleaseDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securityStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeEnd", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeEnd
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeFirstSeen", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeFirstSeen
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastSeen", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastSeen
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeStart", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStart
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vendor", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Vendor
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciJmsListJreUsage.DataOciJmsListJreUsageItems\"}", isOptional: true)]
        public virtual oci.DataOciJmsListJreUsage.IDataOciJmsListJreUsageItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciJmsListJreUsage.IDataOciJmsListJreUsageItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
