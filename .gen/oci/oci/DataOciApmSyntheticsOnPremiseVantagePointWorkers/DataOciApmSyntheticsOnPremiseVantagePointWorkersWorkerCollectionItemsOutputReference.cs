using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciApmSyntheticsOnPremiseVantagePointWorkers
{
    [JsiiClass(nativeType: typeof(oci.DataOciApmSyntheticsOnPremiseVantagePointWorkers.DataOciApmSyntheticsOnPremiseVantagePointWorkersWorkerCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciApmSyntheticsOnPremiseVantagePointWorkers.DataOciApmSyntheticsOnPremiseVantagePointWorkersWorkerCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciApmSyntheticsOnPremiseVantagePointWorkersWorkerCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciApmSyntheticsOnPremiseVantagePointWorkersWorkerCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciApmSyntheticsOnPremiseVantagePointWorkersWorkerCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciApmSyntheticsOnPremiseVantagePointWorkersWorkerCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "apmDomainId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApmDomainId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configurationDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigurationDetails
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

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "geoInfo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GeoInfo
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "identityInfo", typeJson: "{\"fqn\":\"oci.dataOciApmSyntheticsOnPremiseVantagePointWorkers.DataOciApmSyntheticsOnPremiseVantagePointWorkersWorkerCollectionItemsIdentityInfoList\"}")]
        public virtual oci.DataOciApmSyntheticsOnPremiseVantagePointWorkers.DataOciApmSyntheticsOnPremiseVantagePointWorkersWorkerCollectionItemsIdentityInfoList IdentityInfo
        {
            get => GetInstanceProperty<oci.DataOciApmSyntheticsOnPremiseVantagePointWorkers.DataOciApmSyntheticsOnPremiseVantagePointWorkersWorkerCollectionItemsIdentityInfoList>()!;
        }

        [JsiiProperty(name: "monitorList", typeJson: "{\"fqn\":\"oci.dataOciApmSyntheticsOnPremiseVantagePointWorkers.DataOciApmSyntheticsOnPremiseVantagePointWorkersWorkerCollectionItemsMonitorListStructList\"}")]
        public virtual oci.DataOciApmSyntheticsOnPremiseVantagePointWorkers.DataOciApmSyntheticsOnPremiseVantagePointWorkersWorkerCollectionItemsMonitorListStructList MonitorList
        {
            get => GetInstanceProperty<oci.DataOciApmSyntheticsOnPremiseVantagePointWorkers.DataOciApmSyntheticsOnPremiseVantagePointWorkersWorkerCollectionItemsMonitorListStructList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "onPremiseVantagePointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OnPremiseVantagePointId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "opvpId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpvpId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "opvpName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpvpName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Priority
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "resourcePrincipalTokenPublicKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourcePrincipalTokenPublicKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "runtimeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuntimeId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastSyncUp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastSyncUp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "versionDetails", typeJson: "{\"fqn\":\"oci.dataOciApmSyntheticsOnPremiseVantagePointWorkers.DataOciApmSyntheticsOnPremiseVantagePointWorkersWorkerCollectionItemsVersionDetailsList\"}")]
        public virtual oci.DataOciApmSyntheticsOnPremiseVantagePointWorkers.DataOciApmSyntheticsOnPremiseVantagePointWorkersWorkerCollectionItemsVersionDetailsList VersionDetails
        {
            get => GetInstanceProperty<oci.DataOciApmSyntheticsOnPremiseVantagePointWorkers.DataOciApmSyntheticsOnPremiseVantagePointWorkersWorkerCollectionItemsVersionDetailsList>()!;
        }

        [JsiiProperty(name: "workerType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkerType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciApmSyntheticsOnPremiseVantagePointWorkers.DataOciApmSyntheticsOnPremiseVantagePointWorkersWorkerCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciApmSyntheticsOnPremiseVantagePointWorkers.IDataOciApmSyntheticsOnPremiseVantagePointWorkersWorkerCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciApmSyntheticsOnPremiseVantagePointWorkers.IDataOciApmSyntheticsOnPremiseVantagePointWorkersWorkerCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
