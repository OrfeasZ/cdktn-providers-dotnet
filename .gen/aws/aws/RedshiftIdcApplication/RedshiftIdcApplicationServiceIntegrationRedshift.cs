using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RedshiftIdcApplication
{
    [JsiiByValue(fqn: "aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationRedshift")]
    public class RedshiftIdcApplicationServiceIntegrationRedshift : aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegrationRedshift
    {
        private object? _connect;

        /// <summary>connect block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/redshift_idc_application#connect RedshiftIdcApplication#connect}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connect", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationRedshiftConnect\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Connect
        {
            get => _connect;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegrationRedshiftConnect[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegrationRedshiftConnect).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connect = value;
            }
        }
    }
}
