using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataccInfrastructure
{
    [JsiiClass(nativeType: typeof(oci.DataccInfrastructure.DataccInfrastructureServersOutputReference), fullyQualifiedName: "oci.dataccInfrastructure.DataccInfrastructureServersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataccInfrastructureServersOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataccInfrastructureServersOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataccInfrastructureServersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataccInfrastructureServersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "baseVmCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BaseVmCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "computeCapacity", typeJson: "{\"fqn\":\"oci.dataccInfrastructure.DataccInfrastructureServersComputeCapacityList\"}")]
        public virtual oci.DataccInfrastructure.DataccInfrastructureServersComputeCapacityList ComputeCapacity
        {
            get => GetInstanceProperty<oci.DataccInfrastructure.DataccInfrastructureServersComputeCapacityList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ilomIpAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IlomIpAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ilomName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IlomName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceVmCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InstanceVmCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "serverIpAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServerIpAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serverName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServerName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataccInfrastructure.DataccInfrastructureServers\"}", isOptional: true)]
        public virtual oci.DataccInfrastructure.IDataccInfrastructureServers? InternalValue
        {
            get => GetInstanceProperty<oci.DataccInfrastructure.IDataccInfrastructureServers?>();
            set => SetInstanceProperty(value);
        }
    }
}
