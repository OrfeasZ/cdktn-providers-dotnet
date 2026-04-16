using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RedshiftIdcApplication
{
    [JsiiInterface(nativeType: typeof(IRedshiftIdcApplicationServiceIntegrationLakeFormationLakeFormationQuery), fullyQualifiedName: "aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationLakeFormationLakeFormationQuery")]
    public interface IRedshiftIdcApplicationServiceIntegrationLakeFormationLakeFormationQuery
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/redshift_idc_application#authorization RedshiftIdcApplication#authorization}.</summary>
        [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}")]
        string Authorization
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRedshiftIdcApplicationServiceIntegrationLakeFormationLakeFormationQuery), fullyQualifiedName: "aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationLakeFormationLakeFormationQuery")]
        internal sealed class _Proxy : DeputyBase, aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegrationLakeFormationLakeFormationQuery
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/redshift_idc_application#authorization RedshiftIdcApplication#authorization}.</summary>
            [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}")]
            public string Authorization
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
