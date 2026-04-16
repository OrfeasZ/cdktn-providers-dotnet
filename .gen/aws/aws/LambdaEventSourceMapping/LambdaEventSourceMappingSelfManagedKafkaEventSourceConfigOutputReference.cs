using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaEventSourceMapping
{
    [JsiiClass(nativeType: typeof(aws.LambdaEventSourceMapping.LambdaEventSourceMappingSelfManagedKafkaEventSourceConfigOutputReference), fullyQualifiedName: "aws.lambdaEventSourceMapping.LambdaEventSourceMappingSelfManagedKafkaEventSourceConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LambdaEventSourceMappingSelfManagedKafkaEventSourceConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LambdaEventSourceMappingSelfManagedKafkaEventSourceConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LambdaEventSourceMappingSelfManagedKafkaEventSourceConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaEventSourceMappingSelfManagedKafkaEventSourceConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSchemaRegistryConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdaEventSourceMapping.LambdaEventSourceMappingSelfManagedKafkaEventSourceConfigSchemaRegistryConfig\"}}]")]
        public virtual void PutSchemaRegistryConfig(aws.LambdaEventSourceMapping.ILambdaEventSourceMappingSelfManagedKafkaEventSourceConfigSchemaRegistryConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LambdaEventSourceMapping.ILambdaEventSourceMappingSelfManagedKafkaEventSourceConfigSchemaRegistryConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConsumerGroupId")]
        public virtual void ResetConsumerGroupId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchemaRegistryConfig")]
        public virtual void ResetSchemaRegistryConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "schemaRegistryConfig", typeJson: "{\"fqn\":\"aws.lambdaEventSourceMapping.LambdaEventSourceMappingSelfManagedKafkaEventSourceConfigSchemaRegistryConfigOutputReference\"}")]
        public virtual aws.LambdaEventSourceMapping.LambdaEventSourceMappingSelfManagedKafkaEventSourceConfigSchemaRegistryConfigOutputReference SchemaRegistryConfig
        {
            get => GetInstanceProperty<aws.LambdaEventSourceMapping.LambdaEventSourceMappingSelfManagedKafkaEventSourceConfigSchemaRegistryConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "consumerGroupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConsumerGroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemaRegistryConfigInput", typeJson: "{\"fqn\":\"aws.lambdaEventSourceMapping.LambdaEventSourceMappingSelfManagedKafkaEventSourceConfigSchemaRegistryConfig\"}", isOptional: true)]
        public virtual aws.LambdaEventSourceMapping.ILambdaEventSourceMappingSelfManagedKafkaEventSourceConfigSchemaRegistryConfig? SchemaRegistryConfigInput
        {
            get => GetInstanceProperty<aws.LambdaEventSourceMapping.ILambdaEventSourceMappingSelfManagedKafkaEventSourceConfigSchemaRegistryConfig?>();
        }

        [JsiiProperty(name: "consumerGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConsumerGroupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.lambdaEventSourceMapping.LambdaEventSourceMappingSelfManagedKafkaEventSourceConfig\"}", isOptional: true)]
        public virtual aws.LambdaEventSourceMapping.ILambdaEventSourceMappingSelfManagedKafkaEventSourceConfig? InternalValue
        {
            get => GetInstanceProperty<aws.LambdaEventSourceMapping.ILambdaEventSourceMappingSelfManagedKafkaEventSourceConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
