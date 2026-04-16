using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpcEncryptionControl
{
    [JsiiClass(nativeType: typeof(aws.VpcEncryptionControl.VpcEncryptionControlResourceExclusionsOutputReference), fullyQualifiedName: "aws.vpcEncryptionControl.VpcEncryptionControlResourceExclusionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class VpcEncryptionControlResourceExclusionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public VpcEncryptionControlResourceExclusionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpcEncryptionControlResourceExclusionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpcEncryptionControlResourceExclusionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "egressOnlyInternetGateway", typeJson: "{\"fqn\":\"aws.vpcEncryptionControl.VpcEncryptionControlResourceExclusionsEgressOnlyInternetGatewayOutputReference\"}")]
        public virtual aws.VpcEncryptionControl.VpcEncryptionControlResourceExclusionsEgressOnlyInternetGatewayOutputReference EgressOnlyInternetGateway
        {
            get => GetInstanceProperty<aws.VpcEncryptionControl.VpcEncryptionControlResourceExclusionsEgressOnlyInternetGatewayOutputReference>()!;
        }

        [JsiiProperty(name: "elasticFileSystem", typeJson: "{\"fqn\":\"aws.vpcEncryptionControl.VpcEncryptionControlResourceExclusionsElasticFileSystemOutputReference\"}")]
        public virtual aws.VpcEncryptionControl.VpcEncryptionControlResourceExclusionsElasticFileSystemOutputReference ElasticFileSystem
        {
            get => GetInstanceProperty<aws.VpcEncryptionControl.VpcEncryptionControlResourceExclusionsElasticFileSystemOutputReference>()!;
        }

        [JsiiProperty(name: "internetGateway", typeJson: "{\"fqn\":\"aws.vpcEncryptionControl.VpcEncryptionControlResourceExclusionsInternetGatewayOutputReference\"}")]
        public virtual aws.VpcEncryptionControl.VpcEncryptionControlResourceExclusionsInternetGatewayOutputReference InternetGateway
        {
            get => GetInstanceProperty<aws.VpcEncryptionControl.VpcEncryptionControlResourceExclusionsInternetGatewayOutputReference>()!;
        }

        [JsiiProperty(name: "lambda", typeJson: "{\"fqn\":\"aws.vpcEncryptionControl.VpcEncryptionControlResourceExclusionsLambdaOutputReference\"}")]
        public virtual aws.VpcEncryptionControl.VpcEncryptionControlResourceExclusionsLambdaOutputReference Lambda
        {
            get => GetInstanceProperty<aws.VpcEncryptionControl.VpcEncryptionControlResourceExclusionsLambdaOutputReference>()!;
        }

        [JsiiProperty(name: "natGateway", typeJson: "{\"fqn\":\"aws.vpcEncryptionControl.VpcEncryptionControlResourceExclusionsNatGatewayOutputReference\"}")]
        public virtual aws.VpcEncryptionControl.VpcEncryptionControlResourceExclusionsNatGatewayOutputReference NatGateway
        {
            get => GetInstanceProperty<aws.VpcEncryptionControl.VpcEncryptionControlResourceExclusionsNatGatewayOutputReference>()!;
        }

        [JsiiProperty(name: "virtualPrivateGateway", typeJson: "{\"fqn\":\"aws.vpcEncryptionControl.VpcEncryptionControlResourceExclusionsVirtualPrivateGatewayOutputReference\"}")]
        public virtual aws.VpcEncryptionControl.VpcEncryptionControlResourceExclusionsVirtualPrivateGatewayOutputReference VirtualPrivateGateway
        {
            get => GetInstanceProperty<aws.VpcEncryptionControl.VpcEncryptionControlResourceExclusionsVirtualPrivateGatewayOutputReference>()!;
        }

        [JsiiProperty(name: "vpcLattice", typeJson: "{\"fqn\":\"aws.vpcEncryptionControl.VpcEncryptionControlResourceExclusionsVpcLatticeOutputReference\"}")]
        public virtual aws.VpcEncryptionControl.VpcEncryptionControlResourceExclusionsVpcLatticeOutputReference VpcLattice
        {
            get => GetInstanceProperty<aws.VpcEncryptionControl.VpcEncryptionControlResourceExclusionsVpcLatticeOutputReference>()!;
        }

        [JsiiProperty(name: "vpcPeering", typeJson: "{\"fqn\":\"aws.vpcEncryptionControl.VpcEncryptionControlResourceExclusionsVpcPeeringOutputReference\"}")]
        public virtual aws.VpcEncryptionControl.VpcEncryptionControlResourceExclusionsVpcPeeringOutputReference VpcPeering
        {
            get => GetInstanceProperty<aws.VpcEncryptionControl.VpcEncryptionControlResourceExclusionsVpcPeeringOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.vpcEncryptionControl.VpcEncryptionControlResourceExclusions\"}", isOptional: true)]
        public virtual aws.VpcEncryptionControl.IVpcEncryptionControlResourceExclusions? InternalValue
        {
            get => GetInstanceProperty<aws.VpcEncryptionControl.IVpcEncryptionControlResourceExclusions?>();
            set => SetInstanceProperty(value);
        }
    }
}
