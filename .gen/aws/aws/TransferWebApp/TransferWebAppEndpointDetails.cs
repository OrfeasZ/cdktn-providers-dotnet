using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferWebApp
{
    [JsiiByValue(fqn: "aws.transferWebApp.TransferWebAppEndpointDetails")]
    public class TransferWebAppEndpointDetails : aws.TransferWebApp.ITransferWebAppEndpointDetails
    {
        private object? _vpc;

        /// <summary>vpc block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/transfer_web_app#vpc TransferWebApp#vpc}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vpc", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.transferWebApp.TransferWebAppEndpointDetailsVpc\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Vpc
        {
            get => _vpc;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.TransferWebApp.ITransferWebAppEndpointDetailsVpc[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.TransferWebApp.ITransferWebAppEndpointDetailsVpc).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _vpc = value;
            }
        }
    }
}
