using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsJavaDownloadsJavaDownloadToken
{
    [JsiiInterface(nativeType: typeof(IJmsJavaDownloadsJavaDownloadTokenTimeouts), fullyQualifiedName: "oci.jmsJavaDownloadsJavaDownloadToken.JmsJavaDownloadsJavaDownloadTokenTimeouts")]
    public interface IJmsJavaDownloadsJavaDownloadTokenTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_java_downloads_java_download_token#create JmsJavaDownloadsJavaDownloadToken#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_java_downloads_java_download_token#delete JmsJavaDownloadsJavaDownloadToken#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_java_downloads_java_download_token#update JmsJavaDownloadsJavaDownloadToken#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IJmsJavaDownloadsJavaDownloadTokenTimeouts), fullyQualifiedName: "oci.jmsJavaDownloadsJavaDownloadToken.JmsJavaDownloadsJavaDownloadTokenTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.JmsJavaDownloadsJavaDownloadToken.IJmsJavaDownloadsJavaDownloadTokenTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_java_downloads_java_download_token#create JmsJavaDownloadsJavaDownloadToken#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_java_downloads_java_download_token#delete JmsJavaDownloadsJavaDownloadToken#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_java_downloads_java_download_token#update JmsJavaDownloadsJavaDownloadToken#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
