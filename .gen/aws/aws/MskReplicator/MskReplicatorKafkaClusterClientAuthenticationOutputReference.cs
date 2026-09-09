using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskReplicator
{
    [JsiiClass(nativeType: typeof(aws.MskReplicator.MskReplicatorKafkaClusterClientAuthenticationOutputReference), fullyQualifiedName: "aws.mskReplicator.MskReplicatorKafkaClusterClientAuthenticationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MskReplicatorKafkaClusterClientAuthenticationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MskReplicatorKafkaClusterClientAuthenticationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MskReplicatorKafkaClusterClientAuthenticationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskReplicatorKafkaClusterClientAuthenticationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putMtls", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterClientAuthenticationMtls\"}}]")]
        public virtual void PutMtls(aws.MskReplicator.IMskReplicatorKafkaClusterClientAuthenticationMtls @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskReplicator.IMskReplicatorKafkaClusterClientAuthenticationMtls)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSaslScram", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterClientAuthenticationSaslScram\"}}]")]
        public virtual void PutSaslScram(aws.MskReplicator.IMskReplicatorKafkaClusterClientAuthenticationSaslScram @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskReplicator.IMskReplicatorKafkaClusterClientAuthenticationSaslScram)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMtls")]
        public virtual void ResetMtls()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSaslScram")]
        public virtual void ResetSaslScram()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "mtls", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterClientAuthenticationMtlsOutputReference\"}")]
        public virtual aws.MskReplicator.MskReplicatorKafkaClusterClientAuthenticationMtlsOutputReference Mtls
        {
            get => GetInstanceProperty<aws.MskReplicator.MskReplicatorKafkaClusterClientAuthenticationMtlsOutputReference>()!;
        }

        [JsiiProperty(name: "saslScram", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterClientAuthenticationSaslScramOutputReference\"}")]
        public virtual aws.MskReplicator.MskReplicatorKafkaClusterClientAuthenticationSaslScramOutputReference SaslScram
        {
            get => GetInstanceProperty<aws.MskReplicator.MskReplicatorKafkaClusterClientAuthenticationSaslScramOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "mtlsInput", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterClientAuthenticationMtls\"}", isOptional: true)]
        public virtual aws.MskReplicator.IMskReplicatorKafkaClusterClientAuthenticationMtls? MtlsInput
        {
            get => GetInstanceProperty<aws.MskReplicator.IMskReplicatorKafkaClusterClientAuthenticationMtls?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "saslScramInput", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterClientAuthenticationSaslScram\"}", isOptional: true)]
        public virtual aws.MskReplicator.IMskReplicatorKafkaClusterClientAuthenticationSaslScram? SaslScramInput
        {
            get => GetInstanceProperty<aws.MskReplicator.IMskReplicatorKafkaClusterClientAuthenticationSaslScram?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterClientAuthentication\"}", isOptional: true)]
        public virtual aws.MskReplicator.IMskReplicatorKafkaClusterClientAuthentication? InternalValue
        {
            get => GetInstanceProperty<aws.MskReplicator.IMskReplicatorKafkaClusterClientAuthentication?>();
            set => SetInstanceProperty(value);
        }
    }
}
