using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskReplicator
{
    [JsiiClass(nativeType: typeof(aws.MskReplicator.MskReplicatorKafkaClusterApacheKafkaClusterOutputReference), fullyQualifiedName: "aws.mskReplicator.MskReplicatorKafkaClusterApacheKafkaClusterOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MskReplicatorKafkaClusterApacheKafkaClusterOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MskReplicatorKafkaClusterApacheKafkaClusterOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MskReplicatorKafkaClusterApacheKafkaClusterOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskReplicatorKafkaClusterApacheKafkaClusterOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "apacheKafkaClusterIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApacheKafkaClusterIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bootstrapBrokerStringInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BootstrapBrokerStringInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "apacheKafkaClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApacheKafkaClusterId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bootstrapBrokerString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootstrapBrokerString
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterApacheKafkaCluster\"}", isOptional: true)]
        public virtual aws.MskReplicator.IMskReplicatorKafkaClusterApacheKafkaCluster? InternalValue
        {
            get => GetInstanceProperty<aws.MskReplicator.IMskReplicatorKafkaClusterApacheKafkaCluster?>();
            set => SetInstanceProperty(value);
        }
    }
}
