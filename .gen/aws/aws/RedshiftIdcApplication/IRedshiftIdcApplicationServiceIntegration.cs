using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RedshiftIdcApplication
{
    [JsiiInterface(nativeType: typeof(IRedshiftIdcApplicationServiceIntegration), fullyQualifiedName: "aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegration")]
    public interface IRedshiftIdcApplicationServiceIntegration
    {
        /// <summary>lake_formation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/redshift_idc_application#lake_formation RedshiftIdcApplication#lake_formation}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegrationLakeFormation" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "lakeFormation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationLakeFormation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LakeFormation
        {
            get
            {
                return null;
            }
        }

        /// <summary>redshift block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/redshift_idc_application#redshift RedshiftIdcApplication#redshift}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegrationRedshift" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "redshift", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationRedshift\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Redshift
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3_access_grants block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/redshift_idc_application#s3_access_grants RedshiftIdcApplication#s3_access_grants}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegrationS3AccessGrants" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "s3AccessGrants", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationS3AccessGrants\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? S3AccessGrants
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRedshiftIdcApplicationServiceIntegration), fullyQualifiedName: "aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegration")]
        internal sealed class _Proxy : DeputyBase, aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>lake_formation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/redshift_idc_application#lake_formation RedshiftIdcApplication#lake_formation}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegrationLakeFormation" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lakeFormation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationLakeFormation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LakeFormation
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>redshift block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/redshift_idc_application#redshift RedshiftIdcApplication#redshift}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegrationRedshift" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redshift", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationRedshift\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Redshift
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>s3_access_grants block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/redshift_idc_application#s3_access_grants RedshiftIdcApplication#s3_access_grants}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegrationS3AccessGrants" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3AccessGrants", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationS3AccessGrants\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? S3AccessGrants
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
