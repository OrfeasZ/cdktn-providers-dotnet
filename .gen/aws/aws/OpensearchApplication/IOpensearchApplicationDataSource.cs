using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchApplication
{
    [JsiiInterface(nativeType: typeof(IOpensearchApplicationDataSource), fullyQualifiedName: "aws.opensearchApplication.OpensearchApplicationDataSource")]
    public interface IOpensearchApplicationDataSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/opensearch_application#data_source_arn OpensearchApplication#data_source_arn}.</summary>
        [JsiiProperty(name: "dataSourceArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DataSourceArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/opensearch_application#data_source_description OpensearchApplication#data_source_description}.</summary>
        [JsiiProperty(name: "dataSourceDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DataSourceDescription
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchApplicationDataSource), fullyQualifiedName: "aws.opensearchApplication.OpensearchApplicationDataSource")]
        internal sealed class _Proxy : DeputyBase, aws.OpensearchApplication.IOpensearchApplicationDataSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/opensearch_application#data_source_arn OpensearchApplication#data_source_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataSourceArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DataSourceArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/opensearch_application#data_source_description OpensearchApplication#data_source_description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataSourceDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DataSourceDescription
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
