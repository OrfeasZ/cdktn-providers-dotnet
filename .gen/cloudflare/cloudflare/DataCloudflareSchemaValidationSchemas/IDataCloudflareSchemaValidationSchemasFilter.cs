using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareSchemaValidationSchemas
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareSchemaValidationSchemasFilter), fullyQualifiedName: "cloudflare.dataCloudflareSchemaValidationSchemas.DataCloudflareSchemaValidationSchemasFilter")]
    public interface IDataCloudflareSchemaValidationSchemasFilter
    {
        /// <summary>Omit the source-files of schemas and only retrieve their meta-data.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/data-sources/schema_validation_schemas#omit_source DataCloudflareSchemaValidationSchemas#omit_source}
        /// </remarks>
        [JsiiProperty(name: "omitSource", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OmitSource
        {
            get
            {
                return null;
            }
        }

        /// <summary>Filter for enabled schemas.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/data-sources/schema_validation_schemas#validation_enabled DataCloudflareSchemaValidationSchemas#validation_enabled}
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

            /// <summary>Omit the source-files of schemas and only retrieve their meta-data.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/data-sources/schema_validation_schemas#omit_source DataCloudflareSchemaValidationSchemas#omit_source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "omitSource", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? OmitSource
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Filter for enabled schemas.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/data-sources/schema_validation_schemas#validation_enabled DataCloudflareSchemaValidationSchemas#validation_enabled}
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
