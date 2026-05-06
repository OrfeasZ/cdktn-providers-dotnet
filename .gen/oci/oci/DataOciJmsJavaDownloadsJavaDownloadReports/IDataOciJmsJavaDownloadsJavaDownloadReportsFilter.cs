using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciJmsJavaDownloadsJavaDownloadReports
{
    [JsiiInterface(nativeType: typeof(IDataOciJmsJavaDownloadsJavaDownloadReportsFilter), fullyQualifiedName: "oci.dataOciJmsJavaDownloadsJavaDownloadReports.DataOciJmsJavaDownloadsJavaDownloadReportsFilter")]
    public interface IDataOciJmsJavaDownloadsJavaDownloadReportsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_java_downloads_java_download_reports#name DataOciJmsJavaDownloadsJavaDownloadReports#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_java_downloads_java_download_reports#values DataOciJmsJavaDownloadsJavaDownloadReports#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_java_downloads_java_download_reports#regex DataOciJmsJavaDownloadsJavaDownloadReports#regex}.</summary>
        [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Regex
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciJmsJavaDownloadsJavaDownloadReportsFilter), fullyQualifiedName: "oci.dataOciJmsJavaDownloadsJavaDownloadReports.DataOciJmsJavaDownloadsJavaDownloadReportsFilter")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciJmsJavaDownloadsJavaDownloadReports.IDataOciJmsJavaDownloadsJavaDownloadReportsFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_java_downloads_java_download_reports#name DataOciJmsJavaDownloadsJavaDownloadReports#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_java_downloads_java_download_reports#values DataOciJmsJavaDownloadsJavaDownloadReports#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_java_downloads_java_download_reports#regex DataOciJmsJavaDownloadsJavaDownloadReports#regex}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Regex
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
