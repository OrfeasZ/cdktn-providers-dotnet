using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsJavaDownloadsJavaLicenseAcceptanceRecord
{
    [JsiiInterface(nativeType: typeof(IJmsJavaDownloadsJavaLicenseAcceptanceRecordTimeouts), fullyQualifiedName: "oci.jmsJavaDownloadsJavaLicenseAcceptanceRecord.JmsJavaDownloadsJavaLicenseAcceptanceRecordTimeouts")]
    public interface IJmsJavaDownloadsJavaLicenseAcceptanceRecordTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_java_downloads_java_license_acceptance_record#create JmsJavaDownloadsJavaLicenseAcceptanceRecord#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_java_downloads_java_license_acceptance_record#delete JmsJavaDownloadsJavaLicenseAcceptanceRecord#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_java_downloads_java_license_acceptance_record#update JmsJavaDownloadsJavaLicenseAcceptanceRecord#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IJmsJavaDownloadsJavaLicenseAcceptanceRecordTimeouts), fullyQualifiedName: "oci.jmsJavaDownloadsJavaLicenseAcceptanceRecord.JmsJavaDownloadsJavaLicenseAcceptanceRecordTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.JmsJavaDownloadsJavaLicenseAcceptanceRecord.IJmsJavaDownloadsJavaLicenseAcceptanceRecordTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_java_downloads_java_license_acceptance_record#create JmsJavaDownloadsJavaLicenseAcceptanceRecord#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_java_downloads_java_license_acceptance_record#delete JmsJavaDownloadsJavaLicenseAcceptanceRecord#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_java_downloads_java_license_acceptance_record#update JmsJavaDownloadsJavaLicenseAcceptanceRecord#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
