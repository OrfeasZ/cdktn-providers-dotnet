using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RedshiftIdcApplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationRedshiftConnect")]
    public class RedshiftIdcApplicationServiceIntegrationRedshiftConnect : aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegrationRedshiftConnect
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/redshift_idc_application#authorization RedshiftIdcApplication#authorization}.</summary>
        [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}")]
        public string Authorization
        {
            get;
            set;
        }
    }
}
