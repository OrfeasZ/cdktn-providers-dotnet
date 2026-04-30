using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RedshiftIdcApplication
{
    [JsiiInterface(nativeType: typeof(IRedshiftIdcApplicationServiceIntegrationRedshift), fullyQualifiedName: "aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationRedshift")]
    public interface IRedshiftIdcApplicationServiceIntegrationRedshift
    {
        /// <summary>connect block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/redshift_idc_application#connect RedshiftIdcApplication#connect}
        /// </remarks>
        [JsiiProperty(name: "connect", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationRedshiftConnect\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Connect
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRedshiftIdcApplicationServiceIntegrationRedshift), fullyQualifiedName: "aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationRedshift")]
        internal sealed class _Proxy : DeputyBase, aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegrationRedshift
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>connect block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/redshift_idc_application#connect RedshiftIdcApplication#connect}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connect", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationRedshiftConnect\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Connect
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
