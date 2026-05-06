using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ComputeCloudAtCustomerCccInfrastructure
{
    [JsiiClass(nativeType: typeof(oci.ComputeCloudAtCustomerCccInfrastructure.ComputeCloudAtCustomerCccInfrastructureInfrastructureInventoryOutputReference), fullyQualifiedName: "oci.computeCloudAtCustomerCccInfrastructure.ComputeCloudAtCustomerCccInfrastructureInfrastructureInventoryOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ComputeCloudAtCustomerCccInfrastructureInfrastructureInventoryOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public ComputeCloudAtCustomerCccInfrastructureInfrastructureInventoryOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected ComputeCloudAtCustomerCccInfrastructureInfrastructureInventoryOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ComputeCloudAtCustomerCccInfrastructureInfrastructureInventoryOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "capacityStorageTrayCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CapacityStorageTrayCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "computeNodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ComputeNodeCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "managementNodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ManagementNodeCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "performanceStorageTrayCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PerformanceStorageTrayCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "serialNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SerialNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.computeCloudAtCustomerCccInfrastructure.ComputeCloudAtCustomerCccInfrastructureInfrastructureInventory\"}", isOptional: true)]
        public virtual oci.ComputeCloudAtCustomerCccInfrastructure.IComputeCloudAtCustomerCccInfrastructureInfrastructureInventory? InternalValue
        {
            get => GetInstanceProperty<oci.ComputeCloudAtCustomerCccInfrastructure.IComputeCloudAtCustomerCccInfrastructureInfrastructureInventory?>();
            set => SetInstanceProperty(value);
        }
    }
}
