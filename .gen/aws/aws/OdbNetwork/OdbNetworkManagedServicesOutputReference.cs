using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbNetwork
{
    [JsiiClass(nativeType: typeof(aws.OdbNetwork.OdbNetworkManagedServicesOutputReference), fullyQualifiedName: "aws.odbNetwork.OdbNetworkManagedServicesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class OdbNetworkManagedServicesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public OdbNetworkManagedServicesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected OdbNetworkManagedServicesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OdbNetworkManagedServicesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "crossRegionS3RestoreSourcesAccess", typeJson: "{\"fqn\":\"aws.odbNetwork.OdbNetworkManagedServicesCrossRegionS3RestoreSourcesAccessList\"}")]
        public virtual aws.OdbNetwork.OdbNetworkManagedServicesCrossRegionS3RestoreSourcesAccessList CrossRegionS3RestoreSourcesAccess
        {
            get => GetInstanceProperty<aws.OdbNetwork.OdbNetworkManagedServicesCrossRegionS3RestoreSourcesAccessList>()!;
        }

        [JsiiProperty(name: "kmsAccess", typeJson: "{\"fqn\":\"aws.odbNetwork.OdbNetworkManagedServicesKmsAccessList\"}")]
        public virtual aws.OdbNetwork.OdbNetworkManagedServicesKmsAccessList KmsAccess
        {
            get => GetInstanceProperty<aws.OdbNetwork.OdbNetworkManagedServicesKmsAccessList>()!;
        }

        [JsiiProperty(name: "managedS3BackupAccess", typeJson: "{\"fqn\":\"aws.odbNetwork.OdbNetworkManagedServicesManagedS3BackupAccessList\"}")]
        public virtual aws.OdbNetwork.OdbNetworkManagedServicesManagedS3BackupAccessList ManagedS3BackupAccess
        {
            get => GetInstanceProperty<aws.OdbNetwork.OdbNetworkManagedServicesManagedS3BackupAccessList>()!;
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

        [JsiiProperty(name: "s3Access", typeJson: "{\"fqn\":\"aws.odbNetwork.OdbNetworkManagedServicesS3AccessList\"}")]
        public virtual aws.OdbNetwork.OdbNetworkManagedServicesS3AccessList S3Access
        {
            get => GetInstanceProperty<aws.OdbNetwork.OdbNetworkManagedServicesS3AccessList>()!;
        }

        [JsiiProperty(name: "serviceNetworkArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceNetworkArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceNetworkEndpoint", typeJson: "{\"fqn\":\"aws.odbNetwork.OdbNetworkManagedServicesServiceNetworkEndpointList\"}")]
        public virtual aws.OdbNetwork.OdbNetworkManagedServicesServiceNetworkEndpointList ServiceNetworkEndpoint
        {
            get => GetInstanceProperty<aws.OdbNetwork.OdbNetworkManagedServicesServiceNetworkEndpointList>()!;
        }

        [JsiiProperty(name: "stsAccess", typeJson: "{\"fqn\":\"aws.odbNetwork.OdbNetworkManagedServicesStsAccessList\"}")]
        public virtual aws.OdbNetwork.OdbNetworkManagedServicesStsAccessList StsAccess
        {
            get => GetInstanceProperty<aws.OdbNetwork.OdbNetworkManagedServicesStsAccessList>()!;
        }

        [JsiiProperty(name: "zeroEtlAccess", typeJson: "{\"fqn\":\"aws.odbNetwork.OdbNetworkManagedServicesZeroEtlAccessList\"}")]
        public virtual aws.OdbNetwork.OdbNetworkManagedServicesZeroEtlAccessList ZeroEtlAccess
        {
            get => GetInstanceProperty<aws.OdbNetwork.OdbNetworkManagedServicesZeroEtlAccessList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.odbNetwork.OdbNetworkManagedServices\"}", isOptional: true)]
        public virtual aws.OdbNetwork.IOdbNetworkManagedServices? InternalValue
        {
            get => GetInstanceProperty<aws.OdbNetwork.IOdbNetworkManagedServices?>();
            set => SetInstanceProperty(value);
        }
    }
}
