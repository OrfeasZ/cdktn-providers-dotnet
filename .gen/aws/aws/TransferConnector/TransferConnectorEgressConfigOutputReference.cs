using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferConnector
{
    [JsiiClass(nativeType: typeof(aws.TransferConnector.TransferConnectorEgressConfigOutputReference), fullyQualifiedName: "aws.transferConnector.TransferConnectorEgressConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class TransferConnectorEgressConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public TransferConnectorEgressConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected TransferConnectorEgressConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TransferConnectorEgressConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putVpcLattice", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.transferConnector.TransferConnectorEgressConfigVpcLattice\"}}]")]
        public virtual void PutVpcLattice(aws.TransferConnector.ITransferConnectorEgressConfigVpcLattice @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.TransferConnector.ITransferConnectorEgressConfigVpcLattice)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetVpcLattice")]
        public virtual void ResetVpcLattice()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "vpcLattice", typeJson: "{\"fqn\":\"aws.transferConnector.TransferConnectorEgressConfigVpcLatticeOutputReference\"}")]
        public virtual aws.TransferConnector.TransferConnectorEgressConfigVpcLatticeOutputReference VpcLattice
        {
            get => GetInstanceProperty<aws.TransferConnector.TransferConnectorEgressConfigVpcLatticeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcLatticeInput", typeJson: "{\"fqn\":\"aws.transferConnector.TransferConnectorEgressConfigVpcLattice\"}", isOptional: true)]
        public virtual aws.TransferConnector.ITransferConnectorEgressConfigVpcLattice? VpcLatticeInput
        {
            get => GetInstanceProperty<aws.TransferConnector.ITransferConnectorEgressConfigVpcLattice?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.transferConnector.TransferConnectorEgressConfig\"}", isOptional: true)]
        public virtual aws.TransferConnector.ITransferConnectorEgressConfig? InternalValue
        {
            get => GetInstanceProperty<aws.TransferConnector.ITransferConnectorEgressConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
