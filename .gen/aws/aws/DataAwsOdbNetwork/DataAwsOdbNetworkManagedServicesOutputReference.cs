using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsOdbNetwork
{
    [JsiiClass(nativeType: typeof(aws.DataAwsOdbNetwork.DataAwsOdbNetworkManagedServicesOutputReference), fullyQualifiedName: "aws.dataAwsOdbNetwork.DataAwsOdbNetworkManagedServicesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsOdbNetworkManagedServicesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsOdbNetworkManagedServicesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsOdbNetworkManagedServicesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsOdbNetworkManagedServicesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "crossRegionS3RestoreSourcesAccess", typeJson: "{\"fqn\":\"aws.dataAwsOdbNetwork.DataAwsOdbNetworkManagedServicesCrossRegionS3RestoreSourcesAccessList\"}")]
        public virtual aws.DataAwsOdbNetwork.DataAwsOdbNetworkManagedServicesCrossRegionS3RestoreSourcesAccessList CrossRegionS3RestoreSourcesAccess
        {
            get => GetInstanceProperty<aws.DataAwsOdbNetwork.DataAwsOdbNetworkManagedServicesCrossRegionS3RestoreSourcesAccessList>()!;
        }

        [JsiiProperty(name: "kmsAccess", typeJson: "{\"fqn\":\"aws.dataAwsOdbNetwork.DataAwsOdbNetworkManagedServicesKmsAccessList\"}")]
        public virtual aws.DataAwsOdbNetwork.DataAwsOdbNetworkManagedServicesKmsAccessList KmsAccess
        {
            get => GetInstanceProperty<aws.DataAwsOdbNetwork.DataAwsOdbNetworkManagedServicesKmsAccessList>()!;
        }

        [JsiiProperty(name: "managedS3BackupAccess", typeJson: "{\"fqn\":\"aws.dataAwsOdbNetwork.DataAwsOdbNetworkManagedServicesManagedS3BackupAccessList\"}")]
        public virtual aws.DataAwsOdbNetwork.DataAwsOdbNetworkManagedServicesManagedS3BackupAccessList ManagedS3BackupAccess
        {
            get => GetInstanceProperty<aws.DataAwsOdbNetwork.DataAwsOdbNetworkManagedServicesManagedS3BackupAccessList>()!;
        }

        [JsiiProperty(name: "managedServiceIpv4Cidrs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ManagedServiceIpv4Cidrs
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "resourceGatewayArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGatewayArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "s3Access", typeJson: "{\"fqn\":\"aws.dataAwsOdbNetwork.DataAwsOdbNetworkManagedServicesS3AccessList\"}")]
        public virtual aws.DataAwsOdbNetwork.DataAwsOdbNetworkManagedServicesS3AccessList S3Access
        {
            get => GetInstanceProperty<aws.DataAwsOdbNetwork.DataAwsOdbNetworkManagedServicesS3AccessList>()!;
        }

        [JsiiProperty(name: "serviceNetworkArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceNetworkArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceNetworkEndpoint", typeJson: "{\"fqn\":\"aws.dataAwsOdbNetwork.DataAwsOdbNetworkManagedServicesServiceNetworkEndpointList\"}")]
        public virtual aws.DataAwsOdbNetwork.DataAwsOdbNetworkManagedServicesServiceNetworkEndpointList ServiceNetworkEndpoint
        {
            get => GetInstanceProperty<aws.DataAwsOdbNetwork.DataAwsOdbNetworkManagedServicesServiceNetworkEndpointList>()!;
        }

        [JsiiProperty(name: "stsAccess", typeJson: "{\"fqn\":\"aws.dataAwsOdbNetwork.DataAwsOdbNetworkManagedServicesStsAccessList\"}")]
        public virtual aws.DataAwsOdbNetwork.DataAwsOdbNetworkManagedServicesStsAccessList StsAccess
        {
            get => GetInstanceProperty<aws.DataAwsOdbNetwork.DataAwsOdbNetworkManagedServicesStsAccessList>()!;
        }

        [JsiiProperty(name: "zeroTlAccess", typeJson: "{\"fqn\":\"aws.dataAwsOdbNetwork.DataAwsOdbNetworkManagedServicesZeroTlAccessList\"}")]
        public virtual aws.DataAwsOdbNetwork.DataAwsOdbNetworkManagedServicesZeroTlAccessList ZeroTlAccess
        {
            get => GetInstanceProperty<aws.DataAwsOdbNetwork.DataAwsOdbNetworkManagedServicesZeroTlAccessList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsOdbNetwork.DataAwsOdbNetworkManagedServices\"}", isOptional: true)]
        public virtual aws.DataAwsOdbNetwork.IDataAwsOdbNetworkManagedServices? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsOdbNetwork.IDataAwsOdbNetworkManagedServices?>();
            set => SetInstanceProperty(value);
        }
    }
}
