using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsNetworkInterface
{
    [JsiiClass(nativeType: typeof(aws.DataAwsNetworkInterface.DataAwsNetworkInterfaceEnaSrdSpecificationOutputReference), fullyQualifiedName: "aws.dataAwsNetworkInterface.DataAwsNetworkInterfaceEnaSrdSpecificationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsNetworkInterfaceEnaSrdSpecificationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsNetworkInterfaceEnaSrdSpecificationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsNetworkInterfaceEnaSrdSpecificationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsNetworkInterfaceEnaSrdSpecificationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "enaSrdEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EnaSrdEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "enaSrdUdpSpecification", typeJson: "{\"fqn\":\"aws.dataAwsNetworkInterface.DataAwsNetworkInterfaceEnaSrdSpecificationEnaSrdUdpSpecificationList\"}")]
        public virtual aws.DataAwsNetworkInterface.DataAwsNetworkInterfaceEnaSrdSpecificationEnaSrdUdpSpecificationList EnaSrdUdpSpecification
        {
            get => GetInstanceProperty<aws.DataAwsNetworkInterface.DataAwsNetworkInterfaceEnaSrdSpecificationEnaSrdUdpSpecificationList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsNetworkInterface.DataAwsNetworkInterfaceEnaSrdSpecification\"}", isOptional: true)]
        public virtual aws.DataAwsNetworkInterface.IDataAwsNetworkInterfaceEnaSrdSpecification? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsNetworkInterface.IDataAwsNetworkInterfaceEnaSrdSpecification?>();
            set => SetInstanceProperty(value);
        }
    }
}
