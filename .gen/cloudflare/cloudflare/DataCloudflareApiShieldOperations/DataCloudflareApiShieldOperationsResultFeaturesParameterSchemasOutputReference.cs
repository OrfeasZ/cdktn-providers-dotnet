using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareApiShieldOperations
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareApiShieldOperations.DataCloudflareApiShieldOperationsResultFeaturesParameterSchemasOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareApiShieldOperations.DataCloudflareApiShieldOperationsResultFeaturesParameterSchemasOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareApiShieldOperationsResultFeaturesParameterSchemasOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareApiShieldOperationsResultFeaturesParameterSchemasOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareApiShieldOperationsResultFeaturesParameterSchemasOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareApiShieldOperationsResultFeaturesParameterSchemasOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "lastUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parameterSchemas", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareApiShieldOperations.DataCloudflareApiShieldOperationsResultFeaturesParameterSchemasParameterSchemasOutputReference\"}")]
        public virtual cloudflare.DataCloudflareApiShieldOperations.DataCloudflareApiShieldOperationsResultFeaturesParameterSchemasParameterSchemasOutputReference ParameterSchemas
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareApiShieldOperations.DataCloudflareApiShieldOperationsResultFeaturesParameterSchemasParameterSchemasOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareApiShieldOperations.DataCloudflareApiShieldOperationsResultFeaturesParameterSchemas\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareApiShieldOperations.IDataCloudflareApiShieldOperationsResultFeaturesParameterSchemas? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareApiShieldOperations.IDataCloudflareApiShieldOperationsResultFeaturesParameterSchemas?>();
            set => SetInstanceProperty(value);
        }
    }
}
