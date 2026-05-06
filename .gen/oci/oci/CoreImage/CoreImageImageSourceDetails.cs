using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreImage
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreImage.CoreImageImageSourceDetails")]
    public class CoreImageImageSourceDetails : oci.CoreImage.ICoreImageImageSourceDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_image#source_type CoreImage#source_type}.</summary>
        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_image#bucket_name CoreImage#bucket_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BucketName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_image#namespace_name CoreImage#namespace_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "namespaceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NamespaceName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_image#object_name CoreImage#object_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "objectName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ObjectName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_image#operating_system CoreImage#operating_system}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "operatingSystem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OperatingSystem
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_image#operating_system_version CoreImage#operating_system_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "operatingSystemVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OperatingSystemVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_image#source_image_type CoreImage#source_image_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceImageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceImageType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_image#source_uri CoreImage#source_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceUri
        {
            get;
            set;
        }
    }
}
