using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ApprunnerService
{
    [JsiiByValue(fqn: "aws.apprunnerService.ApprunnerServiceNetworkConfigurationIngressConfiguration")]
    public class ApprunnerServiceNetworkConfigurationIngressConfiguration : aws.ApprunnerService.IApprunnerServiceNetworkConfigurationIngressConfiguration
    {
        private object? _isPubliclyAccessible;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/apprunner_service#is_publicly_accessible ApprunnerService#is_publicly_accessible}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isPubliclyAccessible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsPubliclyAccessible
        {
            get => _isPubliclyAccessible;
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
                _isPubliclyAccessible = value;
            }
        }
    }
}
