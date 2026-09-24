using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FunctionsFunction
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.functionsFunction.FunctionsFunctionSourceDetailsArchiveSourceDetails")]
    public class FunctionsFunctionSourceDetailsArchiveSourceDetails : oci.FunctionsFunction.IFunctionsFunctionSourceDetailsArchiveSourceDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#archive_source_type FunctionsFunction#archive_source_type}.</summary>
        [JsiiProperty(name: "archiveSourceType", typeJson: "{\"primitive\":\"string\"}")]
        public string ArchiveSourceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#archive_file FunctionsFunction#archive_file}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "archiveFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ArchiveFile
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#bucket FunctionsFunction#bucket}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#namespace FunctionsFunction#namespace}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Namespace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#object FunctionsFunction#object}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Object
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#object_version_id FunctionsFunction#object_version_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "objectVersionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ObjectVersionId
        {
            get;
            set;
        }
    }
}
