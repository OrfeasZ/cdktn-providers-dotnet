using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayDeployment
{
    [JsiiByValue(fqn: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesMutualTls")]
    public class ApigatewayDeploymentSpecificationRequestPoliciesMutualTls : oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesMutualTls
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#allowed_sans ApigatewayDeployment#allowed_sans}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowedSans", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowedSans
        {
            get;
            set;
        }

        private object? _isVerifiedCertificateRequired;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#is_verified_certificate_required ApigatewayDeployment#is_verified_certificate_required}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isVerifiedCertificateRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsVerifiedCertificateRequired
        {
            get => _isVerifiedCertificateRequired;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isVerifiedCertificateRequired = value;
            }
        }
    }
}
