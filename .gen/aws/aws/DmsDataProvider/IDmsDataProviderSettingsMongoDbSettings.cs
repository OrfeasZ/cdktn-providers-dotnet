using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DmsDataProvider
{
    [JsiiInterface(nativeType: typeof(IDmsDataProviderSettingsMongoDbSettings), fullyQualifiedName: "aws.dmsDataProvider.DmsDataProviderSettingsMongoDbSettings")]
    public interface IDmsDataProviderSettingsMongoDbSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#auth_mechanism DmsDataProvider#auth_mechanism}.</summary>
        [JsiiProperty(name: "authMechanism", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuthMechanism
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#auth_source DmsDataProvider#auth_source}.</summary>
        [JsiiProperty(name: "authSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuthSource
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#auth_type DmsDataProvider#auth_type}.</summary>
        [JsiiProperty(name: "authType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuthType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#certificate_arn DmsDataProvider#certificate_arn}.</summary>
        [JsiiProperty(name: "certificateArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#database_name DmsDataProvider#database_name}.</summary>
        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DatabaseName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#port DmsDataProvider#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Port
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#server_name DmsDataProvider#server_name}.</summary>
        [JsiiProperty(name: "serverName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServerName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#ssl_mode DmsDataProvider#ssl_mode}.</summary>
        [JsiiProperty(name: "sslMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SslMode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDmsDataProviderSettingsMongoDbSettings), fullyQualifiedName: "aws.dmsDataProvider.DmsDataProviderSettingsMongoDbSettings")]
        internal sealed class _Proxy : DeputyBase, aws.DmsDataProvider.IDmsDataProviderSettingsMongoDbSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#auth_mechanism DmsDataProvider#auth_mechanism}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authMechanism", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuthMechanism
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#auth_source DmsDataProvider#auth_source}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuthSource
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#auth_type DmsDataProvider#auth_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuthType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#certificate_arn DmsDataProvider#certificate_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#database_name DmsDataProvider#database_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DatabaseName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#port DmsDataProvider#port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#server_name DmsDataProvider#server_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serverName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServerName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#ssl_mode DmsDataProvider#ssl_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sslMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SslMode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
