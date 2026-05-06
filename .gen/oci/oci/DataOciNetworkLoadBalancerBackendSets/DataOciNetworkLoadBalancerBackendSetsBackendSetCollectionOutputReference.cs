using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciNetworkLoadBalancerBackendSets
{
    [JsiiClass(nativeType: typeof(oci.DataOciNetworkLoadBalancerBackendSets.DataOciNetworkLoadBalancerBackendSetsBackendSetCollectionOutputReference), fullyQualifiedName: "oci.dataOciNetworkLoadBalancerBackendSets.DataOciNetworkLoadBalancerBackendSetsBackendSetCollectionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciNetworkLoadBalancerBackendSetsBackendSetCollectionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciNetworkLoadBalancerBackendSetsBackendSetCollectionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciNetworkLoadBalancerBackendSetsBackendSetCollectionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciNetworkLoadBalancerBackendSetsBackendSetCollectionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "items", typeJson: "{\"fqn\":\"oci.dataOciNetworkLoadBalancerBackendSets.DataOciNetworkLoadBalancerBackendSetsBackendSetCollectionItemsList\"}")]
        public virtual oci.DataOciNetworkLoadBalancerBackendSets.DataOciNetworkLoadBalancerBackendSetsBackendSetCollectionItemsList Items
        {
            get => GetInstanceProperty<oci.DataOciNetworkLoadBalancerBackendSets.DataOciNetworkLoadBalancerBackendSetsBackendSetCollectionItemsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciNetworkLoadBalancerBackendSets.DataOciNetworkLoadBalancerBackendSetsBackendSetCollection\"}", isOptional: true)]
        public virtual oci.DataOciNetworkLoadBalancerBackendSets.IDataOciNetworkLoadBalancerBackendSetsBackendSetCollection? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciNetworkLoadBalancerBackendSets.IDataOciNetworkLoadBalancerBackendSetsBackendSetCollection?>();
            set => SetInstanceProperty(value);
        }
    }
}
