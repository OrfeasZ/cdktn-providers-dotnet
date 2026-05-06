using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseCloudAutonomousVmClusterAcdResourceUsages
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseCloudAutonomousVmClusterAcdResourceUsages.DataOciDatabaseCloudAutonomousVmClusterAcdResourceUsagesAutonomousContainerDatabaseResourceUsagesOutputReference), fullyQualifiedName: "oci.dataOciDatabaseCloudAutonomousVmClusterAcdResourceUsages.DataOciDatabaseCloudAutonomousVmClusterAcdResourceUsagesAutonomousContainerDatabaseResourceUsagesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseCloudAutonomousVmClusterAcdResourceUsagesAutonomousContainerDatabaseResourceUsagesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseCloudAutonomousVmClusterAcdResourceUsagesAutonomousContainerDatabaseResourceUsagesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseCloudAutonomousVmClusterAcdResourceUsagesAutonomousContainerDatabaseResourceUsagesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseCloudAutonomousVmClusterAcdResourceUsagesAutonomousContainerDatabaseResourceUsagesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "autonomousContainerDatabaseVmUsage", typeJson: "{\"fqn\":\"oci.dataOciDatabaseCloudAutonomousVmClusterAcdResourceUsages.DataOciDatabaseCloudAutonomousVmClusterAcdResourceUsagesAutonomousContainerDatabaseResourceUsagesAutonomousContainerDatabaseVmUsageList\"}")]
        public virtual oci.DataOciDatabaseCloudAutonomousVmClusterAcdResourceUsages.DataOciDatabaseCloudAutonomousVmClusterAcdResourceUsagesAutonomousContainerDatabaseResourceUsagesAutonomousContainerDatabaseVmUsageList AutonomousContainerDatabaseVmUsage
        {
            get => GetInstanceProperty<oci.DataOciDatabaseCloudAutonomousVmClusterAcdResourceUsages.DataOciDatabaseCloudAutonomousVmClusterAcdResourceUsagesAutonomousContainerDatabaseResourceUsagesAutonomousContainerDatabaseVmUsageList>()!;
        }

        [JsiiProperty(name: "availableCpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AvailableCpus
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "largestProvisionableAutonomousDatabaseInCpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LargestProvisionableAutonomousDatabaseInCpus
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "provisionableCpus", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] ProvisionableCpus
        {
            get => GetInstanceProperty<double[]>()!;
        }

        [JsiiProperty(name: "provisionedCpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ProvisionedCpus
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "reclaimableCpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReclaimableCpus
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "reservedCpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReservedCpus
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "usedCpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UsedCpus
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseCloudAutonomousVmClusterAcdResourceUsages.DataOciDatabaseCloudAutonomousVmClusterAcdResourceUsagesAutonomousContainerDatabaseResourceUsages\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseCloudAutonomousVmClusterAcdResourceUsages.IDataOciDatabaseCloudAutonomousVmClusterAcdResourceUsagesAutonomousContainerDatabaseResourceUsages? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseCloudAutonomousVmClusterAcdResourceUsages.IDataOciDatabaseCloudAutonomousVmClusterAcdResourceUsagesAutonomousContainerDatabaseResourceUsages?>();
            set => SetInstanceProperty(value);
        }
    }
}
