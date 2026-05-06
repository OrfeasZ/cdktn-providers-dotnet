using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsJavaDownloadsJavaLicenseAcceptanceRecord
{
    [JsiiByValue(fqn: "oci.jmsJavaDownloadsJavaLicenseAcceptanceRecord.JmsJavaDownloadsJavaLicenseAcceptanceRecordTimeouts")]
    public class JmsJavaDownloadsJavaLicenseAcceptanceRecordTimeouts : oci.JmsJavaDownloadsJavaLicenseAcceptanceRecord.IJmsJavaDownloadsJavaLicenseAcceptanceRecordTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_java_downloads_java_license_acceptance_record#create JmsJavaDownloadsJavaLicenseAcceptanceRecord#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_java_downloads_java_license_acceptance_record#delete JmsJavaDownloadsJavaLicenseAcceptanceRecord#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_java_downloads_java_license_acceptance_record#update JmsJavaDownloadsJavaLicenseAcceptanceRecord#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
