using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FunctionsFunction
{
    [JsiiInterface(nativeType: typeof(IFunctionsFunctionSourceDetailsArchiveSourceDetails), fullyQualifiedName: "oci.functionsFunction.FunctionsFunctionSourceDetailsArchiveSourceDetails")]
    public interface IFunctionsFunctionSourceDetailsArchiveSourceDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#archive_source_type FunctionsFunction#archive_source_type}.</summary>
        [JsiiProperty(name: "archiveSourceType", typeJson: "{\"primitive\":\"string\"}")]
        string ArchiveSourceType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#archive_file FunctionsFunction#archive_file}.</summary>
        [JsiiProperty(name: "archiveFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ArchiveFile
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#bucket FunctionsFunction#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Bucket
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#namespace FunctionsFunction#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Namespace
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#object FunctionsFunction#object}.</summary>
        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Object
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#object_version_id FunctionsFunction#object_version_id}.</summary>
        [JsiiProperty(name: "objectVersionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ObjectVersionId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFunctionsFunctionSourceDetailsArchiveSourceDetails), fullyQualifiedName: "oci.functionsFunction.FunctionsFunctionSourceDetailsArchiveSourceDetails")]
        internal sealed class _Proxy : DeputyBase, oci.FunctionsFunction.IFunctionsFunctionSourceDetailsArchiveSourceDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#archive_source_type FunctionsFunction#archive_source_type}.</summary>
            [JsiiProperty(name: "archiveSourceType", typeJson: "{\"primitive\":\"string\"}")]
            public string ArchiveSourceType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#archive_file FunctionsFunction#archive_file}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "archiveFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ArchiveFile
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#bucket FunctionsFunction#bucket}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Bucket
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#namespace FunctionsFunction#namespace}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Namespace
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#object FunctionsFunction#object}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Object
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#object_version_id FunctionsFunction#object_version_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "objectVersionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ObjectVersionId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
