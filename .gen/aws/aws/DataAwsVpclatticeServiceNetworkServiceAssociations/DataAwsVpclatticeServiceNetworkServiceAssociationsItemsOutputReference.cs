using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsVpclatticeServiceNetworkServiceAssociations
{
    [JsiiClass(nativeType: typeof(aws.DataAwsVpclatticeServiceNetworkServiceAssociations.DataAwsVpclatticeServiceNetworkServiceAssociationsItemsOutputReference), fullyQualifiedName: "aws.dataAwsVpclatticeServiceNetworkServiceAssociations.DataAwsVpclatticeServiceNetworkServiceAssociationsItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsVpclatticeServiceNetworkServiceAssociationsItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsVpclatticeServiceNetworkServiceAssociationsItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsVpclatticeServiceNetworkServiceAssociationsItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsVpclatticeServiceNetworkServiceAssociationsItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customDomainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomDomainName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dnsEntry", typeJson: "{\"fqn\":\"aws.dataAwsVpclatticeServiceNetworkServiceAssociations.DataAwsVpclatticeServiceNetworkServiceAssociationsItemsDnsEntryList\"}")]
        public virtual aws.DataAwsVpclatticeServiceNetworkServiceAssociations.DataAwsVpclatticeServiceNetworkServiceAssociationsItemsDnsEntryList DnsEntry
        {
            get => GetInstanceProperty<aws.DataAwsVpclatticeServiceNetworkServiceAssociations.DataAwsVpclatticeServiceNetworkServiceAssociationsItemsDnsEntryList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceNetworkArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceNetworkArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceNetworkId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceNetworkName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceNetworkName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsVpclatticeServiceNetworkServiceAssociations.DataAwsVpclatticeServiceNetworkServiceAssociationsItems\"}", isOptional: true)]
        public virtual aws.DataAwsVpclatticeServiceNetworkServiceAssociations.IDataAwsVpclatticeServiceNetworkServiceAssociationsItems? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsVpclatticeServiceNetworkServiceAssociations.IDataAwsVpclatticeServiceNetworkServiceAssociationsItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
