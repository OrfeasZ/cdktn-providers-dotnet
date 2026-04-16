using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RedshiftIdcApplication
{
    [JsiiByValue(fqn: "aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegration")]
    public class RedshiftIdcApplicationServiceIntegration : aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegration
    {
        private object? _lakeFormation;

        /// <summary>lake_formation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/redshift_idc_application#lake_formation RedshiftIdcApplication#lake_formation}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lakeFormation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationLakeFormation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LakeFormation
        {
            get => _lakeFormation;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegrationLakeFormation[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegrationLakeFormation).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _lakeFormation = value;
            }
        }

        private object? _redshift;

        /// <summary>redshift block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/redshift_idc_application#redshift RedshiftIdcApplication#redshift}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "redshift", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationRedshift\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Redshift
        {
            get => _redshift;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegrationRedshift[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegrationRedshift).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _redshift = value;
            }
        }

        private object? _s3AccessGrants;

        /// <summary>s3_access_grants block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/redshift_idc_application#s3_access_grants RedshiftIdcApplication#s3_access_grants}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3AccessGrants", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationS3AccessGrants\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? S3AccessGrants
        {
            get => _s3AccessGrants;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegrationS3AccessGrants[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegrationS3AccessGrants).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _s3AccessGrants = value;
            }
        }
    }
}
