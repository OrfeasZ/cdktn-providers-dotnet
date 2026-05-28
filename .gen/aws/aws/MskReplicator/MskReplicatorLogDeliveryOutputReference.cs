using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskReplicator
{
    [JsiiClass(nativeType: typeof(aws.MskReplicator.MskReplicatorLogDeliveryOutputReference), fullyQualifiedName: "aws.mskReplicator.MskReplicatorLogDeliveryOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MskReplicatorLogDeliveryOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MskReplicatorLogDeliveryOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MskReplicatorLogDeliveryOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskReplicatorLogDeliveryOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putReplicatorLogDelivery", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskReplicator.MskReplicatorLogDeliveryReplicatorLogDelivery\"}}]")]
        public virtual void PutReplicatorLogDelivery(aws.MskReplicator.IMskReplicatorLogDeliveryReplicatorLogDelivery @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskReplicator.IMskReplicatorLogDeliveryReplicatorLogDelivery)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetReplicatorLogDelivery")]
        public virtual void ResetReplicatorLogDelivery()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "replicatorLogDelivery", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorLogDeliveryReplicatorLogDeliveryOutputReference\"}")]
        public virtual aws.MskReplicator.MskReplicatorLogDeliveryReplicatorLogDeliveryOutputReference ReplicatorLogDelivery
        {
            get => GetInstanceProperty<aws.MskReplicator.MskReplicatorLogDeliveryReplicatorLogDeliveryOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicatorLogDeliveryInput", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorLogDeliveryReplicatorLogDelivery\"}", isOptional: true)]
        public virtual aws.MskReplicator.IMskReplicatorLogDeliveryReplicatorLogDelivery? ReplicatorLogDeliveryInput
        {
            get => GetInstanceProperty<aws.MskReplicator.IMskReplicatorLogDeliveryReplicatorLogDelivery?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorLogDelivery\"}", isOptional: true)]
        public virtual aws.MskReplicator.IMskReplicatorLogDelivery? InternalValue
        {
            get => GetInstanceProperty<aws.MskReplicator.IMskReplicatorLogDelivery?>();
            set => SetInstanceProperty(value);
        }
    }
}
