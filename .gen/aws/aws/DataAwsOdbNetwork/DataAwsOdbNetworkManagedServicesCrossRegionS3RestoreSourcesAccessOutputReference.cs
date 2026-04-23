using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsOdbNetwork
{
    [JsiiClass(nativeType: typeof(aws.DataAwsOdbNetwork.DataAwsOdbNetworkManagedServicesCrossRegionS3RestoreSourcesAccessOutputReference), fullyQualifiedName: "aws.dataAwsOdbNetwork.DataAwsOdbNetworkManagedServicesCrossRegionS3RestoreSourcesAccessOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsOdbNetworkManagedServicesCrossRegionS3RestoreSourcesAccessOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsOdbNetworkManagedServicesCrossRegionS3RestoreSourcesAccessOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsOdbNetworkManagedServicesCrossRegionS3RestoreSourcesAccessOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsOdbNetworkManagedServicesCrossRegionS3RestoreSourcesAccessOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "ipv4Addresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Ipv4Addresses
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsOdbNetwork.DataAwsOdbNetworkManagedServicesCrossRegionS3RestoreSourcesAccess\"}", isOptional: true)]
        public virtual aws.DataAwsOdbNetwork.IDataAwsOdbNetworkManagedServicesCrossRegionS3RestoreSourcesAccess? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsOdbNetwork.IDataAwsOdbNetworkManagedServicesCrossRegionS3RestoreSourcesAccess?>();
            set => SetInstanceProperty(value);
        }
    }
}
