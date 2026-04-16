using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareApiShieldOperation
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareApiShieldOperation.DataCloudflareApiShieldOperationFeaturesOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareApiShieldOperation.DataCloudflareApiShieldOperationFeaturesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareApiShieldOperationFeaturesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareApiShieldOperationFeaturesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareApiShieldOperationFeaturesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareApiShieldOperationFeaturesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "apiRouting", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareApiShieldOperation.DataCloudflareApiShieldOperationFeaturesApiRoutingOutputReference\"}")]
        public virtual cloudflare.DataCloudflareApiShieldOperation.DataCloudflareApiShieldOperationFeaturesApiRoutingOutputReference ApiRouting
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareApiShieldOperation.DataCloudflareApiShieldOperationFeaturesApiRoutingOutputReference>()!;
        }

        [JsiiProperty(name: "confidenceIntervals", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareApiShieldOperation.DataCloudflareApiShieldOperationFeaturesConfidenceIntervalsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareApiShieldOperation.DataCloudflareApiShieldOperationFeaturesConfidenceIntervalsOutputReference ConfidenceIntervals
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareApiShieldOperation.DataCloudflareApiShieldOperationFeaturesConfidenceIntervalsOutputReference>()!;
        }

        [JsiiProperty(name: "parameterSchemas", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareApiShieldOperation.DataCloudflareApiShieldOperationFeaturesParameterSchemasOutputReference\"}")]
        public virtual cloudflare.DataCloudflareApiShieldOperation.DataCloudflareApiShieldOperationFeaturesParameterSchemasOutputReference ParameterSchemas
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareApiShieldOperation.DataCloudflareApiShieldOperationFeaturesParameterSchemasOutputReference>()!;
        }

        [JsiiProperty(name: "schemaInfo", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareApiShieldOperation.DataCloudflareApiShieldOperationFeaturesSchemaInfoOutputReference\"}")]
        public virtual cloudflare.DataCloudflareApiShieldOperation.DataCloudflareApiShieldOperationFeaturesSchemaInfoOutputReference SchemaInfo
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareApiShieldOperation.DataCloudflareApiShieldOperationFeaturesSchemaInfoOutputReference>()!;
        }

        [JsiiProperty(name: "thresholds", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareApiShieldOperation.DataCloudflareApiShieldOperationFeaturesThresholdsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareApiShieldOperation.DataCloudflareApiShieldOperationFeaturesThresholdsOutputReference Thresholds
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareApiShieldOperation.DataCloudflareApiShieldOperationFeaturesThresholdsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareApiShieldOperation.DataCloudflareApiShieldOperationFeatures\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareApiShieldOperation.IDataCloudflareApiShieldOperationFeatures? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareApiShieldOperation.IDataCloudflareApiShieldOperationFeatures?>();
            set => SetInstanceProperty(value);
        }
    }
}
