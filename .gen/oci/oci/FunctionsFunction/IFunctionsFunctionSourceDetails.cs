using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FunctionsFunction
{
    [JsiiInterface(nativeType: typeof(IFunctionsFunctionSourceDetails), fullyQualifiedName: "oci.functionsFunction.FunctionsFunctionSourceDetails")]
    public interface IFunctionsFunctionSourceDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#source_type FunctionsFunction#source_type}.</summary>
        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
        string SourceType
        {
            get;
        }

        /// <summary>archive_source_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#archive_source_details FunctionsFunction#archive_source_details}
        /// </remarks>
        [JsiiProperty(name: "archiveSourceDetails", typeJson: "{\"fqn\":\"oci.functionsFunction.FunctionsFunctionSourceDetailsArchiveSourceDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.FunctionsFunction.IFunctionsFunctionSourceDetailsArchiveSourceDetails? ArchiveSourceDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#handler FunctionsFunction#handler}.</summary>
        [JsiiProperty(name: "handler", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Handler
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#image FunctionsFunction#image}.</summary>
        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Image
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#image_digest FunctionsFunction#image_digest}.</summary>
        [JsiiProperty(name: "imageDigest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ImageDigest
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#pbf_listing_id FunctionsFunction#pbf_listing_id}.</summary>
        [JsiiProperty(name: "pbfListingId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PbfListingId
        {
            get
            {
                return null;
            }
        }

        /// <summary>runtime_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#runtime_config FunctionsFunction#runtime_config}
        /// </remarks>
        [JsiiProperty(name: "runtimeConfig", typeJson: "{\"fqn\":\"oci.functionsFunction.FunctionsFunctionSourceDetailsRuntimeConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.FunctionsFunction.IFunctionsFunctionSourceDetailsRuntimeConfig? RuntimeConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFunctionsFunctionSourceDetails), fullyQualifiedName: "oci.functionsFunction.FunctionsFunctionSourceDetails")]
        internal sealed class _Proxy : DeputyBase, oci.FunctionsFunction.IFunctionsFunctionSourceDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#source_type FunctionsFunction#source_type}.</summary>
            [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>archive_source_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#archive_source_details FunctionsFunction#archive_source_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "archiveSourceDetails", typeJson: "{\"fqn\":\"oci.functionsFunction.FunctionsFunctionSourceDetailsArchiveSourceDetails\"}", isOptional: true)]
            public oci.FunctionsFunction.IFunctionsFunctionSourceDetailsArchiveSourceDetails? ArchiveSourceDetails
            {
                get => GetInstanceProperty<oci.FunctionsFunction.IFunctionsFunctionSourceDetailsArchiveSourceDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#handler FunctionsFunction#handler}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "handler", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Handler
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#image FunctionsFunction#image}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Image
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#image_digest FunctionsFunction#image_digest}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "imageDigest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ImageDigest
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#pbf_listing_id FunctionsFunction#pbf_listing_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pbfListingId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PbfListingId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>runtime_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#runtime_config FunctionsFunction#runtime_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "runtimeConfig", typeJson: "{\"fqn\":\"oci.functionsFunction.FunctionsFunctionSourceDetailsRuntimeConfig\"}", isOptional: true)]
            public oci.FunctionsFunction.IFunctionsFunctionSourceDetailsRuntimeConfig? RuntimeConfig
            {
                get => GetInstanceProperty<oci.FunctionsFunction.IFunctionsFunctionSourceDetailsRuntimeConfig?>();
            }
        }
    }
}
