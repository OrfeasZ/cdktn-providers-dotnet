using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RedshiftIdcApplication
{
    [JsiiInterface(nativeType: typeof(IRedshiftIdcApplicationServiceIntegrationLakeFormation), fullyQualifiedName: "aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationLakeFormation")]
    public interface IRedshiftIdcApplicationServiceIntegrationLakeFormation
    {
        /// <summary>lake_formation_query block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/redshift_idc_application#lake_formation_query RedshiftIdcApplication#lake_formation_query}
        /// </remarks>
        [JsiiProperty(name: "lakeFormationQuery", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationLakeFormationLakeFormationQuery\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LakeFormationQuery
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRedshiftIdcApplicationServiceIntegrationLakeFormation), fullyQualifiedName: "aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationLakeFormation")]
        internal sealed class _Proxy : DeputyBase, aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegrationLakeFormation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>lake_formation_query block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/redshift_idc_application#lake_formation_query RedshiftIdcApplication#lake_formation_query}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lakeFormationQuery", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationLakeFormationLakeFormationQuery\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LakeFormationQuery
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
