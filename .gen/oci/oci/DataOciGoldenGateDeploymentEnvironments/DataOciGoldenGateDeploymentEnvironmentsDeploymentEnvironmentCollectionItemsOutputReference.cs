using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciGoldenGateDeploymentEnvironments
{
    [JsiiClass(nativeType: typeof(oci.DataOciGoldenGateDeploymentEnvironments.DataOciGoldenGateDeploymentEnvironmentsDeploymentEnvironmentCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciGoldenGateDeploymentEnvironments.DataOciGoldenGateDeploymentEnvironmentsDeploymentEnvironmentCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciGoldenGateDeploymentEnvironmentsDeploymentEnvironmentCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciGoldenGateDeploymentEnvironmentsDeploymentEnvironmentCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciGoldenGateDeploymentEnvironmentsDeploymentEnvironmentCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciGoldenGateDeploymentEnvironmentsDeploymentEnvironmentCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Category
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultCpuCoreCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DefaultCpuCoreCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "environmentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnvironmentType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isAutoScalingEnabledByDefault", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAutoScalingEnabledByDefault
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "maxCpuCoreCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxCpuCoreCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "memoryPerOcpuInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemoryPerOcpuInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minCpuCoreCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinCpuCoreCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "networkBandwidthPerOcpuInGbps", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NetworkBandwidthPerOcpuInGbps
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "storageUsageLimitPerOcpuInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StorageUsageLimitPerOcpuInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciGoldenGateDeploymentEnvironments.DataOciGoldenGateDeploymentEnvironmentsDeploymentEnvironmentCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciGoldenGateDeploymentEnvironments.IDataOciGoldenGateDeploymentEnvironmentsDeploymentEnvironmentCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciGoldenGateDeploymentEnvironments.IDataOciGoldenGateDeploymentEnvironmentsDeploymentEnvironmentCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
