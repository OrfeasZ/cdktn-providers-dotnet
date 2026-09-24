using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FunctionsFunction
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.functionsFunction.FunctionsFunctionSourceDetails")]
    public class FunctionsFunctionSourceDetails : oci.FunctionsFunction.IFunctionsFunctionSourceDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#source_type FunctionsFunction#source_type}.</summary>
        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceType
        {
            get;
            set;
        }

        /// <summary>archive_source_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#archive_source_details FunctionsFunction#archive_source_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "archiveSourceDetails", typeJson: "{\"fqn\":\"oci.functionsFunction.FunctionsFunctionSourceDetailsArchiveSourceDetails\"}", isOptional: true)]
        public oci.FunctionsFunction.IFunctionsFunctionSourceDetailsArchiveSourceDetails? ArchiveSourceDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#handler FunctionsFunction#handler}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "handler", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Handler
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#image FunctionsFunction#image}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Image
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#image_digest FunctionsFunction#image_digest}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "imageDigest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ImageDigest
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#pbf_listing_id FunctionsFunction#pbf_listing_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pbfListingId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PbfListingId
        {
            get;
            set;
        }

        /// <summary>runtime_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#runtime_config FunctionsFunction#runtime_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "runtimeConfig", typeJson: "{\"fqn\":\"oci.functionsFunction.FunctionsFunctionSourceDetailsRuntimeConfig\"}", isOptional: true)]
        public oci.FunctionsFunction.IFunctionsFunctionSourceDetailsRuntimeConfig? RuntimeConfig
        {
            get;
            set;
        }
    }
}
