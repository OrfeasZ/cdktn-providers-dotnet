using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareSchemaValidationSchemas
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareSchemaValidationSchemasFilter), fullyQualifiedName: "cloudflare.dataCloudflareSchemaValidationSchemas.DataCloudflareSchemaValidationSchemasFilter")]
    public interface IDataCloudflareSchemaValidationSchemasFilter
    {
        /// <summary>Filter for enabled schemas.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/schema_validation_schemas#validation_enabled DataCloudflareSchemaValidationSchemas#validation_enabled}
        /// </remarks>
        [JsiiProperty(name: "validationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ValidationEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareSchemaValidationSchemasFilter), fullyQualifiedName: "cloudflare.dataCloudflareSchemaValidationSchemas.DataCloudflareSchemaValidationSchemasFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareSchemaValidationSchemas.IDataCloudflareSchemaValidationSchemasFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Filter for enabled schemas.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/schema_validation_schemas#validation_enabled DataCloudflareSchemaValidationSchemas#validation_enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "validationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ValidationEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
