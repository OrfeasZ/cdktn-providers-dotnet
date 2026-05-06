using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFileStorageMountTargets
{
    [JsiiClass(nativeType: typeof(oci.DataOciFileStorageMountTargets.DataOciFileStorageMountTargetsMountTargetsOutputReference), fullyQualifiedName: "oci.dataOciFileStorageMountTargets.DataOciFileStorageMountTargetsMountTargetsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciFileStorageMountTargetsMountTargetsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciFileStorageMountTargetsMountTargetsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciFileStorageMountTargetsMountTargetsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFileStorageMountTargetsMountTargetsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "exportSetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExportSetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "hostnameLabel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostnameLabel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idmapType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdmapType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isLockOverride", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsLockOverride
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "kerberos", typeJson: "{\"fqn\":\"oci.dataOciFileStorageMountTargets.DataOciFileStorageMountTargetsMountTargetsKerberosList\"}")]
        public virtual oci.DataOciFileStorageMountTargets.DataOciFileStorageMountTargetsMountTargetsKerberosList Kerberos
        {
            get => GetInstanceProperty<oci.DataOciFileStorageMountTargets.DataOciFileStorageMountTargetsMountTargetsKerberosList>()!;
        }

        [JsiiProperty(name: "ldapIdmap", typeJson: "{\"fqn\":\"oci.dataOciFileStorageMountTargets.DataOciFileStorageMountTargetsMountTargetsLdapIdmapList\"}")]
        public virtual oci.DataOciFileStorageMountTargets.DataOciFileStorageMountTargetsMountTargetsLdapIdmapList LdapIdmap
        {
            get => GetInstanceProperty<oci.DataOciFileStorageMountTargets.DataOciFileStorageMountTargetsMountTargetsLdapIdmapList>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "locks", typeJson: "{\"fqn\":\"oci.dataOciFileStorageMountTargets.DataOciFileStorageMountTargetsMountTargetsLocksList\"}")]
        public virtual oci.DataOciFileStorageMountTargets.DataOciFileStorageMountTargetsMountTargetsLocksList Locks
        {
            get => GetInstanceProperty<oci.DataOciFileStorageMountTargets.DataOciFileStorageMountTargetsMountTargetsLocksList>()!;
        }

        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NsgIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "observedThroughput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObservedThroughput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateIpIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PrivateIpIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "requestedThroughput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestedThroughput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "reservedStorageCapacity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReservedStorageCapacity
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeBillingCycleEnd", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeBillingCycleEnd
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciFileStorageMountTargets.DataOciFileStorageMountTargetsMountTargets\"}", isOptional: true)]
        public virtual oci.DataOciFileStorageMountTargets.IDataOciFileStorageMountTargetsMountTargets? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciFileStorageMountTargets.IDataOciFileStorageMountTargetsMountTargets?>();
            set => SetInstanceProperty(value);
        }
    }
}
