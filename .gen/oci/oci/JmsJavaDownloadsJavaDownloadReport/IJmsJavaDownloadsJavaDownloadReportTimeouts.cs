using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsJavaDownloadsJavaDownloadReport
{
    [JsiiInterface(nativeType: typeof(IJmsJavaDownloadsJavaDownloadReportTimeouts), fullyQualifiedName: "oci.jmsJavaDownloadsJavaDownloadReport.JmsJavaDownloadsJavaDownloadReportTimeouts")]
    public interface IJmsJavaDownloadsJavaDownloadReportTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_java_downloads_java_download_report#create JmsJavaDownloadsJavaDownloadReport#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_java_downloads_java_download_report#delete JmsJavaDownloadsJavaDownloadReport#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_java_downloads_java_download_report#update JmsJavaDownloadsJavaDownloadReport#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IJmsJavaDownloadsJavaDownloadReportTimeouts), fullyQualifiedName: "oci.jmsJavaDownloadsJavaDownloadReport.JmsJavaDownloadsJavaDownloadReportTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.JmsJavaDownloadsJavaDownloadReport.IJmsJavaDownloadsJavaDownloadReportTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_java_downloads_java_download_report#create JmsJavaDownloadsJavaDownloadReport#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_java_downloads_java_download_report#delete JmsJavaDownloadsJavaDownloadReport#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_java_downloads_java_download_report#update JmsJavaDownloadsJavaDownloadReport#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
