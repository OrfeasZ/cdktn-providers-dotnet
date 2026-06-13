using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ApiShieldOperation
{
    [JsiiClass(nativeType: typeof(cloudflare.ApiShieldOperation.ApiShieldOperationSchemasOutputReference), fullyQualifiedName: "cloudflare.apiShieldOperation.ApiShieldOperationSchemasOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApiShieldOperationSchemasOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApiShieldOperationSchemasOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApiShieldOperationSchemasOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiShieldOperationSchemasOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "learned", typeJson: "{\"fqn\":\"cloudflare.apiShieldOperation.ApiShieldOperationSchemasLearnedOutputReference\"}")]
        public virtual cloudflare.ApiShieldOperation.ApiShieldOperationSchemasLearnedOutputReference Learned
        {
            get => GetInstanceProperty<cloudflare.ApiShieldOperation.ApiShieldOperationSchemasLearnedOutputReference>()!;
        }

        [JsiiProperty(name: "uploaded", typeJson: "{\"fqn\":\"cloudflare.apiShieldOperation.ApiShieldOperationSchemasUploadedOutputReference\"}")]
        public virtual cloudflare.ApiShieldOperation.ApiShieldOperationSchemasUploadedOutputReference Uploaded
        {
            get => GetInstanceProperty<cloudflare.ApiShieldOperation.ApiShieldOperationSchemasUploadedOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.apiShieldOperation.ApiShieldOperationSchemas\"}", isOptional: true)]
        public virtual cloudflare.ApiShieldOperation.IApiShieldOperationSchemas? InternalValue
        {
            get => GetInstanceProperty<cloudflare.ApiShieldOperation.IApiShieldOperationSchemas?>();
            set => SetInstanceProperty(value);
        }
    }
}
