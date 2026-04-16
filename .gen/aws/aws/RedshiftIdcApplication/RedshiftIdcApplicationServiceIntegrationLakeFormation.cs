using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RedshiftIdcApplication
{
    [JsiiByValue(fqn: "aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationLakeFormation")]
    public class RedshiftIdcApplicationServiceIntegrationLakeFormation : aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegrationLakeFormation
    {
        private object? _lakeFormationQuery;

        /// <summary>lake_formation_query block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/redshift_idc_application#lake_formation_query RedshiftIdcApplication#lake_formation_query}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lakeFormationQuery", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationLakeFormationLakeFormationQuery\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LakeFormationQuery
        {
            get => _lakeFormationQuery;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegrationLakeFormationLakeFormationQuery[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegrationLakeFormationLakeFormationQuery).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _lakeFormationQuery = value;
            }
        }
    }
}
